using Evaluator.Logic;

namespace Evaluator.UI.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPA_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "(";
        }

        private void btnPC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ")";
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "^";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "/";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "*";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "-";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "+";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length -1);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += $" = {FunctionEvaluator.Evaluate(txtDisplay.Text)}";
        }
    }
}
