using SysOtica.Negocio.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysOtica.Conexao
{
    public interface IReceitaDados
    {
        void inserirReceita(Receita receita);
        void alterarReceita(Receita receita);
        void excluirreceita(Receita receita);
        List<Receita> listaReceita();
        List<Receita> vendaReceita();
        List<Receita> puxaReceita(string cl_nome);
    }
}
