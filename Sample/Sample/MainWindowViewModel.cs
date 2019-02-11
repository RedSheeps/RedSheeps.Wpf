using RedSheeps.Wpf.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Input;
using RedSheeps.Wpf.Interactivity;

namespace Sample
{
    public class MainWindowViewModel
    {
        public ICommand InitializeCommand => new Command(OnInitialize);

        public string FileName => DateTime.Today.ToString("yyyyMMdd");

        public Command<string> SaveFileCommand => new Command<string>(OnSaveFile);

        public Command<string> OpenFileCommand => new Command<string>(OnOpenFile);
        public Command<IEnumerable<string>> OpenFilesCommand => new Command<IEnumerable<string>>(OnOpenFiles);

        public ICommand ShowMessageCommand => new Command(OnShowMessage);

        public INotification Notification { get; } = new Notification();

        public ICommand ShowConfirmCommand => new Command(OnShowConfirm);

        public INotification<ShowMessageEventArgs> NotificationConfirm { get; } = new Notification<ShowMessageEventArgs>();

        public ICommand PositiveCommand => new Command(OnPositive);

        private void OnInitialize()
        {
            
        }

        private void OnSaveFile(string fileName)
        {

        }

        private void OnOpenFile(string fileName)
        {

        }

        private void OnOpenFiles(IEnumerable<string> fileNames)
        {

        }

        private void OnShowMessage()
        {
            Notification.Notify();
        }

        private void OnShowConfirm()
        {
            var showMessageEventArgs = new ShowMessageEventArgs();
            NotificationConfirm.Notify(showMessageEventArgs);
            Debug.WriteLine(showMessageEventArgs.MessageBoxResult);
        }

        private void OnPositive()
        {
        }
    }
}
