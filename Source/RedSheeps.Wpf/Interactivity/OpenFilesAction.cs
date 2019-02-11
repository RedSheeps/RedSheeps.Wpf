using Microsoft.Win32;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace RedSheeps.Wpf.Interactivity
{
    public class OpenFilesAction : TriggerAction<DependencyObject>
    {
        #region Dependency Properties
        public static readonly DependencyProperty DefaultExtProperty = DependencyProperty.Register(
            "DefaultExt", typeof(string), typeof(OpenFilesAction), new PropertyMetadata(default(string)));

        public string DefaultExt
        {
            get => (string)GetValue(DefaultExtProperty);
            set => SetValue(DefaultExtProperty, value);
        }

        public static readonly DependencyProperty FileNameProperty =
            DependencyProperty.Register("FileName", typeof(string), typeof(OpenFilesAction), new PropertyMetadata(default(string)));

        public string FileName
        {
            get => (string)GetValue(FileNameProperty);
            set => SetValue(FileNameProperty, value);
        }

        public static readonly DependencyProperty FilterProperty = DependencyProperty.Register(
            "Filter", typeof(string), typeof(OpenFilesAction), new PropertyMetadata(default(string)));

        public string Filter
        {
            get => (string)GetValue(FilterProperty);
            set => SetValue(FilterProperty, value);
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(OpenFilesAction), new PropertyMetadata(default(string)));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register("Command", typeof(ICommand), typeof(OpenFilesAction), new PropertyMetadata(default(ICommand)));

        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        #endregion

        protected override void Invoke(object parameter)
        {
            if (Command != null && Command.CanExecute(null))
            {
                var dialog = new OpenFileDialog
                {
                    DefaultExt = DefaultExt,
                    FileName = FileName,
                    Filter = Filter,
                    Title = Title,
                    Multiselect = true
                };
                if (dialog.ShowDialog() == true)
                {
                    Command.Execute(dialog.FileNames);
                }
            }
        }
    }
}
