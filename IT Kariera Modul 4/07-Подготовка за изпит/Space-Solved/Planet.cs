namespace ConsoleApp333
{
    internal class Planet
    {
        private string starName;
        private string planetName;
        private string planetType;
        private string supportLife;
        public Planet(string starName, string planetName, string planetType, string supportLife)
        {
            StarName = starName;
            PlanetName = planetName;
            PlanetType = planetType;
            SupportLife = supportLife;
        }

        public string StarName { get => starName; set => starName = value; }
        public string PlanetName { get => planetName; set => planetName = value; }
        public string PlanetType { get => planetType; set => planetType = value; }
        public string SupportLife { get => supportLife; set => supportLife = value; }
    }
}