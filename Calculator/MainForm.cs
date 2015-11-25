using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator {

    public partial class MainForm : Form {

        private Handler handler = new Handler();

        private bool dotTyped = false;
        private bool inputClear = true;
        private bool readyForNext = false;
        private bool needToClearOutput = false;

        public MainForm() {
            InitializeComponent();
            KeyPreview = true;
            MaximizeBox = false;
            KeyPress += new KeyPressEventHandler(PressHandler);
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void SetText(String str) {
            displayWindow.Text = str;
        }

        private void ResetParameters(bool resetInput = false) {
            dotTyped = false;
            inputClear = true;
            readyForNext = false;
            handler.Clear();
            outputField.Clear();
            if(resetInput) 
                displayWindow.Text = "0";
        }

        private void SetText(double value) {
            displayWindow.Text = System.Convert.ToString(value);
        }

        private void displayText(String str) {
            if (readyForNext) {
                displayWindow.Clear();
                readyForNext = false;
            }

            if (needToClearOutput) {
                outputField.Clear();
                needToClearOutput = false;
            }

            if (inputClear) {
                displayWindow.Text = str;
                inputClear = false;
            } else {
                displayWindow.AppendText(str);
            }

            outputField.AppendText(str);
        }

        private void button0_Click(object sender, EventArgs e) {
            if (readyForNext) {
                displayWindow.Clear();
                readyForNext = false;
            }
            if (!inputClear) {
                displayWindow.AppendText("0");
                inputClear = false;
            }

            outputField.AppendText("0");
        }

        private void digitButton_Click(object sender, EventArgs e) {
            Button digit = sender as Button;
            displayText(digit.Text);
        }

        private void dotBtn_Click(object sender, EventArgs e) {
            if (readyForNext) {
                displayWindow.Text = "0";
                readyForNext = false;
            }
            if (!dotTyped) {
                displayWindow.AppendText(",");
                dotTyped = true;
                inputClear = false;
                outputField.AppendText(",");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e) {
            ResetParameters(true);
        }

        private void PressHandler(object sender, KeyPressEventArgs e) {
            if (e.KeyChar >= '1' && e.KeyChar <= '9') {
                displayText(char.ToString(e.KeyChar));
                return;
            }

            if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '÷') {
                handleOperation((Operation)e.KeyChar);
                return;
            }

            if (e.KeyChar == '=') {
                calculateBtn_Click(null, null);
                return;
            }

            switch (e.KeyChar) {
                case '/':
                    handleOperation(Operation.Div);
                    break;

                case (char)'0':
                    button0_Click(null, null);
                    break;
                     
                case '.':
                    dotBtn_Click(null, null);
                    break;
                
                case (char)Keys.Escape:
                    clearBtn_Click(null, null);
                    break;

                case (char)Keys.Enter:
                    calculateBtn_Click(null, null);
                    break;

                case (char)Keys.Back:
                    backspaceBtn_Click(null, null);
                    break;               
            }
        }

        private void calculateBtn_Click(object sender, EventArgs e) {
            handler.AddNumber(double.Parse(displayWindow.Text));
            double res = handler.Calculate(true);
            SetText(res);
            outputField.Text += String.Format(" = {0}", System.Convert.ToString(res));
            
            dotTyped = false;
            inputClear = true;
            needToClearOutput = true;

            handler.Clear();
        }

        private void operationBtn_click(object sender, EventArgs e) {
            Button opBtn = sender as Button;
            handleOperation((Operation)System.Convert.ToChar(opBtn.Text));
        }

        private void handleOperation(Operation op) {
            dotTyped = false;

            if (readyForNext) {
                handler.ChangeLastOperation(op);
                outputField.Text = outputField.Text.Substring(0, outputField.TextLength - 2);
                outputField.AppendText(String.Format("{0} ", (char)op));
                return;
            }

            handler.AddNumber(double.Parse(displayWindow.Text));
            handler.AddOperation(op);
            SetText(handler.Calculate());
            readyForNext = true;
            outputField.AppendText(String.Format(" {0} ", (char)op));
        }

        private void changeSingBtn_Click(object sender, EventArgs e) {
            if (displayWindow.Text != "0") {
                if (displayWindow.Text[0] != '-')
                   displayWindow.Text = "-" + displayWindow.Text;
                else
                   displayWindow.Text = displayWindow.Text.Substring(1, displayWindow.Text.Length - 1);
            }
        }

        private void backspaceBtn_Click(object sender, EventArgs e) {
            if (displayWindow.TextLength > 1) {
                displayWindow.Text = displayWindow.Text.Substring(0, displayWindow.TextLength - 1);
                outputField.Text = outputField.Text.Substring(0, outputField.TextLength - 1);
            } else {
                displayWindow.Text = "0";
                if(outputField.TextLength> 0)
                    outputField.Text = outputField.TextLength == 1 ? "" : outputField.Text.Substring(0, outputField.TextLength - 1) + "0";
                inputClear = true;
            }
        }

        private void copyDisplayBtn_Click(object sender, EventArgs e) {
            Clipboard.SetText(displayWindow.Text);
        }

        private void copyOutBtn_Click(object sender, EventArgs e) {
            Clipboard.SetText(outputField.Text);
        }
    }
}
