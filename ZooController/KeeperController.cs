using ZooDataAccess;
using ZooModel;

namespace ZooController
{
    public class KeeperController
    {
        private MemoryAnimalDao<Lion> _memoryLionDao;
     
        public KeeperController()
        {
            _memoryLionDao = MemoryAnimalDao<Lion>.Create();
        }

        public void FeedAnimals(int weight = 0)
        {
            foreach (var animal in _memoryLionDao.GetAll())
            {
                animal.EatMeat();
                _memoryLionDao.Update(animal);
            }
        }


    }
}