using ProjetoElemento.Models;

namespace ProjetoElemento.View;

public partial class Show : ContentPage
{
	public Show(Pessoa pessoa)
	{
		InitializeComponent();
		show_name.Text = " "+pessoa.Nome;
        show_cpf.Text = " " + pessoa.Cpf;
        show_endereco.Text = " " + pessoa.Endereco;
    }
}