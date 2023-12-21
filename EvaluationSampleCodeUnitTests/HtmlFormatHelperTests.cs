

using EvaluationSampleCode;

namespace EvaluationSampleCodeUnitTests
{
    [TestClass]
    public class HtmlFormatHelperTests
    {
        [TestMethod]
        public void GetBoldFormatTest_ShouldReturnBoldText()
        {
            var helper = new HtmlFormatHelper();
            var result = helper.GetBoldFormat("Hello Cedric");
            Assert.AreEqual("<b>Hello Cedric</b>", result);
        }

        [TestMethod]

        public void GetItalicFormatTest_ShouldReturnItalicText()
        {
            var helper = new HtmlFormatHelper();
            var result = helper.GetItalicFormat("Hello Cedric");
            Assert.AreEqual("<i>Hello Cedric</i>", result);
        }

        [TestMethod]
        public void GetFormattedListElementsTest_ShouldReturnFormattedList()
        {
            var helper = new HtmlFormatHelper();
            var result = helper.GetFormattedListElements(new List<string> { "Hello", "World" });
            Assert.AreEqual("<ul><li>Hello</li><li>World</li></ul>", result);
        }

    }
}
