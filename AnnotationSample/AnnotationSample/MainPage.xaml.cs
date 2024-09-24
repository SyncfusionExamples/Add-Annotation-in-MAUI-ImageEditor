using Syncfusion.Maui.ImageEditor;
namespace AnnotationSample
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnImageEditorLoaded(object sender, EventArgs e)
        {
            imageEditor.AddText("Good day", new ImageEditorTextSettings() { Id = 1, Background = Colors.Teal });
            imageEditor.SaveEdits();
        }

        private void SelectShape_Clicked(object sender, EventArgs e)
        {
            int shapeId;
            if (int.TryParse(shape.Text, out shapeId))
            {
                imageEditor.SelectAnnotation(shapeId);
            }
        }

    }

}
