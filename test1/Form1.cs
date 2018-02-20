using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class Form1 : Form
    {
        public Form1()        
        {
            InitializeComponent();
            
        }

        public static int balance = 2000;
        public static int pin = 5100;
        public static int tryPinTime = 0;
        public static int pinTemp;
        public static string accountInformation = "Name: Kamal Al Nasr;\r\nType:Checking ***1234\r\nPhoine: (615)963-5848\r\nAddress: 3500 John A. Merritt Ave. Nashville, TN 37209";
        public static string currentModule = "enterPin";

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentModule != "display")
            {
                textMessage.Text = textMessage.Text + button1.Text;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (currentModule != "display")
            {
                textMessage.Text = textMessage.Text + button2.Text;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (currentModule != "display")
            {
                textMessage.Text = textMessage.Text + button3.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (currentModule != "display")
            {
                textMessage.Text = textMessage.Text + button4.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (currentModule != "display")
            {
                textMessage.Text = textMessage.Text + button5.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (currentModule != "display")
            {
                textMessage.Text = textMessage.Text + button6.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (currentModule != "display")
            {
                textMessage.Text = textMessage.Text + button7.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (currentModule != "display")
            {
                textMessage.Text = textMessage.Text + button8.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (currentModule != "display")
            {
                textMessage.Text = textMessage.Text + button9.Text;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (currentModule != "display")
            {
                textMessage.Text = textMessage.Text + button0.Text;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (currentModule != "display")
            {
                textMessage.Text = "";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult messageExit;
            messageExit = MessageBox.Show("Exit ATM system:","ATM Information",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (messageExit==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (currentModule== "enterPin")
            {
                if (Convert.ToInt32(textMessage.Text) == pin)
                {
                    labelTitle.ForeColor = Color.FromKnownColor(KnownColor.White);
                    labelTitle.BackColor = Color.FromKnownColor(KnownColor.DodgerBlue);

                    labelMessageTitle.Text = "Account Infomrmation";
                    labelMessageTitle.ForeColor = Color.FromKnownColor(KnownColor.Black);
                    labelMessageTitle.BackColor = Color.FromKnownColor(KnownColor.DodgerBlue);

                    buttonBack.Text = "BK/SPC";
                    buttonBack.Enabled = true;

                    buttonFastCash.Visible = true;

                    buttonMakeDeposit.Visible = true;

                    buttonWithdraw.Visible = true;

                    buttonChangePin.Visible = true;

                    buttonShowBalance.Visible = true;

                    buttonAccount.Visible = true;

                    textMessage.Text = accountInformation;
                    textMessage.PasswordChar = char.Parse("\0");
                    textMessage.Font= new Font(textMessage.Font.Name, 16, textMessage.Font.Style, textMessage.Font.Unit);
                    currentModule = "display";


                } else
                {
                    labelMessageTitle.Text = "Incorrect PIN. ENTER Again";
                    tryPinTime++;
                    textMessage.Text = "";
                    if (tryPinTime >= 3)
                    {
                        labelMessageTitle.Text = "Incorrect PIN for 3 times. Exit.";
                        DialogResult messageExit;
                        messageExit = MessageBox.Show("Incorrect PIN for 3 times. Exit.", "ATM Information", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        Application.Exit();
                    }
                }
                
            } else if (currentModule == "changePinInputOldPin")
            {
                if (Convert.ToInt32(textMessage.Text)==pin)
                {
                    currentModule = "changePinInputNewPin";
                    labelMessageTitle.Text = "Change PIN: Input New PIN";
                    textMessage.Text = "";
                } else
                {
                    labelMessageTitle.Text = "Change PIN: Input PIN didn't match Old PIN";
                    textMessage.Text = "";
                }
            } else if (currentModule == "changePinInputNewPin")
            {
                pin = Convert.ToInt32(textMessage.Text);
                labelMessageTitle.Text = "Change PIN: PIN is changed";
                textMessage.Text = "";

            } else if (currentModule == "makeDeposit")
            {
                int depositAmount = Convert.ToInt32(textMessage.Text);
                if (depositAmount>1000)
                {
                    labelMessageTitle.Text = "Make Deposit: Only accept <$1000";
                    textMessage.Text = "";

                } else {
                    balance = balance + depositAmount;

                    labelMessageTitle.Text = "Make Deposit: Added $"+ depositAmount + " deposit";

                    textMessage.Font = new Font(textMessage.Font.Name, 24, textMessage.Font.Style, textMessage.Font.Unit);
                    textMessage.Text = "Current Balance is $"+ balance;
                    currentModule = "display";

                } 
            }  else if (currentModule == "withdraw")
            {
                int withdrawAmount = Convert.ToInt32(textMessage.Text);
                if (balance < 100)
                {
                    labelMessageTitle.Text = "Withdraw: Current balance <$100. Not allowed";
                    textMessage.Text = "";

                } else if ((balance- withdrawAmount)<0)
                {
                    labelMessageTitle.Text = "Withdraw: Balance after withdraw <$0. Not allowed";
                    textMessage.Text = "";
                } else {
                    balance = balance - withdrawAmount;

                    labelMessageTitle.Text = "Withdraw: Success. Withdrawed $" + withdrawAmount;

                    textMessage.Font = new Font(textMessage.Font.Name, 24, textMessage.Font.Style, textMessage.Font.Unit);
                    textMessage.Text = "Current Balance is $" + balance;
                    currentModule = "display";
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (textMessage.Text.Length>0)
            {
                if (currentModule != "display")
                {
                    textMessage.Text = textMessage.Text.Substring(0, textMessage.Text.Length - 1);
                }
            }
            
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            labelMessageTitle.Text = "Account Infomrmation";

            textMessage.PasswordChar = char.Parse("\0");
            textMessage.Font = new Font(textMessage.Font.Name, 16, textMessage.Font.Style, textMessage.Font.Unit);
            textMessage.Text = accountInformation;
            currentModule = "display";
        }

        private void buttonShowBalance_Click(object sender, EventArgs e)
        {
            labelMessageTitle.Text = "Current Balance:";

            textMessage.Font = new Font(textMessage.Font.Name, 60, textMessage.Font.Style, textMessage.Font.Unit);
            textMessage.PasswordChar = char.Parse("\0");
            textMessage.Text = balance.ToString();
            currentModule = "display";
        }

        private void buttonChangePin_Click(object sender, EventArgs e)
        {
            currentModule = "changePinInputOldPin";

            labelMessageTitle.Text = "Change PIN: Input Old PIN and ENTER";

            textMessage.Font = new Font(textMessage.Font.Name, 60, textMessage.Font.Style, textMessage.Font.Unit);
            textMessage.PasswordChar = char.Parse(".");
            textMessage.Text = "";

            
        }

        private void buttonMakeDeposit_Click(object sender, EventArgs e)
        {
            currentModule = "makeDeposit";
            labelMessageTitle.Text = "Make Deposit: Input amount and ENTER";

            textMessage.Font = new Font(textMessage.Font.Name, 60, textMessage.Font.Style, textMessage.Font.Unit);
            textMessage.PasswordChar = char.Parse("\0");
            textMessage.Text = "";


        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            currentModule = "withdraw";
            labelMessageTitle.Text = "Withdraw: Input amount and ENTER";

            textMessage.PasswordChar = char.Parse("\0");
            textMessage.Font = new Font(textMessage.Font.Name, 60, textMessage.Font.Style, textMessage.Font.Unit);
            textMessage.Text = "";
        }

        private void buttonFastCash_Click(object sender, EventArgs e)
        {
            currentModule = "fastcash";
            if (balance < 200)
            {
                labelMessageTitle.Text = "Fast Cash: Balance <$200";

                textMessage.PasswordChar = char.Parse("\0");
                textMessage.Font = new Font(textMessage.Font.Name, 24, textMessage.Font.Style, textMessage.Font.Unit);
                textMessage.Text = "";

            }
            else
            {
                balance = balance - 100;

                labelMessageTitle.Text = "Fast Cash: Withdrawed $" + 100;

                textMessage.PasswordChar = char.Parse("\0");
                textMessage.Font = new Font(textMessage.Font.Name, 24, textMessage.Font.Style, textMessage.Font.Unit);
                textMessage.Text = "Current Balance is $" + balance;
            }
            currentModule = "display";
        }


        private void textMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
