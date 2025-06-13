using ProjetoElemento.Models;

namespace ProjetoElemento.Views;

public partial class Show : ContentPage
{
	public Show(Pessoa pessoa)
	{
		InitializeComponent();

        showName.Text = " "+pessoa.Nome;
		showCpf.Text = " "+pessoa.Cpf;
		showEndereco.Text = " "+pessoa.Endereco;
    }
}