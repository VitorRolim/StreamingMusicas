class ReprodutorMusical 
{
    public ReprodutorMusical(string reproduzir)
    {
        Reproducao = reproduzir;
    }

    public ReprodutorMusical(string reproduzir, string pausar)
    {
        Reproducao = reproduzir;
        Pausa = pausar;
    }

    public ReprodutorMusical(string reproduzir, string pausar, string avancar)
    {
        Reproducao = reproduzir;
        Pausa = pausar;
        Avanco = avancar;
    }

    public ReprodutorMusical(string reproduzir, string pausar, string avancar, string controleVolume)
    {
        Reproducao = reproduzir;
        Pausa = pausar;
        Avanco = avancar;
        ControleVolume = controleVolume;
    }




    public string Reproducao { get; set; }
    public string Pausa { get; set; }
    public string Avanco { get; set; }
    public string ControleVolume { get; set; }

    public void ReproduzirMusica()
    {
        Console.WriteLine("A música está sendo reproduzida");
    }

    public void PausarMusica()
    {
        Console.WriteLine("A música foi pausada");
    }

    public void AvancarMusica()
    {
        Console.WriteLine("A música avançou 5 segundos");
    }

    public void ControleVolumeMusica() 
    { 
        if(ControleVolume == "++")
        {
            Console.WriteLine("O volume da música aumentou");
        }
        else
        {
            Console.WriteLine("O volume da música diminuiu");
        }
    }

}