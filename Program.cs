﻿using System;
using System.IO;

namespace codexpaula6
{
    class Program {
        static void Main(string[] args) {
            string[] perguntas = File.ReadAllLines(@"C:\Users\FIC\Desktop\codexpaula6\perguntas.txt");
            string[] respostas = new string[perguntas.Length];
            StreamWriter arquivo_respostas = new StreamWriter(@"C:\Users\FIC\Desktop\codexpaula6\respostas.csv", true);
            fazerPerguntas(perguntas, respostas, arquivo_respostas);
            arquivo_respostas.Close();
        }
        static void fazerPerguntas(string[] perguntas, string[] respostas, StreamWriter arquivo_respostas) {
            for(int i = 0; i < perguntas.Length; i++){
                Console.Write("Qual " + perguntas[i] + ": ");
                respostas[i] = Console.ReadLine();
            }
            escreverRespostas(respostas, arquivo_respostas);
            Console.Write("Quer cadastrar um novo cliente (sim ou não)? ");
            string novo = Console.ReadLine();
            if (novo == "sim" || novo == "Sim" || novo == "s" || novo == "S" )
                fazerPerguntas(perguntas, respostas, arquivo_respostas);
        }
        static void escreverRespostas(string[] respostas, StreamWriter arquivo_respostas) {
            for(int i = 0; i < respostas.Length; i++){
                if (i == (respostas.Length - 1))
                    arquivo_respostas.Write(respostas[i] + "\n");
                else
                    arquivo_respostas.Write(respostas[i] + ";");
            }
        }
    }
}