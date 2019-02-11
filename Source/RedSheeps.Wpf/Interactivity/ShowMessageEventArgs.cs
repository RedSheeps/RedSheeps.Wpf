using System;
using System.Windows;

namespace RedSheeps.Wpf.Interactivity
{
    public class ShowMessageEventArgs : EventArgs
    {
        public MessageBoxResult MessageBoxResult { get; set; }
    }
}