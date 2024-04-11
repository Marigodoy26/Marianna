using Microsoft.Maui.Controls;

namespace Marianna;

public partial class MainPage : ContentPage
{
		Animais atual; 
		Cachorro Pandora= new Cachorro();

		Gata Princesa= new Gata();

		Coelinha Bunny= new Coelinha();

	public MainPage()
	{
		InitializeComponent();

		atual= Pandora;

	}

	void mudarclicado (object sender, EventArgs args)

	{
		if(atual==Pandora)
		{
			atual=Princesa;
		}
		else if(atual==Princesa)
		{
			atual=Bunny;
		}
		else if (atual==Bunny)
		{
			atual=Pandora;
		}
	}

	void fomeclicado (object sender, EventArgs args)

	{
		atual.Setcomer(atual.Getfome()+0.1);
		ConfiguraçãodeProgresso();

	}

	void brincarclicado (object sender, EventArgs args)
	{
		atual.Setbrincar(atual.Getbrincar()+0.1);
		ConfiguraçãodeProgresso();
	}

	void beberclicado (object sender, EventArgs args)
	{
		atual.Setbeber(atual.Getbeber()+0.1);
		ConfiguraçãodeProgresso();
	}
	
	void ConfiguraçãodeProgresso()
	{
		fome.Progress=atual.Getfome();
		agua.Progress=atual.Getbeber();
		alegria.Progress=atual.Getbrincar();
	}

	

}

