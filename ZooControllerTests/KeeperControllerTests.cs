using ZooController;

namespace ZooControllerTests
{
    public class KeeperControllerTests
    {
        [Fact]
        public void TestFeedAnimalsSuccess()
        {
            // Arrange
            KeeperController keeperController = new KeeperController();
            int beforeWeight = keeperController.Animals.Sum(x => x.Weight);
            int afterWeight = beforeWeight + keeperController.Animals.Count();

            // Act
            keeperController.FeedAnimals();

            // Assert
            Assert.True(afterWeight == keeperController.Animals.Sum(x => x.Weight));
        }
    }
}