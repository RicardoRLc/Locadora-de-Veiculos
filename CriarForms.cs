using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{
    public class CriarForm : Form
    {

        public  CriarForm()
        {


            // Criando o botão para acessar p formulario.
            Button botao1 = new Button();

            // Seta a mensagem que o botao mostra.

            botao1.Text = "Codigo Cliente";
            // Irá setar onde o botão ficara.

            botao1.Location = new Point(30, 30);


            // Define o estilo da borda.
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Set the accept button of the form to button1.
            this.AcceptButton = botao1;

            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;

            // Adiciona o botao no form.
            this.Controls.Add(botao1);


            // Tipo de form que sera .
            this.ShowDialog();
        }

    }
}