namespace PROVA_DE_SUFICIENCIA
{
    partial class TelaInicial
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
            this.RegistrarPassageiro = new System.Windows.Forms.Button();
            this.GraficoCSV = new System.Windows.Forms.Button();
            this.btnViagem = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // RegistrarPassageiro
            // 
            this.RegistrarPassageiro.Location = new System.Drawing.Point(48, 211);
            this.RegistrarPassageiro.Name = "RegistrarPassageiro";
            this.RegistrarPassageiro.Size = new System.Drawing.Size(194, 64);
            this.RegistrarPassageiro.TabIndex = 0;
            this.RegistrarPassageiro.Text = "Registrar Passageiro";
            this.RegistrarPassageiro.UseVisualStyleBackColor = true;
            this.RegistrarPassageiro.Click += new System.EventHandler(this.RegistrarPassageiro_Click);
            // 
            // GraficoCSV
            // 
            this.GraficoCSV.Location = new System.Drawing.Point(48, 309);
            this.GraficoCSV.Name = "GraficoCSV";
            this.GraficoCSV.Size = new System.Drawing.Size(194, 59);
            this.GraficoCSV.TabIndex = 1;
            this.GraficoCSV.Text = "Grafico";
            this.GraficoCSV.UseVisualStyleBackColor = true;
            this.GraficoCSV.Click += new System.EventHandler(this.GraficoCSV_Click);
            // 
            // btnViagem
            // 
            this.btnViagem.Location = new System.Drawing.Point(48, 112);
            this.btnViagem.Name = "btnViagem";
            this.btnViagem.Size = new System.Drawing.Size(194, 61);
            this.btnViagem.TabIndex = 2;
            this.btnViagem.Text = "Viagem Cadastro";
            this.btnViagem.UseVisualStyleBackColor = true;
            this.btnViagem.Click += new System.EventHandler(this.btnViagem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 33);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick_1);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 397);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnViagem);
            this.Controls.Add(this.GraficoCSV);
            this.Controls.Add(this.RegistrarPassageiro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TelaInicial";
            this.Text = "TelaInicial";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button RegistrarPassageiro;
        private Button GraficoCSV;
        private Button btnViagem;
        private ComboBox comboBox1;
    }
}