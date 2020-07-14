using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace serializacao_xml
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando meu objeto pela classe clsPerson
            clsPerson p = new clsPerson();

            //Setando os Atributos do meu objeto 
            p.Nome = "Fernando dos Santos Araujo";
            p.CPF = "169412346";
            p.Idade = 18;

            //Criando um arquivo com nome Teste_xml.xml e instanciando na variavel fs
            FileStream fs = new FileStream("Teste_xml.xml", FileMode.Create);

             // Cria um objeto XmlSerializer para realizar a serialização com formatacao em xml
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(p.GetType());
            
            //Serializando o meu objeto p dentro do arquivo fs, e sendo formatado 
            //pela variavel de instancia x em arquivo xml 
            x.Serialize(fs, p);
            
            //Fechando meu arquivo
            fs.Close();

            System.Console.WriteLine("Objeto serializado com sucesso !");
         }
    }
}
