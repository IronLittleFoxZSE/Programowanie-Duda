namespace SimpleCalculatorMauiApp
{
    public partial class MainPage : ContentPage
    {
        public string FirstNumberStr { get; set; }
        public string SecondNumberStr { get; set; }

        private string result;
        public string Result
        {
            get { return result; }
            set { result = value; OnPropertyChanged(); }
        }

        private Color resultColor;
        public Color ResultColor
        {
            get { return resultColor; }
            set { resultColor = value; OnPropertyChanged(); }
        }


        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //int firstNumber;
            if (!int.TryParse(firstNumberEntry.Text, out int firstNumber)
                || !int.TryParse(secondNumberEntry.Text, out int secondNumber))
            {
                resultLabel.Text = $"Błedne dane";
                resultLabel.BackgroundColor = Colors.Red;
                return;
            }

            int result = firstNumber + secondNumber;

            resultLabel.Text = $"Wynik to {result}";
            resultLabel.BackgroundColor = Colors.Green;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            if (!int.TryParse(FirstNumberStr, out int firstNumber)
                || !int.TryParse(SecondNumberStr, out int secondNumber))
            {
                Result = $"Błedne dane";
                ResultColor = Colors.Red;
                return;
            }

            int result = firstNumber + secondNumber;

            Result = $"Wynik to {result}";
            ResultColor = Colors.Green;
        }
    }
}
