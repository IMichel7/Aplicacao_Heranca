using System.Collections.Generic;

namespace ClassesHeranca
{
    // Desenvolvido por: Michel Furtado da Silva
    public class Professor : Funcionario
    {
        public string Titulacao { get; set; }
        public string Area { get; set; }

        public Professor(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null,
                         decimal salario = 0, string matricula = "", string titulacao = "", string area = "")
            : base(nome, cpf, rg, logradouro, salario, matricula)
        {
            Titulacao = titulacao;
            Area = area;
        }

        public override List<(string campo, string valor)> RetornarDados()
        {
            var dados = new List<(string campo, string valor)>
            {
                ("Nome", Nome),
                ("CPF", Cpf),
                ("RG", Rg),
                ("Endereço", Logradouro.ToString()),
                ("Salário", Salario.ToString()),
                ("Matrícula", Matricula),
                ("Titulação", Titulacao),
                ("Área", Area)
            };
            return dados;
        }

        // Representação textual: "nome, titulação, matrícula"
        public override string ToString()
        {
            return $"{Nome}, {Titulacao}, {Matricula}";
        }
    }
}
