using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ContactManager;

namespace ContactManager.WinForms
{
    public partial class AddNewContact : Form
    {
        private ContactManagerrr instan;
        private int indextoedit;
        public bool isEdit = false;


        public AddNewContact()
        {
            InitializeComponent();
        }

        public AddNewContact(ContactManagerrr c,int index)
        {
            this.indextoedit = index;
            this.instan = c;
            isEdit = true;
            InitializeComponent();
        }

        private void NametextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back) || e.KeyChar == (char)Keys.Space);
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (isValidated()) {

                ContactManagerrr cm = new ContactManagerrr();

                cm.setName(NametextBox.Text.Trim());
                cm.setEmail(EmailtextBox.Text.Trim());
                if (!isEdit)
                {
                    ContactManagerUi.instances.Add(cm);
                    MessageBox.Show("All Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (isEdit) {
                    ContactManagerUi.instances[indextoedit] = cm;
                }
                ResetForm();
                this.Close();

            }
        }

        private void ResetForm()
        {
            NametextBox.Clear();
            EmailtextBox.Clear();
        }
       
        
        private bool isValidated()
        {
            RegexUtilities util = new RegexUtilities();
            bool isFalse = false;
            if (NametextBox.Text.Trim() == "" )
            {
                NameError.Visible = true;
                NameError.Text = "Name should be utmost 50 chaaracters long";
               
            }
            if(isNameSame(NametextBox.Text.Trim().ToUpper())){
                MessageBox.Show("This Name already exists.. ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                isFalse = true;
            }

            if (EmailtextBox.Text.Trim() == "" || !util.IsValidEmail(EmailtextBox.Text.Trim()) )
            {
                EmailError.Visible = true ;
                EmailError.Text = "Email should be in correct format";

                isFalse = true;
            
            }

            if (isFalse)
            {
                return false;
            }
            return true;

        }

        private bool isNameSame(String name)
        {
            foreach (ContactManagerrr a in ContactManagerUi.instances)
            {
                if (name == a.getName().ToUpper()) {
                    return true;
                }
            }

            return false;
        }

        private void AddNewContact_Load(object sender, EventArgs e)
        {
            if (isEdit) {

                NametextBox.Text = instan.getName();
                EmailtextBox.Text = instan.getEmail();
            }
        }
    }
}
