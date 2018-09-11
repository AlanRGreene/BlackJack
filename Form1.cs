using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackApp1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        BlackJackApplication secondForm = new BlackJackApplication();

        //checking if what is enetered into the age text box is a digit
        bool check(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                {
                    return true;

                }
            }
            return false;
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            //declaring variables
            string name;
            string gender;
            int age = 0;

            //concatenating the firstname and surname strings
            name = TxtFirstName.Text + " " + TxtSurname.Text;
            //assigning gender a black string
            gender = "";
            //checking that there is something entered into the age text box
            if (!string.IsNullOrEmpty(TxtAge.Text))
            {
                if (!check(TxtAge.Text))
                {
                    age = int.Parse(TxtAge.Text);
                    //checking there is something entered into the first name and surname text box
                    if (TxtFirstName.Text == "" || TxtSurname.Text == "")
                    {
                        MessageBox.Show("Please enter your first and second name");
                    }
                    else
                    {
                        //checking that the accept radio button is accepted
                        if (RadAccept.Checked)
                        {
                            //checking if the male radio button is accepted
                            if (RadMale.Checked)
                            {
                                //checking that the users age is 18 or over
                                if (age >= 18)
                                {
                                    //displaying the information message box and launching the form
                                    gender = gender + RadMale.Text;
                                    MessageBox.Show("The players name is " + name + "\n"
                                             + "He is " + age + " " + "years old\n"
                                             + "He has accepted the terms and conditions");
                                    secondForm.Show();
                                }
                                else
                                {
                                    //displaying the catch case for someone too young to play
                                    MessageBox.Show("Sorry, you are under the legal age and cannot play!");
                                }

                            }
                            //code for when the female radio button is checked
                            else if (RadFemale.Checked)
                            {
                                //checking that the user is of legal age to play
                                if (age >= 18)
                                {
                                    //displaying the information message box and launching the blackjack application
                                    gender = gender + RadFemale.Text;
                                    MessageBox.Show("The players name is " + name + "\n"
                                             + "She is " + age + " " + "years old\n"
                                             + "She has accepted the terms and conditions");
                                    secondForm.Show();
                                }
                                else
                                {
                                    //catch case for if the user is too young to play
                                    MessageBox.Show("Sorry, you are under the legal age and cannot play!");
                                }

                            }
                        }


                        //message box for when the reject radio button is checked
                        else if (RadReject.Checked)
                        {
                            MessageBox.Show("You have not accepted the terms and conditions and cannot play!");
                        }
                    }
                }

                else
                {
                    //catch case for when the user does not enter digits in the age text box
                    MessageBox.Show("Please enter an age in digits");
                }
            }
            else
            {
                //catch case for when the user does not enter a value into the age text box
                MessageBox.Show("Please enter your all of your details");
            }
        }


        private void BtnLoginExit_Click(object sender, EventArgs e)
        {
            //click event closing the application
            this.Close();
        }
    }
}
