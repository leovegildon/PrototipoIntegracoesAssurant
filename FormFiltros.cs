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
    public partial class FormFiltros : Form
    {
        public FormFiltros()
        {
            InitializeComponent();
        }

        public class Seguros
        {
            public string Data { get; set; }
            public string Loja { get; set; }
            public string NumeroBilhete { get; set; }
            public string Marca { get; set; }
            public string NumeroDeSerie { get; set; }
            public string ValorBilhete { get; set; }
            public string ValorDoProduto { get; set; }
            public string Plano { get; set; }
            public string Prazo { get; set; }
            public string Status { get; set; }
            public Button BotaoEditar { get; set; }
        }

        List<Seguros> listaSeguros = new List<Seguros>();
            private void FormFiltros_Load(object sender, EventArgs e)
        {
            listaSeguros.Add(new Seguros()
            {
                Data = "02/03/2023",
                Loja = "LB BONOCO",
                NumeroBilhete = "151001000569300",
                Marca = "Mondial",
                NumeroDeSerie = "1231265456",
                ValorBilhete = "R$119,99",
                Plano = "LBTG00006",
                Prazo = "12",
                ValorDoProduto = "349,99",
                Status = "Aprovado"
            });
            listaSeguros.Add(new Seguros()
            {
                Data = "01/03/2023",
                Loja = "LB SSA SHOPPING",
                NumeroBilhete = "151001004525600",
                Marca = "Mondial",
                NumeroDeSerie = "1231265456",
                ValorBilhete = "R$119,99",
                Plano = "LBTG00006",
                Prazo = "12",
                ValorDoProduto = "349,99",
                Status = "Aprovado"
            });
            listaSeguros.Add(new Seguros()
            {
                Data = "01/03/2023",
                Loja = "LB SH BELA VISTA",
                NumeroBilhete = "151001003467590",
                Marca = "Mondial",
                NumeroDeSerie = "1231265456",
                ValorBilhete = "R$119,99",
                Plano = "LBTG00006",
                Prazo = "12",
                ValorDoProduto = "349,99",
                Status = "Aprovado"
            });
            listaSeguros.Add(new Seguros()
            {
                Data = "01/03/2023",
                Loja = "LB RUA GRANDE",
                NumeroBilhete = "151001065986000",
                Marca = "Mondial",
                NumeroDeSerie = "1231265456",
                ValorBilhete = "R$119,99",
                Plano = "LBTG00006",
                Prazo = "12",
                ValorDoProduto = "349,99",
                Status = "Aprovado"
            });
            listaSeguros.Add(new Seguros()
            {
                Data = "01/03/2023",
                Loja = "LB SH PATIO MACEIO",
                NumeroBilhete = "1510010066794600",
                Marca = "Mondial",
                NumeroDeSerie = "1231265456",
                ValorBilhete = "R$119,99",
                Plano = "LBTG00006",
                Prazo = "12",
                ValorDoProduto = "349,99",
                Status = "Rejeitado"
            });
            dataGridView1.DataSource = listaSeguros;

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.Value.Equals("Rejeitado"))

            {

                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;

            }

            if (e.Value != null && e.Value.Equals("Aprovado"))

            {

                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;

            }
        }
    }
}
