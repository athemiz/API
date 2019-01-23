using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web.Http;
using SimpleCRUD_API.Models;

namespace SimpleCRUD_API.Controllers
{
    public class FuncionariosController : ApiController
    {

        private static List<Funcionario> listaFuncionarios = new List<Funcionario>();

        [AcceptVerbs("GET")]
        public List<Funcionario> List()
        {
            return listaFuncionarios;
        }

        [AcceptVerbs("GET")]
        public HttpResponseMessage Show(int id)
        {
            var item = listaFuncionarios.Find(x => x.id == id);
            if (item != null && id < listaFuncionarios.Count)
                return Request.CreateResponse(HttpStatusCode.OK, listaFuncionarios[id]);

            else return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Este funcionario não existe.");
        }

        [AcceptVerbs("POST")]
        public void Create(string nome, string sobrenome, string funcao, int idade)
        {
            Funcionario entidade = new Funcionario(nome, sobrenome, funcao, idade);
            listaFuncionarios.Add(entidade);
        }


        [AcceptVerbs("POST")]
        public HttpResponseMessage Destroy(int id)
        {
            var item = listaFuncionarios.Find(x => x.id == id);
            if (item != null && id < listaFuncionarios.Count)
            {
                listaFuncionarios.RemoveAt(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Funcionario removido.");
            }

            else return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Este funcionario não existe.");
            
        }

        [AcceptVerbs("POST")]
        public HttpResponseMessage Update(int id, int? idade, string nome="", string sobrenome="", string funcao="")
        {
            var item = listaFuncionarios.Find(x => x.id == id);
            if (item != null && id < listaFuncionarios.Count)
            {
                if (nome != "") listaFuncionarios[id].nome = nome;
                if (sobrenome != "") listaFuncionarios[id].sobrenome = sobrenome;
                if (funcao != "") listaFuncionarios[id].funcao = funcao;
                if (idade.HasValue) listaFuncionarios[id].idade = idade.Value;

                return Request.CreateResponse(HttpStatusCode.OK, "funcionario atualizado.");
            }
            else return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Este funcionario não existe.");
        }

    }
}
