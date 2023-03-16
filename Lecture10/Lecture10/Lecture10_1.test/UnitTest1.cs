namespace Lecture10_1.test
{
    [Category("Unit")]
    public class Tests
    {
        private Flashlight myFlashlight = new Flashlight();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            string expectedResultString = "Turn on lamp\r\n";

            StringWriter stringWriter = new StringWriter();

            Console.SetOut(stringWriter);
            
            myFlashlight.PowerPressed();

            string consoleOutput = stringWriter.ToString();

            Assert.That(consoleOutput, Is.EqualTo(expectedResultString));
        }
    }
}