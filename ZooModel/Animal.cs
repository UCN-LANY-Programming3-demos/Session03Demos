namespace ZooModel
{
    public abstract class Animal
    {
        public int Weight { get; set; }
        public string Name { get; set; }

        public Animal(int weight, string name)
        {
            Weight = weight;
            Name = name;
        }

        protected void Eat()
        {
            Weight++;
        }
    }
}