using SysOtica.Negocio.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexao
{
    public interface IClienteDados
    {
        void inserirCliente(Cliente C);
        void alterarCliente(Cliente C);
        void excluirCliente(Cliente C);
        List<Cliente> listarCliente();
        List<Cliente> pesquisarCliente(string cl_nome);
        List<Cliente> getCliente(int cl_id);
        
    }
}
