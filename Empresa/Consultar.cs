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
    public partial class Consultar : Form
    {
        DAO consul;
        
        public Consultar()
        {
            consul = new DAO();
            InitializeComponent();
            ConfigurarDataGrid();
            NomeColunas();//Nomear os titulos das colunas
            AdicionarDados();//preenchendo o datagrid view   
        }//fim construtor

        public void NomeColunas()
        {
            dataGridView1.Columns[0].Name= "CPF";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Telefone";
            dataGridView1.Columns[3].Name = "Cidade";
            dataGridView1.Columns[4].Name = "UF";
        }//fim do nome colunas

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }//Datagrid view
    
        public void ConfigurarDataGrid()
        {
            dataGridView1.AllowUserToAddRows= false;//Usuario nao pode add linha
            dataGridView1.AllowUserToDeleteRows = false;// Usuario nao pode excluir linha
            dataGridView1.AllowUserToResizeColumns= false;// Usuario nao pode redimencionar coluna
            dataGridView1.AllowUserToResizeRows= false;// Usuario nao pode redimencionar linha
            dataGridView1.ColumnCount = 5;
        }//Fim ConfigurarDataGrid

        public void AdicionarDados()
        {
            consul.PreencherVetor();//Preencher os vetores

            for (int i = 0; i < consul.QuantidadeDados(); i++)
            {
                dataGridView1.Rows.Add(consul.CPF[i], consul.nome[i], consul.telefone[i], consul.cidade[i], consul.UF[i]);
            }// fim for
        }//fim do adicionar dados



    }//fim da classe
}// fim do projeto
