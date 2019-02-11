namespace RedSheeps.Wpf.Controls
{
    public class FantImage : System.Windows.Controls.Image
    {
        protected override void OnRender(System.Windows.Media.DrawingContext dc)
        {
            VisualBitmapScalingMode = System.Windows.Media.BitmapScalingMode.Fant;
            base.OnRender(dc);
        }
    }
}
