using System;
using System.Collections.Generic;
using ClassesHeranca;

namespace AplicacaoHeranca
{
    // Desenvolvido por: Michel Furtado da Silva
    class Program
    {
        static void Main(string[] args)
        {
            // Lista única para armazenar todos os cadastros, 
            // pois todas as classes derivam de Pessoa
            List<Pessoa> pessoas = new List<Pessoa>();

            // Cadastro de três alunos (um deles cursando Sistemas de Informação)
            Aluno aluno1 = new Aluno(
                nome: "Alice Souza",
                cpf: "111.222.333-44",
                rg: "MG-12.345.678",
                logradouro: new Endereco("Rua A", 100, "Centro", "Belo Horizonte", "MG", "12345-678"),
                matricula: 1001,
                cursoAluno: new Curso("Sistemas de Informação", "Curso focado em TI", 1200)
            );

            Aluno aluno2 = new Aluno(
                nome: "Bruno Lima",
                cpf: "222.333.444-55",
                rg: "SP-98.765.432",
                logradouro: new Endereco("Rua B", 200, "Jardim", "São Paulo", "SP", "23456-789"),
                matricula: 1002,
                cursoAluno: new Curso("Engenharia", "Curso de Engenharia", 1400)
            );

            Aluno aluno3 = new Aluno(
                nome: "Carla Mendes",
                cpf: "333.444.555-66",
                rg: "RJ-76.543.210",
                logradouro: new Endereco("Rua C", 300, "Copacabana", "Rio de Janeiro", "RJ", "34567-890"),
                matricula: 1003,
                cursoAluno: new Curso("Sistemas de Informação", "Curso focado em TI", 1200)
            );

            pessoas.Add(aluno1);
            pessoas.Add(aluno2);
            pessoas.Add(aluno3);

            // Cadastro de dois professores (área de Tecnologia, titulação Mestre)
            Professor professor1 = new Professor(
                nome: "Dr. Eduardo Silva",
                cpf: "444.555.666-77",
                rg: "MG-11.223.344",
                logradouro: new Endereco("Rua D", 400, "Savassi", "Belo Horizonte", "MG", "45678-901"),
                salario: 5000,
                matricula: "P1001",
                titulacao: "Mestre",
                area: "Tecnologia"
            );

            Professor professor2 = new Professor(
                nome: "Dra. Fernanda Alves",
                cpf: "555.666.777-88",
                rg: "SP-22.334.455",
                logradouro: new Endereco("Rua E", 500, "Pinheiros", "São Paulo", "SP", "56789-012"),
                salario: 5500,
                matricula: "P1002",
                titulacao: "Mestre",
                area: "Tecnologia"
            );

            pessoas.Add(professor1);
            pessoas.Add(professor2);

            // Cadastro de um coordenador com senha "AbcBolinhas"
            Coordenador coordenador = new Coordenador(
                nome: "Gustavo Ramos",
                cpf: "666.777.888-99",
                rg: "RJ-33.445.566",
                logradouro: new Endereco("Rua F", 600, "Centro", "Rio de Janeiro", "RJ", "67890-123"),
                salario: 6000,
                matricula: "C1001",
                senha: "AbcBolinhas"
            );

            pessoas.Add(coordenador);

            // Cadastro de dois técnicos administrativos na função de "Desenvolvedor"
            TecnicoAdministrativo tecnico1 = new TecnicoAdministrativo(
                nome: "Henrique Costa",
                cpf: "777.888.999-00",
                rg: "MG-44.556.667",
                logradouro: new Endereco("Rua G", 700, "Industrial", "Belo Horizonte", "MG", "78901-234"),
                salario: 3000,
                matricula: "T1001",
                funcao: "Desenvolvedor"
            );

            TecnicoAdministrativo tecnico2 = new TecnicoAdministrativo(
                nome: "Isabel Oliveira",
                cpf: "888.999.000-11",
                rg: "SP-55.667.778",
                logradouro: new Endereco("Rua H", 800, "Centro", "São Paulo", "SP", "89012-345"),
                salario: 3200,
                matricula: "T1002",
                funcao: "Desenvolvedor"
            );

            pessoas.Add(tecnico1);
            pessoas.Add(tecnico2);

            // Listagem dos cadastros
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"Tipo: {pessoa.GetType().Name}");
                Console.WriteLine("Retorno do método RetornarDados():");
                foreach (var (campo, valor) in pessoa.RetornarDados())
                {
                    Console.WriteLine($"  {campo}: {valor}");
                }
                Console.WriteLine($"Representação via ToString(): {pessoa}");
                Console.WriteLine(new string('-', 50));
            }

            // Aguarda o usuário pressionar uma tecla para fechar
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
