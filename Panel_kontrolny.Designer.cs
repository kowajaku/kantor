namespace Kantor
{
    partial class Panel_kontrolny
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
            this.bt_zamina_PLN = new System.Windows.Forms.Button();
            this.bt_zamina_obca = new System.Windows.Forms.Button();
            this.bt_podglad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_zamina_PLN
            // 
            this.bt_zamina_PLN.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_zamina_PLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_zamina_PLN.Location = new System.Drawing.Point(128, 98);
            this.bt_zamina_PLN.Name = "bt_zamina_PLN";
            this.bt_zamina_PLN.Size = new System.Drawing.Size(205, 123);
            this.bt_zamina_PLN.TabIndex = 0;
            this.bt_zamina_PLN.Text = "Zamiana PLN na  obcą";
            this.bt_zamina_PLN.UseVisualStyleBackColor = false;
            this.bt_zamina_PLN.Click += new System.EventHandler(this.bt_zamina_PLN_Click);
            // 
            // bt_zamina_obca
            // 
            this.bt_zamina_obca.BackColor = System.Drawing.Color.Tan;
            this.bt_zamina_obca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_zamina_obca.Location = new System.Drawing.Point(551, 98);
            this.bt_zamina_obca.Name = "bt_zamina_obca";
            this.bt_zamina_obca.Size = new System.Drawing.Size(223, 123);
            this.bt_zamina_obca.TabIndex = 1;
            this.bt_zamina_obca.Text = "Zamiana na obcej na PLN";
            this.bt_zamina_obca.UseVisualStyleBackColor = false;
            this.bt_zamina_obca.Click += new System.EventHandler(this.bt_zamina_obca_Click);
            // 
            // bt_podglad
            // 
            this.bt_podglad.BackColor = System.Drawing.Color.Red;
            this.bt_podglad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_podglad.Location = new System.Drawing.Point(327, 302);
            this.bt_podglad.Name = "bt_podglad";
            this.bt_podglad.Size = new System.Drawing.Size(223, 123);
            this.bt_podglad.TabIndex = 2;
            this.bt_podglad.Text = "Podglad";
            this.bt_podglad.UseVisualStyleBackColor = false;
            this.bt_podglad.Click += new System.EventHandler(this.bt_podglad_Click);
            // 
            // Panel_kontrolny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 492);
            this.Controls.Add(this.bt_podglad);
            this.Controls.Add(this.bt_zamina_obca);
            this.Controls.Add(this.bt_zamina_PLN);
            this.Name = "Panel_kontrolny";
            this.Text = "Panel_kontrolny";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_zamina_PLN;
        private System.Windows.Forms.Button bt_zamina_obca;
        private System.Windows.Forms.Button bt_podglad;
    }
}