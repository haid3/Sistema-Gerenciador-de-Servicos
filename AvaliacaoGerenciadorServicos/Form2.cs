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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
             FormSair OutroForm = new FormSair();     // criei uma variavel e adicionei o nome do form, 
             OutroForm.ShowDialog();                  // executei um dialog da variavel criada
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSair OutroForm = new FormSair();    // criei uma variavel e adicionei o nome do form, 
            OutroForm.ShowDialog();                 // executei um dialog da variavel criada
        }

        private void manutençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {


           

            Manutencaoclientes Formmanutencaocliente = new Manutencaoclientes();
            Formmanutencaocliente.ShowDialog();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manutençãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Manutencaoservicos Formmanutencaoservico = new Manutencaoservicos();
            Formmanutencaoservico.ShowDialog();
        }

        private void manutençãoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Cadastrofuncionarios cadastrarfuncionario = new Cadastrofuncionarios();
            cadastrarfuncionario.ShowDialog();
            
        }
    }
}
