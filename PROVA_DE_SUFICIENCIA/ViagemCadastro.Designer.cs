namespace PROVA_DE_SUFICIENCIA
{
    partial class ViagemCadastro
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
            this.mskTxtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.lblHoraViagem = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblDataViagem = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.RegistrarViagem = new System.Windows.Forms.Button();
            this.txtNomeMotorista = new System.Windows.Forms.TextBox();
            this.mskDataViagem = new System.Windows.Forms.MaskedTextBox();
            this.mskHoraViagem = new System.Windows.Forms.MaskedTextBox();
            this.CheckMunicipal = new System.Windows.Forms.CheckBox();
            this.CheckInterMunicipal = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mskTxtPlaca
            // 
            this.mskTxtPlaca.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTxtPlaca.Location = new System.Drawing.Point(7, 159);
            this.mskTxtPlaca.Mask = "AAA-0000";
            this.mskTxtPlaca.Name = "mskTxtPlaca";
            this.mskTxtPlaca.Size = new System.Drawing.Size(137, 55);
            this.mskTxtPlaca.TabIndex = 2;
            // 
            // lblHoraViagem
            // 
            this.lblHoraViagem.AutoSize = true;
            this.lblHoraViagem.Location = new System.Drawing.Point(404, 118);
            this.lblHoraViagem.Name = "lblHoraViagem";
            this.lblHoraViagem.Size = new System.Drawing.Size(116, 25);
            this.lblHoraViagem.TabIndex = 34;
            this.lblHoraViagem.Text = "Hora Viagem";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(12, 118);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(52, 25);
            this.lblPlaca.TabIndex = 36;
            this.lblPlaca.Text = "Placa";
            // 
            // lblDataViagem
            // 
            this.lblDataViagem.AutoSize = true;
            this.lblDataViagem.Location = new System.Drawing.Point(204, 118);
            this.lblDataViagem.Name = "lblDataViagem";
            this.lblDataViagem.Size = new System.Drawing.Size(114, 25);
            this.lblDataViagem.TabIndex = 35;
            this.lblDataViagem.Text = "Data Viagem";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(143, 25);
            this.lblNome.TabIndex = 34;
            this.lblNome.Text = "Nome motorista";
            // 
            // RegistrarViagem
            // 
            this.RegistrarViagem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegistrarViagem.Location = new System.Drawing.Point(12, 278);
            this.RegistrarViagem.Name = "RegistrarViagem";
            this.RegistrarViagem.Size = new System.Drawing.Size(225, 69);
            this.RegistrarViagem.TabIndex = 7;
            this.RegistrarViagem.Text = "Registrar";
            this.RegistrarViagem.UseVisualStyleBackColor = true;
            this.RegistrarViagem.Click += new System.EventHandler(this.RegistrarViagem_Click);
            // 
            // txtNomeMotorista
            // 
            this.txtNomeMotorista.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomeMotorista.Location = new System.Drawing.Point(11, 49);
            this.txtNomeMotorista.Name = "txtNomeMotorista";
            this.txtNomeMotorista.Size = new System.Drawing.Size(440, 55);
            this.txtNomeMotorista.TabIndex = 1;
            // 
            // mskDataViagem
            // 
            this.mskDataViagem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskDataViagem.Location = new System.Drawing.Point(204, 159);
            this.mskDataViagem.Mask = "00/00/0000";
            this.mskDataViagem.Name = "mskDataViagem";
            this.mskDataViagem.Size = new System.Drawing.Size(137, 55);
            this.mskDataViagem.TabIndex = 3;
            this.mskDataViagem.ValidatingType = typeof(System.DateTime);
            // 
            // mskHoraViagem
            // 
            this.mskHoraViagem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskHoraViagem.Location = new System.Drawing.Point(404, 159);
            this.mskHoraViagem.Mask = "00:00";
            this.mskHoraViagem.Name = "mskHoraViagem";
            this.mskHoraViagem.Size = new System.Drawing.Size(77, 55);
            this.mskHoraViagem.TabIndex = 4;
            this.mskHoraViagem.ValidatingType = typeof(System.DateTime);
            // 
            // CheckMunicipal
            // 
            this.CheckMunicipal.AutoSize = true;
            this.CheckMunicipal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckMunicipal.Location = new System.Drawing.Point(303, 250);
            this.CheckMunicipal.Name = "CheckMunicipal";
            this.CheckMunicipal.Size = new System.Drawing.Size(201, 52);
            this.CheckMunicipal.TabIndex = 5;
            this.CheckMunicipal.Text = "Municipal";
            this.CheckMunicipal.UseVisualStyleBackColor = true;
            this.CheckMunicipal.CheckedChanged += new System.EventHandler(this.CheckMunicipal_CheckedChanged);
            // 
            // CheckInterMunicipal
            // 
            this.CheckInterMunicipal.AutoSize = true;
            this.CheckInterMunicipal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckInterMunicipal.Location = new System.Drawing.Point(303, 330);
            this.CheckInterMunicipal.Name = "CheckInterMunicipal";
            this.CheckInterMunicipal.Size = new System.Drawing.Size(274, 52);
            this.CheckInterMunicipal.TabIndex = 6;
            this.CheckInterMunicipal.Text = "Intermunicipal";
            this.CheckInterMunicipal.UseVisualStyleBackColor = true;
            this.CheckInterMunicipal.CheckedChanged += new System.EventHandler(this.CheckInterMunicipal_CheckedChanged);
            // 
            // ViagemCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 399);
            this.Controls.Add(this.mskHoraViagem);
            this.Controls.Add(this.mskDataViagem);
            this.Controls.Add(this.mskTxtPlaca);
            this.Controls.Add(this.lblHoraViagem);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblDataViagem);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.CheckInterMunicipal);
            this.Controls.Add(this.CheckMunicipal);
            this.Controls.Add(this.RegistrarViagem);
            this.Controls.Add(this.txtNomeMotorista);
            this.Name = "ViagemCadastro";
            this.Text = "ViagemCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox mskTxtPlaca;
        private Label lblHoraViagem;
        private Label lblPlaca;
        private Label lblDataViagem;
        private Label lblNome;
        private Button RegistrarViagem;
        private TextBox txtNomeMotorista;
        private MaskedTextBox mskDataViagem;
        private MaskedTextBox mskHoraViagem;
        private CheckBox CheckMunicipal;
        private CheckBox CheckInterMunicipal;
    }
}