using System;
using System.Windows.Forms;
using System.Drawing;

/*
 0         1         2         3         4         5         6         7         8         9
  0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890
  +-----------------------------------------------------------------------------------------+
00|                                                                                         |
01|                                                                                         |
02|                                                                                         |
03|                                                                                         |
04|                                                                                         |
05|                                                                                         |
06|                                                                                         |
07|                                                                                         |
08|                                                                                         |
09|                                                                                         |
10|                                                                                         |
11|                                                                                         |
12|                                                                                         |
13|                                                                                         |
14|                                                                                         |
15|                                                                                         |
16|                                                                                         |
17|                                                                                         |
18|                                                                                         |
19|                                                                                         |
20|                                                                                         |
  +-----------------------------------------------------------------------------------------+
*/
namespace View
{
    public class CriarForm : Form
    {

        PropriedadeBotao botaoCadastroCliente;
        PropriedadeBotao botaoListarCliente;

        PropriedadeBotao botaoCadastroVeiculo;

        PropriedadeBotao botaoListarVeiculo;
        public CriarForm()
        {

            this.Text = "Veiculos LDTA";
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.Size = new Size(900, 460);

            // Criando o botão para acessar p formulario.

            this.botaoCadastroCliente = new PropriedadeBotao(new Point(10,20),new Size(150, 70),"CADASTRO DO CLIENTE");
            this.botaoCadastroCliente.Click += new EventHandler(this.botaoCadastroClienteClick);
           
            this.botaoListarCliente = new PropriedadeBotao(new Point(200, 20),new Size(100, 70),"LISTA DOS CLIENTES");
            this.botaoListarCliente.Click += new EventHandler(this.botaoListarClienteClick);

            this.botaoCadastroVeiculo = new PropriedadeBotao(new Point(10,100),new Size(120, 70),"CADASTRO DE VEÍCULO");
            this.botaoCadastroVeiculo.Click += new EventHandler(this.botaoCadastroVeiculoClick);          

            this.botaoListarVeiculo = new PropriedadeBotao(new Point(200,100),new Size(120, 70),"LISTA DE VEÍCULOS");
            this.botaoListarVeiculo.Click += new EventHandler(this.botaoListarVeiculoClick);          

 

           // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;

            // Adiciona o botao no form.
            this.Controls.Add(botaoCadastroCliente);
            this.Controls.Add(botaoListarCliente);
            this.Controls.Add(botaoCadastroVeiculo);
            this.Controls.Add(botaoListarVeiculo);    
            // Tipo de form que sera .
            // this.ShowDialog();

        }
        private void botaoCadastroClienteClick(object sender, EventArgs e)
        {
           CadastroCliente tela = new CadastroCliente();
           tela.Show(); 
        }
         private void botaoListarClienteClick(object sender, EventArgs e)
        {
            // CadastroCliente botaoCadastroClienteClick = new CadastroCliente(this);
            // botaoCadastroClienteClick.Show();
        }
        private void botaoCadastroVeiculoClick(object sender, EventArgs e)
        {
            // CadastroCliente botaoCadastroClienteClick = new CadastroCliente(this);
            // botaoCadastroClienteClick.Show();
        }

        private void botaoListarVeiculoClick(object sender, EventArgs e)
        {
            // CadastroCliente botaoCadastroClienteClick = new CadastroCliente(this);
            // botaoCadastroClienteClick.Show();
        }
        
    }
}