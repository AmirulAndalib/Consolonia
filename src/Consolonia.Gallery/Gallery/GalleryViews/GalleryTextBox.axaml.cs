using Avalonia.Controls;
using Avalonia.Input.TextInput;
using Avalonia.Markup.Xaml;

namespace Consolonia.Gallery.Gallery.GalleryViews
{
    [GalleryOrder(80)]
    public class GalleryTextBox : UserControl
    {
        public GalleryTextBox()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            var textBox = this.Find<TextBox>("numericWatermark");
            if (textBox != null)
                textBox
                    .TextInputOptionsQuery += (_, a) => { a.ContentType = TextInputContentType.Number; };
        }
    }
}