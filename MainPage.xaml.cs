using ProjetoElemento.Models;



namespace ProjetoElemento   
{
    public partial class MainPage : ContentPage
    {
        Pessoa pessoa =  new Pessoa();
       

        public MainPage()
        {
            InitializeComponent();
        }
        
        public void Salvar(object sender, EventArgs e)
        {
         
            
        }    
       
        public async void Limpar(object sender, EventArgs e)
        {
            var resposta = await DisplayAlert("Tem Certeza?",
                "Todo o conteúdo do formulário será perdido",
                "sim","não");
            if (resposta)
            {
                nome.Text = "";
                cpf.Text = "";
                endereco.Text = "";
                senha.Text = "";
               
                await DisplayAlert("Apagou","Tudo foi apagado","OK");
            }
        }

    }

}
