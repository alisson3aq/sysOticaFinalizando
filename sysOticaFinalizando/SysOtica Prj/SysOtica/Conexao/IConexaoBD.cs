using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexao
{
    public interface IConexaoBD
    {
        //Estabelece uma conexão com o banco de dados
        void AbrirConexao();

        //Desconecta do Banco de Dados
        void FecharConexao();
    }
}
