namespace ConsoleApp333
{
    internal class Star
    {
        private string galaxyName;
        private string starName;
        private double weight;
        private double size;
        private int temperature;
        private double compatibility;
        private string starClass;



        public Star(string galaxyName, string starName, double weight, double size, int temperature, double compatibility)
        {
            GalaxyName = galaxyName;
            StarName = starName;
            Weight = weight;
            Size = size;
            Temperature = temperature;
            Compatibility = compatibility;
        }

        public double Compatibility { get => compatibility; set => compatibility = value; }
        public int Temperature { get => temperature; set => temperature = value; }
        public double Size { get => size; set => size = value; }
        public double Weight { get => weight; set => weight = value; }
        public string StarName { get => starName; set => starName = value; }
        public string GalaxyName { get => galaxyName; set => galaxyName = value; }
        public string StarClass { get => starClass; set => starClass = value; }

        public string StarClassSet()
        {
            if (Temperature >= 30000 && Compatibility >= 30000 && Weight >= 16 && Size >= 6.6)
            {
                return "O";
            }
            else if (Temperature > 10000 && Temperature < 30000 && Compatibility < 30000 && Compatibility > 25 && Weight < 16 && Weight > 2.1 && Size < 6.6 && Size > 2)
            {
                return "B";
            }
            else if (Temperature > 7500 && Temperature < 10000 && Compatibility < 25 && Compatibility > 5 && Weight < 2.1 && Weight > 1.4 && Size < 2 && Size > 1.4)
            {
                return "A";
            }
            else if (Temperature > 6000 && Temperature < 7500 && Compatibility < 5 && Compatibility > 1.5 && Weight < 1.4 && Weight > 1.04 && Size < 1.4 && Size > 1.15)
            {
                return "F";
            }
            else if (Temperature > 5200 && Temperature < 6000 && Compatibility < 1.5 && Compatibility > 0.6 && Weight < 1.04 && Weight > 0.8 && Size < 1.15 && Size > 0.96)
            {
                return "G";
            }
            else if (Temperature > 3700 && Temperature < 5200 && Compatibility < 0.6 && Compatibility > 0.08 && Weight < 0.8 && Weight > 0.45 && Size < 0.96 && Size > 0.7)
            {
                return "F";
            }
            else if (Temperature > 2400 && Temperature < 3700 && Compatibility <= 0.08 && Weight < 0.45 && Weight > 0.08 && Size <= 0.7)
            {
                return "M";
            }
            else
            {
                return "Unknown";
            }
        }
    }
}