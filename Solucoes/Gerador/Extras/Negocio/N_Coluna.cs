using Extras.Entidades;
using System.Collections.Generic;
using System.Linq;
using Utilidades;
using System;

namespace Extras.Negocio
{
    public static class N_Coluna
    {
        public static List<E_Coluna> Buscar(string nm_tabela)
        {
            return Conexao.Banco.ExecuteQuery<E_Coluna>(String.Format(@"SELECT CONVERT(VARCHAR, COLUNAS.NAME) AS Name,
                                                                       CONVERT(BIT, ISNULL((SELECT TOP 1 1 FROM SYS.OBJECTS O INNER JOIN SYS.INDEXES I ON O.OBJECT_ID = I.OBJECT_ID AND I.IS_PRIMARY_KEY = 1 INNER JOIN SYS.INDEX_COLUMNS IC ON I.OBJECT_ID = IC.OBJECT_ID AND I.INDEX_ID = IC.INDEX_ID WHERE O.NAME = TABELAS.NAME AND IC.COLUMN_ID = COLUNAS.COLORDER),'0')) AS 'PK',
                                                                       CONVERT(BIT, ISNULL((SELECT TOP 1 1 FROM SYS.FOREIGN_KEY_COLUMNS WHERE PARENT_COLUMN_ID = COLUNAS.COLORDER AND PARENT_OBJECT_ID = COLUNAS.ID),'0')) AS 'FK',
                                                                       CONVERT(BIT, (CASE WHEN COLUNAS.ISNULLABLE = 1 THEN 1 ELSE 0 END)) AS 'Nullable',
                                                                       ISNULL(TIPOS.NAME,'') AS 'SqlType',
                                                                       CONVERT(INT, ISNULL(COLUNAS.PREC,'')) AS 'Size',
                                                                       CONVERT(INT, ISNULL(COLUNAS.SCALE,0)) AS 'Scale',
                                                                       CONVERT(BIT, (CASE WHEN COLUMNPROPERTY(OBJECT_ID(TABELAS.NAME), COLUNAS.NAME,'ISIDENTITY') = 1 THEN 1 ELSE 0 END)) AS 'Identity'
                                                                       FROM
                                                                       SYSCOLUMNS COLUNAS
                                                                       INNER JOIN SYSOBJECTS TABELAS ON TABELAS.ID = COLUNAS.ID
                                                                       LEFT JOIN  SYSTYPES TIPOS ON TIPOS.XTYPE = COLUNAS.XTYPE
                                                                       WHERE
                                                                       TABELAS.TYPE = 'U' AND
                                                                       TABELAS.ID = COLUNAS.ID AND
                                                                       COLUNAS.USERTYPE = TIPOS.USERTYPE AND
                                                                       TABELAS.NAME = '{0}' ORDER BY COLUNAS.COLORDER", nm_tabela)).ToList();
        }
    }
}