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
        

        public CriarForm()
        {

            this.Text = "Veiculos LDTA";
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.Size = new Size(800, 460);

            // Criando o botão para acessar p formulario.

            this.botaoCadastroCliente = new PropriedadeBotao(new Point(400, 200),new Size(150, 70),"CADASTRO DO CLIENTE");
            
            this.Controls.Add(botaoCadastroCliente);
            this.botaoCadastroCliente.Click += new EventHandler(this.botaoCadastroClienteClick);
            Button botao1 = new Button();
            Button botao2 = new Button();
            Button botao3 = new Button();

            // Seta a mensagem que o botao mostra.
            botao1.Text = "Cadastrar Cliente";
            // Seta o Click 
            // botao1.Click += new EventHandler(this.botao1);
            botao2.Text = "Cadastrar Veículo";

            botao3.Text = "Listar Veículo";


            // Irá setar onde o botão ficara.

            botao1.Location = new Point(10, 20);
            botao2.Location = new Point(50, 220);
            botao3.Location = new Point(10, 320);

            //Irá setar o tamanho do botão

            botao1.Size = new Size(100, 60);
            botao2.Size = new Size(100, 90);
            botao3.Size = new Size(100, 90);

            // // Define o estilo da borda.
            // this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // // Set the accept button of the form to button1.
            // this.AcceptButton = botao1;
            // this.AcceptButton = botao2;
            // this.AcceptButton = botao3;

            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;

            // Adiciona o botao no form.
            this.Controls.Add(botao1);
            this.Controls.Add(botao2);
            this.Controls.Add(botao3);
            this.Controls.Add(botaoCadastroCliente);


            // Tipo de form que sera .
            this.ShowDialog();

        }
        private void botaoCadastroClienteClick(object sender, EventArgs e)
        {
            // CadastroCliente botaoCadastroClienteClick = new CadastroCliente(this);
            // botaoCadastroClienteClick.Show();
        }
    }
}