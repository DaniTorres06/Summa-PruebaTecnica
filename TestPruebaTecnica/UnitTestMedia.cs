using Summa_PruebaTecnica;

namespace TestPruebaTecnica
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Pruebas");
        }

        [Test]
        public void TestAgentA()
        {
            List<double> vLstNumbers = new List<double> { 10, 6, 15, 4 };
            Media vObjMedia = new Media();
            double AgentA = vObjMedia.AgentA(vLstNumbers);
            Assert.NotZero(AgentA);
        }

        [Test]
        public void TestAgentB()
        {
            List<double> vLstNumbers = new List<double> { 12, 8, 5, 3 };
            Media vObjMedia = new Media();
            double AgentA = vObjMedia.AgentB(vLstNumbers);
            Assert.NotZero(AgentA);
        }

        [Test]
        public void TestAgentC()
        {
            List<double> vLstNumbers = new List<double> { 7, 6, 75, 68 };
            Media vObjMedia = new Media();
            double AgentA = vObjMedia.AgentC(vLstNumbers);
            Assert.NotZero(AgentA);
        }

    }
}