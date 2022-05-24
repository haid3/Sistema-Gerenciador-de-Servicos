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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* if(txtbox_usuario.Text.Length < 4 || txtbox_senha.Text.Length < 6)
            //{
           // MessageBox.Show("O campo usuário deve conter pelo menos 4 dígitos e senha 6");

            }  */


            if (txtbox_usuario.Text == "" || txtbox_senha.Text == "" ) 
            {
                MessageBox.Show("Preencha todos os campos!");

            }

    

            else if(txtbox_senha.Text == "1" && txtbox_usuario.Text == "1")
                {
                    MessageBox.Show("Logado com Sucesso,\n Administrador!");

                    //FECHA TODOS OS FORMS this.Close();  
                     //ESCONDE TODOS OS FORMS this.Hide();


                    Form2 FormEntrar = new Form2();
                    this.Hide();
                    FormEntrar.ShowDialog();
               

            }
        }

        private void btn_encerrar_Click(object sender, EventArgs e)
        {
            FormSair OutroForm = new FormSair();
            OutroForm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtbox_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtbox_usuario_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
