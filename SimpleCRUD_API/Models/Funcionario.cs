using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleCRUD_API.Models
{
    public class Funcionario
    {
        public static int idCount = 0;
        public int id { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string funcao { get; set; }
        public int idade { get; set; }
        public DateTime dataCriacao { get; set; }
        public DateTime dataModificacao { get; set; }

    public Funcionario(string nome, string sobrenome, string funcao, int idade)
        {
            this.id = idCount;
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.funcao = funcao;
            this.idade = idade;
            this.dataCriacao = DateTime.Today;
            this.dataModificacao = DateTime.Today;
            idCount++;
        }
    }
}