using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baigiamasis_darbas.Test
{
    public class AruodasTest : BaseTest
    {
        [Test]
        public void AruodasPageTest()
        {
            _aruodasPage.NavigateToDefaultPage()
                 .AcceptAllCookies()
                .SelectDropdownButtonSavivaldybe()
                .SelectSavivaldybeFromDropdown()
                .SelectDropdownButonMikrorajonas()
                .SelectMikrorajonasFromDropdown()
                .ClickSelectMikrorajonasButton()
                .SelectDropdownButtonGatve()
                .SelectGatveFromDropdown()
                .ClickSelectGatveButton()
                .SelectDropdownButtonNamoTipas()
                .SelectNamoTipasFromDropdown()
                .ClickSelectNamoTipasButton()
                .SelectDropdownButtonPlotas()
                .SelectPlotasNuoMaziausiuFromDropdown()
                .SelectPlotasIkiDidziausiuFromDropdown()
                .SelectDropdownButtonIrengimas()
                .SelectIrengimasFromDropdown()
                .ClickSelectIrengimasButton()
                .SelectDropdownButtonKaina()
                .InsertKainaFrom("20000")
                .InsertKainaTill("500000")
                .ClickIssaugotiKainaButton()
                .ClickIssaugotiButton()
                .CheckResult("Skelbimų pagal Jūsų paieškos kriterijus neradome");
        }
        [TestCase("panyseva@yahoo.com", "slaptazodis123", true, false)]
        public void AruodasPage1Test(string elPastas, string slaptazodis, bool NoriuGautiAruodasLtNaujienlaiskius, bool SuPortaloTaisyklemisSutinku, string elPastas1, string slaptazodis1)
        {
            _aruodasPage1.NavigateToDefaultPage()
                .ClickCookiesButton()
                .ClickMeniuButton()
                .ClickPrisijungtiFromMeniuDropdown()
                .SelectButtonRegistruotis()
                .InputElPastoAdresas(elPastas)
                .InputSlaptazodis(slaptazodis)
                .InputElPastasAndSlaptazodis(elPastas, slaptazodis)
                .CheckResult("Labai stiprus slaptažodis")
                .ClickBoxNoriuGautiAruodasLtNaujienlaiskius(NoriuGautiAruodasLtNaujienlaiskius)
                .ClickBoxSuPortaloTaisyklemisSutinku(SuPortaloTaisyklemisSutinku)
                .ClickButtonRegistruotis();
        }
        [Test]
        public void AruodasPage2Test(string elPastas, string slaptazodis)
        {
            _aruodasPage2.NavigateToDefaultPage()
                .ClickCookiesButton()
                .ClickPrisijungtiButton()
                .InputElPastas(elPastas)
                .InputSlaptazodis(slaptazodis)
                .InputElPastasAndSlaptazodis(elPastas, slaptazodis);
        }
    }
}
