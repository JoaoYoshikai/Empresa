using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa
{
    public partial class Atualizar : Form
    {
        DAO atu;
        
        public Atualizar()
        {
            atu = new DAO();
            InitializeComponent();
        
        }

        private void Atualizar_Load(object sender, EventArgs e)
        {

        }

        private void cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//cpf

        private void nome_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//nome

        private void telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//telefone

        private void cidade_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//cidade

        private void uf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//uf

        private void button1_Click(object sender, EventArgs e)
        {
            atu.Atualizar(Convert.ToInt64(cpf.Text), "pessoa","Nome", nome.Text);
            atu.Atualizar(Convert.ToInt64(cpf.Text), "pessoa", "Telefone", nome.Text);
            atu.Atualizar(Convert.ToInt64(cpf.Text), "pessoa", "Cidade", nome.Text);
            atu.Atualizar(Convert.ToInt64(cpf.Text), "pessoa", "UF", nome.Text);
            MessageBox.Show("Dados atualizados!");
        }//fim do atualizar
    }//fim da classe
}//fim do projeto
