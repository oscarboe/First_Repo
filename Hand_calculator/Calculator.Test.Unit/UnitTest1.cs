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

<<<<<<< HEAD
        [Test]
        public void simpleAdd()
=======

        [TestCase(8, 9, 17)]
        [TestCase(3.5, 2.5, 6)]
        [TestCase(-3,-5,-8)]
        public void simpleAdd(double a,double b, double x)
>>>>>>> b7ebf92cd9210ac63298331a867ae37fdaf34a23
        {
            //uut = new Hand_calculator.Calculator();
            
            
<<<<<<< HEAD
            Assert.That(uut.Add(9,10),Is.EqualTo(19));
            
            
        }

     
        [Test]
        public void Substract()
=======
            Assert.That(uut.Add(a,b),Is.EqualTo(x));
        }

        [TestCase(9, 10, -1)]
        [TestCase(3.5, 4.5, -1)]
        [TestCase(-10, -9, -1)]
        public void Substract(double a, double b, double x)
>>>>>>> b7ebf92cd9210ac63298331a867ae37fdaf34a23
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
        [TestCase(20, 10)]
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

        //Accumulator
        [Test]
        public void Accumulator_multiply()
        {
            uut.Multiply(3, 3);
            uut.Multiply(3, 3);
            Assert.That(uut.Accumulator, Is.EqualTo(18));
        }

        [Test]
        public void Accumulator_arithmetic()
        {
            uut.Add(10, 10);
            uut.Subtract(3, 2);
            Assert.That(uut.Accumulator, Is.EqualTo(21));
        }

        [Test]
        public void Accumulator_simpleAdd_Twice()
        {
            uut.Add(5,5);
            uut.Add(10,10);
            Assert.That(uut.Accumulator, Is.EqualTo(30));
        }

        [Test]
        public void Accumulator_subtract()
        {
            uut.Subtract(10, 20);
            uut.Subtract(20, 5);
            Assert.That(uut.Accumulator, Is.EqualTo(5));
        }
    }
}