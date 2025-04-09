namespace ClassesHeranca
{
    // Desenvolvido por: Michel Furtado da Silva
    // Funcionario é abstrata e herda de Pessoa.
    public abstract class Funcionario : Pessoa
    {
        public decimal Salario { get; set; }
        public string Matricula { get; set; }

        public Funcionario(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null, decimal salario = 0, string matricula = "")
            : base(nome, cpf, rg, logradouro)
        {
            Salario = salario;
            Matricula = matricula;
        }
    }
}
