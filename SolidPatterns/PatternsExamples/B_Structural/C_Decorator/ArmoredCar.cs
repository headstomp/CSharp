namespace PatternsExamples.B_Structural.C_Decorator
{
    public class ArmoredCar : ICar
    {
        private readonly ICar _decoratedCar;

        public ArmoredCar(ICar decoratedCar)
        {
            _decoratedCar = decoratedCar;
        }

        public int Drive() => _decoratedCar.Drive() - 20;

	    public int Attack() => _decoratedCar.Attack();

	    public int Defend() => _decoratedCar.Defend() + 40;
    }
}