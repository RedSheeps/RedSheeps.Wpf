using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace RedSheeps.Wpf.Interactivity
{
    public static partial class RangeBases
    {
        #region ValueChanged
        public static readonly DependencyProperty ValueChangedProperty =
            DependencyProperty.RegisterAttached("ValueChanged", typeof(ICommand), typeof(RangeBases), new FrameworkPropertyMetadata(OnValueChangedChanged));

        public static ICommand GetValueChanged(DependencyObject target)
        {
            return (ICommand)target.GetValue(ValueChangedProperty);
        }

        public static void SetValueChanged(DependencyObject target, ICommand value)
        {
            target.SetValue(ValueChangedProperty, value);
        }

        private static void OnValueChangedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is RangeBase target)
            {
                if (e.OldValue != null)
                {
                    target.ValueChanged -= OnValueChanged;
                }
                if (e.NewValue != null)
                {
                    target.ValueChanged += OnValueChanged;
                }
            }
        }

        private static void OnValueChanged(object o, RoutedPropertyChangedEventArgs<double> eventArgs)
        {
            var command = GetValueChanged((DependencyObject)o);
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
    }
}
