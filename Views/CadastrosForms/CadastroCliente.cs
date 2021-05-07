using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{

    public class CadastroCliente : Form
    {
        CadastroCliente chamarCadastro;
        Label nomeLabel;
         

        public CriarForm()
        {

            this.Text = "Cadastro de Clientes";
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.Size = new Size(650, 340);

           this.chamarCadastro = new Label (nomeLabel);  

            this.StartPosition = FormStartPosition.CenterScreen;

            this.Controls.Add(chamarCadastro);

        }

        string nome;
        string dataNascimento;
        string cpf;
        string diasDevolucao;
        public CadastroClientes()
        {
            nome;
            dataNascimento;
            cpf;
            diasDevolucao;
        }

    }
}