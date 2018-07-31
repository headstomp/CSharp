namespace PatternsExamples.C_Behavioral.Commands
{
    public class LightCommand : IDemoCommand
    {
        private readonly ILight _light;

        public LightCommand(ILight light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.LightIsOn = !_light.LightIsOn;
        }
    }
}