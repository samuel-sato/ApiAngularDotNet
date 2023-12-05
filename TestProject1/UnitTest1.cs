namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        CarService carService;
        PersonModel person;
        Car carro;

        [SetUp]
        public void Setup()
        {
            carService = new CarService();
            person = new PersonModel {
                Id = Guid.NewGuid(),
                Active = true,
                Age = 18,
                Email = "emailTeste@gmail.com",
                Name = "Pessoa 1"
            };
            carro = new Car(new Guid(), 2022, "Gol", "CBA9E56");
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
            DocumentoCarro documentoCarro = new DocumentoCarro(new Guid(), carro);
            Assert.IsNotNull(documentoCarro);
        }

        [Test]
        public void AdicionarPropretarioCarroAoDocumento()
        {
            DocumentoCarro documentoCarro = new DocumentoCarro(new Guid(), carro);
            documentoCarro.SetProprietario(person);
            Assert.That(documentoCarro.Proprietario.Id,Is.EqualTo(person.Id));
        }

        [Test]
        public void DarPermissaoVisualizacaoDoDocumento()
        {
            DocumentoCarro documentoCarro = new DocumentoCarro(new Guid(), carro);
            documentoCarro.SetProprietario(person);

            DocumentoSerivce documentoSerivce = new DocumentoSerivce();

            PersonModel p1 = new PersonModel { Id = new Guid(), Name = "P1" };

            documentoSerivce.DarPermissaoVisualizacao(documentoCarro, person, p1);
            Assert.IsTrue(documentoSerivce.PossuiPermissaoVisualizar(documentoCarro, p1));
        }
    }
}