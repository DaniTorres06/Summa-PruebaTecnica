using Summa_PruebaTecnica;

namespace TestPruebaTecnica
{
    public class TestsStaircase
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Test Staircase");
        }

        [Test]
        public void TestAgentA()
        {
            int vIntEscaler = 4;
            Staircase vObjStaircase = new Staircase();
            string AgentA = vObjStaircase.AgentA(vIntEscaler);
            Assert.IsNotEmpty(AgentA);
        }

        [Test]
        public void TestAgentB()
        {
            int vIntEscaler = 3;
            Staircase vObjStaircase = new Staircase();
            string AgentA = vObjStaircase.AgentB(vIntEscaler);
            Assert.IsNotEmpty(AgentA);
        }

        [Test]
        public void TestAgentC()
        {
            int vIntEscaler = 2;
            Staircase vObjStaircase = new Staircase();
            string AgentA = vObjStaircase.AgentC(vIntEscaler);
            Assert.IsNotEmpty(AgentA);
        }

    }
}