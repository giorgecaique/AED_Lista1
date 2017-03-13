using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AED1
{
    public class Cabecalho
    {
        static public void Print(string exercicio, TimeSpan tempoIterativo, TimeSpan tempoRecursivo, int operacoesIterativo, int operacoesRecursivo, object resultIterativo, object resultRecursivo)
        {
            Console.WriteLine(@"--------------------------------------------------------
Sistemas de Informação - Algoritmos e Estrutura de Dados
--------------------------------------------------------
Aluno:     Giorge Caique Pinheiro de Souza Luiz
Matrícula: 548749
Professor: João Caram
Exercício: {0}
--------------------------------------------------------
Tempo de execução
Iterativo : {1}
Recursivo : {2}

Número de operações
Iterativo : {3}
Recursivo : {4}

Resultado
Iterativo : {5}
Recursivo : {6}
--------------------------------------------------------
Pressione qualquer tecla para sair", exercicio, tempoIterativo, tempoRecursivo, operacoesIterativo, operacoesRecursivo, resultIterativo, resultRecursivo);
            Console.ReadKey();
        }
    }
}


