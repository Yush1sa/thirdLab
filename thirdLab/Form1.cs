
namespace thirdLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calculate()
        {
            try { 
            var firstVector = new Vector(double.Parse(FirstVecX.Text), double.Parse(FirstVecY.Text), double.Parse(FirstVecZ.Text));
            var secondVector = new Vector(double.Parse(SecondVecX.Text), double.Parse(SecondVecY.Text), double.Parse(SecondVecZ.Text));

            string resultVector;

            switch (cmbOperation.Text)
            {
                case "+":
                    resultVector = firstVector + secondVector;
                    break;
                case "-":
                    resultVector = firstVector - secondVector;
                    break;
                case "*":
                    resultVector = firstVector * secondVector;
                    break;
                case "&":
                    resultVector = firstVector & secondVector;
                    break;
                default:
                    resultVector = firstVector + secondVector;
                    break;
            }
            result.Text = resultVector;
            }
            catch (FormatException) {
                return;
            }
        }

        private void onValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
