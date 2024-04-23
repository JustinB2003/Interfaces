using System;

public interface IPlayable
{
    void Play();
}

public class Guitar : IPlayable
{
    public void Play()
    {
        Console.WriteLine("GUITAR IS NOW PLAYING!");
    }
}

public class Piano : IPlayable
{
    public void Play()
    {
        Console.WriteLine("PIANO IS NOW PLAYING!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Guitar guitar = new Guitar();
        Piano piano = new Piano();

        guitar.Play();
        piano.Play();
    }
}
