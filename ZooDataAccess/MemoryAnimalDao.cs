using ZooModel;

namespace ZooDataAccess
{
    public class MemoryAnimalDao<TAnimal> where TAnimal : Animal
    {
        public static MemoryAnimalDao<TAnimal> Create()
        {
            return new MemoryAnimalDao<TAnimal>();
        }

        public List<TAnimal> Animals { get; }

        public MemoryAnimalDao()
        {
            Animals = new List<TAnimal>();

            //Zebra marty = new Zebra("Marty");
            //Lion alex = new Lion("Alex");

            //Animals.Add(alex);
            //Animals.Add(marty);
        }

        // CRUD methods
        public IEnumerable<TAnimal> GetAll()
        {
            return Animals;
        }

        public TAnimal? GetByName(string name)
        {
            return Animals.SingleOrDefault(a => a.Name == name);
        }

        public void Create(TAnimal animal)
        {
            Animals.Add(animal);
        }

        public void Update(TAnimal animal)
        {
            //var updateAnimal = Animals.Single(a => a.Name == animal.Name);
            //updateAnimal.Weight = animal.Weight;
        }

        public void Delete(TAnimal animal)
        {

        }
    }
}