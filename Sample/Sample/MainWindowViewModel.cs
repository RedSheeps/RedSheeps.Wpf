using RedSheeps.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
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

        public Command<CloseWindowActionEventArgs> CloseWindowCommand => new Command<CloseWindowActionEventArgs>(OnCloseWindow);

        public ICommand ShowMessageCommand => new Command(OnShowMessage);

        public INotification Notification { get; } = new Notification();

        public ICommand ShowConfirmCommand => new Command(OnShowConfirm);

        public INotification<ShowMessageEventArgs> NotificationConfirm { get; } = new Notification<ShowMessageEventArgs>();

        public ICommand PositiveCommand => new Command(OnPositive);

        public Command<CancelEventArgs> WindowClosingCommand => new Command<CancelEventArgs>(OnExecute);

        public INotification<ShowMessageEventArgs> ConfirmCloseWindow { get; } = new Notification<ShowMessageEventArgs>();

        private void OnExecute(CancelEventArgs e)
        {
            var showMessageEventArgs = new ShowMessageEventArgs();
            ConfirmCloseWindow.Notify(showMessageEventArgs);
            if (showMessageEventArgs.MessageBoxResult == MessageBoxResult.Cancel)
                e.Cancel = true;
        }

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

        bool close;
        private void OnCloseWindow(CloseWindowActionEventArgs e)
        {
            close = !close;
            e.Handle = close;
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
