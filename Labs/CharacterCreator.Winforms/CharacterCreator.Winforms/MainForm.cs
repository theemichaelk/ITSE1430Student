using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharacterCreator;
using System.Diagnostics;

namespace CharacterCreator.Winforms
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public static List<Characters> instances = new List<Characters>();

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                Application.Exit();
            }
            if (e.KeyCode == Keys.F)
            {
                aboutToolStripMenuItem_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.N)
            {
                addNewToolStripMenuItem_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.O)
            {
                editToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyCode == Keys.Delete)
            {
                deleteToolStripMenuItem_Click(sender, e);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm abt = new AboutForm();
            abt.ShowDialog();
        }


        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewCharacter anc = new AddNewCharacter();
            anc.ShowDialog();

            ReloadRoster();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListBox.SelectedIndex >= 0)
            {

                int ag = ListBox.SelectedIndex;
                Characters c = instances[ag];
                AddNewCharacter ance = new AddNewCharacter(c, ag);

                ance.isEdit = true;
                ance.ShowDialog();

                ReloadRoster();
            }

        }

        private void ReloadRoster()
        {
            ListBox.Items.Clear();
            foreach (Characters a in instances)
            {

                ListBox.Items.Add(a.getName());

            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListBox.SelectedIndex >= 0)
            {

                int IndexofSelected = ListBox.SelectedIndex;





                Characters c = instances[IndexofSelected];
                if (MessageBox.Show("Are you Sure to want to delete " + c.getName(), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    instances.RemoveAt(IndexofSelected); ReloadRoster();
                }
            }
        }

    }
}
