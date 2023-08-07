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
    public partial class Form1 : Form
    {
        Cadastrar cad;
        Consultar con;
        Atualizar atu;
        Excluir exc;
        DAO consul;
        
        
        
        public Form1()
        {
            InitializeComponent();
        
            cad = new Cadastrar();
            con = new Consultar();
            atu= new Atualizar();
            exc= new Excluir();
            consul = new DAO();
            
        }//fim do construtor

        

        private void button1_Click(object sender, EventArgs e)
        {
            cad.ShowDialog();//abre a tela
        }//cadastrar

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.ShowDialog();//abre a tela

        }//consultar

        private void button2_Click(object sender, EventArgs e)
        {
            atu.ShowDialog();//abre a tela
        }//atualizar

        private void button3_Click(object sender, EventArgs e)
        {
            exc.ShowDialog();//abre a tela
        }//excluir

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }//fim da classe
}// fim do projeto
