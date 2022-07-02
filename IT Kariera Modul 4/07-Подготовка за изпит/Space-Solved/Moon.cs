namespace ConsoleApp333
{
    internal class Moon
    {
        private string planetName;
        private string moonName;
        public Moon(string planetName, string moonName)
        {
            PlanetName = planetName;
            MoonName = moonName;
        }

        public string PlanetName { get => planetName; set => planetName = value; }
        public string MoonName { get => moonName; set => moonName = value; }
    }
}