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


        [TestCase(9, 10, 19)]
        [TestCase(3.5, 2.5, 6)]
        [TestCase(-3,-5,-8)]
        public void simpleAdd(double a,double b, double x)
        {
            //uut = new Hand_calculator.Calculator();
            
            
            Assert.That(uut.Add(a,b),Is.EqualTo(x));
        }

        [TestCase(9, 10, -1)]
        [TestCase(3.5, 4.5, -1)]
        [TestCase(-10, -9, -1)]
        public void Substract(double a, double b, double x)
        {
           // uut = new Hand_calculator.Calculator();


            Assert.That(uut.Subtract(a, b), Is.EqualTo(x));
        }
        
        [TestCase(9, 10, 90)]
        [TestCase(3.5, 10, 35)]
        [TestCase(3.5, -10, -35)]
        public void Multiply(double a, double b, double x)
        {
            //uut = new Hand_calculator.Calculator()
            Assert.That(uut.Multiply(a, b), Is.EqualTo(x));
        }
        [TestCase(2,3,8)]
        [TestCase(3, 0,1)]
        [TestCase(10, -1, 0.1)]


        public void Power(double x,double exp, double result)
        {
           // uut = new Hand_calculator.Calculator()
           Assert.That(uut.Power(x, exp), Is.EqualTo(result));
        }


        // normal divide case
        [TestCase(10, 5)]
        public void Divide(double dividend, double divison)
        {
            Assert.That(uut.Divide(dividend, divison), Is.EqualTo(2));
        }

        // divide by zero exception case
        [TestCase(10, 0)]
        public void DivideZero(double dividend, double division)
        {
            
            Assert.That(() => uut.Divide(dividend,division), Throws.TypeOf<DivideByZeroException>());

        }

    }
}