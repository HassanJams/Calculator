namespace Calculator
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Stores the first number for calculations
        /// </summary>
        private double leftOperand = 0.0;
        /// <summary>
        /// Stores the selected math calculation 
        /// </summary>
        private string mathoperation = "";
        /// <summary>
        /// Tracks if an operation is in progress
        /// </summary>
        private bool mathOpInProgress = false;

        /// <summary>
        /// Sets up the calculator form
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles number button clicks
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event data</param>
        private void numBtn_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" || (mathOpInProgress && display.Text != "."))
            {
                display.Clear();
            }
            mathOpInProgress = false;
            display.Text += ((Button)sender).Text;
        }
        /// <summary>
        /// Clears the current number.
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event data</param>
        private void clearEntryBtn_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }

        /// <summary>
        /// Resets everything.. numbers, operation, and what not
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event data</param>

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // clear any memory locations including current 
            // operands and potential operator 

            leftOperand = 0.0;
            mathoperation = "";
            mathOpInProgress = false;
            clearEntryBtn_Click(sender: sender, e: e);

        }
        /// <summary>
        /// Deletes the last digit
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event data</param>
        private void backSpaceBtn_Click(object sender, EventArgs e)
        {
            //if number in the display is larger than one digit 
            if (display.Text.Length > 1)
            {
                //remove last number from the display 
                display.Text = display.Text.Substring(0, display.Text.Length - 1);
            }
            else
            {
                clearEntryBtn_Click(sender: sender, e: e);
            }
        }
        /// <summary>
        /// Switches the number between positive and negative
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event data</param>
        private void signBtn_Click(object sender, EventArgs e)
        {
            display.Text = (-double.Parse(display.Text)).ToString();
        }

        /// <summary>
        /// Adds a decimal point and if their isn't one
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event data</param>
        private void decimalBtn_Click(object sender, EventArgs e)
        {
            // Conditional operator to test for existing . 
            // If one exists, keep the same
            // Else, Add .
            display.Text = (display.Text.Contains('.')) ? display.Text : display.Text + '.';
        }
        /// <summary>
        /// Stores the selected math operation
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event data</param>
        private void mathOperationBtn_Click(object sender, EventArgs e)
        {
            leftOperand = double.Parse(display.Text);
            mathoperation = ((Button)sender).Text;
            mathOpInProgress = false;
            display.Clear();

        }

        /// <summary>
        /// Does the math for each button and shows the result
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event data</param>
        private void equalBtn_Click(object sender, EventArgs e)
        {
            switch (mathoperation)
            {
                case "+":
                    display.Text = (leftOperand + double.Parse(display.Text)).ToString();
                    break;
                case "-":
                    display.Text = (leftOperand - double.Parse(display.Text)).ToString();
                    break;
                case "X":
                    display.Text = (leftOperand * double.Parse(display.Text)).ToString();
                    break;
                case "÷":
                    display.Text = (leftOperand / double.Parse(display.Text)).ToString();
                    break;
                default:
                    break; 


            }
        }
    }
}
