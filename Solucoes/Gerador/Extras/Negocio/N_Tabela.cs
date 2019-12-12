using Extras.Entidades;
using System.Collections.Generic;
using System.Linq;
using Utilidades;
using System;

namespace Extras.Negocio
{
    public static class N_Tabela
    {
        public static List<E_Tabela> Buscar(bool comColunas, string nm_tabela)
        {
            var retorno = new List<E_Tabela>();

            retorno.AddRange(Conexao.Banco.ExecuteQuery<E_Tabela>(String.Format("select Name from SYSOBJECTS where type = 'u' {0} order by name", ((nm_tabela ?? "").Trim().Length > 0 ? (String.Format("AND Name = '{0}'", nm_tabela)) : ""))));

            if (comColunas)
                retorno.ForEach(a => a.Columns = N_Coluna.Buscar(a.Name).ToList());

            return retorno;
        }
    }
}