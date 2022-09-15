using ZooController;
using ZooDataAccess;
using ZooModel;

namespace ZooControllerTests
{
    public class KeeperControllerTests
    {
        [Fact]
        public void TestFeedAnimalsSuccess()
        {
            // Arrange
            MemoryAnimalDao<Lion> _memoryAnimalDao = new MemoryAnimalDao<Lion>();
            _memoryAnimalDao.Create(new Lion("Alex"));

            KeeperController keeperController = new KeeperController(_memoryAnimalDao);
            int afterWeight = _memoryAnimalDao.Animals.Sum(a => a.Weight) + 1;

            //// Act
            keeperController.FeedAnimals();

            //// Assert
            Assert.True(afterWeight == _memoryAnimalDao.Animals.Sum(a => a.Weight));
        }
    }
}