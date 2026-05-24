using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {

        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte 5 Estrelas",
                ValorDiariaAdulto = 150.0,
                ValorDiariaCrianca = 75.0
            },
            new Quarto()
            {
                Descricao = "Suíte 4 Estrelas",
                ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca = 55.0
            },
            new Quarto()
            {
                Descricao = "Suíte 3 Estrelas",
                ValorDiariaAdulto = 80.0,
                ValorDiariaCrianca = 40.0
            },
            new Quarto()
            {
                Descricao = "Suíte 2 Estrelas",
                ValorDiariaAdulto = 50.0,
                ValorDiariaCrianca = 25.0
            },
            new Quarto()
            {
                Descricao = "Suíte 1 Estrela",
                ValorDiariaAdulto = 30.0,
                ValorDiariaCrianca = 15.0
            }
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.Inicio());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 500;
            window.Height = 800;

            return window;
        }
    }
}