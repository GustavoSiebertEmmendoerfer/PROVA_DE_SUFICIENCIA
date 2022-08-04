using PROVA_DE_SUFICIENCIA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROVA_DE_SUFICIENCIA
{
    public partial class Grafico : Form
    {
        private readonly Viagem _viagem;
        public Grafico(Viagem viagem)
        {
            _viagem = viagem;
            InitializeComponent();
        }

        private void ListViewCSV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Grafico_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (var passageiro in _viagem.Passageiros)
                {
                    var item = new ListViewItem(passageiro.Nome);
                    item.SubItems.Add(passageiro.Idade.ToString());
                    item.SubItems.Add(passageiro.Telefone.ToString());
                    item.SubItems.Add($"R${passageiro.GetTarifa()}");
                    ListViewCSV.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnExport_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV| *.csv", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.AppendLine("Nome;Idade;Telefone;Tarifa");
                            foreach (ListViewItem item in ListViewCSV.Items)
                            {
                                sb.AppendLine(string.Format($"{item.SubItems[0].Text};{item.SubItems[1].Text};{item.SubItems[2].Text};{item.SubItems[3].Text}"));
                            }
                            await sw.WriteLineAsync(sb.ToString());
                            MessageBox.Show("Arquivo salvo com sucesso", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
