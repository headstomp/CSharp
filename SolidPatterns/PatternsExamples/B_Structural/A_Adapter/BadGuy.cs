namespace PatternsExamples.B_Structural.A_Adapter
{
    public class BadGuy : IBadGuy
    {
        public int Drive() => 30;

	    public int Shoot() => 50;
    }
}
