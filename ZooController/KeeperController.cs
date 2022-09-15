using ZooDataAccess;
using ZooModel;

namespace ZooController
{
    public class KeeperController
    {
        private MemoryAnimalDao<Lion> _memoryLionDao;
     
        public KeeperController(MemoryAnimalDao<Lion> memoryAnimalDao)
        {
            _memoryLionDao = memoryAnimalDao;
        }

        public void FeedAnimals()
        {
            foreach (var animal in _memoryLionDao.GetAll())
            {
                animal.EatMeat();
                _memoryLionDao.Update(animal);
            }
        }
    }
}