
using CalcProjec;
using System;
using Xunit;

namespace TestCalcProject
{
    public class UnitTest1
    {
        public Calculadora ConstruirClasse()
        {
            string data = "03/06/2024";
            Calculadora calc = new Calculadora(data);
        }
        
        [Theory]
        [InlineData (1,2,3)]
        [InlineData(2, 2, 4)]
        public void Test1(int val1, int val2, int res)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalc = calc.Somar(val1, val2);
            Assert.Equal(resultadoCalc, res);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(2, 3, 6)]
        public void TestMult(int val1, int val2, int res)
        {
            Calculadora calc = ConstruirClasse();

            int resultado = calc.Multiplicar(val1, val2);
            Assert.Equal(resultado, res);
        }
        [Theory]
        [InlineData(6, 5, 1)]
        [InlineData(5, 3, 2)]
        public void TestSub(int val1, int val2, int res)
        {
            Calculadora calc = ConstruirClasse();

            int resultado = calc.Subtrair(val1, val2);
            Assert.Equal(resultado, res);
        }
        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(9, 3, 3)]
        //[InlineData(6, 4, 2)]
        //[InlineData(9, 0, 3)]
        public void TestDiv(int val1, int val2, int res)
        {
            Calculadora calc = ConstruirClasse();

            int resultado = calc.Dividir(val1, val2);
            Assert.Equal(resultado, res);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = ConstruirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3, 0));  
        }
        public void TestarHistorico()
        {
            Calculadora calc = new ConstruirClasse();

            calc.Somar(1, 2);
            calc.Somar(2,6);
            calc.Somar(4, 3);
            calc.Somar(3, 7);

            var lista = calc.Historico();

            Assert.NotEmpty(calc.Historico()); // checar se a lista nao ta vazia
            Assert.Equal(3, lista.Count);
        }
    }
}
