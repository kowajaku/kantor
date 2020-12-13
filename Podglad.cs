﻿using System;
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
            List<List<string>> dane = MySQL_Load_base.pobierz_dane_podglad();
            dataGridView1.Rows.Clear();
            if (dane==null)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView1);
                for(int i=0;i<7;i++)
                {
                    newRow.Cells[i].Value = "ERROR";
                }
                dataGridView1.Rows.Add(newRow);

            }
            else
            {
               for(int i=0;i<dane.Count();i++)
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(dataGridView1);
                    for(int j=0;j<dane[i].Count();j++)
                    {
                        newRow.Cells[j].Value = dane[i][j];
                    }
                    dataGridView1.Rows.Add(newRow);
                }

            }
            //
            //for (int i = 0; i < 5; i++)
            //{
            //    DataGridViewRow newRow = new DataGridViewRow();

            //    newRow.CreateCells(dataGridView1);
            //    newRow.Cells[0].Value = "hej";
            //    newRow.Cells[1].Value = "Ala";
            //    newRow.Cells[2].Value = "ma";
            //    newRow.Cells[3].Value = "kota";
            //    newRow.Cells[4].Value = "Ktos";
            //    newRow.Cells[5].Value = "kota";
            //    newRow.Cells[6].Value = "Ktos";
            //    dataGridView1.Rows.Add(newRow);
            //}
        }




        private void Podglad_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.poprzednie.Show();
        }
    }
}
