namespace Kantor
{
    partial class Zamiana_obcej_PLN
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_zamien = new System.Windows.Forms.Button();
            this.tB_kwota = new System.Windows.Forms.TextBox();
            this.cB_waluty = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(84, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kwota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(389, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Waluta  do wymiany";
            // 
            // bt_zamien
            // 
            this.bt_zamien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_zamien.Location = new System.Drawing.Point(590, 299);
            this.bt_zamien.Name = "bt_zamien";
            this.bt_zamien.Size = new System.Drawing.Size(159, 98);
            this.bt_zamien.TabIndex = 2;
            this.bt_zamien.Text = "Zamień";
            this.bt_zamien.UseVisualStyleBackColor = true;
            this.bt_zamien.Click += new System.EventHandler(this.bt_zamien_Click);
            // 
            // tB_kwota
            // 
            this.tB_kwota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_kwota.Location = new System.Drawing.Point(89, 106);
            this.tB_kwota.Name = "tB_kwota";
            this.tB_kwota.Size = new System.Drawing.Size(173, 30);
            this.tB_kwota.TabIndex = 3;
            // 
            // cB_waluty
            // 
            this.cB_waluty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cB_waluty.FormattingEnabled = true;
            this.cB_waluty.Location = new System.Drawing.Point(394, 106);
            this.cB_waluty.Name = "cB_waluty";
            this.cB_waluty.Size = new System.Drawing.Size(196, 33);
            this.cB_waluty.TabIndex = 4;
            // 
            // Zamiana_obcej_PLN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cB_waluty);
            this.Controls.Add(this.tB_kwota);
            this.Controls.Add(this.bt_zamien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Zamiana_obcej_PLN";
            this.Text = "Zamiana_obcej_PLN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Zamiana_obcej_PLN_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_zamien;
        private System.Windows.Forms.TextBox tB_kwota;
        private System.Windows.Forms.ComboBox cB_waluty;
    }
}