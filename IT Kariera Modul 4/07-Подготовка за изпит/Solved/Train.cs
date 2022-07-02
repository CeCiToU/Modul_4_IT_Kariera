namespace Trains_Exam
{
    internal class Train
    {
        private int number;
        private int cars;
        private string name;
        private string type;

        public Train()
        {
        }

        public Train(int number, string name, string type, int cars)
        {
            Number = number;
            Name = name;
            Type = type;
            Cars = cars;
        }

        public int Number { get => number; set => number = value; }
        public int Cars { get => cars; set => cars = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }

        public override string ToString()
        {
            return $"{Number} {Name} {Type} {Cars}";
        }
    }
}