using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;
using Microsoft.Win32;

namespace RedSheeps.Wpf.Interactivity
{
    public class SaveFileAction : TriggerAction<DependencyObject>
    {
        public static readonly DependencyProperty InitialDirectoryProperty = DependencyProperty.Register(
            "InitialDirectory", typeof(string), typeof(SaveFileAction), new PropertyMetadata(default(string)));

        public string InitialDirectory
        {
            get => (string)GetValue(InitialDirectoryProperty);
            set => SetValue(InitialDirectoryProperty, value);
        }

        public static readonly DependencyProperty InitialSpecialDirectoryProperty = DependencyProperty.Register(
            "InitialSpecialDirectory", typeof(Environment.SpecialFolder?), typeof(SaveFileAction), new PropertyMetadata(default(Environment.SpecialFolder?)));

        public Environment.SpecialFolder? InitialSpecialDirectory
        {
            get => (Environment.SpecialFolder?)GetValue(InitialSpecialDirectoryProperty);
            set => SetValue(InitialSpecialDirectoryProperty, value);
        }


        public static readonly DependencyProperty DefaultExtProperty = DependencyProperty.Register(
            "DefaultExt", typeof(string), typeof(SaveFileAction), new PropertyMetadata(default(string)));

        public string DefaultExt
        {
            get => (string) GetValue(DefaultExtProperty);
            set => SetValue(DefaultExtProperty, value);
        }

        public static readonly DependencyProperty FileNameProperty =
            DependencyProperty.Register("FileName", typeof(string), typeof(SaveFileAction), new PropertyMetadata(default(string)));

        public string FileName
        {
            get => (string)GetValue(FileNameProperty);
            set => SetValue(FileNameProperty, value);
        }

        public static readonly DependencyProperty FilterProperty = DependencyProperty.Register(
            "Filter", typeof(string), typeof(SaveFileAction), new PropertyMetadata(default(string)));

        public string Filter
        {
            get => (string) GetValue(FilterProperty);
            set => SetValue(FilterProperty, value);
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(SaveFileAction), new PropertyMetadata(default(string)));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register("Command", typeof(ICommand), typeof(SaveFileAction), new PropertyMetadata(default(ICommand)));

        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        private string GetInitialDirectory() =>
            (InitialSpecialDirectory != null
                ? Environment.GetFolderPath(InitialSpecialDirectory.Value)
                : InitialDirectory) ?? string.Empty;


        protected override void Invoke(object parameter)
        {
            if(Command != null && Command.CanExecute(null))
            {
                var dialog = new SaveFileDialog
                {
                    InitialDirectory = GetInitialDirectory(),
                    DefaultExt = DefaultExt,
                    FileName = FileName,
                    Filter = Filter,
                    Title = Title
                };
                if (dialog.ShowDialog() == true)
                {
                    Command.Execute(dialog.FileName);
                }
            }
        }
    }
}
