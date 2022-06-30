using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSerialização
{
    [Serializable]
   internal class Paciente
    {
        string nome;
        DateTime dataNascimento;
        [NonSerialized]
        [XmlIgnore]//adicionar depois de finalizar o SOAP
        string cpf;
    }
}
