namespace MauiApp_MGCC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            getRes();  
        }

        public async void getRes()
        {
            double imc;
            if ((double.TryParse(EntryAlt.Text, out double inputAlt)) && (double.TryParse(EntryPes.Text, out double inputPes)))
            {
                imc = inputPes / Math.Pow(inputAlt, 2);
                string message = $"Tu IMC es de: {imc:F2}. ";

                if (imc < 18.5)
                    message += "\nEstás bajo de peso.";

                if (imc >= 18.5 && imc <= 24.9)
                    message += "\nEstás en el peso normal.";

                if (imc >= 25 && imc <= 29.9)
                    message += "\nTienes obesidad.";

                if (imc > 30)
                    message += "\nTienes sobrepeso.";

                await DisplayAlert("Resultado", message, "Ok");
            }
        }

        private void Cleanbtn_Clicked(object sender, EventArgs e)
        {
            EntryAlt.Text = "";
            EntryPes.Text = "";
        }
    }

}



