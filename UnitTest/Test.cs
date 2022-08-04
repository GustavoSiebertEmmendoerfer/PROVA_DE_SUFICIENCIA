
using FluentAssertions;
using PROVA_DE_SUFICIENCIA;
using PROVA_DE_SUFICIENCIA.Entities;

namespace UnitTest
{
    public class Test
    {
        [Fact]
        public void ValidarCampos_Should_Throw_Excetion()
        {
            //Arrange
            var municipal = new Municipal("AAA-3333", "Senhor Motorista", DateTime.Now, new TimeOnly(00, 00));
            var cadastro = new Cadastro(municipal);
            cadastro.txtNome.Text = "Senhor Passageiro";
            cadastro.mskTxtRg.Text = "743867534";
            cadastro.mskTxtTelefone.Text = "47 99999-9999";
            cadastro.checkIdoso.Checked = true;
            cadastro.comboBox1.SelectedItem = "59";

            //Act
            var result = Record.Exception(() => cadastro.ValidarCampos());

            //Assert
            result.Should().BeOfType<ArgumentException>();
            result.Message.Should().Be("Idoso não qualificado");
        }

        [Fact]
        public void ValidarCampos_Should_Not_Throw_Exception()
        {
            //Arrange
            var municipal = new Municipal("AAA-3333", "Senhor Motorista", DateTime.Now, new TimeOnly(00, 00));
            var cadastro = new Cadastro(municipal);
            cadastro.txtNome.Text = "Senhor Passageiro";
            cadastro.mskTxtRg.Text = "743867534";
            cadastro.mskTxtTelefone.Text = "47 99999-9999";
            cadastro.checkIdoso.Checked = true;
            cadastro.comboBox1.SelectedItem = "60";

            //Act
            var result = Record.Exception(() => cadastro.ValidarCampos());

            //Assert
            result.Should().BeNull();
        }
        [Fact]
        public void Municipal_Should_Throw_Exception()
        {
            //Arrange
            var municipal = new Municipal("AAA-3333", "Senhor Motorista", DateTime.Now, new TimeOnly(00, 00));
            var listPassageiro = new PassageiroFaker().Generate(36);
            Exception result = null;

            //Act
            foreach (var item in listPassageiro)
                result = Record.Exception(() => municipal.AddPassageiro(item));
            

            //Assert
            result.Should().BeOfType<ArgumentException>();
            result.Message.Should().Be("Limite de 35 passageiros atingido");
        }
        [Fact]
        public void Intermunicipal_Should_Throw_Exception()
        {
            //Arrange
            var interMunicipal = new Intermunicipal("AAA-3333", "Senhor Motorista", DateTime.Now, new TimeOnly(00, 00));
            var listPassageiro = new PassageiroFaker().Generate(3);

            //Act
            foreach (var item in listPassageiro) 
                interMunicipal.AddPassageiro(item);
            
            var result = interMunicipal.GetValorTotal();

            //Assert
            result.Should().BeGreaterThan(29.83f);
            result.Should().BeLessThan(29.85f);
        }
    }
}