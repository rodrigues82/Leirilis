using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test.Bussiness
{
    public class Livro
    {
        public static Model.Receitas GetReceita(string pNomeReceita)
        {
            //calcular pneus

            //calcular IVA



            Model.Receitas result = new Model.Receitas();




            result.Ingrediente = GetIngredientes(pNomeReceita);
            result.Qtd = GetQta(pNomeReceita);

            return result;
        }

        private static string GetQta(string pNomeReceita)
        {
            throw new NotImplementedException();
        }

        private static string GetIngredientes(string pNomeReceita)
        {
            throw new NotImplementedException();
        }
    }
}