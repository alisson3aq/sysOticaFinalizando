using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negocio.Classes_Basicas
{
    public class Cliente
    {
        private int cl_id;
        private String cl_nome;
        private DateTime cl_datanascimento;
        private String cl_cpf;
        private String cl_rg;
        private String cl_telefone;
        private String cl_celular;
        private String cl_telefone2;
        private String cl_cep;
        private String cl_endereco;
        private String cl_numero;
        private String cl_bairro;
        private String cl_cidade;
        private String cl_email;
        private String cl_nomepai;
        private String cl_nomemae;
        private String cl_profissao;
        private String cl_observacoes;
        private String cl_uf;
        private Venda venda;
        private List<Receita> listareceita;

        public Cliente(int cl_id, string cl_nome, DateTime cl_datanascimento, string cl_cpf, string cl_rg, string cl_telefone, string cl_celular, string cl_telefone2, string cl_cep, string cl_endereco, string cl_numero, string cl_bairro, string cl_cidade, string cl_email, string cl_nomepai, string cl_nomemae, string cl_profissao, string cl_observacoes, string cl_uf,Venda venda, List<Receita> listareceita)
        {
            this.cl_id = cl_id;
            this.cl_nome = cl_nome;
            this.cl_datanascimento = cl_datanascimento;
            this.cl_cpf = cl_cpf;
            this.cl_rg = cl_rg;
            this.cl_telefone = cl_telefone;
            this.cl_celular = cl_celular;
            this.cl_telefone2 = cl_telefone2;
            this.cl_cep = cl_cep;
            this.cl_endereco = cl_endereco;
            this.cl_numero = cl_numero;
            this.cl_bairro = cl_bairro;
            this.cl_cidade = cl_cidade;
            this.cl_email = cl_email;
            this.cl_nomepai = cl_nomepai;
            this.cl_nomemae = cl_nomemae;
            this.cl_profissao = cl_profissao;
            this.cl_observacoes = cl_observacoes;
            this.cl_uf = cl_uf;
            this.venda = venda;
            this.listareceita = new List<Receita>();
        }

        public Cliente()
        {
        }

        public int Cl_id
        {
            get
            {
                return cl_id;
            }

            set
            {
                cl_id = value;
            }
        }

        public string Cl_nome
        {
            get
            {
                return cl_nome;
            }

            set
            {
                cl_nome = value;
            }
        }

        public DateTime Cl_datanascimento
        {
            get
            {
                return cl_datanascimento;
            }

            set
            {
                cl_datanascimento = value;
            }
        }

        public string Cl_cpf
        {
            get
            {
                return cl_cpf;
            }

            set
            {
                cl_cpf = value;
            }
        }

        public string Cl_rg
        {
            get
            {
                return cl_rg;
            }

            set
            {
                cl_rg = value;
            }
        }

        public string Cl_telefone
        {
            get
            {
                return cl_telefone;
            }

            set
            {
                cl_telefone = value;
            }
        }

        public string Cl_celular
        {
            get
            {
                return cl_celular;
            }

            set
            {
                cl_celular = value;
            }
        }

        public string Cl_telefone2
        {
            get
            {
                return cl_telefone2;
            }

            set
            {
                cl_telefone2 = value;
            }
        }

        public string Cl_cep
        {
            get
            {
                return cl_cep;
            }

            set
            {
                cl_cep = value;
            }
        }

        public string Cl_endereco
        {
            get
            {
                return cl_endereco;
            }

            set
            {
                cl_endereco = value;
            }
        }

        public string Cl_numero
        {
            get
            {
                return cl_numero;
            }

            set
            {
                cl_numero = value;
            }
        }

        public string Cl_bairro
        {
            get
            {
                return cl_bairro;
            }

            set
            {
                cl_bairro = value;
            }
        }

        public string Cl_cidade
        {
            get
            {
                return cl_cidade;
            }

            set
            {
                cl_cidade = value;
            }
        }

        public string Cl_email
        {
            get
            {
                return cl_email;
            }

            set
            {
                cl_email = value;
            }
        }

        public string Cl_nomepai
        {
            get
            {
                return cl_nomepai;
            }

            set
            {
                cl_nomepai = value;
            }
        }

        public string Cl_nomemae
        {
            get
            {
                return cl_nomemae;
            }

            set
            {
                cl_nomemae = value;
            }
        }

        public string Cl_profissao
        {
            get
            {
                return cl_profissao;
            }

            set
            {
                cl_profissao = value;
            }
        }

        public string Cl_observacoes
        {
            get
            {
                return cl_observacoes;
            }

            set
            {
                cl_observacoes = value;
            }
        }

        public string Cl_uf
        {
            get
            {
                return cl_uf;
            }

            set
            {
                cl_uf = value;
            }
        }

        public List<Receita> Listareceita
        {
            get
            {
                return listareceita;
            }

            set
            {
                listareceita = value;
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
