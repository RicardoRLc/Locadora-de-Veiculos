using System;
using System.Drawing;
using System.Windows.Forms;

namespace Locadora_Veiculos_Ltda
{
    partial class CadastrarVeiculo : Form
    {
        Library.Label lbl_Marca;
        Library.Label lbl_Modelo;
        Library.Label lbl_AnoFab;
        Library.Label lbl_Preco;
        Library.RichTextBox rtxt_Marca;        
        Library.MaskedTextBox mtxt_AnoFab;
        Library.MaskedTextBox mtxt_preco;
        ComboBox cb_QtdEstoque;
        Library.Button btn_Confirmar;
        Library.Button btn_Cancelar;
        Form parent;

        public void InitializeComponent(Form parent, bool isUpdate)
        {
            this.BackColor = Color.LightGray;
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.Size = new Size(360, 300);
            this.parent = parent;

            if (isUpdate)
            {
                this.Load += new EventHandler(this.LoadForm);
            }

            this.lbl_Marca = new Library.Label();
            this.lbl_Marca.Text = "Marca :";
            this.lbl_Marca.Location = new Point(20, 20);
            this.Controls.Add(lbl_Marca);

            this.lbl_Modelo = new Library.Label();
            this.lbl_Modelo.Text = "Modelo:";
            this.lbl_Modelo.Location = new Point(20, 60);
            this.Controls.Add(lbl_Modelo);

            this.lbl_AnoFab = new Library.Label();
            this.lbl_AnoFab.Text = "CPF :";
            this.lbl_AnoFab.Location = new Point(20, 100);
            this.Controls.Add(lbl_AnoFab);

            this.lbl_DiasDevol = new Library.Label();
            this.lbl_DiasDevol.Text = "Dias P/ Devolução :";
            this.lbl_DiasDevol.Location = new Point(20, 140);
            this.Controls.Add(lbl_DiasDevol);

            this.rtxt_NomeCliente = new Library.RichTextBox();
            this.rtxt_NomeCliente.Size = new Size(170, 20);
            this.Controls.Add(rtxt_NomeCliente);

            this.mtxt_DataNasc = new Library.MaskedTextBox();
            this.mtxt_DataNasc.Mask = "00/00/0000";
            this.mtxt_DataNasc.Location = new Point(150, 60);
            this.Controls.Add(mtxt_DataNasc);

            this.mtxt_CpfCLiente = new Library.MaskedTextBox();
            this.mtxt_CpfCLiente.Mask = "000,000,000-00";
            this.mtxt_CpfCLiente.ReadOnly = isUpdate;
            this.Controls.Add(mtxt_CpfCLiente);

            this.cb_QtdEstoque = new ComboBox();
            this.cb_QtdEstoque.Items.Add("1 Unidade");
            this.cb_QtdEstoque.Items.Add("2 unidades");
            this.cb_QtdEstoque.Items.Add("3 unidades");
            this.cb_QtdEstoque.Items.Add("5 Unidades");
            this.cb_QtdEstoque.Items.Add("10 Unidades");
            this.cb_QtdEstoque.AutoCompleteMode = AutoCompleteMode.Append;
            this.cb_QtdEstoque.Location = new Point(150, 140);
            this.cb_QtdEstoque.Size = new Size(170, 20);
            this.Controls.Add(cb_QtdEstoque);

           
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