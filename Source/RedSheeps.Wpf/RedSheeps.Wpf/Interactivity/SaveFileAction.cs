using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interactivity;
using Microsoft.Win32;

namespace RedSheeps.Wpf.Interactivity
{
    public class SaveFileAction : TriggerAction<DependencyObject>
    {
        public static readonly DependencyProperty DefaultExtProperty = DependencyProperty.Register(
            "DefaultExt", typeof(string), typeof(SaveFileAction), new PropertyMetadata(default(string)));

        public string DefaultExt
        {
            get { return (string) GetValue(DefaultExtProperty); }
            set { SetValue(DefaultExtProperty, value); }
        }

        public static readonly DependencyProperty FilterProperty = DependencyProperty.Register(
            "Filter", typeof(string), typeof(SaveFileAction), new PropertyMetadata(default(string)));

        public string Filter
        {
            get { return (string) GetValue(FilterProperty); }
            set { SetValue(FilterProperty, value); }
        }

        protected override void Invoke(object parameter)
        {
            var dialog = new SaveFileDialog();
            dialog.DefaultExt = DefaultExt;
            dialog.Filter = Filter;
            if (dialog.ShowDialog() == true)
            {
                var fileName = dialog.FileName;
            }
        }
    }
}
