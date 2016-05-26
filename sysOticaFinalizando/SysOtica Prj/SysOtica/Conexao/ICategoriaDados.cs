using SysOtica.Negocio.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexao
{
   public interface ICategoriaDados
    {
        void inserirCategoria(Categoria c);
        List<Categoria> pesquisaCategoria();
    }
}
