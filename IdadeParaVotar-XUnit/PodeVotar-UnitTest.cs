using IdadeParaVotar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IdadeParaVotar_XUnit
{
    public class PodeVotar_UnitTest
    {
        [Theory]
        [InlineData(14, "Não pode votar")]
        [InlineData(17, "Voto opcional")]
        [InlineData(21, "Pode votar")]
        [InlineData(16, "Voto opcional")]
        [InlineData(18, "Pode votar")]
        [InlineData(-15, "valor inválido")]
        [InlineData(200, "valor inválido")]

        public void verificarSePodeVotar(int vlIdade, string mensagem)
        {
            //Act
            var obtido = PodeVotar.Votar(vlIdade);

            //Assert
            Assert.Equal(obtido, mensagem);
        }
    }
}
