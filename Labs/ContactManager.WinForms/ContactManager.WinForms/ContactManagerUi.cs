using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.WinForms
{
    public partial class ContactManagerUi : Form
    {
        public ContactManagerUi()
        {
            InitializeComponent();
        }

        public static List<ContactManagerrr> instances = new List<ContactManagerrr>();
        public static List<ContactManagerrr> messages = new List<ContactManagerrr>();

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutMe abt = new AboutMe();
            abt.ShowDialog();
        }

        private void ContactManagerUi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                Application.Exit();
            }
            if (e.KeyCode == Keys.F)
            {
                aboutToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyCode == Keys.Insert)
            {
                addNewContactToolStripMenuItem_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.N)
            {
                addNewContactToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyCode == Keys.Delete) {
                deleteToolStripMenuItem_Click(sender, e);
            }

        }

        private void addNewContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewContact ad = new AddNewContact();
            ad.ShowDialog();

            ReloadRoster();

        }


        private void ReloadRoster()
        {


            ListBox.Items.Clear();
            foreach (ContactManagerrr a in instances)
            {

                ListBox.Items.Add(a.getName());

            }
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (ListBox.SelectedIndex >= 0)
            {

                int ag = ListBox.SelectedIndex;
                ContactManagerrr m = instances[ag];
                EmailSending emailsending = new EmailSending(m.getName(), m.getEmail());
                emailsending.ShowDialog();
                ReloadMessaging();


                ReloadRoster();
            }
        }

        private void ReloadMessaging()
        {
            MessagesListBoc.Items.Clear();
            foreach (ContactManagerrr h in messages)
            {

                MessagesListBoc.Items.Add(h.getName() + ",  " + h.getSubject());



            }
        }

        private void ContactManagerUi_Load(object sender, EventArgs e)
        {

        }

        private void viewMessageDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmailDetilsVievwer();
        }



        private void MessagesListBoc_Click(object sender, EventArgs e)
        {
            EmailDetilsVievwer();
        }

        private void EmailDetilsVievwer()
        {
            if (MessagesListBoc.SelectedIndex >= 0)
            {
                int index = MessagesListBoc.SelectedIndex;
                ContactManagerrr a = messages[index];
                EmailSending email = new EmailSending(a.getName(), a.getEmail(), a.getSubject(), a.getMessage());
                email.ShowDialog();
            }
        }

        private void ListBox_DoubleClick(object sender, EventArgs e)
        {

            if (ListBox.SelectedIndex >= 0)
            {

                int ag = ListBox.SelectedIndex;
                ContactManagerrr c = instances[ag];
                AddNewContact ance = new AddNewContact(c, ag);

                ance.isEdit = true;
                ance.ShowDialog();

                ReloadRoster();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBox_DoubleClick(sender, e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListBox.SelectedIndex >= 0)
            {

                int IndexofSelected = ListBox.SelectedIndex;





                ContactManagerrr c = instances[IndexofSelected];
                if (MessageBox.Show("Are you Sure to want to delete " + c.getName(), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    instances.RemoveAt(IndexofSelected); ReloadRoster();
                }
            }
        }
    }
}
