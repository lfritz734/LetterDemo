using static System.Console;
class LetterDemo
{
    static void Main()
    {
        // Write your code here
        Letter aLetter = new Letter();
        CertifiedLetter aCertified = new CertifiedLetter();

        //original attempt at code, but this did not use auto-implemented properties:
        /*
        

        WriteLine(aLetter.Name.ToString());
        WriteLine(aLetter.Date.ToString());
        WriteLine(aCertified.Name.ToString());
        WriteLine(aCertified.Date.ToString());
        */

        aLetter.Name = "Electric Company";
        aLetter.Date = "02/14/18";
        aCertified.Name = "Electric Company";
        aCertified.Date = "02/14/18";
        aCertified.TrackingNumber = "12345";

        WriteLine(aLetter.ToString());

        WriteLine(aCertified.ToString() + "Tracking Number:" + aCertified.TrackingNumber);
    }
}

// Write your classes here
class Letter
{
    public string Name { get; set; }
    public string Date { get; set; }

    public override string ToString()
    {
        return (GetType() + ": " + Name + "\n" + Date);
    }
}

class CertifiedLetter : Letter
{
    public string TrackingNumber { get; set; }
}



