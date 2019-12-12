using Modelo;
using System;
using System.Deployment.Application;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace Utilidades
{
    public static class Email
    {
        public static void Enviar(TB_DIV_CHAMADO chamado, OperacaoEmail operacao)
        {
            Conexao.Reiniciar();
            chamado = Conexao.Banco.TB_DIV_CHAMADOs.FirstOrDefault(a => a.ID_CHAMADO == chamado.ID_CHAMADO);
            var emailDestino = Conexao.Banco.TB_DIV_USUARIOs.Where(a => a.LOGIN == chamado.LOGIN_SOLICITANTE || a.LOGIN == chamado.LOGIN_ATENDENTE).Select(a => a.EMAIL).ToList().Where(a => a.Treat().Trim().Length > 0).ToList();

            var configuracoes = Conexao.Banco.TB_DIV_CONFIG_EMAILs.FirstOrDefault();
            if (configuracoes == null || configuracoes == new TB_DIV_CONFIG_EMAIL() || (configuracoes.ST_ENVIAR ?? "N").Trim().ToUpper() == "N" || emailDestino == null || emailDestino.Count == 0)
                return;

            var titulo = "SGC: ";

            switch (operacao)
            {
                case OperacaoEmail.Envio: titulo += "(lançamento)"; break;
                case OperacaoEmail.Atendimento: titulo += "(atendimento)"; break;
                case OperacaoEmail.Evolucao: titulo += "(evolução)"; break;
                case OperacaoEmail.Finalizacao: titulo += "(finalização)"; break;
            }

            titulo += " | " + String.Format("#{0} - {1}", chamado.ID_CHAMADO, chamado.DS_RESUMO.Treat());

            var dt_Chamado = chamado.DT_CHAMADO.ToString("dd/MM/yyyy HH:mm");
            var dt_Atendimento = chamado.DT_ATENDIMENTO.GetValueOrDefault().ToString("dd/MM/yyyy HH:mm");
            var dt_Finalizado = chamado.DT_FINALIZADO.GetValueOrDefault().ToString("dd/MM/yyyy HH:mm");

            var existeEventos = chamado.TB_DIV_EVENTOs.OrderByDescending(a => a.ID_EVENTO).Count() > 0;

            var dt_UltimaEvolucao = existeEventos ? chamado.TB_DIV_EVENTOs.OrderByDescending(a => a.ID_EVENTO).FirstOrDefault().DT_EVENTO.GetValueOrDefault().ToString("dd/MM/yyyy HH:mm") : "";
            var nm_Atendente = chamado.LOGIN_ATENDENTE != null ? Conexao.Banco.TB_DIV_USUARIOs.FirstOrDefault(a => a.LOGIN == chamado.LOGIN_ATENDENTE).NM_USUARIO.Treat() : "";
            var nm_Solicitante = chamado.LOGIN_SOLICITANTE != null ? Conexao.Banco.TB_DIV_USUARIOs.FirstOrDefault(a => a.LOGIN == chamado.LOGIN_SOLICITANTE).NM_USUARIO.Treat() : "";
            var nm_Finalizador = existeEventos ? chamado.TB_DIV_EVENTOs.OrderByDescending(a => a.ID_EVENTO).FirstOrDefault().LOGIN_FINALIZADOR.Treat() : "";
            var ds_UltimoEvento = existeEventos ? chamado.TB_DIV_EVENTOs.OrderByDescending(a => a.ID_EVENTO).FirstOrDefault().DS_EVENTO.Treat() : "";

            var corpo = new StringBuilder().AppendFormat("O chamado <b>#{0}</b> foi ", chamado.ID_CHAMADO);

            if (operacao == OperacaoEmail.Envio)
            {
                corpo.AppendLine(String.Format("lançado {0}pelo usuário <b>{1}</b> (<b>{2}</b>) na data <b>{3}</b>!", (chamado.LOGIN_ATENDENTE != null ? ("para o usuário <b>" + chamado.LOGIN_ATENDENTE + "</b> (<b>" + nm_Atendente + "</b>) ") : " "), chamado.LOGIN_SOLICITANTE, nm_Solicitante, dt_Chamado));

                var ds_Chamado = chamado.DS_CHAMADO.Treat();

                if (ds_Chamado.Length > 0)
                    corpo.AppendLine("<br>Segue a descrição: " + ds_Chamado);
            }
            else if (operacao == OperacaoEmail.Atendimento)
            {
                corpo.AppendLine(String.Format("atendido pelo usuário <b>{0}</b> (<b>{1}</b>) na data <b>{2}</b>!", chamado.LOGIN_ATENDENTE, nm_Atendente, dt_Atendimento));

                if(ds_UltimoEvento.Length > 0)
                    corpo.AppendLine("<br>Segue o adendo do atendente: " + ds_UltimoEvento);
            }
            else if (operacao == OperacaoEmail.Evolucao)
            {
                corpo.AppendLine(String.Format("evoluido pelo usuário <b>{0}</b> (<b>{1}</b>) na data <b>{2}</b>!", chamado.LOGIN_ATENDENTE, nm_Atendente, dt_UltimaEvolucao));

                if(ds_UltimoEvento.Length > 0)
                    corpo.AppendLine("<br>Segue a observação: " + ds_UltimoEvento);
            }
            else if (operacao == OperacaoEmail.Finalizacao)
            {
                corpo.AppendLine(String.Format("finalizado pelo usuário <b>{0}</b> (<b>{1}</b>) na data <b>{2}</b>!", chamado.TB_DIV_EVENTOs.OrderByDescending(a => a.ID_EVENTO).FirstOrDefault().LOGIN_FINALIZADOR, nm_Finalizador, dt_Finalizado));

                var ds_Sugestao = chamado.DS_SUGESTAO.Treat();
                if(ds_Sugestao.Length > 0)
                    corpo.AppendLine("<br>Segue a ultima nota/sugestão: " + ds_Sugestao);
            }

            corpo.AppendLine("<br><br><b>----<br><b>Lembrete!</b><br>Não responda este e-mail, pois toda a comunicação será através do sistema de chamados SGC!");

            var email = new MailMessage(configuracoes.LOGIN.Treat(), emailDestino.First())
            {
                Subject = titulo,
                Body = corpo.ToString(),
                IsBodyHtml = true
            };

            emailDestino.Remove(emailDestino.First());

            if (emailDestino.Count > 0)
                foreach (var destinatario in emailDestino)
                    email.CC.Add(destinatario);

            bool tryAgain = true;
            while (tryAgain)
            {
                try
                {
                    tryAgain = false;
                    new SmtpClient(configuracoes.SMTP.Treat(), configuracoes.PORTA.GetValueOrDefault())
                    {
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(configuracoes.LOGIN.Treat(), configuracoes.SENHA ?? ""),
                        EnableSsl = configuracoes.SSL.Treat() == "S"
                    }.Send(email);
                }
                catch
                {
                    tryAgain = MessageBox.Show("Ocorreu um erro ao tentar enviar o email informativo sobre o chamado!\nDeseja tentar enviar novamente?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                }
            }
        }
    }
}