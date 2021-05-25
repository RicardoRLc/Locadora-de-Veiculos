using System;
using System.Drawing;
using System.Windows.Forms;
using Locadora_Veiculos_Ltda;
namespace View
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaInicial());
        }
        public class TelaInicial : Form
        {            
            Library.PictureBox pb_Menu;
            Library.Button btn_CadastroCliente;
            Library.Button btn_ConsultaCliente;
            Library.Button btn_ListaClientes;
            Library.Button btn_CadastroFilme;
            Library.Button btn_ConsultaFilme;
            Library.Button btn_ListaFilmes;
            Library.Button btn_CadastroLocacao;
            Library.Button btn_ConsultaLocacao;
            Library.Button btn_ListaLocacoes;
            Library.Button btn_MenuSair;

            public TelaInicial()
            {
                this.Text = "Locadora de Veículos Ltda";
                this.BackColor = Color.DarkGray;
                this.Font = new Font(this.Font, FontStyle.Bold);
                this.Size = new Size(380, 520);

                this.pb_Menu = new Library.PictureBox();
                this.pb_Menu.Location = new Point(10, 10);
                this.pb_Menu.Size = new Size(350, 70);
                this.pb_Menu.ClientSize = new Size(345, 70);
                this.pb_Menu.Load("./Views/assets/logo.jpg");
                this.Controls.Add(pb_Menu);

                this.btn_CadastroCliente = new Library.Button();
                this.btn_CadastroCliente.Location = new Point(80, 90);
                this.btn_CadastroCliente.Size = new Size(200, 30);
                this.btn_CadastroCliente.Text = "Cadastro Cliente";
                this.Controls.Add(btn_CadastroCliente);
                this.btn_CadastroCliente.Click += new EventHandler(btn_CadastroClienteClick);

                 this.btn_ConsultaCliente = new Library.Button();
                this.btn_ConsultaCliente.Location = new Point(80, 120);
                this.btn_ConsultaCliente.Size = new Size(200, 30);
                this.btn_ConsultaCliente.Text = "Consulta Cliente";
                this.Controls.Add(btn_ConsultaCliente);
                this.btn_ConsultaCliente.Click += new EventHandler(btn_ConsultaClienteClick);

                this.btn_ListaClientes = new Library.Button();
                this.btn_ListaClientes.Location = new Point(80, 150);
                this.btn_ListaClientes.Size = new Size(200, 30);
                this.btn_ListaClientes.Text = "Lista Clientes";
                this.Controls.Add(btn_ListaClientes);
                this.btn_ListaClientes.Click += new EventHandler(btn_ListaClientesClick);

                this.btn_CadastroFilme = new Library.Button();
                this.btn_CadastroFilme.Location = new Point(80, 200);
                this.btn_CadastroFilme.Size = new Size(200, 30);
                this.btn_CadastroFilme.Text = "Cadastro Veículo";
                this.Controls.Add(btn_CadastroFilme);
                // this.btn_CadastroFilme.Click += new EventHandler(btn_CadastroFilmeClick);

                this.btn_ConsultaFilme = new Library.Button();
                this.btn_ConsultaFilme.Location = new Point(80, 230);
                this.btn_ConsultaFilme.Size = new Size(200, 30);
                this.btn_ConsultaFilme.Text = "Consulta Veículo";
                this.Controls.Add(btn_ConsultaFilme);
                // this.btn_ConsultaFilme.Click += new EventHandler(btn_ConsultaFilmeClick);

                this.btn_ListaFilmes = new Library.Button();
                this.btn_ListaFilmes.Location = new Point(80, 260);
                this.btn_ListaFilmes.Size = new Size(200, 30);
                this.btn_ListaFilmes.Text = "Lista Veículos";
                this.Controls.Add(btn_ListaFilmes);
                // this.btn_ListaFilmes.Click += new EventHandler(btn_ListaFilmesClick);

                this.btn_CadastroLocacao = new Library.Button();
                this.btn_CadastroLocacao.Location = new Point(80, 310);
                this.btn_CadastroLocacao.Size = new Size(200, 30);
                this.btn_CadastroLocacao.Text = "Cadastro Locação";
                this.Controls.Add(btn_CadastroLocacao);
                // this.btn_CadastroLocacao.Click += new EventHandler(btn_CadastroLocacaoClick);
                
                this.btn_ConsultaLocacao = new Library.Button();
                this.btn_ConsultaLocacao.Location = new Point(80, 340);
                this.btn_ConsultaLocacao.Size = new Size(200, 30);
                this.btn_ConsultaLocacao.Text = "Consulta Locação";
                this.Controls.Add(btn_ConsultaLocacao);
                // this.btn_ConsultaLocacao.Click += new EventHandler(btn_ConsultaLocacaoClick);

                this.btn_ListaLocacoes = new Library.Button();
                this.btn_ListaLocacoes.Location = new Point(80, 370);
                this.btn_ListaLocacoes.Size = new Size(200, 30);
                this.btn_ListaLocacoes.Text = "Lista Locações";
                this.Controls.Add(btn_ListaLocacoes);
                // this.btn_ListaLocacoes.Click += new EventHandler(btn_ListaLocacoesClick);

                this.btn_MenuSair = new Library.Button();
                this.btn_MenuSair.Location = new Point(100, 420);
                this.btn_MenuSair.Text = "Sair";
                this.Controls.Add(btn_MenuSair);
                this.btn_MenuSair.Click += new EventHandler(btn_MenuSairClick);
            }
            
            private void btn_CadastroClienteClick(object sender, EventArgs e)
            {
                CadastroCliente cadastrarClienteClick = new CadastroCliente(this);
                cadastrarClienteClick.Show();
            }
            private void btn_ConsultaClienteClick(object sender, EventArgs e)
            {
                ConsultaCliente consultaClienteClick = new ConsultaCliente(this);
                consultaClienteClick.Show();
            }
            
            private void btn_ListaClientesClick(object sender, EventArgs e)
            {
                ListaCliente listaClienteClick = new ListaCliente(this);
                listaClienteClick.Show();
            }
            
            private void btn_CadastroFilmeClick(object sender, EventArgs e)
            {
                // CadastroFilme cadastrarFilmeClick = new CadastroFilme(this);
                // cadastrarFilmeClick.Show();
            }
            
            private void btn_ConsultaFilmeClick(object sender, EventArgs e)
            {
                // ConsultaFilme consultarFilmeClick = new ConsultaFilme(this);
                // consultarFilmeClick.Show();
            }
            
            private void btn_ListaFilmesClick(object sender, EventArgs e)
            {
                // ListaFilme listaFilmeClick = new ListaFilme(this);
                // listaFilmeClick.Show();
            }
            
            private void btn_CadastroLocacaoClick(object sender, EventArgs e)
            {
                // CadastroLocacao cadastrarLocacaoClick = new CadastroLocacao(this);
                // cadastrarLocacaoClick.Show();
            }
            
            private void btn_ConsultaLocacaoClick(object sender, EventArgs e)
            {
                // ConsultaLocacao consultarLocacaoClick = new ConsultaLocacao(this);
                // consultarLocacaoClick.Show();
            }
            
            private void btn_ListaLocacoesClick(object sender, EventArgs e)
            {
                // ListaLocacao listaLocacaoClick = new ListaLocacao(this);
                // listaLocacaoClick.Show();
            }
            
            private void btn_MenuSairClick(object sender, EventArgs e)
            {
                this.Close();
            }

        }
    }
}   