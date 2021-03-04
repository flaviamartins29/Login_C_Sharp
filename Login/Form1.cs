using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();

            string usuario, senha;
            usuario = textUsuario.Text;
            senha = textSenha.Text;
            
            if (usuario == "Admin" && senha == "Admin")
            {
                novo.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Senha e ou usuario incorretos", "Menssagem", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
