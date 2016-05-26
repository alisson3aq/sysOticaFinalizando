using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negocio.Classes_Basicas
{
    public class Usuario
    {

        private int us_id;
        private String us_senha;
        private String us_endereco;
        private String us_telefone;
        private String us_tipo;
        private String us_usuario;
        private String us_nome;
        private List<Venda> venda;

        public Usuario(int us_id, string us_senha, string us_endereco, string us_telefone, string us_tipo, string us_usuario, string us_nome, List<Venda> venda)
        {
            this.us_id = us_id;
            this.us_senha = us_senha;
            this.us_endereco = us_endereco;
            this.us_telefone = us_telefone;
            this.us_tipo = us_tipo;
            this.us_usuario = us_usuario;
            this.us_nome = us_nome;
            this.venda = new List<Venda>();
        }

        public Usuario()
        {
        }

        public int Us_id
        {
            get
            {
                return us_id;
            }

            set
            {
                us_id = value;
            }
        }

        public string Us_senha
        {
            get
            {
                return us_senha;
            }

            set
            {
                us_senha = value;
            }
        }

        public string Us_endereco
        {
            get
            {
                return us_endereco;
            }

            set
            {
                us_endereco = value;
            }
        }

        public string Us_telefone
        {
            get
            {
                return us_telefone;
            }

            set
            {
                us_telefone = value;
            }
        }

        public string Us_tipo
        {
            get
            {
                return us_tipo;
            }

            set
            {
                us_tipo = value;
            }
        }

        public string Us_usuario
        {
            get
            {
                return us_usuario;
            }

            set
            {
                us_usuario = value;
            }
        }

        public string Us_nome
        {
            get
            {
                return us_nome;
            }

            set
            {
                us_nome = value;
            }
        }

        public List<Venda> Venda
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
