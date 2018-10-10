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


namespace CharacterCreator.Winforms
{
    public partial class AddNewCharacter : Form
    {
        Characters c;
        int IndexToReplaced;
        public bool isEdit = false;
        public AddNewCharacter()
        {
            InitializeComponent();
        }
        public AddNewCharacter(Characters th, int index)
        {
            InitializeComponent();
            c = th; IndexToReplaced = index;
        }


        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (isValidated())
            {
                Characters ch = new Characters();
                ch.setName(NametextBox.Text.Trim());
                ch.setProfession(ProfessioncomboBox.SelectedIndex);
                ch.setRace(RacecomboBox.SelectedIndex);
                ch.setStrength(Convert.ToInt32(StrengthnumericUpDown.Value));
                ch.setIntelligence(Convert.ToInt32(IntelligencenumericUpDown.Value));
                ch.setAgility(Convert.ToInt32(AgilitynumericUpDown.Value));
                ch.setConstitution(Convert.ToInt32(ConstitutionnumericUpDown.Value));
                ch.setCharisma(Convert.ToInt32(CharismanumericUpDown.Value));
                ch.setBiography(BiographytextBox.Text.Trim());


                if (!isEdit)
                {

                    MainForm.instances.Add(ch);
                    MessageBox.Show("All Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if (isEdit)
                {
                    MainForm.instances[IndexToReplaced] = ch;

                }


                ClearForm();
                this.Close();

            }
        }

        private void ClearForm()
        {
            NametextBox.Clear();
            ProfessioncomboBox.SelectedIndex = -1;
            RacecomboBox.SelectedIndex = -1;
            StrengthnumericUpDown.Value = 50;
            IntelligencenumericUpDown.Value = 50;
            AgilitynumericUpDown.Value = 50;
            ConstitutionnumericUpDown.Value = 50;
            CharismanumericUpDown.Value = 50;
            BiographytextBox.Clear();
        }

        private bool isValidated()
        {
            bool isFalse = false;
            if (NametextBox.Text.Trim() == "")
            {
                NameError.Visible = true;
                NameError.Text = "Name should be utmost 50 chaaracters long and should only be from a-zA-Z";
                isFalse = true;
            }
            else { NameError.Text = ""; }

            if (ProfessioncomboBox.SelectedIndex == -1)
            {
                professionError.Visible = true;
                professionError.Text = "Profession Should be filled ";
                isFalse = true;
            }
            else { professionError.Text = ""; }
            if (RacecomboBox.SelectedIndex == -1)
            {
                raceError.Visible = true;
                raceError.Text = "Race should be  filled ";
                isFalse = true;
            }
            else { raceError.Text = ""; }
            /////


            if (isFalse)
            {
                return false;
            }
            return true;
        }

        private void NametextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back) || e.KeyChar == (char)Keys.Space;
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewCharacter_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                label1.Text = "Edit Character";
                NametextBox.Text = c.getName();

                ProfessioncomboBox.SelectedIndex = c.getProfession();
                RacecomboBox.SelectedIndex = c.getRace();
                StrengthnumericUpDown.Value = c.getStrength();
                IntelligencenumericUpDown.Value = c.getIntelligence();
                AgilitynumericUpDown.Value = c.getAgility();
                ConstitutionnumericUpDown.Value = c.getConstitution();
                CharismanumericUpDown.Value = c.getCharisma();
                BiographytextBox.Text = c.getBiography();


            }
        }
    }
}
