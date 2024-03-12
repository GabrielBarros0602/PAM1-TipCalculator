namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
         
        private void OnFifteenClicked(object sender, EventArgs e) 
        {
            double amount = Convert.ToDouble(ValueEntry.Text.ToString());
            double result = amount * 0.15;
            double TotalValue2 = result + amount;

            TipValue.Text = result.ToString();
            TotalValue.Text = TotalValue2.ToString();
        }

        private void OnTwentyClicked(object sender, EventArgs e) 
        {
            double amount = Convert.ToDouble(ValueEntry.Text.ToString());
            double result = amount * 0.2;
            double TotalValue2 = result + amount;

            TipValue.Text = result.ToString();
            TotalValue.Text = TotalValue2.ToString();
        }

        private void OnRoundDownClicked(object sender, EventArgs e)
        {
            double result = CalculateTip();
            double roundedResult = Math.Floor(result);
            double amount = Convert.ToDouble(ValueEntry.Text.ToString());
            double TotalValue2 = roundedResult + amount;

            TipValue.Text = roundedResult.ToString();
            TotalValue.Text = TotalValue2.ToString();
        }

        private void OnRoundUpClicked(object sender, EventArgs e) 
        {
            double result = CalculateTip();
            double roundedResult = Math.Ceiling(result);
            double amount = Convert.ToDouble(ValueEntry.Text.ToString());
            double TotalValue2 = roundedResult + amount;

            TipValue.Text = roundedResult.ToString();
            TotalValue.Text = TotalValue2.ToString();
        }


        private double CalculateTip()
        {
            double amount = Convert.ToDouble(ValueEntry.Text.ToString());
            double percent = PercentageSlider.Value;
            
            double result = amount * (percent / 100);
            return result;
        }
    }

}
