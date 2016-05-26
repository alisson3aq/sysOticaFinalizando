using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negocio.Excecoes
{
    public class CampoVazioException : Exception
    {
        public string Mensagem;
        public CampoVazioException(string message) : base(message)
        {
            this.Mensagem = message;
        }
    }
}
