using Extras.Negocio;
using System;
using System.Linq;
using System.Text;

namespace Extras.Extras
{
    public static class Fontes
    {
        private static string Spacing(int positions)
        {
            return "".PadLeft(positions * 4);
        }

        private static bool Ignore(string sqlType)
        {
            sqlType = sqlType.ToUpper();

            switch (sqlType)
            {
                case "BIGINT":
                case "BINARY":
                case "BIT":
                case "DATE":
                case "DATETIME":
                case "DATETIME2":
                case "DATETIMEOFFSET":
                case "GEOGRAPHY":
                case "GEOMETRY":
                case "HIERARCHYID":
                case "IMAGE":
                case "SMALLDATETIME":
                case "SMALLINT":
                case "SMALLMONEY":
                case "SQL_VARIANT":
                case "SYSNAME":
                case "TIME":
                case "TEXT":
                case "TINYINT":
                case "TIMESTAMP":
                case "UNIQUEIDENTIFIER":
                case "VARBINARY":
                case "XML":
                    return true;
                default:
                    return false;
            }
        }

        public static string Procedure(string nm_tabela)
        {
            var tabela = N_Tabela.Buscar(true, nm_tabela).FirstOrDefault();
            var cad_tabela = "CAD_" + nm_tabela.Substring(3).ToUpper();

            var procedure = new StringBuilder();
            procedure.AppendLine("");
            procedure.AppendLine(String.Format("IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE NAME = '{0}' AND TYPE = 'P')", cad_tabela));
            procedure.AppendLine("    DROP PROCEDURE " + cad_tabela);
            procedure.AppendLine("GO");
            procedure.AppendLine("");
            procedure.AppendLine("CREATE PROCEDURE " + cad_tabela);
            procedure.AppendLine("(");
            procedure.AppendLine(Spacing(1) + "@OPERACAO VARCHAR(1),");

            int count = 0;
            foreach (var a in tabela.Columns)
            {
                procedure.AppendLine(String.Format("{0}@{1} {2}{3}{4}", Spacing(1), a.Name.ToUpper(), a.SqlType.ToUpper(), (Ignore(a.SqlType) ? "" : ("(" + a.Size + (a.Scale > 0 ? a.Scale.ToString() : "") + ")")), (count == (tabela.Columns.Count - 1) ? "" : ",")));
                count++;
            }

            procedure.AppendLine(") WITH RECOMPILE AS");
            procedure.AppendLine("BEGIN");
            procedure.AppendLine(Spacing(1) + "SET @OPERACAO = UPPER(REPLACE(ISNULL(@OPERACAO,''), ' ', ''))");
            procedure.AppendLine("");
            procedure.AppendLine(Spacing(1) + "IF (LEN(@OPERACAO) = 0 OR (@OPERACAO <> 'C' AND @OPERACAO <> 'A' AND @OPERACAO <> 'D'))");
            procedure.AppendLine(Spacing(2) + "RAISERROR('É necessário informar o tipo da operação!', 15, 1)");
            procedure.AppendLine(Spacing(1) + "ELSE");
            procedure.AppendLine(Spacing(1) + "BEGIN");
            procedure.AppendLine(Spacing(2) + "IF (@OPERACAO = 'D')");
            procedure.AppendLine(Spacing(2) + "BEGIN");
            procedure.AppendLine(String.Format("{0}DELETE FROM {1}", Spacing(3), tabela.Name.ToUpper()));
            procedure.AppendLine(Spacing(3) + "WHERE");

            count = 0;
            foreach (var a in tabela.Columns.Where(b => b.PK))
            {
                procedure.AppendLine(String.Format("{0}{1} = @{1}{2}", Spacing(3), a.Name.ToUpper(), (count == (tabela.Columns.Where(b => b.PK).Count() - 1) ? "" : " AND ")));
                count++;
            }

            procedure.AppendLine(Spacing(2) + "END");
            procedure.AppendLine(Spacing(2) + "ELSE");
            procedure.AppendLine(Spacing(2) + "BEGIN");

            count = 0;
            foreach (var a in tabela.Columns)
            {
                if (a.PK && !a.FK && (a.CSharpType == typeof(decimal) || a.CSharpType == typeof(int)))
                    procedure.AppendLine(String.Format("{0}SET @{1} = ISNULL((SELECT MAX({1}) FROM {2}), 0) + 1", Spacing(3), a.Name.ToUpper(), tabela.Name.ToUpper()));
                else if (a.CSharpType == typeof(string))
                    procedure.AppendLine(String.Format("{0}SET @{1} = RTRIM(LTRIM(UPPER(REPLACE(ISNULL(@{1}, ''), '  ', ' '))))", Spacing(3), a.Name.ToUpper()));

                count++;
            }

            procedure.AppendLine("");

            foreach (var a in tabela.Columns.Where(a => a.CSharpType == typeof(string)))
            {
                procedure.AppendLine(String.Format("{0}IF (LEN(@{1}) > {2})", Spacing(3), a.Name.ToUpper(), a.Size));
                procedure.AppendLine(String.Format("{0}SET @{1} = SUBSTRING(@{1}, 0, 2)", Spacing(4), a.Name.ToUpper()));
            }

            foreach (var a in tabela.Columns.Where(a => a.CSharpType == typeof(int) && a.CSharpType == typeof(decimal)))
            {
                procedure.AppendLine(String.Format("{0}IF (@{1} > {2}{3})", Spacing(3), a.Name.ToUpper(), a.Size, (a.Scale > 0 ? ("." + a.Scale) : "")));
                procedure.AppendLine(String.Format("{0}SET @{1} = {2}{3}", Spacing(4), a.Name.ToUpper(), a.Size, (a.Scale > 0 ? ("." + a.Scale) : "")));
            }

            procedure.AppendLine("");
            procedure.AppendLine(Spacing(3) + "IF(@OPERACAO = 'C')");
            procedure.AppendLine(Spacing(3) + "BEGIN");

            var keys = String.Format("{0}IF EXISTS (SELECT 1 FROM {1} WHERE ", Spacing(4), tabela.Name.ToUpper());

            count = 0;
            foreach (var a in tabela.Columns.Where(a => a.PK))
            {
                keys += String.Format("{0} = @{0}{1}", a.Name.ToUpper(), (count == (tabela.Columns.Where(b => b.PK).Count() - 1) ? ")" : " AND "));
                count++;
            }

            procedure.AppendLine(keys);
            procedure.AppendLine(Spacing(5) + "RAISERROR('Não foi possível cadastrar {o/a descrição} no banco de dados porque a mesma já se encontra cadastrada!', 15, 1)");
            procedure.AppendLine("");
            procedure.AppendLine(String.Format("{0}INSERT INTO {1} (", Spacing(4), tabela.Name.ToUpper()));

            count = 0;
            foreach (var a in tabela.Columns)
            {
                procedure.AppendLine(Spacing(5) + a.Name.ToUpper() + (count == (tabela.Columns.Count - 1) ? ")" : ","));
                count++;
            }

            procedure.AppendLine(Spacing(4) + "VALUES (");

            count = 0;
            foreach (var a in tabela.Columns)
            {
                procedure.AppendLine(String.Format("{0}@{1}{2}", Spacing(5), a.Name.ToUpper(), (count == (tabela.Columns.Count - 1) ? ")" : ",")));
                count++;
            }

            procedure.AppendLine(Spacing(3) + "END");
            procedure.AppendLine(Spacing(3) + "ELSE IF (@OPERACAO = 'A')");
            procedure.AppendLine(Spacing(3) + "BEGIN");

            keys = String.Format("{0}IF NOT EXISTS (SELECT 1 FROM {1} WHERE ", Spacing(4), tabela.Name.ToUpper());

            count = 0;
            foreach (var a in tabela.Columns.Where(a => a.PK))
            {
                keys += String.Format("{0} = @{0}{1}", a.Name.ToUpper(), (count == (tabela.Columns.Where(b => b.PK).Count() - 1) ? ")" : " AND "));
                count++;
            }

            procedure.AppendLine(keys);
            procedure.AppendLine(Spacing(5) + "RAISERROR('Não foi possível alterar {o/a descrição} no banco de dados porque o(a) mesmo(a) não consta como cadastrado(a)!', 15, 1)");

            procedure.AppendLine(Spacing(4) + "ELSE");
            procedure.AppendLine(String.Format("{0}UPDATE {1} SET", Spacing(5), tabela.Name.ToUpper()));

            count = 0;
            foreach (var a in tabela.Columns.Where(a => !a.PK))
            {
                procedure.AppendLine(String.Format("{0}{1} = @{1}{2}", Spacing(6), a.Name.ToUpper(), (count == (tabela.Columns.Where(b => !b.PK).Count() - 1) ? "" : " AND ")));
                count++;
            }

            procedure.AppendLine(Spacing(5) + "WHERE");

            count = 0;
            foreach (var a in tabela.Columns.Where(a => a.PK))
            {
                procedure.AppendLine(String.Format("{0}{1} = @{1}{2}", Spacing(6), a.Name.ToUpper(), (count == (tabela.Columns.Where(b => b.PK).Count() - 1) ? "" : " AND ")));
                count++;
            }

            procedure.AppendLine(Spacing(3) + "END");
            procedure.AppendLine(Spacing(2) + "END");
            procedure.AppendLine(Spacing(1) + "END");
            procedure.AppendLine("END");

            return procedure.ToString();
        }
    }
}