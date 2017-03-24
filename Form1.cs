using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace TicTacToe
{
    
    public partial class TicTacToe : Form
    {
        ArrayList lastStep = new ArrayList();
        List<Button> list = new List<Button>();
        Button[] buttons=new Button[10];
        Button lastButton;
        private bool sign = true;
        public TicTacToe()
        {
            InitializeComponent();
            buttons[1] = button1;
            buttons[2] = button2;
            buttons[3] = button3;
            buttons[4] = button4;
            buttons[5] = button5;
            buttons[6] = button6;
            buttons[7] = button7;
            buttons[8] = button8;
            buttons[9] = button9;

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button) sender;
            changeSign(button);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            changeSign(button);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            changeSign(button);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            changeSign(button);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            changeSign(button);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            changeSign(button);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            changeSign(button);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            changeSign(button);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            changeSign(button);

        }

        private void changeSign(Button selectedButton)
        {
            lastButton = selectedButton;
            list.Add(selectedButton);
            selectedButton.Text = "X";
            selectedButton.Enabled = false;
            if (sign == true)
            {
                selectedButton.Text = "X";
                selectedButton.Enabled = false;
                sign = false;
            }
            else if (sign == false)
            {
                selectedButton.Text = "O";
                selectedButton.Enabled = false;
                sign = true;
            }

        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void новаГраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sign = true;
            for (int i=1;i<=9;i++) {
                buttons[i].Enabled = true;
                buttons[i].Text = "";
            }
            list.Clear();
        }

        private void відмінитиХідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.Count != 0)
            {
                list[list.Count - 1].Enabled = true;
                list[list.Count - 1].Text = "";
                list.RemoveAt(list.Count - 1);
                sign = !sign;
            }
            
        }

    }
}
