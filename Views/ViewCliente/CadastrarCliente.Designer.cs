using System;
using System.Drawing;
using System.Windows.Forms;

namespace Locadora_Veiculos_Ltda
{
    partial class CadastroCliente : Form
    {
        Library.Label lbl_Nome;
        Library.Label lbl_DataNasc;
        Library.Label lbl_CPF;
        Library.Label lbl_DiasDevol;
        private ErrorProvider TextErrorNome;
        private ErrorProvider TextErrorNasc;
        private ErrorProvider TextErrorCpf;
        private ErrorProvider TextErrorDev;
        Library.RichTextBox rtxt_NomeCliente;
        Library.MaskedTextBox mtxt_DataNasc;
        Library.MaskedTextBox mtxt_CpfCLiente;
        ComboBox cb_DiasDevol;
        Library.Button btn_Confirmar;
        Library.Button btn_Cancelar;
        Form parent;

        public void InitializeComponent(Form parent, bool isUpdate)
        {
            this.BackColor = Color.LightGray;
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.Size = new Size(365, 300);
            this.parent = parent;

            if (isUpdate)
            {
                this.Load += new EventHandler(this.LoadForm);
            }

            this.lbl_Nome = new Library.Label();
            this.lbl_Nome.Text = "Nome :";
            this.lbl_Nome.Location = new Point(20, 20);
            this.Controls.Add(lbl_Nome);

            this.lbl_DataNasc = new Library.Label();
            this.lbl_DataNasc.Text = "Data de Nascimento :";
            this.lbl_DataNasc.Location = new Point(20, 60);
            this.Controls.Add(lbl_DataNasc);

            this.lbl_CPF = new Library.Label();
            this.lbl_CPF.Text = "CPF :";
            this.lbl_CPF.Location = new Point(20, 100);
            this.Controls.Add(lbl_CPF);

            this.lbl_DiasDevol = new Library.Label();
            this.lbl_DiasDevol.Text = "Dias P/ Devolução :";
            this.lbl_DiasDevol.Location = new Point(20, 140);
            this.Controls.Add(lbl_DiasDevol);

            this.rtxt_NomeCliente = new Library.RichTextBox();
            this.rtxt_NomeCliente.Size = new Size(170, 20);
            this.TextErrorNome = new ErrorProvider();
            this.TextErrorNome.SetIconAlignment(this.rtxt_NomeCliente, ErrorIconAlignment.MiddleRight);
            this.TextErrorNome.SetIconPadding(this.rtxt_NomeCliente, 5);
            this.Controls.Add(rtxt_NomeCliente);

            this.mtxt_DataNasc = new Library.MaskedTextBox();
            this.mtxt_DataNasc.Mask = "00/00/0000";
            this.mtxt_DataNasc.Location = new Point(150, 60);
            this.TextErrorNasc = new ErrorProvider();
            this.TextErrorNasc.SetIconAlignment(this.mtxt_DataNasc, ErrorIconAlignment.MiddleRight);
            this.TextErrorNasc.SetIconPadding(this.mtxt_DataNasc, 5);
            this.Controls.Add(mtxt_DataNasc);

            this.mtxt_CpfCLiente = new Library.MaskedTextBox();
            this.mtxt_CpfCLiente.Mask = "000,000,000-00";
            this.mtxt_CpfCLiente.ReadOnly = isUpdate;
            this.TextErrorCpf = new ErrorProvider();
            this.TextErrorCpf.SetIconAlignment(this.mtxt_CpfCLiente, ErrorIconAlignment.MiddleRight);
            this.TextErrorCpf.SetIconPadding(this.mtxt_CpfCLiente, 5);
            this.Controls.Add(mtxt_CpfCLiente);

            this.cb_DiasDevol = new ComboBox();
            this.cb_DiasDevol.Items.Add("1 Dia");
            this.cb_DiasDevol.Items.Add("2 Dias");
            this.cb_DiasDevol.Items.Add("3 Dias");
            this.cb_DiasDevol.Items.Add("4 Dias");
            this.cb_DiasDevol.Items.Add("1 Semana");
            this.cb_DiasDevol.AutoCompleteMode = AutoCompleteMode.Append;
            this.cb_DiasDevol.Location = new Point(150, 140);
            this.cb_DiasDevol.Size = new Size(170, 20);
            this.TextErrorDev = new ErrorProvider();
            this.TextErrorDev.SetIconAlignment(this.cb_DiasDevol, ErrorIconAlignment.MiddleRight);
            this.TextErrorDev.SetIconPadding(this.cb_DiasDevol, 5);
            this.Controls.Add(cb_DiasDevol);


            this.btn_Confirmar = new Library.Button();
            this.btn_Confirmar.Text = "CONFIRMAR";
            this.btn_Confirmar.Location = new Point(10, 190);
            this.btn_Confirmar.Click += new EventHandler(this.btn_ConfirmarClick);
            this.Controls.Add(btn_Confirmar);

            this.btn_Cancelar = new Library.Button();
            this.btn_Cancelar.Text = "CANCELAR";
            this.btn_Cancelar.Location = new Point(180, 190);
            this.btn_Cancelar.Click += new EventHandler(this.btn_CancelarClick);
            this.Controls.Add(btn_Cancelar);
        }
    }
}