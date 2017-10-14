using System;
using System.IO;
namespace codexpaula6
{
    class Program {
        static void Main(string[] args) {
            Pessoa cliente = new Pessoa();
            cliente.prepararPerguntas(@"C:\Users\alander\CodeXP\codexpaula6\perguntas.txt");
            cliente.escreverCabecalhoSeArquivoNaoExiste(@"C:\Users\alander\CodeXP\codexpaula6\respostas.csv");
            cliente.fazerPerguntas();
        }
    }
}