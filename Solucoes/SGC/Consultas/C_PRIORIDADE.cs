using Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Consultas
{
    public static class C_PRIORIDADE
    {
        public static IQueryable<E_PRIORIDADE> Buscar()
        {
            return (new List<E_PRIORIDADE> 
            {
                new E_PRIORIDADE 
                {
                    ID_PRIORIDADE = "1",
                },
                new E_PRIORIDADE 
                {
                    ID_PRIORIDADE = "2",
                },
                new E_PRIORIDADE 
                {
                    ID_PRIORIDADE = "3",
                }
            }).AsQueryable();
        }
    }
}