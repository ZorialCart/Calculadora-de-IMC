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

        public void getRes()
        {
            double imc;
            if ((double.TryParse(EntryAlt.Text, out double inputAlt)) && (double.TryParse(EntryPes.Text, out double inputPes)))
            {
                imc = inputPes / Math.Pow(inputAlt, 2);

                if (imc < 18.5)
                    RIMC.Text = "Estás en el peso normal.";

                if (imc >= 18.5 && imc <= 24.9)
                    RIMC.Text = "Estás en el peso normal.";

                if (imc >= 25 && imc <= 29.9)
                    RIMC.Text = "Tienes en el peso normal.";

                if (imc > 30)
                    RIMC.Text = "Tienes sobrepeso.";

                Result.Text = imc.ToString();


            }








            //if (imc < 18.5)
            //{
            //   Console.WriteLine("El peso es bajo.");
            //}   
            //if(imc )
            //    18.5 BAJO
            //18.5 - 24.9     nORMAL

            //25 - 29.9
            //30



        }

    }

}



