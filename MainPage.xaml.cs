using ProjetoElemento.Models;
using ProjetoElemento.View;


namespace ProjetoElemento
{
    public partial class MainPage : ContentPage
    {
        Pessoa pessoa = new Pessoa();


        public MainPage()
        {
            InitializeComponent();
        }

        public void Salvar(object sender, EventArgs e)
        {
            pessoa.Nome = nome.Text;
            pessoa.Cpf = cpf.Text;
            pessoa.Endereco = endereco.Text;
            pessoa.Senha = senha.Text;

            var resposta = pessoa.Salva(pessoa);

            DisplayAlert("Aviso", resposta, "OK");

        }
        public async void Novo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Show(pessoa));
        }
        public async void Limpar(object sender, EventArgs e)
        {
            var resposta = await DisplayAlert("Tem Certeza?",
                "Todo o conteúdo do formulário será perdido",
                "sim", "não");
            if (resposta)
            {
                nome.Text = "";
                cpf.Text = "";
                endereco.Text = "";
                senha.Text = "";

                await DisplayAlert("Apagou", "Tudo foi apagado", "OK");
            }
        }

    }

}