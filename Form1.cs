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
    }
}
