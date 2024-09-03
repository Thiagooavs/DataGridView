using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
           dtGrid.Rows.Add(txtNome.Text, txtCurso.Text, txtCidade.Text);
           lblTotal.Text = dtGrid.RowCount.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGrid.Rows.RemoveAt(dtGrid.CurrentRow.Index);
            MessageBox.Show("Aluno excluido com suscesso","Exclusão");
            lblTotal.Text = dtGrid.RowCount.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            dtGrid.CurrentRow.Cells[0].Value =txtAlterar.Text;
            dtGrid.CurrentRow.Cells[1].Value = txtAltCurso.Text;
            dtGrid.CurrentRow.Cells[2].Value = txtAltCidade.Text;
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            dtGrid.Rows.Clear();
            lblTotal.Text = dtGrid.RowCount.ToString();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo ao banco de alunos", "Bem vindo");
        }

        private void dtGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtGrid.RowCount > 0)
            {
                txtAlterar.Text = dtGrid.CurrentRow.Cells[0].Value.ToString();
                txtAltCurso.Text = dtGrid.CurrentRow.Cells[1].Value.ToString();
                txtAltCidade.Text = dtGrid.CurrentRow.Cells[2].Value.ToString();
            }
        }
    }
}
