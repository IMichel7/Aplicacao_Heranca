using System.Collections.Generic;

namespace ClassesHeranca
{
    // Desenvolvido por: Michel Furtado da Silva
    // A classe Pessoa é abstrata, ou seja, não pode ser instanciada diretamente.
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public Endereco Logradouro { get; set; }

        public Pessoa(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Logradouro = logradouro ?? new Endereco();
        }

        // Método abstrato que retorna os dados da pessoa em uma lista de tuplas (campo, valor)
        public abstract List<(string campo, string valor)> RetornarDados();

        // Pode-se sobrescrever o ToString() aqui se desejar uma representação padrão,
        // mas as classes concretas terão sua própria versão.
        public override string ToString()
        {
            return Nome;
        }
    }
}
