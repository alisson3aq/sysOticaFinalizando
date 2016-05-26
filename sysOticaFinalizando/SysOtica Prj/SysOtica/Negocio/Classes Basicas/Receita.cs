using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negocio.Classes_Basicas
{
    public class Receita
    {
        private int rc_id;
        private DateTime rc_historico;
        private decimal rc_lodesferico;
        private decimal rc_loeesferico;
        private decimal rc_podesferico;
        private decimal rc_poeesferico;
        private decimal rc_lodcilindrico;
        private decimal rc_loecilindrico;
        private decimal rc_podcilindrico;
        private decimal rc_poecilindrico;
        private decimal rc_lodeixo;
        private decimal rc_loeeixo;
        private decimal rc_podeixo;
        private decimal rc_poeeixo;
        private decimal rc_lodaltura;
        private decimal rc_loealtura;
        private decimal rc_podaltura;
        private decimal rc_poealtura;
        private decimal rc_loddnp;
        private decimal rc_loednp;
        private decimal rc_poddnp;
        private decimal rc_poednp;
        private decimal rc_adicao;
        private String rc_nomemedico;
        private String rc_observacoes;
        private DateTime rc_data;
        private DateTime rc_dtavencimento;
        private Cliente cliente;
        private Venda venda;


        public Receita()
        {

            Cliente = new Cliente();

        }


        public int Rc_id
        {
            get
            {
                return rc_id;
            }

            set
            {
                rc_id = value;
            }
        }

        public DateTime Rc_historico
        {
            get
            {
                return rc_historico;
            }

            set
            {
                rc_historico = value;
            }
        }

        public decimal Rc_lodesferico
        {
            get
            {
                return rc_lodesferico;
            }

            set
            {
                rc_lodesferico = value;
            }
        }

        public decimal Rc_loeesferico
        {
            get
            {
                return rc_loeesferico;
            }

            set
            {
                rc_loeesferico = value;
            }
        }

        public decimal Rc_podesferico
        {
            get
            {
                return rc_podesferico;
            }

            set
            {
                rc_podesferico = value;
            }
        }

        public decimal Rc_poeesferico
        {
            get
            {
                return rc_poeesferico;
            }

            set
            {
                rc_poeesferico = value;
            }
        }

        public decimal Rc_lodcilindrico
        {
            get
            {
                return rc_lodcilindrico;
            }

            set
            {
                rc_lodcilindrico = value;
            }
        }

        public decimal Rc_loecilindrico
        {
            get
            {
                return rc_loecilindrico;
            }

            set
            {
                rc_loecilindrico = value;
            }
        }

        public decimal Rc_podcilindrico
        {
            get
            {
                return rc_podcilindrico;
            }

            set
            {
                rc_podcilindrico = value;
            }
        }

        public decimal Rc_poecilindrico
        {
            get
            {
                return rc_poecilindrico;
            }

            set
            {
                rc_poecilindrico = value;
            }
        }

        public decimal Rc_lodeixo
        {
            get
            {
                return rc_lodeixo;
            }

            set
            {
                rc_lodeixo = value;
            }
        }

        public decimal Rc_loeeixo
        {
            get
            {
                return rc_loeeixo;
            }

            set
            {
                rc_loeeixo = value;
            }
        }

        public decimal Rc_podeixo
        {
            get
            {
                return rc_podeixo;
            }

            set
            {
                rc_podeixo = value;
            }
        }

        public decimal Rc_poeeixo
        {
            get
            {
                return rc_poeeixo;
            }

            set
            {
                rc_poeeixo = value;
            }
        }

        public decimal Rc_lodaltura
        {
            get
            {
                return rc_lodaltura;
            }

            set
            {
                rc_lodaltura = value;
            }
        }

        public decimal Rc_loealtura
        {
            get
            {
                return rc_loealtura;
            }

            set
            {
                rc_loealtura = value;
            }
        }

        public decimal Rc_podaltura
        {
            get
            {
                return rc_podaltura;
            }

            set
            {
                rc_podaltura = value;
            }
        }

        public decimal Rc_poealtura
        {
            get
            {
                return rc_poealtura;
            }

            set
            {
                rc_poealtura = value;
            }
        }

        public decimal Rc_loddnp
        {
            get
            {
                return rc_loddnp;
            }

            set
            {
                rc_loddnp = value;
            }
        }

        public decimal Rc_loednp
        {
            get
            {
                return rc_loednp;
            }

            set
            {
                rc_loednp = value;
            }
        }

        public decimal Rc_poddnp
        {
            get
            {
                return rc_poddnp;
            }

            set
            {
                rc_poddnp = value;
            }
        }

        public decimal Rc_poednp
        {
            get
            {
                return rc_poednp;
            }

            set
            {
                rc_poednp = value;
            }
        }

        public decimal Rc_adicao
        {
            get
            {
                return rc_adicao;
            }

            set
            {
                rc_adicao = value;
            }
        }

        public string Rc_nomemedico
        {
            get
            {
                return rc_nomemedico;
            }

            set
            {
                rc_nomemedico = value;
            }
        }

        public string Rc_observacoes
        {
            get
            {
                return rc_observacoes;
            }

            set
            {
                rc_observacoes = value;
            }
        }

        public DateTime Rc_data
        {
            get
            {
                return rc_data;
            }

            set
            {
                rc_data = value;
            }
        }

        public DateTime Rc_dtavencimento
        {
            get
            {
                return rc_dtavencimento;
            }

            set
            {
                rc_dtavencimento = value;
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
    }
}