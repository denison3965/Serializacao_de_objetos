using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace serializacao_bin.Model
{
    [Serializable]
    public class MeuObjeto
    {
        public int ID;
        public String Name;
    }
}