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
    public class ClienteControlador
    {
        
        public void ValidarCamposVazios(Cliente c)
        {
            if (string.IsNullOrEmpty(c.Cl_nome))
            {
                MessageBox.Show("Nome vazio! Digite o nome...");
            }
            if (string.IsNullOrEmpty(c.Cl_cpf))
            {
                MessageBox.Show("CPF vazio! Digite o CPF...");
            }
            if (string.IsNullOrEmpty(c.Cl_rg))
            {
                MessageBox.Show("RG vazio! Digite o RG...");
            }
            if (string.IsNullOrEmpty(c.Cl_telefone))
            {
                MessageBox.Show("Telefone vazio! Digite o telefone...");
            }
            if (string.IsNullOrEmpty(c.Cl_celular))
            {
                MessageBox.Show("Celular vazio! Digite o Celular...");
            }
            if (string.IsNullOrEmpty(c.Cl_telefone2))
            {
                MessageBox.Show("Telefone2 vazio! Digite o Telefone2...");
            }
            if (string.IsNullOrEmpty(c.Cl_cep))
            {
                MessageBox.Show("CEP vazio! Digite o CEP...");
            }
            if (string.IsNullOrEmpty(c.Cl_endereco))
            {
                MessageBox.Show("Endereço vazio! Digite o Endereço...");
            }
            if (string.IsNullOrEmpty(c.Cl_numero))
            {
                MessageBox.Show("Número vazio! Digite o Número...");
            }
            if (string.IsNullOrEmpty(c.Cl_bairro))
            {
                MessageBox.Show("Bairro vazio! Digite o Bairro...");
            }
            if (string.IsNullOrEmpty(c.Cl_cidade))
            {
                MessageBox.Show("Cidade vazio! Digite a Cidade...");
            }
            if (string.IsNullOrEmpty(c.Cl_uf))
            {
                MessageBox.Show("UF vazio! Digite o UF...");
            }
            if (string.IsNullOrEmpty(c.Cl_email))
            {
                MessageBox.Show("Email vazio! Digite o Email...");
            }
            if (string.IsNullOrEmpty(c.Cl_nomepai))
            {
                MessageBox.Show("Nome do Pai vazio! Digite o nome do Pai...");
            }

            if (string.IsNullOrEmpty(c.Cl_nomemae))
            {
                MessageBox.Show("Nome mãe vazio! Digite o Nome mãe...");
            }
            if (string.IsNullOrEmpty(c.Cl_profissao))
            {
                MessageBox.Show("Profissão vazio! Digite o Profissão...");
            }
            if (string.IsNullOrEmpty(c.Cl_observacoes))
            {
                MessageBox.Show("Observação vazio! Digite a observação...");
            }

        }

        public void ValidarGuid(Cliente c)
        {
            if (c == null)
            {
                MessageBox.Show("Int vazio ou inválido");
            }
        }

    }
}
