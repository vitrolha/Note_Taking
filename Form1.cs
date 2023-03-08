using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note_Taking_Estudo
{
    public partial class Form1 : Form
    {
        DataTable tabela;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabela = new DataTable();
            tabela.Columns.Add("Titulo", typeof(String));
            tabela.Columns.Add("Texto", typeof(String));

            dataGridView1.DataSource= tabela;

            dataGridView1.Columns["Texto"].Visible = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtboxTitulo.Clear();
            txtboxTexto.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            tabela.Rows.Add(txtboxTitulo.Text, txtboxTexto.Text);
            txtboxTitulo.Clear();
            txtboxTexto.Clear();
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if(index>-1)
            {
                txtboxTitulo.Text = tabela.Rows[index].ItemArray[0].ToString();
                txtboxTexto.Text = tabela.Rows[index].ItemArray[1].ToString();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            tabela.Rows[index].Delete();
        }
    }
}
