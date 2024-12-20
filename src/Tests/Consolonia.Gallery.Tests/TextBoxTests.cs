using System.Threading.Tasks;
using Avalonia.Input;
using Consolonia.Gallery.Tests.Base;
using Consolonia.NUnit;
using NUnit.Framework;

namespace Consolonia.Gallery.Tests
{
    [TestFixture]
    internal class TextBoxTests : GalleryTestsBaseBase
    {
        [Test]
        public async Task PerformSingleTest()
        {
            await UITest.KeyInput(Key.Tab);
            await UITest.KeyInput(Key.Right);
            await UITest.AssertHasText(@"elit\. ");
            await UITest.KeyInput(Key.Right);
            await UITest.StringInput("asd");
            await UITest.KeyInput(3, Key.Left, RawInputModifiers.Control);
            await UITest.AssertHasText(@"t, consectetur adipiscing elit\.asd");
            await UITest.KeyInput(Key.Home);
            await UITest.KeyInput(7, Key.Right, RawInputModifiers.Control);
            await UITest.AssertHasText("ipsum dolor sit amet, consectetur ");

            //readonly
            await UITest.KeyInput(Key.Tab);
            await UITest.StringInput("asdf");
            await UITest.AssertHasText("This is read only");
            await UITest.AssertHasText("ReadOnly watermark");
            await UITest.AssertHasText("This is disabled");
            await UITest.AssertHasText("This is disabled watermark");

            await UITest.KeyInput(Key.Tab);
            await UITest.KeyInput(Key.Tab);
            await UITest.KeyInput(Key.Delete);
            await UITest.AssertHasText("Floating Watermark");

            const string checkText = "asd3333";
            await UITest.StringInput(checkText);
            await UITest.AssertHasText("Floating Watermark");
            await UITest.AssertHasText(checkText);
        }
    }
}