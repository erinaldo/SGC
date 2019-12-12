using Modelo;
using System;
using Utilidades;

namespace Entidades
{
    public class E_ITEM
    {
        public Operacao OPERACAO { get; set; }
        public int ID_ITEM { get; set; }
        public string DS_ITEM { get; set; }
        public E_MODELO MODELO { get; set; }
        public E_GRUPOPRODUTO GRUPOPRODUTO { get; set; }
        
        

        public E_ITEM(TB_DIV_ITEM item = null)
        {
            this.OPERACAO = Operacao.Normal;

            if (item != null)
            {
                this.ID_ITEM = item.ID_ITEM;
                this.DS_ITEM = item.DS_ITEM.Treat();
                this.MODELO = item.TB_DIV_MODELO != null ? new E_MODELO(item.TB_DIV_MODELO) : null;
                this.GRUPOPRODUTO = item.TB_DIV_GRUPOPRODUTO != null ? new E_GRUPOPRODUTO(item.TB_DIV_GRUPOPRODUTO) : null;
            }
        }
    }
}