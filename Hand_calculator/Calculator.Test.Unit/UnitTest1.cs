using NUnit.Framework.Constraints;

namespace Calculator.Test.Unit_
{
    public class CalculatorUnitTest
    {
        private Hand_calculator.Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut=new Hand_calculator.Calculator();
        }


        [Test]
        public void simpleAdd()
        {
            //uut = new Hand_calculator.Calculator();
            
            
            Assert.That(uut.Add(9,10),Is.EqualTo(19));
        }

        [Test]
        public void Substract()
        {
           // uut = new Hand_calculator.Calculator();


            Assert.That(uut.Subtract(9, 10), Is.EqualTo(-1));
        }
        [Test]
        public void Multiply()
        {
            //uut = new Hand_calculator.Calculator()
            Assert.That(uut.Multiply(9, 10), Is.EqualTo(90));
        }
        [TestCase(2,3,8)]
        [TestCase(3, 2,9)]

        public void Power(double x,double exp, double result)
        {
           // uut = new Hand_calculator.Calculator()
           Assert.That(uut.Power(x, exp), Is.EqualTo(result));
        }


    }
}