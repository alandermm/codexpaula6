using System;
using System.IO;
namespace codexpaula6
{
    class Pessoa {
        private StreamWriter arquivo_respostas;
        private string[] perguntas;
        private string[] respostas;
        private bool existe_cadastro;
        public void prepararPerguntas (String path_campos){
            this.perguntas = File.ReadAllLines(path_campos);
        }
        public void escreverCabecalhoSeArquivoNaoExiste(String path_respostas ) {
            this.existe_cadastro = File.Exists(path_respostas);
            this.arquivo_respostas = new StreamWriter(path_respostas, true);
            if(!this.existe_cadastro){
                for(int i = 0; i < this.perguntas.Length; i++){
                    if (i == (perguntas.Length - 1))
                        arquivo_respostas.WriteLine(perguntas[i]);
                    else
                        this.arquivo_respostas.Write(perguntas[i] + ";");
                }    
            }
        }
        public void fazerPerguntas() {
            this.respostas = new string[perguntas.Length];
            for(int i = 0; i < this.perguntas.Length; i++){
                Console.Write("Qual " + this.perguntas[i] + ": ");
                this.respostas[i] = Console.ReadLine();
            }
            escreverRespostas();
            Console.Write("Quer cadastrar um novo cliente (sim ou não)? ");
            string novo = Console.ReadLine();
            if (novo == "sim" || novo == "Sim" || novo == "s" || novo == "S" )
                fazerPerguntas();
            arquivo_respostas.Close();
        }
        protected void escreverRespostas() {
            for(int i = 0; i < this.respostas.Length; i++){
                if (i == (this.respostas.Length - 1))
                    arquivo_respostas.Write(this.respostas[i] + "\n");
                else
                    arquivo_respostas.Write(this.respostas[i] + ";");
            }
        }
    }
}