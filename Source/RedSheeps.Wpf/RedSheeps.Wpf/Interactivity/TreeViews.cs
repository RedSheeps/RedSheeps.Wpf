using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RedSheeps.Wpf.Interactivity
{
    public static partial class TreeViews
    {

        #region SelectedItemChanged
        public static readonly DependencyProperty SelectedItemChangedProperty =
            DependencyProperty.RegisterAttached("SelectedItemChanged", typeof(ICommand), typeof(TreeViews), new FrameworkPropertyMetadata(OnSelectedItemChangedChanged));

        public static ICommand GetSelectedItemChanged(DependencyObject target)
        {
            return (ICommand)target.GetValue(SelectedItemChangedProperty);
        }

        public static void SetSelectedItemChanged(DependencyObject target, ICommand value)
        {
            target.SetValue(SelectedItemChangedProperty, value);
        }

        private static void OnSelectedItemChangedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is TreeView target)
            {
                if (e.OldValue != null)
                {
                    target.SelectedItemChanged -= OnSelectedItemChanged;
                }
                if (e.NewValue != null)
                {
                    target.SelectedItemChanged += OnSelectedItemChanged;
                }
            }
        }

        private static void OnSelectedItemChanged(object o, RoutedPropertyChangedEventArgs<object> eventArgs)
        {
            var command = GetSelectedItemChanged((DependencyObject)o);
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
    }
}
