using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//Conectando aos comandos do banco de dados

namespace Empresa
{
    public partial class Cadastrar : Form
    {
        DAO conectar;       
        
        public Cadastrar()
        {
            InitializeComponent();
            conectar = new DAO();//Ligando o formulario ao Conector do banco de dados           
        }//Fim do construtor


        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                string result = conectar.Inserir(Convert.ToInt64(cpf.Text), nome.Text, Convert.ToInt64(telefone.Text), cidade.Text, uf.Text, "Pessoa");
                MessageBox.Show(result);
            } catch(Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro.Message);
            }//fim do catch
        }//Botão cadastrar

        private void cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Botao cpf

        private void nome_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Botao nome

        private void telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Botao telefone

        private void cidade_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Botao cidade

        private void uf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Botao UF


    }//Fim classe
}//Fim projeto
