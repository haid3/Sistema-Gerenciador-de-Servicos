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
    public partial class Manutencaoclientes : Form
    {
        public Manutencaoclientes()
        {
            InitializeComponent();
        }

        private void Manutencaoclientes_Load(object sender, EventArgs e)
        {
            btn_gravarcliente.Visible = false;
            btn_excluircliente.Visible = false;
        }

        private void Manutencaoclientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btn_fecharcliente_Click(object sender, EventArgs e)
        {
            this.Close(); /*dei um close para fechar o cadastro e voltar a tela de menu(form2
            da pagina anterior)*/   

        }

        private void btn_editarcliente_Click(object sender, EventArgs e)
        {
            btn_gravarcliente.Visible = true;
            btn_excluircliente.Visible = true;
        }

        private void btn_novocliente_Click(object sender, EventArgs e)
        {
            btn_gravarcliente.Visible = true;
            btn_novocliente.Visible = false;
        }

        private void btn_gravarcliente_Click(object sender, EventArgs e)


                                //começo validação se campos estão vazios


        {
            if (txtbox_nomecliente.Text == "")  
            {
                MessageBox.Show("Preencha o nome do cliente!");
            }

            if (txtbox_enderecocliente.Text == "")
            {
                MessageBox.Show("Preencha o endereço do cliente");
            }

            if (txtbox_cidadecliente.Text == "")
            {
                MessageBox.Show("Preencha a cidade do cliente");
            }

            if (txtbox_bairrocliente.Text == "")
            {
                MessageBox.Show("Preencha o bairro do cliente");
            }

            if (combobox_sexocliente.Text == string.Empty) {           // Para seleções utilizamos
                MessageBox.Show("Selecione o sexo do cliente!");       //desta forma
            }

            if (combobox_ufcliente.Text == string.Empty)
            {
                MessageBox.Show("Selecione o estado do cliente. (UF)");
            }


            if (maskedtextbox_cepcliente.Text.Replace(".", "").Replace("/", "").Replace("-", "").Trim().Length != 0)
            {
                //Caso esteja preenchido ele nao faz nada. Caso vazio, ele apresenta a mensagem
            }
            else {
                MessageBox.Show("Preencha o cep do cliente");
            


               if (maskedtextbox_datanasccliente.Text.Replace(".", "").Replace("/", "").Replace("-", "").Trim().Length != 0)
                {
                    //mesmo caso acima
                }
                else
                {
                    MessageBox.Show("Preencha a data de nascimento do cliente");

                }                                   //Termino da validação se vazio



            }


        }







    }
    }

