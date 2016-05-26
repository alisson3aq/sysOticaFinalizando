using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negocio.Classes_Basicas
{
   public class Venda
    {
        private int vn_id;
        private Cliente cliente;
        private int vn_receita;
        private decimal vn_valor;
        private decimal vn_valortotal;
        private decimal vn_desconto;
        private String vn_formapagamento;
        private DateTime vn_dtsaida;
        private int vn_qtdsaida;
        private List<ProdutoVenda> listaitens;
        private object produtoVenda;

        public int Vn_id
        {
            get
            {
                return vn_id;
            }

            set
            {
                vn_id = value;
            }
        }

        public Cliente Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
            }
        }

        public int Vn_receita
        {
            get
            {
                return vn_receita;
            }

            set
            {
                vn_receita = value;
            }
        }

        public decimal Vn_valor
        {
            get
            {
                return vn_valor;
            }

            set
            {
                vn_valor = value;
            }
        }

        public decimal Vn_valortotal
        {
            get
            {
                return vn_valortotal;
            }

            set
            {
                vn_valortotal = value;
            }
        }

        public decimal Vn_desconto
        {
            get
            {
                return vn_desconto;
            }

            set
            {
                vn_desconto = value;
            }
        }

        public string Vn_formapagamento
        {
            get
            {
                return vn_formapagamento;
            }

            set
            {
                vn_formapagamento = value;
            }
        }

        public DateTime Vn_dtsaida
        {
            get
            {
                return vn_dtsaida;
            }

            set
            {
                vn_dtsaida = value;
            }
        }

        public int Vn_qtdsaida
        {
            get
            {
                return vn_qtdsaida;
            }

            set
            {
                vn_qtdsaida = value;
            }
        }

        public List<ProdutoVenda> Listaitens
        {
            get
            {
                return listaitens;
            }

            set
            {
                listaitens = value;
            }
        }

        public object ProdutoVenda
        {
            get
            {
                return produtoVenda;
            }

            set
            {
                produtoVenda = value;
            }
        }
    }
}
