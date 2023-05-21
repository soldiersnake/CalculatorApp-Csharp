namespace Calculator
{
    public partial class Form1 : Form
    {
        string selectedOperator;
        int acumatedValue;
        public Form1()
        {
            InitializeComponent();
        }
        private void NumberAction_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int buttonValue = int.Parse(button.Text);
            int currentValue = int.Parse(txtValue.Text);
            currentValue = currentValue * 10 + buttonValue;
            txtValue.Text = currentValue.ToString();
        }

        private void OperatorAction_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            selectedOperator = button.Text;
            acumatedValue = int.Parse(txtValue.Text);
            txtValue.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtValue.Text = "0";
            acumatedValue = 0;
            selectedOperator = string.Empty;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            int secondAcumulatedValue = int.Parse(txtValue.Text);
            int result = 0;
            switch (selectedOperator)
            {
                case "+":
                    result = acumatedValue + secondAcumulatedValue;
                    break;
                case "*":
                    result = acumatedValue * secondAcumulatedValue;
                    break;
                case "/":
                    result = acumatedValue / secondAcumulatedValue;
                    break;
                case "-":
                    result = acumatedValue - secondAcumulatedValue;
                    break;
            }
            //if(selectedOperator == "*")
            //{
            //    result = acumatedValue * secondAcumulatedValue;
            //}
            //if (selectedOperator == "+")
            //{
            //    result = acumatedValue + secondAcumulatedValue;
            //}
            //if (selectedOperator == "-")
            //{
            //    result = acumatedValue - secondAcumulatedValue;
            //}
            //if (selectedOperator == "/")
            //{
            //    result = acumatedValue / secondAcumulatedValue;
            //}
            txtValue.Text = result.ToString();
        }
    }
}