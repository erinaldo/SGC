using System;

namespace Utilidades
{
    public static class Enumeradores
    {
        public static string Value(this Enum value)
        {
            var attribs = value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(StringValueAttribute), false) as StringValueAttribute[];
            return attribs.Length > 0 ? attribs[0].StringValue : null;
        }
    }

    public class StringValueAttribute : Attribute
    {
        public string StringValue { get; protected set; }

        public StringValueAttribute(string value)
        {
            this.StringValue = value;
        }
    }

    public enum Operacao
    {
        [StringValue("C")]
        Cadastrar,
        [StringValue("A")]
        Alterar,
        [StringValue("D")]
        Deletar,
        [StringValue("")]
        Normal
    }

    public enum OperacaoEmail
    {
        Envio,
        Atendimento,
        Evolucao,
        Finalizacao
    }

    public class Quantidade
    {
        public enum Buscar { Cinquenta = 50, Cem = 100, Duzentos = 200, Mil = 1000, Todos }
    }
}
