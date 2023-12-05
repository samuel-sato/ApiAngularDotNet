namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        CarService carService;
        [SetUp]
        public void Setup()
        {
            carService = new CarService();
        }

        [Test]
        public void CriarCarro()
        {
            Car c1 = new Car(new Guid(), 2018, "Ford Ka", "ABC2E56");
            Assert.IsNotNull(carService.Add(c1));
        }

        [Test]
        public void CriarDocumentoCarro()
        {
            Car c1 = new Car(new Guid(), 2018, "Ford Ka", "ABC2E56");
            DocumentoCarro documentoCarro = new DocumentoCarro(new Guid(), c1);
            Assert.IsNotNull(documentoCarro);
        }     
    }
}