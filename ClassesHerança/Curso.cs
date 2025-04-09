namespace ClassesHeranca
{
    // Desenvolvido por: Michel Furtado da Silva
    public class Curso
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int CargaHoraria { get; set; }

        public Curso(string nome = "", string descricao = "", int cargaHoraria = 0)
        {
            Nome = nome;
            Descricao = descricao;
            CargaHoraria = cargaHoraria;
        }

        // Representação textual: "nome, carga horaria"
        public override string ToString()
        {
            return $"{Nome}, {CargaHoraria}";
        }
    }
}
