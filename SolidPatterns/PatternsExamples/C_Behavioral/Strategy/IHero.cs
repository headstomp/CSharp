namespace PatternsExamples.C_Behavioral.Strategy
{
    public interface IHero
    {
        string DoHeroStuff();

        void ChangeSuperPower(ISuperPower power);
    }
}