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
    public class FornecedorControlador
    {
        FornecedoresDados forn = new FornecedoresDados();

        public void VerificaPreenchimento(Fornecedor fr)
        {
            if (String.IsNullOrEmpty(fr.Fr_bairro)) { MessageBox.Show("Campo Bairro Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_celularrepresentante)) { MessageBox.Show("Campo Celular Representante Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_cep)) { MessageBox.Show("Campo CEP Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_cidade)) { MessageBox.Show("Campo Cidade Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_cnpj)) { MessageBox.Show("Campo CNPJ Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_contato)) { MessageBox.Show("Campo Contato Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_email)) { MessageBox.Show("Campo E-mail Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_endereco)) { MessageBox.Show("Campo Endereço Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_fantasia)) { MessageBox.Show("Campo Nome Fantasia Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_fax)) { MessageBox.Show("Campo Fax Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_inscricaoestadual)) { MessageBox.Show("Campo Inscrição Estadual Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_nomerepresentante)) { MessageBox.Show("Campo Nome Representante Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_observacoes)) { MessageBox.Show("Campo Observações Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_razaosocial)) { MessageBox.Show("Campo Razão Social Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_telefone)) { MessageBox.Show("Campo Telefone Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_telefonerepresentante)) { MessageBox.Show("Campo Telefone Representante Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_uf)) { MessageBox.Show("Campo UF Vazio"); }

        }


        public void ValidarGuid(Fornecedor fr)
        {
            if (fr == null)
            {
                MessageBox.Show("Int vazio ou inválido");
            }

        }

    }
}
