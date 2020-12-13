using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kantor
{
    public partial class Podglad : Form
    {
        Form poprzednie;
        public Podglad(Form poprzednie)
        {
            InitializeComponent();
            this.poprzednie = poprzednie;

            dataGridView1.Rows.Clear();
            for (int i = 0; i < 5; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dataGridView1);
                newRow.Cells[0].Value = "hej";
                newRow.Cells[1].Value = "Ala";
                newRow.Cells[2].Value = "ma";
                newRow.Cells[3].Value = "kota";
                newRow.Cells[4].Value = "Ktos";
                newRow.Cells[5].Value = "kota";
                newRow.Cells[6].Value = "Ktos";
                dataGridView1.Rows.Add(newRow);
            }
        }




        private void Podglad_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.poprzednie.Show();
        }
    }
}
