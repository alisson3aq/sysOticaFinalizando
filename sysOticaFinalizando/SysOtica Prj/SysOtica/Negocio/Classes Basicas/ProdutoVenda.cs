using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negocio.Classes_Basicas
{
    public class ProdutoVenda
    {
        private Venda venda;
        private Produto produto;
        private int pv_qtd;
        private decimal pv_preco;

        public ProdutoVenda()
        {
            produto = new Produto();
        }


        public Venda Venda
        {
            get
            {
                return venda;
            }

            set
            {
                venda = value;
            }
        }

        public Produto Produto
        {
            get
            {
                return produto;
            }

            set
            {
                produto = value;
            }
        }

        public int Pv_qtd
        {
            get
            {
                return pv_qtd;
            }

            set
            {
                pv_qtd = value;
            }
        }

        public decimal Pv_preco
        {
            get
            {
                return pv_preco;
            }

            set
            {
                pv_preco = value;
            }
        }
    }
}
