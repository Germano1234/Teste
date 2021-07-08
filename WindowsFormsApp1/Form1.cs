using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int selecionado;
        public Form1()
        {
            InitializeComponent();
            Colunas();
            selecionado = -1;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
        }

        public string language = Properties.Settings.Default.Language;

        private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }

        private void Colunas()
        {
            lvlProdutos.Columns.Insert(0, "ID Produto", 100, HorizontalAlignment.Right);
            lvlProdutos.Columns.Insert(1, "Nome", 200, HorizontalAlignment.Left);
            lvlProdutos.Columns.Insert(2, "Preço", 60, HorizontalAlignment.Center);
            lvlProdutos.Columns.Insert(3, "Descrição", 160, HorizontalAlignment.Left);
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            if (selecionado > -1)
            {
                lvlProdutos.Items[selecionado].SubItems[0].Text = IDP.Text.Trim();
                lvlProdutos.Items[selecionado].SubItems[1].Text = NOP.Text.Trim();
                lvlProdutos.Items[selecionado].SubItems[2].Text = PRP.Text.Trim();
                lvlProdutos.Items[selecionado].SubItems[3].Text = DES.Text.Trim();
                selecionado = -1;
                NOP.Text = String.Empty;
                IDP.Text = String.Empty;
                PRP.Text = String.Empty;
                DES.Text = String.Empty;
                return;
            }
            ListViewItem Produto = lvlProdutos.Items.Add(IDP.Text.Trim());
            Produto.SubItems.Add(new ListViewItem.ListViewSubItem(null, NOP.Text));
            Produto.SubItems.Add(new ListViewItem.ListViewSubItem(null, PRP.Text));
            Produto.SubItems.Add(new ListViewItem.ListViewSubItem(null, DES.Text));
            NOP.Text = String.Empty;
            IDP.Text = String.Empty;
            PRP.Text = String.Empty;
            DES.Text = String.Empty;

        }


        private void REM_Click(object sender, EventArgs e)
        {
            if (lvlProdutos.SelectedIndices.Count < 1)
            {
                MessageBox.Show("Selecione um Item para remover!");
                return;
            }
            selecionado = lvlProdutos.SelectedIndices[0];
            lvlProdutos.Items.RemoveAt(selecionado);
            NOP.Text = String.Empty;
            IDP.Text = String.Empty;
            PRP.Text = String.Empty;
            DES.Text = String.Empty;
            selecionado = -1;

        }

        private void lvlProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvlProdutos.SelectedIndices.Count < 1)
                return;
            selecionado = lvlProdutos.SelectedIndices[0];
            IDP.Text = lvlProdutos.Items[selecionado].SubItems[0].Text;
            NOP.Text = lvlProdutos.Items[selecionado].SubItems[1].Text;
            PRP.Text = lvlProdutos.Items[selecionado].SubItems[2].Text;
            DES.Text = lvlProdutos.Items[selecionado].SubItems[3].Text;
        }


        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgChangeLanguage dialog = new dlgChangeLanguage();
            if (dialog.ShowDialog() == DialogResult.Yes)
            {
                //Change Language to English
                language = "en-US";
                englishToolStripMenuItem.Checked = true;
                portuguêsToolStripMenuItem.Checked = false;
                españolToolStripMenuItem.Checked = false;

                //Save user choice in settings
                Properties.Settings.Default.Language = "en-US";
                Properties.Settings.Default.Save();

                Application.Restart();
            }
        }

        private void portuguêsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            dlgChangeLanguage dialog = new dlgChangeLanguage();
            if (dialog.ShowDialog() == DialogResult.Yes)
            {
                //Change Language to English
                language = "pt-BR";
                englishToolStripMenuItem.Checked = true;
                portuguêsToolStripMenuItem.Checked = false;
                españolToolStripMenuItem.Checked = false;

                //Save user choice in settings
                Properties.Settings.Default.Language = "pt-BR";
                Properties.Settings.Default.Save();

                Application.Restart();
            }
        }


        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgChangeLanguage dialog = new dlgChangeLanguage();
            if (dialog.ShowDialog() == DialogResult.Yes)
            {
                //Change Language to English
                language = "es-ES";
                englishToolStripMenuItem.Checked = true;
                portuguêsToolStripMenuItem.Checked = false;
                españolToolStripMenuItem.Checked = false;

                //Save user choice in settings
                Properties.Settings.Default.Language = "es-ES";
                Properties.Settings.Default.Save();

                Application.Restart();
            }
        }
    }
}
