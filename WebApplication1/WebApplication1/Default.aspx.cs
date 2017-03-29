using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBotao_Click(object sender, EventArgs e)
        {
            int gastos, entrada, lucro;
            // Cria e abre a conexão com o banco de dados (essa string só serve para acessar o banco localmente)
            // Veja mais strings de conexão em http://www.connectionstrings.com/
            using (SqlConnection conn = new SqlConnection("Server=tcp:serversala.database.windows.net,1433;Database=bancogeral;User ID=aluno@serversala;Password=123Mudar;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                conn.Open();
                // Cria um comando para inserir um novo registro à tabela
                using (SqlCommand cmd = new SqlCommand("select sum(Valor_custo) from TbCaixa;", conn))
                {
                    gastos = (int)cmd.ExecuteScalar();
                }
                txtValor1.Text = gastos.ToString();

                using (SqlCommand cmd = new SqlCommand("select sum(Valor_cobrado) from TbCaixa;", conn))
                {
                   entrada = (int)cmd.ExecuteScalar();
                }
                txtValor2.Text = entrada.ToString();

                lucro = entrada - gastos;
                txtValor3.Text = lucro.ToString();
            }
        }

        protected void btnComanda_Click(object sender, EventArgs e)
        {
            int comanda, valorComanda;

            if (int.TryParse(txtComanda.Text, out comanda) == false)
            {
                // Campo não contém um número inteiro!
                txtComanda.Text = "Valor Inválido!";
                // O return encerra a execução por aqui
                return;
            }

            using (SqlConnection conn = new SqlConnection("Server=tcp:serversala.database.windows.net,1433;Database=bancogeral;User ID=aluno@serversala;Password=123Mudar;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                conn.Open();
                // Cria um comando para inserir um novo registro à tabela
                using (SqlCommand cmd = new SqlCommand("select sum(Valor_cobrado) from TbCaixa where Comanda = @comanda ;", conn))
                {
                    cmd.Parameters.AddWithValue("@comanda", comanda);
                    valorComanda = (int)cmd.ExecuteScalar();
                }
                txtValorComanda.Text = valorComanda.ToString();
            }
        }

        protected void btnGeral_Click(object sender, EventArgs e)
        {

        }
    }
}