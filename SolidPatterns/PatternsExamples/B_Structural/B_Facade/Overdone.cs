namespace PatternsExamples.B_Structural.B_Facade
{
    public class Overdone : IOverdone
    {
	    private string SomeString { get; } = string.Empty;

	    public Overdone(string someString)
        {
            SomeString = someString;
        }

        public int DoSomething(int x, int y) => x * y;

	    public int DoSomethingElse(int x, int y, int z) => (x + y) * z;

	    public int DoSomethingAgain(int x, int y, int z, int a) => (x + y + z) * a;
    }
}