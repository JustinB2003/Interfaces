using System;

// Interface for compression and encryption
public interface IEncryptableCompressible
{
    void Compress();
    void Encrypt();
}

// Interface for document storage operations
public interface IStorable
{
    void Read();
    void Write();
}

// Document class implementing IStorable
public class Document : IStorable
{
    public Document()
    {
        Console.WriteLine("Creating document with: Test Document");
    }

    public virtual void Read()
    {
        Console.WriteLine("Implementing the Read Method for IStorable");
    }

    public virtual void Write()
    {
        Console.WriteLine("Implementing the Write Method for IStorable");
    }
}

// Note class deriving from Document and implementing IEncryptableCompressible
public class Note : Document, IEncryptableCompressible
{
    public Note() : base()
    {
        Console.WriteLine("Creating note");
    }

    // Implementing IStorable methods
    public override void Read()
    {
        base.Read(); // Call the base class method
    }

    public override void Write()
    {
        base.Write(); // Call the base class method
    }

    // Implementing IEncryptableCompressible methods
    public void Compress()
    {
        Console.WriteLine("Implementing Compress");
        Console.WriteLine("Implementing LogSavedBytes");
        Console.WriteLine("Implementing Compress");
        Console.WriteLine("Implementing LogOriginalSize");
        Console.WriteLine("Implementing LogSavedBytes");
        Console.WriteLine("Implementing Compress");
        base.Read(); // Call the base class method
    }

    public void Encrypt()
    {
        Console.WriteLine("Implementing Encrypt");
    }
}

// Tester class
public class Tester
{
    static void Main()
    {
        Document theNote = new Note();

        IStorable isNote = theNote as IStorable;

        if (isNote != null)
        {
            isNote.Read();
            isNote.Write();
        }

        Console.WriteLine();

        theNote.Read();
        theNote.Write();

        Console.WriteLine();

        Note note = new Note();
        IEncryptableCompressible isNote2 = note as IEncryptableCompressible;

        if (isNote2 != null)
        {
            isNote2.Compress();
            isNote2.Encrypt();
        }

        Console.WriteLine();

        note.Compress();
        note.Encrypt();
    }
}
