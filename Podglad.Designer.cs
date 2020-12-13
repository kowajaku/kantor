namespace Kantor
{
    partial class Podglad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Godzian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwa_operacji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.il_jed_wym = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ilos_jed_wymie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Godzian,
            this.nazwa_operacji,
            this.il_jed_wym,
            this.Ilos_jed_wymie,
            this.imie,
            this.nazwisko});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1250, 490);
            this.dataGridView1.TabIndex = 0;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.MinimumWidth = 6;
            this.Data.Name = "Data";
            this.Data.Width = 125;
            // 
            // Godzian
            // 
            this.Godzian.HeaderText = "Godzina";
            this.Godzian.MinimumWidth = 6;
            this.Godzian.Name = "Godzian";
            this.Godzian.Width = 125;
            // 
            // nazwa_operacji
            // 
            this.nazwa_operacji.HeaderText = "Nazwa operacji";
            this.nazwa_operacji.MinimumWidth = 6;
            this.nazwa_operacji.Name = "nazwa_operacji";
            this.nazwa_operacji.Width = 125;
            // 
            // il_jed_wym
            // 
            this.il_jed_wym.HeaderText = "Ilosc jed. wym.";
            this.il_jed_wym.MinimumWidth = 6;
            this.il_jed_wym.Name = "il_jed_wym";
            this.il_jed_wym.Width = 125;
            // 
            // Ilos_jed_wymie
            // 
            this.Ilos_jed_wymie.HeaderText = "Ilosc jed. wymienionych";
            this.Ilos_jed_wymie.MinimumWidth = 6;
            this.Ilos_jed_wymie.Name = "Ilos_jed_wymie";
            this.Ilos_jed_wymie.Width = 125;
            // 
            // imie
            // 
            this.imie.HeaderText = "Imie";
            this.imie.MinimumWidth = 6;
            this.imie.Name = "imie";
            this.imie.Width = 125;
            // 
            // nazwisko
            // 
            this.nazwisko.HeaderText = "Nazwisko";
            this.nazwisko.MinimumWidth = 6;
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Width = 125;
            // 
            // Podglad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 490);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Podglad";
            this.Text = "Podglad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Podglad_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Godzian;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwa_operacji;
        private System.Windows.Forms.DataGridViewTextBoxColumn il_jed_wym;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ilos_jed_wymie;
        private System.Windows.Forms.DataGridViewTextBoxColumn imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwisko;
    }
}