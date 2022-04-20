using AcademyF_EquazioneSecondoGrado.Core;
using Xunit;

namespace AcademyF_EquazioneSecondoGrado.Tests
{
    public class Equazione2GradoTest
    {
        [Fact]
        public void Test1() //Dovrebbe iniziare con Should..
        {
            //ARRAGE: predisposizione del test
            Equation equazione = new Equation();
            //ACT: chiamare la funzionalità da testare
            double[] risultato=equazione.RisolviEquazioneDiSecondoGrado(1, -3, 2);
            //ASSERT: valuto il risultato atteso vs quello effettivamente restituito
            Assert.True(risultato.Length == 2);
            Assert.True(risultato[0] == 1); //Assert.Equal(1, risultato[0]);
            Assert.True(risultato[1] == 2); //Assert.Equal(2, risultato[1]);
            
        }

        [Fact]
        public void Test2() //Dovrebbe iniziare con Should..
        {
            //ARRAGE: predisposizione del test
            Equation equazione = new Equation();
            //ACT: chiamare la funzionalità da testare
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(1, -5, 6);
            //ASSERT: valuto il risultato atteso vs quello effettivamente restituito
            Assert.True(risultato.Length == 2);
            Assert.True(risultato[0] == 2); //Assert.Equal(2, risultato[0]);
            Assert.True(risultato[1] == 3); //Assert.Equal(3, risultato[1]);

        }

        [Fact]
        public void Test3() //Dovrebbe iniziare con Should..
        {
            //ARRAGE: predisposizione del test
            Equation equazione = new Equation();
            //ACT: chiamare la funzionalità da testare
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(1, 2, 1);
            //ASSERT: valuto il risultato atteso vs quello effettivamente restituito
            Assert.True(risultato.Length == 1);
            Assert.True(risultato[0] == -1); //Assert.Equal(-1, risultato[0]);
        }
        [Fact]
        public void Test4() //Dovrebbe iniziare con Should..
        {
            //ARRAGE: predisposizione del test
            Equation equazione = new Equation();
            //ACT: chiamare la funzionalità da testare
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(1, -3, 10);
            //ASSERT: valuto il risultato atteso vs quello effettivamente restituito
            Assert.Null(risultato);
        }

    }
}