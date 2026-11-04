namespace cifrario_di_cesare
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_titolo = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.txt_frase_C = new System.Windows.Forms.TextBox();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.txt_chiave_C = new System.Windows.Forms.TextBox();
            this.btn_cripta = new System.Windows.Forms.Button();
            this.lbl_criptata = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_titolo
            // 
            this.lbl_titolo.AutoSize = true;
            this.lbl_titolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titolo.Location = new System.Drawing.Point(250, 9);
            this.lbl_titolo.Name = "lbl_titolo";
            this.lbl_titolo.Size = new System.Drawing.Size(318, 31);
            this.lbl_titolo.TabIndex = 0;
            this.lbl_titolo.Text = "CIFRARIO DI CESARE";
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(12, 87);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(165, 16);
            this.lbl_1.TabIndex = 1;
            this.lbl_1.Text = "inserire la frase da criptare";
            // 
            // txt_frase_C
            // 
            this.txt_frase_C.Location = new System.Drawing.Point(183, 83);
            this.txt_frase_C.Name = "txt_frase_C";
            this.txt_frase_C.Size = new System.Drawing.Size(126, 20);
            this.txt_frase_C.TabIndex = 2;
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2.Location = new System.Drawing.Point(12, 160);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(172, 16);
            this.lbl_2.TabIndex = 3;
            this.lbl_2.Text = "inserire la chiave di codifica";
            // 
            // txt_chiave_C
            // 
            this.txt_chiave_C.Location = new System.Drawing.Point(190, 156);
            this.txt_chiave_C.Name = "txt_chiave_C";
            this.txt_chiave_C.Size = new System.Drawing.Size(36, 20);
            this.txt_chiave_C.TabIndex = 4;
            // 
            // btn_cripta
            // 
            this.btn_cripta.Location = new System.Drawing.Point(21, 249);
            this.btn_cripta.Name = "btn_cripta";
            this.btn_cripta.Size = new System.Drawing.Size(108, 54);
            this.btn_cripta.TabIndex = 5;
            this.btn_cripta.Text = "CRIPTA";
            this.btn_cripta.UseVisualStyleBackColor = true;
            this.btn_cripta.Click += new System.EventHandler(this.btn_cripta_Click);
            // 
            // lbl_criptata
            // 
            this.lbl_criptata.AutoSize = true;
            this.lbl_criptata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_criptata.Location = new System.Drawing.Point(190, 270);
            this.lbl_criptata.Name = "lbl_criptata";
            this.lbl_criptata.Size = new System.Drawing.Size(2, 15);
            this.lbl_criptata.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_criptata);
            this.Controls.Add(this.btn_cripta);
            this.Controls.Add(this.txt_chiave_C);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.txt_frase_C);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.lbl_titolo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titolo;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.TextBox txt_frase_C;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.TextBox txt_chiave_C;
        private System.Windows.Forms.Button btn_cripta;
        private System.Windows.Forms.Label lbl_criptata;
    }
}

