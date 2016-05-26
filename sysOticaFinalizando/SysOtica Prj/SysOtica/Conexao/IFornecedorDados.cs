using SysOtica.Negocio.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexao
{
    public interface IFornecedorDados
    {
        void inserirFornecedor(Fornecedor fr);
        void alteraFornecedor(Fornecedor fr);
        void excluiFornecedor(Fornecedor fr);
        bool verificaduplicidade(Fornecedor fornecedor);
        List<Fornecedor> listaFornecedor();
        List<Fornecedor> pesquisarFornecedor(string fr_fantasia);
    }
}
