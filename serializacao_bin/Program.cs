using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using serializacao_bin.Model;

namespace serializacao_bin
{
    class Program
    {
        static void Main(string[] args)
        {

            //Criando o meu objeto e atribuindo as suas propriedades
            MeuObjeto obj = new MeuObjeto();
            obj.ID = 15;
            obj.Name = "Fernando de Oliveira";

            //Criando um variavel para formatar meu arquivo em binario quando o processo de serializacao for executado
            IFormatter formatter = new BinaryFormatter();

            //iniciando um arquivo 
            Stream stream = new FileStream("ExampleNew.txt",FileMode.Create,FileAccess.Write);

            //Serealizando o meu objeto com o formato binario
            formatter.Serialize(stream, obj);

            //fechando o meu arquivo
            stream.Close();


            //deserializacao
            stream = new FileStream("ExampleNew.txt",FileMode.Open,FileAccess.Read);
            MeuObjeto objnew = (MeuObjeto)formatter.Deserialize(stream);

            Console.WriteLine(objnew.ID);
            Console.WriteLine(objnew.Name);

            Console.ReadKey();

            //https://www.guru99.com/c-sharp-serialization.html
        }
    }
}
