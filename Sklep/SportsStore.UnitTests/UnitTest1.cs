using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using SportsStore.WebUI.Controllers;
using SportsStore.WebUI.Models;
using SportsStore.WebUI.HtmlHelpers;
namespace SportsStore.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Paginate()
        {
            // …polecenie usunięte w celu zachowania zwięzłości…
        }
        [TestMethod]
        public void Can_Generate_Page_Links()
        {
            // przygotowanie — definiowanie metody pomocniczej HTML — potrzebujemy tego,
            // aby użyć metody rozszerzającej
            HtmlHelper myHelper = null;
            // przygotowanie — tworzenie danych PagingInfo
            PagingInfo pagingInfo = new PagingInfo
            {
                CurrentPage = 2,
                TotalItems = 28,
                ItemsPerPage = 10
            };
            // przygotowanie — konfigurowanie delegatu z użyciem wyrażenia lambda
            Func<int, string> pageUrlDelegate = i => "Strona" + i;
            // działanie
            MvcHtmlString result = myHelper.PageLinks(pagingInfo, pageUrlDelegate);
            // asercje
            Assert.AreEqual(@"<a class=""btn btn-default"" href=""Strona1"">1</a>"
            + @"<a class="" btn btn-default btn-primary selected"" href=""Strona2"">2</a>"
            + @"<a class=""btn btn-default"" href=""Strona3"">3</a>", result.ToString());
        }
    }
}