namespace PROVA_DE_SUFICIENCIA
{
    partial class Grafico
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
            this.BtnExport = new System.Windows.Forms.Button();
            this.ListViewCSV = new System.Windows.Forms.ListView();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.Idade = new System.Windows.Forms.ColumnHeader();
            this.Telefone = new System.Windows.Forms.ColumnHeader();
            this.Tarifa = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // BtnExport
            // 
            this.BtnExport.Location = new System.Drawing.Point(726, 577);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(112, 34);
            this.BtnExport.TabIndex = 1;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // ListViewCSV
            // 
            this.ListViewCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewCSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Idade,
            this.Telefone,
            this.Tarifa});
            this.ListViewCSV.Location = new System.Drawing.Point(23, 12);
            this.ListViewCSV.MultiSelect = false;
            this.ListViewCSV.Name = "ListViewCSV";
            this.ListViewCSV.Size = new System.Drawing.Size(815, 542);
            this.ListViewCSV.TabIndex = 2;
            this.ListViewCSV.UseCompatibleStateImageBehavior = false;
            this.ListViewCSV.View = System.Windows.Forms.View.Details;
            this.ListViewCSV.SelectedIndexChanged += new System.EventHandler(this.ListViewCSV_SelectedIndexChanged);
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            // 
            // Idade
            // 
            this.Idade.Text = "Idade";
            // 
            // Telefone
            // 
            this.Telefone.Text = "Telefone";
            // 
            // Tarifa
            // 
            this.Tarifa.Text = "Tarifa";
            // 
            // Grafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 640);
            this.Controls.Add(this.ListViewCSV);
            this.Controls.Add(this.BtnExport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Grafico";
            this.Text = "Grafico";
            this.Load += new System.EventHandler(this.Grafico_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button BtnExport;
        private ListView ListViewCSV;
        private ColumnHeader Nome;
        private ColumnHeader Idade;
        private ColumnHeader Telefone;
        private ColumnHeader Tarifa;
    }
}