
namespace thirdLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate()
        {
            try
            {
                var firstVector = new Vector(double.Parse(FirstVecX.Text), double.Parse(FirstVecY.Text), double.Parse(FirstVecZ.Text));
                var secondVector = new Vector(double.Parse(SecondVecX.Text), double.Parse(SecondVecY.Text), double.Parse(SecondVecZ.Text));

                LenFirstVec.Text = firstVector.CalcLength();
                LenSecondVec.Text = secondVector.CalcLength();

                string resultVector;

                switch (cmbOperation.Text)
                {
                    case "+":
                        resultVector = (firstVector + secondVector).Show();
                        break;
                    case "-":
                        resultVector = (firstVector - secondVector).Show();
                        break;
                    case "*":
                        resultVector = (firstVector * secondVector).Show();
                        break;
                    case "&":
                        resultVector = firstVector & secondVector;
                        break;
                    default:
                        resultVector = (firstVector + secondVector).Show();
                        break;
                }
                result.Text = resultVector;
            }
            catch (FormatException)
            {
                return;
            }
        }

        private void onValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
