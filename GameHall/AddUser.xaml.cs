using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Ink;
using System.Reflection;

namespace GameHall
{
    /// <summary>
    /// Interaction logic for AddUser.xaml
    /// </summary>
    public partial class AddUser
    {
        public AddUser()
        {
            InitializeComponent();
            BrushColorCombo.ItemsSource = typeof(Colors).GetProperties();
            PropertyInfo[] colors = BrushColorCombo.ItemsSource.Cast<PropertyInfo>().ToArray();
            for (int i = 0; i < colors.Length; i++)
            {
                if (colors[i].Name == "Black")
                {
                    BrushColorCombo.SelectedIndex = i;
                    break;
                }
            }
        }

        private void BrushSizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (PaintCanvas == null) return;

            var drawingAttributes = PaintCanvas.DefaultDrawingAttributes;
            drawingAttributes.Width = BrushSlider.Value;
            drawingAttributes.Height = BrushSlider.Value;
            PaintCanvas.EraserShape = new RectangleStylusShape(BrushSlider.Value, BrushSlider.Value);

            // From the help:
            // "If you change the EraserShape, the cursor rendered on the InkCanvas is not updated until the next EditingMode change."
            var previousEditingMode = PaintCanvas.EditingMode;
            PaintCanvas.EditingMode = InkCanvasEditingMode.None;
            PaintCanvas.EditingMode = previousEditingMode;
        }

        private void BrushColorCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Color selectedColor = (Color)(BrushColorCombo.SelectedItem as PropertyInfo).GetValue(null, null);
            PaintCanvas.DefaultDrawingAttributes.Color = selectedColor;
        }

        private void BrushStateCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PaintCanvas == null) return;

            // HACK: This is very hacky. Doing this as I know the order of the ComboBoxItems on the UI.
            // Best way would probably to get the selected item as an enum value.
            switch (BrushStateCombo.SelectedIndex)
            {
                case 0:
                    PaintCanvas.EditingMode = InkCanvasEditingMode.Ink;
                    break;
                case 1:
                    PaintCanvas.EditingMode = InkCanvasEditingMode.Select;
                    break;
                case 2:
                    PaintCanvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
                    break;
                case 3:
                    PaintCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
                    break;
            }
        }

        private void BrushShapesCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PaintCanvas == null) return;

            // HACK: This is very hacky. Doing this as I know the order of the ComboBoxItems on the UI.
            // Best way would probably to get the selected item as an enum value.
            switch (BrushShapesCombo.SelectedIndex)
            {
                case 0:
                    PaintCanvas.DefaultDrawingAttributes.StylusTip = StylusTip.Ellipse;
                    break;
                case 1:
                    PaintCanvas.DefaultDrawingAttributes.StylusTip = StylusTip.Rectangle;
                    break;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();                        
        }

        private void BtnCancel(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void BtnAdd(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}
