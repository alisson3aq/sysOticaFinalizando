using SysOtica.Negocio.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexao
{
    public interface IUsuarioDados
    {
        void inserirUsuario(Usuario usu);
        void alteraUsuario(Usuario usu);
        void deleteUsuario(Usuario usu);
        bool verificaduplicidade(Usuario usu);
        List<Usuario> pesquisaUsuario(string us_nome);
        List<Usuario> listaUsuario();
    }
}
