using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class TestesUnitarios
    {
        [TestMethod]
        public void CasdastraCarro()
        {
            try
            {
                Car c1 = new Car(new Guid(), 2018, "Ford Ka", "ABC2D19");
                CarService service = CarService();
                service.Add(c1);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}
