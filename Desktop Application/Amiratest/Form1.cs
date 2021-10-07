using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Amiratest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct TestData
        {
            public string serNum;
            /*
            public int devID;
            public float tmpC;
            public float tmpF;
            public float pwr5V;
            public float pwr3V;
            public bool led0;
            public bool led1;
            public bool led2;
            public bool led3;
            public bool led4;
            public bool led5;
            public bool led6;
            public float mtrAfwd;
            public float mtrArev;
            public float mtrBfwd;
            public float mtrBrev;
            */
        }


        TestData board0;
        TestData board1;
        TestData board2;
        TestData board3;
        TestData board4;
        TestData board5;
        TestData board6;
        TestData board7;


        public void dataArrays()
        {
            string[] boards = new string[8];
            boards[0] = "board0";
            boards[1] = "board1";
            boards[2] = "board2";
            boards[3] = "board3";
            boards[4] = "board4";
            boards[5] = "board5";
            boards[6] = "board6";
            boards[7] = "board7";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //display pre-test checks for user
            MessageBox.Show("Make sure this is good.\nMake Sure that is good.\nMake sure thus is good.", "Pre Test Checks");

            //cycle through prompt for user to enter serials 1 through 0
            board0.serNum = SerialNumberPrompt.ShowDialog("Please Scan or Enter The Serial Number of the Board in Test Slot 0", "Full Panel Test");
            //check if serial number was entered correctly, re-prompt user for correct serial
            while (string.IsNullOrEmpty(board0.serNum))
            {
                DialogResult dr = MessageBox.Show("Incorrect Serial Number. Please Re-Enter!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                board0.serNum = SerialNumberPrompt.ShowDialog("Please Scan or Enter The Serial Number of the Board in Test Slot 0", "Full Panel Test");
            }

            board1.serNum = SerialNumberPrompt.ShowDialog("Please Scan or Enter The Serial Number of the Board in Test Slot 1", "Full Panel Test");
            //check if serial number was entered correctly, re-prompt user for correct serial
            while (string.IsNullOrEmpty(board1.serNum))
            {
                DialogResult dr = MessageBox.Show("Incorrect Serial Number. Please Re-Enter!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                board1.serNum = SerialNumberPrompt.ShowDialog("Please Scan or Enter The Serial Number of the Board in Test Slot 1", "Full Panel Test");
            }

            board2.serNum = SerialNumberPrompt.ShowDialog("Please Scan or Enter The Serial Number of the Board in Test Slot 2", "Full Panel Test");
            //check if serial number was entered correctly, re-prompt user for correct serial
            while (string.IsNullOrEmpty(board2.serNum))
            {
                DialogResult dr = MessageBox.Show("Incorrect Serial Number. Please Re-Enter!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                board2.serNum = SerialNumberPrompt.ShowDialog("Please Scan or Enter The Serial Number of the Board in Test Slot 2", "Full Panel Test");
            }

            board3.serNum = SerialNumberPrompt.ShowDialog("Please Scan or Enter The Serial Number of the Board in Test Slot 3", "Full Panel Test");
            //check if serial number was entered correctly, re-prompt user for correct serial
            while (string.IsNullOrEmpty(board3.serNum))
            {
                DialogResult dr = MessageBox.Show("Incorrect Serial Number. Please Re-Enter!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                board3.serNum = SerialNumberPrompt.ShowDialog("Please Scan or Enter The Serial Number of the Board in Test Slot 3", "Full Panel Test");
            }

            board4.serNum = SerialNumberPrompt.ShowDialog("Please Scan or Enter The Serial Number of the Board in Test Slot 4", "Full Panel Test");
            //check if serial number was entered correctly, re-prompt user for correct serial
            while (string.IsNullOrEmpty(board4.serNum))
            {
                DialogResult dr = MessageBox.Show("Incorrect Serial Number. Please Re-Enter!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                board4.serNum = SerialNumberPrompt.ShowDialog("Please Scan or Enter The Serial Number of the Board in Test Slot 4", "Full Panel Test");
            }

            board5.serNum = SerialNumberPrompt.ShowDialog("Please Scan or Enter The Serial Number of the Board in Test Slot 5", "Full Panel Test");
            //check if serial number was entered correctly, re-prompt user for correct serial
            while (string.IsNullOrEmpty(board5.serNum))
            {
                DialogResult dr = MessageBox.Show("Incorrect Serial Number. Please Re-Enter!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                board5.serNum = SerialNumberPrompt.ShowDialog("Please Scan or Enter The Serial Number of the Board in Test Slot 5", "Full Panel Test");
            }

            board6.serNum = SerialNumberPrompt.ShowDialog("Please Scan or Enter The Serial Number of the Board in Test Slot 6", "Full Panel Test");
            //check if serial number was entered correctly, re-prompt user for correct serial
            while (string.IsNullOrEmpty(board6.serNum))
            {
                DialogResult dr = MessageBox.Show("Incorrect Serial Number. Please Re-Enter!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                board6.serNum = SerialNumberPrompt.ShowDialog("Please Scan or Enter The Serial Number of the Board in Test Slot 6", "Full Panel Test");
            }

            board7.serNum = SerialNumberPrompt.ShowDialog("Please Scan or Enter The Serial Number of the Board in Test Slot 7", "Full Panel Test");
            //check if serial number was entered correctly, re-prompt user for correct serial
            while (string.IsNullOrEmpty(board7.serNum))
            {
                DialogResult dr = MessageBox.Show("Incorrect Serial Number. Please Re-Enter!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                board7.serNum = SerialNumberPrompt.ShowDialog("Please Scan or Enter The Serial Number of the Board in Test Slot 7", "Full Panel Test");
            }

            /*
            MessageBox.Show(board1.serNum, "Board 1 Serial Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(board2.serNum, "Board 2 Serial Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(board3.serNum, "Board 3 Serial Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(board4.serNum, "Board 4 Serial Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(board5.serNum, "Board 5 Serial Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(board6.serNum, "Board 6 Serial Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(board7.serNum, "Board 7 Serial Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(board8.serNum, "Board 8 Serial Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
            */
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fullArrayTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void testSetupButton_Click(object sender, EventArgs e)
        {
            string serNum9 = SerialNumberPrompt.ShowDialog("Scan or Enter Test Slot 9's Serial Number", "Single Board Test");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Exit Program?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void abortTestButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("ALL TEST PROGRESS WILL BE LOST!\nAre you sure?\n", "Abort Test?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                //abort test algorithm here
            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void devicesButton_Click(object sender, EventArgs e)
        {

            /*
             IIviSessionFactory sf = new IviSessionFactory();
             try
             {
                 IIviDCPwr instr = (IIviDCPwr)sf.CreateDriver("psu3V");
                 instr.Initialize("psu3V", true, true, "");
                 IIviDCPwrOutput output = instr.Outputs.Item["OUTPUT"];
                 output.VoltageLevel = 3.0;
                 output.CurrentLimit = 1.0;
                 output.Enabled = true;
                 instr.Close();
             }
             catch (System.Runtime.InteropServices.COMException error)
             {
                 String msg =
                 String.Format("{0} {1}",
                 error.Message,
                 "0x" + Convert.ToString(error.ErrorCode, 16));
                 System.Diagnostics.Debug.WriteLine(msg);

             }
            */
        }

        private void viewTestResultsButton_Click(object sender, EventArgs e)
        {

        }

        private void viewTestDataButton_Click(object sender, EventArgs e)
        {
            //open form in separate window
            /*Form2 form = new Form2();
            form.TopLevel = true;
            //this.Controls.Add(form);
            form.Show();
            */

            //open listView in panel
            Form2 myForm = new Form2();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            mainPanel.Controls.Add(myForm);
            myForm.Show();
        }

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }
    }

    
    public static class SerialNumberPrompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 160,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 20, Top = 20, Width = 400, Text = text };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 450 };
            
            Button confirmation = new Button() { Text = "OK", Left = 370, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };

            Button cancellation = new Button() { Text = "Cancel", Left = 260, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            cancellation.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(textBox);
            prompt.Controls.Add(textLabel);
            
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            prompt.CancelButton = cancellation;
            prompt.Controls.Add(cancellation);

            
            cancellation.DialogResult = DialogResult.Cancel;
            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }


    
}