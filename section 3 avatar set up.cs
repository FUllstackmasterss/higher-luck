using System;
using System.Windows.Forms;

namespace HigherLuck
{
    public partial class Form1
    {
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            bool namesWritten = txtFirstName.Text.Trim() != "" && txtSecondName.Text.Trim() != "";

            btnSetupFirst.Enabled = namesWritten && player1 == null;
            btnSetupSecond.Enabled = namesWritten && player1 != null && player2 == null;
        }

        private void btnSetupFirst_Click(object sender, EventArgs e)
        {
            try
            {
                RadioButton radio = GetChosenRadio();
                if (radio == null)
                {
                    MessageBox.Show("Please choose an avatar.");
                    return;
                }

                player1 = new Player(txtFirstName.Text.Trim(), GetAvatarFile(radio));
                ShowFirstPlayer();

                txtFirstName.Enabled = false;
                radio.Checked = false;
                radio.Enabled = false;

                txtName_TextChanged(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSetupSecond_Click(object sender, EventArgs e)
        {
            try
            {
                RadioButton radio = GetChosenRadio();
                if (radio == null)
                {
                    MessageBox.Show("Please choose an avatar.");
                    return;
                }

                player2 = new Player(txtSecondName.Text.Trim(), GetAvatarFile(radio));
                ShowSecondPlayer();

                txtSecondName.Enabled = false;
                radio.Enabled = false;

                txtName_TextChanged(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ResetAll()
        {
            ResetPart2();
            ResetSection4();

            nudRounds.Value = 5;
            nudRounds.Enabled = true;
            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtFirstName.Enabled = true;
            txtSecondName.Enabled = true;

            rdoAvatar1.Enabled = true;
            rdoAvatar2.Enabled = true;
            rdoAvatar3.Enabled = true;
            rdoAvatar4.Enabled = true;
            rdoAvatar1.Checked = true;

            btnSetupFirst.Enabled = false;
            btnSetupSecond.Enabled = false;
        }

        private RadioButton GetChosenRadio()
        {
            if (rdoAvatar1.Checked && rdoAvatar1.Enabled) return rdoAvatar1;
            if (rdoAvatar2.Checked && rdoAvatar2.Enabled) return rdoAvatar2;
            if (rdoAvatar3.Checked && rdoAvatar3.Enabled) return rdoAvatar3;
            if (rdoAvatar4.Checked && rdoAvatar4.Enabled) return rdoAvatar4;
            return null;
        }

        private string GetAvatarFile(RadioButton radio)
        {
            if (radio == rdoAvatar1) return "Icon04.png";
            if (radio == rdoAvatar2) return "Icon03.png";
            if (radio == rdoAvatar3) return "Icon02.png";
            return "Icon01.png";
        }
    }
} 