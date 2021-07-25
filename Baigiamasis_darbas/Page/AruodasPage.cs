using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baigiamasis_darbas.Page
{
    public class AruodasPage : BasePage
    {
        private const string PageAddress = "https://m.aruodas.lt/?obj=2&change_region=1";

        //private IWebElement _Cookies => Driver.FindElement(By.XPath("/html/body/div[2]/div[3]/div/div[1]/div/div[2]/div/button[1]"));
        private IWebElement _SelectSavivaldybe => Driver.FindElement(By.XPath("/html/body/div[1]/div/div[3]/div[1]/div/ul[3]/li[1]/a[1]"));
        private IWebElement _TextElementSavivaldybe => Driver.FindElement(By.CssSelector("body > div.popup-window > ul:nth-child(3) > li:nth-child(7) > a"));

        private IWebElement _SelectMikrorajona => Driver.FindElement(By.CssSelector("#searchFilterFQuartal > a"));
        private IWebElement _TextElementMikrorajonas => Driver.FindElement(By.CssSelector("#multiSelectList > li:nth-child(3) > label > span.filter-checkbox"));
        private IWebElement _TextElementMikrorajonasSelectButton => Driver.FindElement(By.Id("submitSelect1"));
        private IWebElement _SelectGatve => Driver.FindElement(By.CssSelector("#searchFilterFStreets > a"));
        private IWebElement _TextElementGatve => Driver.FindElement(By.CssSelector("#multiSelectList > li:nth-child(2) > label > span.filter-checkbox"));
        private IWebElement _TextElementGatveSelectButton => Driver.FindElement(By.Id("submitSelect1"));
        private IWebElement _SelectNamoTipas => Driver.FindElement(By.CssSelector("#searchFilterFBuildingType > a"));
        private IWebElement _TextElementNamoTipas => Driver.FindElement(By.CssSelector("#multiSelectList > li:nth-child(7) > label > span.filter-checkbox"));
        private IWebElement _TextElementNamoTipasSelectButton => Driver.FindElement(By.Id("submitSelect1"));
        private IWebElement _SelectPlotas => Driver.FindElement(By.CssSelector("#searchFilterFAreaOverAll > a"));
        private IWebElement _TextElementPlotasNuoMaziausiu => Driver.FindElement(By.CssSelector("#itemMin20 > label > span"));

        private IWebElement _TextElementPlotasIkiDidziausiu => Driver.FindElement(By.CssSelector("#itemMax300 > label > span"));
        private IWebElement _SelectIrengimas => Driver.FindElement(By.CssSelector("#searchFilterFHouseState > a"));
        private IWebElement _TextElementIrengimas => Driver.FindElement(By.CssSelector("#multiSelectList > li:nth-child(2) > label > span.filter-checkbox"));
        private IWebElement _TextElementIrengimasSelectButton => Driver.FindElement(By.Id("submitSelect1"));
        private IWebElement _SelectKaina => Driver.FindElement(By.CssSelector("#searchFilterFPrice > a"));
        private IWebElement _KainaInsertFieldFrom => Driver.FindElement(By.Id("customValueFrom"));
        private IWebElement _KainaInsertFieldTill => Driver.FindElement(By.Id("customValueTill"));
        private IWebElement _ClickIssaugotiKainaButton => Driver.FindElement(By.CssSelector("#buttonSaveInputs > button"));
        private IWebElement _ClickIssaugotiButton => Driver.FindElement(By.Id("submit_search_button"));
        private IWebElement _Result => Driver.FindElement(By.CssSelector("#divBodyContainer > div.body-content-container > div.error-message"));
        public AruodasPage(IWebDriver webdriver) : base(webdriver)
        {
        }
        public AruodasPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }
        public AruodasPage AcceptAllCookies()
        {
            Cookie myCookie = new Cookie("CookieConsent",
                "CPJ4-MQPJ4-MQAcABBENBkCsAP_AAH_AAChQIGNf_X__b3_j-_59f_t0eY1P9_7_v-0zjhfdt-8N2f_X_L8X42M7vF36pq4KuR4Eu3LBIQdlHOHcTUmw6okVrzPsbk2Mr7NKJ7PEmnMbO2dYGH9_n93TuZKY7__8___z__-v_v____f_r-3_3__59X---_e_V399zLv9_____9nN___BAwAkw1L6ALsSxwZNo0qhRAjCsJDoBQAUUAwtE1hAyuCnZXAR6ghYAITUBGBECDEFGLAIABAIAkIiAkAPBAIgCIBAACAFSAhAARsAgsALAwCAAUA0LECKAIQJCDI4KjlMCAiRaKCeysASi72NMIQyiwAoFH9FRgIlCCBYGQkLBzHAEgIAAAAA.f_gAD_gAAAAA",
            "https://m.aruodas.lt/?obj=2&change_region=1",
                "/",
                DateTime.Now.AddDays(30));
            Driver.Manage().Cookies.AddCookie(myCookie);
            Driver.Navigate().Refresh();
            return this;
        }
        public AruodasPage SelectDropdownButtonSavivaldybe()
        {
            _SelectSavivaldybe.Click();
            return this;
        }
        public AruodasPage SelectSavivaldybeFromDropdown()
        {
            _TextElementSavivaldybe.Click();
            return this;
        }
        public AruodasPage SelectDropdownButonMikrorajonas()
        {
            _SelectMikrorajona.Click();
            return this;
        }
        public AruodasPage SelectMikrorajonasFromDropdown()
        {
            _TextElementMikrorajonas.Click();
            return this;
        }
        public AruodasPage ClickSelectMikrorajonasButton()
        {
            _TextElementMikrorajonasSelectButton.Click();
            return this;
        }
        public AruodasPage SelectDropdownButtonGatve()
        {
            _SelectGatve.Click();
            return this;
        }
        public AruodasPage SelectGatveFromDropdown()
        {
            _TextElementGatve.Click();
            return this;
        }
        public AruodasPage ClickSelectGatveButton()
        {
            _TextElementGatveSelectButton.Click();
            return this;
        }
        public AruodasPage SelectDropdownButtonNamoTipas()
        {
            _SelectNamoTipas.Click();
            return this;
        }
        public AruodasPage SelectNamoTipasFromDropdown()
        {
            _TextElementNamoTipas.Click();
            return this;
        }
        public AruodasPage ClickSelectNamoTipasButton()
        {
            _TextElementNamoTipasSelectButton.Click();
            return this;
        }
        public AruodasPage SelectDropdownButtonPlotas()
        {
            _SelectPlotas.Click();
            return this;
        }
        public AruodasPage SelectPlotasNuoMaziausiuFromDropdown()
        {
            _TextElementPlotasNuoMaziausiu.Click();
            return this;
        }
        public AruodasPage SelectPlotasIkiDidziausiuFromDropdown()
        {
            _TextElementPlotasIkiDidziausiu.Click();
            return this;
        }
        public AruodasPage SelectDropdownButtonIrengimas()
        {
            _SelectIrengimas.Click();
            return this;
        }
        public AruodasPage SelectIrengimasFromDropdown()
        {
            _TextElementIrengimas.Click();
            return this;
        }
        public AruodasPage ClickSelectIrengimasButton()
        {
            _TextElementIrengimasSelectButton.Click();
            return this;
        }
        public AruodasPage SelectDropdownButtonKaina()
        {
            _SelectKaina.Click();
            return this;
        }
        public AruodasPage InsertKainaFrom(string kaina)
        {
            _KainaInsertFieldFrom.Click();
            _KainaInsertFieldFrom.Clear();
            _KainaInsertFieldFrom.SendKeys(kaina);
            return this;
        }
        public AruodasPage InsertKainaTill(string kaina)
        {
            _KainaInsertFieldTill.Click();
            _KainaInsertFieldTill.Clear();
            _KainaInsertFieldTill.SendKeys(kaina);
            return this;
        }
        public AruodasPage ClickIssaugotiKainaButton()
        {
            _ClickIssaugotiKainaButton.Click();
            return this;
        }
        public AruodasPage ClickIssaugotiButton()
        {
            _ClickIssaugotiButton.Click();
            return this;
        }
        public AruodasPage CheckResult(string result)
        {

            Assert.IsTrue(_Result.Text.Equals("Skelbimų pagal Jūsų paieškos kriterijus neradome"));
            return this;
        }
    }
}
