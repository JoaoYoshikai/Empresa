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
    public partial class Excluir : Form
    {
        DAO exc;
        
        public Excluir()
        {
            exc = new DAO();
            InitializeComponent();
        }

        private void cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//CPF

        private void button1_Click(object sender, EventArgs e)
        {
            string result = exc.Excluir(Convert.ToInt64(cpf.Text), "pessoa");
            MessageBox.Show("iscruido!");
        }//Botao excluir
    }//FIM CLASSE
}//FIM PROJETO
