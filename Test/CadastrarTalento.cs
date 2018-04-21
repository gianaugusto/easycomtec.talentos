using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using System.Collections.Generic;

namespace Test
{
    public class CadastrarTalento:TestBase
    {
        [Fact]
        public void CadastrarTalento_Funcionando()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:4200/");


            Assert.Equal("", driver.Title);

        }

        [Fact]
        public void Cadastrar_Talento()
        {
            CadastrarTalento_Funcionando();

            Preencher_Talento_Email();
            Preencher_Talento_Informacao_Basica();
            Preencher_Talento_Informacao_Bancaria();
            Preencher_Talento_Conhecimento();
        }

        [Fact]
        protected void Preencher_Talento_Email()
        {
            driver.FindElementById("email").SendKeys("gianaugusto-test@gmail.com");
           
            driver.FindElementsByClassName("btn-primary").FirstOrDefault(x => x.Text.ToLower().Equals("proximo")).Click();

            new WebDriverWait(driver, TimeSpan.FromSeconds(10))
                .Until(x => x.FindElements(By.Id("nome")).Any());
        }

        [Fact]
        protected void Preencher_Talento_Informacao_Basica()
        {
            driver.FindElementById("nome").SendKeys("Giancarlos test");
            driver.FindElementById("skype").SendKeys("gianaugusto-test");
            driver.FindElementById("telefone").SendKeys("15997570000");
            driver.FindElementById("linkedin").SendKeys("http://linkedin.com/gian-teste");
            driver.FindElementById("cidade").SendKeys("Sorocaba");
            driver.FindElementById("estado").SendKeys("SP");
            driver.FindElementById("portfolio").SendKeys("http://gianaugusto.com.br/test");

            driver.FindElementsByName("disponibilidade-horas")[0].Click();
            driver.FindElementsByName("disponibilidade-periodo")[0].Click();

            driver.FindElementsByClassName("btn-primary").FirstOrDefault(x => x.Text.ToLower().Equals("proximo")).Click();

            new WebDriverWait(driver, TimeSpan.FromSeconds(10))
                .Until(x => x.FindElements(By.Id("cpf")).Any());
        }


        [Fact]
        protected void Preencher_Talento_Informacao_Bancaria()
        {
            driver.FindElementById("nome").SendKeys("Giancarlos banco test");
            driver.FindElementById("cpf").SendKeys("00000000000");
            driver.FindElementById("banco").SendKeys("Itau");
            driver.FindElementById("agencia").SendKeys("0000");
            driver.FindElementById("conta").SendKeys("00000-0");

            driver.FindElementsByName("tipoconta")[0].Click();
            driver.FindElementsByName("dtipoconta")[1].Click();

            driver.FindElementsByClassName("btn-primary").FirstOrDefault(x => x.Text.ToLower().Equals("proximo")).Click();

            new WebDriverWait(driver, TimeSpan.FromSeconds(10))
                .Until(x => x.FindElements(By.TagName("h4")).Any(y => y.Text.Contains("Conhecimentos")));
        
        }

        [Fact]
        protected void Preencher_Talento_Conhecimento()
        {
            var conhecimentos = new List<string>();

            conhecimentos.Add("312294c7-b6c6-452b-a44e-2a680e7251ad");
            conhecimentos.Add("312294c7-b6c6-452b-a44e-2a680e7252ad");
            conhecimentos.Add("312294c7-b6c6-452b-a44e-2a680e7253ad");
            conhecimentos.Add("312294c7-b6c6-452b-a44e-2a680e7254ad");
            conhecimentos.Add("312294c7-b6c6-452b-a44e-2a680e7255ad");
            conhecimentos.Add("312294c7-b6c6-452b-a44e-2a680e7256ad");
            conhecimentos.Add("312294c7-b6c6-452b-a44e-2a680e7257ad");
            conhecimentos.Add("312294c7-b6c6-452b-a44e-2a680e7258ad");
            conhecimentos.Add("312294c7-b6c6-452b-a44e-2a680e7259ad");
            conhecimentos.Add("312294c7-b6c6-452b-a44e-2a680e7211ad");
            conhecimentos.Add("312294c7-b6c6-452b-a44e-2a680e7221ad");
            conhecimentos.Add("312294c7-b6c6-452b-a44e-2a680e7231ad");
            conhecimentos.Add("312294c7-b6c6-452b-a44e-2a680e7241ad");
            conhecimentos.Add("312294c7-b6c6-452b-a44e-2a680e7251ad");
            conhecimentos.Add("312294c7-b6c6-452b-a44e-2a680e7261ad");
            conhecimentos.Add("312294c7-b6c6-452b-a44e-2a680e7271ad");
            conhecimentos.Add("312294c7-b6c6-452b-a44e-2a680e7281ad");
            conhecimentos.Add("312294c7-b6c6-452b-a44e-2a680e7291ad");
            conhecimentos.Add("312294c7-b6c6-452b-a44e-2a680e7151ad");
            conhecimentos.Add("312294c7-b6c6-452b-a44e-2a680e7251ad");
            conhecimentos.Add("312294c7-b6c6-452b-a44e-2a680e7351ad");
            conhecimentos.Add("312294c7-b6c6-452b-a44e-2a680e7451ad");
            conhecimentos.Add("312294c7-b6c6-452b-a44e-2a680e7551ad");
            conhecimentos.Add("312294c7-b6c6-452b-a44e-2a680e7651ad");
            conhecimentos.Add("312294c7-b6c6-452b-a44e-2a680e7751ad");
            conhecimentos.Add("312294c7-b6c6-452b-a44e-2a680e7851ad");


            foreach (var item in conhecimentos)
            {
                driver.FindElementsByName(item)[new Random().Next(6)].Click();
            }

            driver.FindElementsByClassName("btn-primary").FirstOrDefault(x => x.Text.ToLower().Equals("enviar")).Click();

            new WebDriverWait(driver, TimeSpan.FromSeconds(60))
                .Until(x => x.FindElements(By.TagName("p")).Any(y => y.Text == "Talento cadastrado com sucesso."));
        }
    }
}
