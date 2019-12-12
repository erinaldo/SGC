using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilidades;

namespace Consultas
{
    public static class C_MENU
    {
        public static bool Gerar(ref int transacao)
        {
            try
            {
                Conexao.Iniciar(ref transacao);

                var menus = new List<E_MENU>();
                menus.Add(new E_MENU() { ID_MENU = "C1", DS_MENU = "Cadastro de usuário" });
                menus.Add(new E_MENU() { ID_MENU = "C2", DS_MENU = "Cadastro de grupo de usuário" });
                menus.Add(new E_MENU() { ID_MENU = "C3", DS_MENU = "Cadastro de cargo" });
                menus.Add(new E_MENU() { ID_MENU = "C4", DS_MENU = "Cadastro de departamento" });
                menus.Add(new E_MENU() { ID_MENU = "C5", DS_MENU = "Cadastro de grupo de produto" });
                menus.Add(new E_MENU() { ID_MENU = "C6", DS_MENU = "Cadastro de item" });
                menus.Add(new E_MENU() { ID_MENU = "C7", DS_MENU = "Cadastro de categoria" });
                menus.Add(new E_MENU() { ID_MENU = "C9", DS_MENU = "Cadastro de marca" });
                menus.Add(new E_MENU() { ID_MENU = "C10", DS_MENU = "Cadastro de modelo" });
                menus.Add(new E_MENU() { ID_MENU = "C11", DS_MENU = "Cadastro de status" });
                menus.Add(new E_MENU() { ID_MENU = "C13", DS_MENU = "Cadastro de cliente / fornecedor" });
                menus.Add(new E_MENU() { ID_MENU = "C14", DS_MENU = "Cadastro de equipamento" });
                menus.Add(new E_MENU() { ID_MENU = "C15", DS_MENU = "Cadastro de equipamento x usuário" });

                menus.Add(new E_MENU() { ID_MENU = "L1", DS_MENU = "Lançamento de chamado" });
                menus.Add(new E_MENU() { ID_MENU = "L3", DS_MENU = "Lançamento de alocação de recurso" });
                menus.Add(new E_MENU() { ID_MENU = "L4", DS_MENU = "Lançamento de conhecimento" });
                menus.Add(new E_MENU() { ID_MENU = "L6", DS_MENU = "Lançamento de comunicado" });

                menus.Add(new E_MENU() { ID_MENU = "R1", DS_MENU = "Relatório de chamados por departamento" });
                menus.Add(new E_MENU() { ID_MENU = "R2", DS_MENU = "Relatório de chamados por solicitante" });
                menus.Add(new E_MENU() { ID_MENU = "R3", DS_MENU = "Relatório de chamados por departamento por categoria" });
                menus.Add(new E_MENU() { ID_MENU = "R4", DS_MENU = "Relatório de chamados por categoria" });

                menus.Add(new E_MENU() { ID_MENU = "D1", DS_MENU = "Dashboard" });

                var menusExistentes = Conexao.Banco.TB_DIV_MENUs;

                var menusGravar = menus.Where(a => !menusExistentes.Select(b => b.ID_MENU).Contains(a.ID_MENU));
                foreach (var menu in menusGravar)
                {
                    Conexao.Banco.CAD_DIV_MENU(Operacao.Cadastrar.Value(),
                                               menu.ID_MENU,
                                               menu.DS_MENU);

                    Conexao.Enviar();
                }
            }
            catch (Exception excessao)
            {
                Conexao.Voltar(ref transacao);
                throw excessao;
            }

            Conexao.Finalizar(ref transacao);

            return true;
        }
    }
}