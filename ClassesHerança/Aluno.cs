using System.Collections.Generic;

namespace ClassesHeranca
{
    // Desenvolvido por: Michel Furtado da Silva
    public class Aluno : Pessoa
    {
        public int MatriculaAluno { get; set; }
        public Curso CursoAluno { get; set; }

        public Aluno(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null, int matricula = 0, Curso? cursoAluno = null)
            : base(nome, cpf, rg, logradouro)
        {
            MatriculaAluno = matricula;
            CursoAluno = cursoAluno ?? new Curso();
        }

        // Implementação obrigatória do método abstrato
        public override List<(string campo, string valor)> RetornarDados()
        {
            var dados = new List<(string campo, string valor)>
            {
                ("Nome", Nome),
                ("CPF", Cpf),
                ("RG", Rg),
                ("Endereço", Logradouro.ToString()),
                ("Matrícula", MatriculaAluno.ToString()),
                ("Curso", CursoAluno.Nome)
            };
            return dados;
        }

        // Representação textual: "nome, matrícula e nome do curso"
        public override string ToString()
        {
            return $"{Nome}, {MatriculaAluno} e {CursoAluno.Nome}";
        }
    }
}
