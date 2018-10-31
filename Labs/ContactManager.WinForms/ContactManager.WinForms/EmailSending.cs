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
    public partial class EmailSending : Form
    {
        private String Email;
        private String Receiver,Subject,Message;
        private bool isView = false;
        public EmailSending()
        {
            InitializeComponent();
        }

        public EmailSending(String name, String email)
        {
            InitializeComponent();
            this.Receiver = name;
            this.Email = email;
        }

        public EmailSending(String name, String email,String subject, String message)
        {
            InitializeComponent();
            this.Receiver = name;
            this.Email = email;
            this.Subject = subject;
            this.Message = message;
            this.isView = true;

        }

        private void EmailSending_Load(object sender, EventArgs e)
        {

            if (isView) {
                SubjecttextBox.Text = Subject;
                MessagetextBox.Text = Message;
                SaveButton.Enabled = false;
                SubjecttextBox.ReadOnly = true;
                MessagetextBox.ReadOnly = true;
            
            }
            EmailtextBox.Text = Email;
            NametextBox.Text = Receiver;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (isValidated())
            {

                ContactManagerrr cm = new ContactManagerrr();

                cm.setName(NametextBox.Text.Trim());
                cm.setEmail(EmailtextBox.Text.Trim());
                cm.setSubject(SubjecttextBox.Text.Trim());
                cm.SetMessage(MessagetextBox.Text.Trim());

                ContactManagerUi.messages.Add(cm);
                MessageBox.Show("Email Sent", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
                this.Close();

            }
        }

        private void ResetForm()
        {
            MessagetextBox.Clear();
            EmailtextBox.Clear();
            SubjecttextBox.Clear();
            NametextBox.Clear();
        }

        private bool isValidated()
        {
            if (SubjecttextBox.Text.Trim() == "") {
                MessageBox.Show("Subject is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SubjecttextBox.Focus();
                return false;
            }
            return true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
