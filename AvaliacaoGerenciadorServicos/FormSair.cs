using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoGerenciadorServicos
{
    public partial class FormSair : Form
    {
        public FormSair()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            // FormSair SairForm = new FormSair();

            // this.Close();

            Application.Exit();

        }

        private void btn_naosair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
