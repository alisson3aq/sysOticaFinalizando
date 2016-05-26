using SysOtica.Conexao;
using SysOtica.Negocio.Classes_Basicas;
using SysOtica.Negocio.Excecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysOtica.Negocio.Regras_de_Negocio
{
    public class VendaControlador
    {

        public void ValorDivergente(Venda v)
        {

            if (v.Vn_desconto == v.Vn_valor)
            {
                MessageBox.Show("Desconto não pode ser 100%!");
            }


        }

        }
}
