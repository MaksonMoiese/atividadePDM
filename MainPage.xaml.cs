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

           

         

            DisplayAlert("Item salvo",
                "O cadastro  foi salvo",
                "ok");
            
        }    
        public async void Limpar(object sender, EventArgs e)
        {
            var resposta = await DisplayAlert("Tem Certeza?",
                "Todo o conteúdo do formulário será perdido",
                "sim","não");
            if (resposta)
            {

               
                await DisplayAlert("Apagou","Tudo foi apagado","OK");
            }
        }

    }

}
