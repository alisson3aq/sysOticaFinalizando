using SysOtica.Conexao;
using SysOtica.Negocio.Classes_Basicas;
using SysOtica.Negocio.Excecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysOtica.Negocio.Regras_de_Negocio
{
    public class UsuarioControlador
    {

            UsuarioDados user = new UsuarioDados();

           public void VerificaPreenchimento(Usuario usuario)
           {
                if (String.IsNullOrEmpty(usuario.Us_usuario)) { MessageBox.Show("Campo Usuario Vazio"); }
                if (String.IsNullOrEmpty(usuario.Us_senha)) { MessageBox.Show("Campo Senha Vazio"); }
                if (String.IsNullOrEmpty(usuario.Us_endereco)) { MessageBox.Show("Campo Endereço Vazio"); }
               if (String.IsNullOrEmpty(usuario.Us_nome)) { MessageBox.Show("Campo Nome Vazio"); }
               if (String.IsNullOrEmpty(usuario.Us_telefone)) { MessageBox.Show("Campo Telefone Vazio"); }
               if (String.IsNullOrEmpty(usuario.Us_tipo)) { MessageBox.Show("Campo Tipo Vazio"); }

            }

                    public void ValidarGuid(Usuario usuario)
                    {

                        if (usuario == null)
                        {
                            MessageBox.Show("Int vazio ou inválido");
                        }

                    }




    }
}
