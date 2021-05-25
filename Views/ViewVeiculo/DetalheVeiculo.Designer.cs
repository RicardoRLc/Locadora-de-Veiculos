// using System;
// using Models;
// using Library;
// using System.Drawing;
// using System.Windows.Forms;

// namespace Locadora_Veiculos_Ltda
// {
//     partial class ClienteDetalhe : Form
//     {
//         Library.Label lbl_IdCliente;
//         Library.Label lbl_Nome;
//         Library.Label lbl_DataNasc;
//         Library.Label lbl_CPF;
//         Library.Label lbl_DiasDevol;
//         Library.ButtonDetail btn_SairDetalhe;
//         Library.ButtonDetail btn_UpdateCliente;
//         Library.ButtonDetail btn_DeleteCliente;
//         Form parent;

//         int idCliente;
//         ClienteModels clienteX;

//         // Detailed customer window
//         public void InitializeComponent(Form parent, ClienteModels cliente)
//         {
//             // Window parameters
//             this.BackColor = Color.LightGray;
//             this.Font = new Font(this.Font, FontStyle.Bold);
//             this.Size = new Size(500, 290);
//             this.idCliente = cliente.IdCliente;
//             this.clienteX = cliente;
//             this.parent = parent;
            
//             this.lbl_IdCliente = new Library.Label();
//             this.lbl_IdCliente.Text = "ID do Cliente: " + cliente.IdCliente;
//             this.lbl_IdCliente.Location = new Point(20, 20);
//             this.lbl_IdCliente.Font = new Font(lbl_IdCliente.Font, FontStyle.Bold);
//             this.lbl_IdCliente.ForeColor = Color.Black;
//             this.Controls.Add(lbl_IdCliente);

//             this.lbl_Nome = new Library.Label();
//             this.lbl_Nome.Text = "Nome: " + cliente.NomeCliente;
//             this.lbl_Nome.Location = new Point(20, 50);
//             this.lbl_Nome.Font = new Font(lbl_Nome.Font, FontStyle.Bold);
//             this.lbl_Nome.ForeColor = Color.Black;
//             this.Controls.Add(lbl_Nome);

//             this.lbl_DataNasc = new Library.Label();
//             this.lbl_DataNasc.Text = "Data de Nascimento: " + cliente.DataNascimento;
//             this.lbl_DataNasc.Location = new Point(20, 80);
//             this.lbl_DataNasc.Font = new Font(lbl_DataNasc.Font, FontStyle.Bold);
//             this.lbl_DataNasc.ForeColor = Color.Black;
//             this.Controls.Add(lbl_DataNasc);

//             this.lbl_CPF = new Library.Label();
//             this.lbl_CPF.Text = "CPF: " + cliente.CpfCliente;
//             this.lbl_CPF.Location = new Point(20, 110);
//             this.lbl_CPF.Font = new Font(lbl_CPF.Font, FontStyle.Bold);
//             this.lbl_CPF.ForeColor = Color.Black;
//             this.Controls.Add(lbl_CPF);

//             this.lbl_DiasDevol = new Library.Label();
//             this.lbl_DiasDevol.Text = "Dias P/ Devolução: " + cliente.DiasDevolucao.ToString();
//             this.lbl_DiasDevol.Location = new Point(20, 140);
//             this.lbl_DiasDevol.Font = new Font(lbl_DiasDevol.Font, FontStyle.Bold);
//             this.lbl_DiasDevol.ForeColor = Color.Black;
//             this.Controls.Add(lbl_DiasDevol);
            
//             this.btn_DeleteCliente = new Library.ButtonDetail(ButtonType.Delete);
//             this.btn_DeleteCliente.Text = "DELETAR";
//             this.btn_DeleteCliente.Location = new Point(10, 180);
//             this.btn_DeleteCliente.Size = new Size(140, 50);
//             this.btn_DeleteCliente.BackColor = Color.DarkGray;
//             this.btn_DeleteCliente.Click += new EventHandler(this.btn_DeleteClienteClick);
//             this.Controls.Add(btn_DeleteCliente);
            
//             this.btn_UpdateCliente = new Library.ButtonDetail(ButtonType.Update);
//             this.btn_UpdateCliente.Text = "ALTERAR";
//             this.btn_UpdateCliente.Location = new Point(170, 180);
//             this.btn_UpdateCliente.Size = new Size(140, 50);
//             this.btn_UpdateCliente.BackColor = Color.DarkGray;
//             this.btn_UpdateCliente.Click += new EventHandler(this.btn_UpdateClienteClick);
//             this.Controls.Add(btn_UpdateCliente);
            
//             this.btn_SairDetalhe = new Library.ButtonDetail(ButtonType.Sair);
//             this.btn_SairDetalhe.Text = "SAIR";
//             this.btn_SairDetalhe.Location = new Point(330, 180);
//             this.btn_SairDetalhe.Size = new Size(140, 50);
//             this.btn_SairDetalhe.BackColor = Color.DarkGray;
//             this.btn_SairDetalhe.Click += new EventHandler(this.btn_SairDetalheClick);
//             this.Controls.Add(btn_SairDetalhe);
//         }
//     }
// }