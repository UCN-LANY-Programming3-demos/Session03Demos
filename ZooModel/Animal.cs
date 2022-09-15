namespace ZooModel
{
    // The animal class is an abstraction of an animal
    public abstract class Animal
    {
        public int Weight { get; set; }
        public string Name { get; set; }

        public Animal(int weight, string name)
        {
            Weight = weight;
            Name = name;
        }

        // Eat method available to derived classes
        protected void Eat()
        {
            Weight++;
        }
    }
}