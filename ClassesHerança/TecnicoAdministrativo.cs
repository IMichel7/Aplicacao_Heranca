using System.Collections.Generic;

namespace ClassesHeranca
{
    // Desenvolvido por: Michel Furtado da Silva
    public class TecnicoAdministrativo : Funcionario
    {
        public string Funcao { get; set; }

        public TecnicoAdministrativo(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null,
                                       decimal salario = 0, string matricula = "", string funcao = "")
            : base(nome, cpf, rg, logradouro, salario, matricula)
        {
            Funcao = funcao;
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
                ("Função", Funcao)
            };
            return dados;
        }

        // Representação textual: "nome, função"
        public override string ToString()
        {
            return $"{Nome}, {Funcao}";
        }
    }
}
