using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negocio.Excecoes
{
    public class BancoDeDadosException : Exception
    {
        public string Mensagem;
        public BancoDeDadosException(string message) : base(message)
        {
            this.Mensagem = message;
        }
    }
}
