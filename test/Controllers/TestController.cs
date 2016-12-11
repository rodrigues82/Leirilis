using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bus = test.Bussiness;
using  test.Bussiness.Model;

namespace test.Controllers
{
    public class TestController : ApiController
    {
        // POST api/values
        public Receitas PostDados(string nomeReceita)
        {
            Receitas receitas =null;

           receitas=  Bus.Livro.GetReceita(nomeReceita);

            return receitas;
        }

    }
}
