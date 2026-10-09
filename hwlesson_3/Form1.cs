using hwlesson_3;
using System;
using System.Collections;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace hwlesson_3
{
    public partial class Form1 : Form
    {
        private char currentSymbol;
        private Stopwatch stopwatch = new Stopwatch();
        private bool isWaitingInput = false;

        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }


        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            currentSymbol = (char)rnd.Next('A', 'Z' + 1);

            lblSignal.Text = $"Press the letter: {currentSymbol}";
            lblResult.Text = "Waiting for a click...";

            stopwatch.Restart();
            isWaitingInput = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (isWaitingInput)
            {
                stopwatch.Stop();
                isWaitingInput = false;

                char pressedChar = (char)e.KeyValue;

                if (pressedChar == currentSymbol)
                {
                    lblResult.Text = $"You got it! Your reaction time: {stopwatch.ElapsedMilliseconds} ms";
                }
                else
                {
                    lblResult.Text = $"Wrong! You needed to press {currentSymbol}, but pressed {pressedChar}";
                }
            }
        }


        private void btnTask2_Click(object sender, EventArgs e)
        {
            ArrayList collection = new ArrayList { "Element 1", 2026, true, 3.14 };

            Thread thread = new Thread(() =>
            {
                foreach (var item in collection)
                {
                    string result = item.ToString();

                    this.Invoke(new Action(() =>
                    {
                        MessageBox.Show($"ToString(): {result}", "Task 2");
                    }));
                }
            });

            thread.Start();
        }

        private void btnTask3_Click(object sender, EventArgs e)
        {
            Bank myBank = new Bank();

            myBank.Name = "Monobank";
            myBank.Money = 5000;
            myBank.Percent = 10;

            MessageBox.Show("Properties of the bank have been changed. Data written to 'bank.txt' in background threads!", "Task 3");
        }
    }
}