namespace PatternsExamples.B_Structural.A_Adapter
{
    public interface ICharacter
    {
        int Chase();

        int Flee();

        int Attack();
    }

    public interface IFlyingSquirrel
    {
        int Fly();

        int DropAcorns();
    }

    public interface IMoose
    {
        int Run();

        int Charge();
    }

    public interface IBadGuy
    {
        int Drive();

        int Shoot();
    }
}