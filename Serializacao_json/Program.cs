using System;
using Newtonsoft.Json;
using System.IO;
using System.Text;

namespace Serializacao_json
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serializacao");

            //estanciando um objeto com base na classe Movie 
            Movie filme = new Movie {Id = 1, Title = "Mission Imposible"};

            //serializando o objeto criado em json, e jogando para uma variavel do tipo string
            string result = JsonConvert.SerializeObject(filme);

            //Criando um arquivo e instanciando ele na variavel wp 
            StreamWriter wp = new StreamWriter("file.json");

            //Escrevendo o meu objeto serializado no arquivo que eu criei
            wp.WriteLine(result);

            //fechando o arquivo
            wp.Close();
            
            System.Console.WriteLine(result);

            //Deserializacao

            System.Console.WriteLine("\nDeserialization");

            //pegando um arquivo existente chamado file.json, e jogando na variavel leitor 
            StreamReader leitor = new StreamReader("file.json", Encoding.UTF8);

            //Lendo o que esta na variavel leittor e colocando na variavel lido
            string lido = leitor.ReadToEnd();



            //transformando o meu arquivo json em objeto novamente com base na classe Movie(Deserializacao)
            Movie newFilme = JsonConvert.DeserializeObject<Movie>(lido);

            //imprimindo o meu objeto que foi deserializado 
            Console.WriteLine("ID: " + newFilme.Id + "\nTitle: " + newFilme.Title);

            Console.ReadKey();

          
        }
    }
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }
    } 
}
