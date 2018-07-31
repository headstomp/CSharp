﻿namespace PatternsExamples.B_Structural.C_Decorator
{
    public class AttackCar : ICar
    {
        private readonly ICar _decoratedCar;

        public AttackCar(ICar decoratedCar)
        {
            _decoratedCar = decoratedCar;
        }

        public int Drive() => _decoratedCar.Drive() - 10;

	    public int Attack() => _decoratedCar.Attack() + 30;

	    public int Defend() => _decoratedCar.Defend() - 10;
    }
}
