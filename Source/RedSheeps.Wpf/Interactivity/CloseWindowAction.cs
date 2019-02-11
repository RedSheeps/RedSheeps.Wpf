using System.Windows;
using System.Windows.Interactivity;

namespace RedSheeps.Wpf.Interactivity
{
    public class CloseWindowAction : TriggerAction<DependencyObject>
    {
        protected override void Invoke(object parameter)
        {
            Window.GetWindow(AssociatedObject)?.Close();
        }
    }
}
