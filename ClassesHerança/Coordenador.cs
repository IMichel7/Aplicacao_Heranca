using System.Collections.Generic;

namespace ClassesHeranca
{
    // Desenvolvido por: Michel Furtado da Silva
    public class Coordenador : Funcionario
    {
        public string SenhaAlarme { get; set; }

        public Coordenador(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null,
                             decimal salario = 0, string matricula = "", string senha = "")
            : base(nome, cpf, rg, logradouro, salario, matricula)
        {
            SenhaAlarme = senha;
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
                ("Senha", SenhaAlarme)
            };
            return dados;
        }

        // Representação textual: "nome, matrícula"
        public override string ToString()
        {
            return $"{Nome}, {Matricula}";
        }
    }
}
