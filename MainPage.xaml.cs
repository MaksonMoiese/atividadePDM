namespace ProjetoElemento
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        public void Salvar(object sender, EventArgs e)
        {
            DisplayAlert("Tudo ok",
                "Formulário salvo com sucesso",
                "ok");
        }    
        public async void Limpar(object sender, EventArgs e)
        {
            var resposta = await DisplayAlert("Tem Certeza?",
                "Todo o conteudo do formulario será perdido",
                "sim","não");
            if (resposta)
            {
                DisplayAlert("Apagou","Tudo foi apagado","OK");
            }
        }

    }

}
