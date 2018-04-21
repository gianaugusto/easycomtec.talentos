using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using System.Collections.Generic;

namespace Test
{
    public class AlterarTalento : CadastrarTalento
    {
        [Fact]
        public void AlterarTalento_Funcionando()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:4200/talento/312294c7-b6c6-452b-a44e-000000000000");
            Assert.Equal("", driver.Title);
        }

        [Fact]
        public void Alterar_Talento()
        {
            AlterarTalento_Funcionando();

            Preencher_Talento_Email();
            Preencher_Talento_Informacao_Basica();
            Preencher_Talento_Informacao_Bancaria();
            Preencher_Talento_Conhecimento();
        }

    }
}
