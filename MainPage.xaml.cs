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
            var _nome = nome.Text;
            var _cpf = cpf.Text;
            var _endereco = endereco.Text; 
            var _senha = senha.Text;
           
            if (string.IsNullOrEmpty(_nome)
                && string.IsNullOrEmpty(_cpf) &&
                string.IsNullOrEmpty(_senha)) { 
            DisplayAlert("Item faltante",
                "Algum item não foi preenchido",
                "ok");
            }
            else { 
            DisplayAlert("Item salvo",
                "O cadastro " + _nome + " foi salvo",
                "ok");
                Nome.Text = _nome;
                CPF.Text = _cpf;
                Endereco.Text = _endereco;
                Senha.Text = _senha;
            }
            
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
