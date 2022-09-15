using ZooModel;

namespace ZooController
{
    public class KeeperController
    {
        private List<Animal> _animals = new();

        public List<Animal> Animals { get { return _animals; } }

        public KeeperController()
        {
            Zebra marty = new Zebra("Marty");
            Lion alex = new Lion("Alex");

            _animals.Add(alex);
            _animals.Add(marty);
        }

        public void FeedAnimals()
        {
            foreach (var animal in _animals)
            {
                if (animal is ICarnivore)
                {
                    ((ICarnivore)animal).EatMeat();
                }
                if (animal is IHerbavore)
                {
                    ((IHerbavore)animal).EatGrass();
                }
            }
        }
    }
}