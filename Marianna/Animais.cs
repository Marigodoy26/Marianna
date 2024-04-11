namespace Marianna;

public class Animais 
{
    protected double fome;

    protected double felicidade;

    protected double sede;

    protected string Animaisfoto;

 public Animais()
 {
  fome = 0;
  felicidade = 0;
  sede = 0;
 }
 
   public void Setcomer (double f)
	{
       if(f< 0)
        fome= 0;
        else if (f> 0)
            fome= 1;
       else 
       fome= f;
       
	}

	public void Setbeber (double s)
	{
		if(s< 0)
        fome= 0;
        else if (s> 0)
            sede= 1;
       else 
       sede= s;
	}

	public void Setbrincar (double fe)
	{
		if(fe< 0)
        felicidade= 0;
        else if (fe> 0)
            felicidade= 1;
       else 
       felicidade= fe;
	}

	public double Getfome()
    {
        return fome;
    }
    
    public double Getbeber()
    {
        return sede;
    }

    public double Getbrincar()
    {
        return felicidade;
    }

    
    public string Getimagem (object sender, EventArgs args)
	{
		return Animaisfoto;
	}
}

