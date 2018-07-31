using PatternsExamples.B_Structural.A_Adapter;

namespace PatternsExamples.B_Structural.A_Adapter
{
    public class FlyingSquirrel : IFlyingSquirrel
    {
        public int Fly() => 20;

	    public int DropAcorns() => 1;
    }
}
