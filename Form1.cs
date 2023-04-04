using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoIntegracoesAssurant
{
    public partial class FormPai : Form
    {
        public FormPai()
        {
            InitializeComponent();
        }

        

        private void FormPai_Load(object sender, EventArgs e)
        {
            timer1.Interval = 50;
            timer1.Start();
        }

        private void abre_form_filho(Form formulario)
        {

            formulario.MdiParent = this;
            formulario.StartPosition = FormStartPosition.CenterParent;
            formulario.WindowState = FormWindowState.Maximized;
            formulario.Show();
        }

        private void integraçãoAXAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string noSelecionado = treeView1.SelectedNode.Text;
            if (noSelecionado == "Monitoração de Envios para Seguradora")
            {
                FormFiltros formFiltros = new FormFiltros();
                abre_form_filho(formFiltros);
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                treeView1.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormFiltros>().Count() == 0)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                treeView1.Visible = true;
            }
        }

        private void monitoraçãoDeEnvioParaSeguradoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFiltros formFiltros = new FormFiltros();
            abre_form_filho(formFiltros);
        }

        private void treeView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string noSelecionado = treeView1.SelectedNode.Text;
                if (noSelecionado == "Monitoração de Envios para Seguradora")
                {
                    FormFiltros formFiltros = new FormFiltros();
                    abre_form_filho(formFiltros);
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    treeView1.Visible = false;
                }
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}