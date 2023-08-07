using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//Importando a classe da dados do MYSQL
using Org.BouncyCastle.Math;

namespace Empresa
{
    class DAO
    {
        public MySqlConnection conexao;
        public long[] CPF;
        public string[] nome;
        public long[] telefone;
        public string[] cidade;
        public string[] UF;
        int i;
        int contador;


        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=EmpresaTI17T;Uid=root;password=");
            try
            {
                conexao.Open();//Abrir a conexao com o banco de dados  
                MessageBox.Show("Conectado!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado! \n\n" + erro.Message);
            }
        }//Fim do construtor    

        //Método de inserção de dados:

        public string Inserir(long CPF, string Nome, long Telefone, string Cidade, string UF, string nomeTabela)
        {
            string inserir = $"Insert into {nomeTabela}(CPF, Nome, Telefone, Cidade, UF) values('{CPF}','{Nome}','{Telefone}','{Cidade}', '{UF}')";//Código banco de dados
            MySqlCommand sql = new MySqlCommand(inserir, conexao);//Comando e onde executar
            string resultado = sql.ExecuteNonQuery() + " Executado!";//Executando (é o ctrl enter)
            return resultado;
        }//fim do método

        public void PreencherVetor()
        {
            string query = "Select * from pessoa";

            //Instanciar

            this.CPF      = new long[100];
            this.nome     = new string[100];
            this.telefone = new long[100];
            this.cidade   = new string[100];
            this.UF       = new string[100];

            //Preparar o comando

            MySqlCommand sql = new MySqlCommand(query, conexao);

            //Leitor

            MySqlDataReader leitura = sql.ExecuteReader();
            i = 0;
            contador = 0;
          
            while(leitura.Read())
                {
                CPF[i] = Convert.ToInt64(leitura["CPF"]);
                nome[i] = leitura["Nome"] + "";
                telefone[i] = Convert.ToInt64(leitura["Telefone"]);
                cidade[i] = leitura["Cidade"] + "";
                UF[i] = leitura["UF"] + "";
                i++;
                contador++;
                }//fim while

            //Encerro a comunicação com o banco
            leitura.Close();
        }//fim do preenchervetor

        public int QuantidadeDados()
        {
            return contador;
        }//fim do quantidadeDados
    

        public string Atualizar(long CPF, string nomeTabela, string campo, string dado)
        {
            string query = $"update{nomeTabela} set {campo} = '{dado}' where CPF = '{CPF}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + " Atualizado!";
            return resultado;
        }//fim atualizar

        public string Excluir(long CPF, string nomeTabela)
        {
            string query = $"delete from {nomeTabela} where CPF = {CPF}";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + " Excluído!";
            return resultado;
        }//fim excluir

    }//Fim da classe
}//Fim do projeto
