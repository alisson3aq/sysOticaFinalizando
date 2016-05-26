using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negocio.Classes_Basicas
{
    public class Fornecedor
    {
        private int fr_id;
        private String fr_razaosocial;
        private String fr_inscricaoestadual;
        private String fr_fantasia;
        private String fr_endereco;
        private String fr_cidade;
        private String fr_uf;
        private String fr_bairro;
        private String fr_cep;
        private String fr_contato;
        private String fr_telefone;
        private String fr_fax;
        private String fr_email;
        private String fr_nomerepresentante;
        private String fr_telefonerepresentante;
        private String fr_celularrepresentante;
        private String fr_observacoes;
        private String fr_cnpj;
        private Produto produto;



        public Fornecedor()
        {
        }

        public int Fr_id
        {
            get
            {
                return fr_id;
            }

            set
            {
                fr_id = value;
            }
        }

        public string Fr_razaosocial
        {
            get
            {
                return fr_razaosocial;
            }

            set
            {
                fr_razaosocial = value;
            }
        }

        public string Fr_inscricaoestadual
        {
            get
            {
                return fr_inscricaoestadual;
            }

            set
            {
                fr_inscricaoestadual = value;
            }
        }

        public string Fr_fantasia
        {
            get
            {
                return fr_fantasia;
            }

            set
            {
                fr_fantasia = value;
            }
        }

        public string Fr_endereco
        {
            get
            {
                return fr_endereco;
            }

            set
            {
                fr_endereco = value;
            }
        }

        public string Fr_cidade
        {
            get
            {
                return fr_cidade;
            }

            set
            {
                fr_cidade = value;
            }
        }

        public string Fr_uf
        {
            get
            {
                return fr_uf;
            }

            set
            {
                fr_uf = value;
            }
        }

        public string Fr_bairro
        {
            get
            {
                return fr_bairro;
            }

            set
            {
                fr_bairro = value;
            }
        }

        public string Fr_cep
        {
            get
            {
                return fr_cep;
            }

            set
            {
                fr_cep = value;
            }
        }

        public string Fr_contato
        {
            get
            {
                return fr_contato;
            }

            set
            {
                fr_contato = value;
            }
        }

        public string Fr_telefone
        {
            get
            {
                return fr_telefone;
            }

            set
            {
                fr_telefone = value;
            }
        }

        public string Fr_fax
        {
            get
            {
                return fr_fax;
            }

            set
            {
                fr_fax = value;
            }
        }

        public string Fr_email
        {
            get
            {
                return fr_email;
            }

            set
            {
                fr_email = value;
            }
        }

        public string Fr_nomerepresentante
        {
            get
            {
                return fr_nomerepresentante;
            }

            set
            {
                fr_nomerepresentante = value;
            }
        }

        public string Fr_telefonerepresentante
        {
            get
            {
                return fr_telefonerepresentante;
            }

            set
            {
                fr_telefonerepresentante = value;
            }
        }

        public string Fr_celularrepresentante
        {
            get
            {
                return fr_celularrepresentante;
            }

            set
            {
                fr_celularrepresentante = value;
            }
        }

        public string Fr_observacoes
        {
            get
            {
                return fr_observacoes;
            }

            set
            {
                fr_observacoes = value;
            }
        }

        public string Fr_cnpj
        {
            get
            {
                return fr_cnpj;
            }

            set
            {
                fr_cnpj = value;
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
    }
}
