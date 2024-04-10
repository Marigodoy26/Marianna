namespace Marianna;

public class Animais 

{
    protected double fome;

    protected double felicidade;

    protected double sede;

 public Animais
 {
  fome = 0;
  felicidade = 0;
  sede = 0
 }
 
   void SetComer ()
	{
       if(f< 0)
        fome= 0;
        else if (f> 0)
            fome= 1;
       else 
       fome= f;
       
	}

	void SetBeber ()
	{
		if(s< 0)
        fome= 0;
        else if (s> 0)
            sede= 1;
       else 
       sede= s;
	}

	void SetBrincar ()
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
        return beber;
    }

    public double Getbrincar()
    {
        return brincar;
    }

     protected string Animaisdesing()
    void Getimagem (object sender, EventArgs args)
	{
		return Animaisdesing;
	}
}

