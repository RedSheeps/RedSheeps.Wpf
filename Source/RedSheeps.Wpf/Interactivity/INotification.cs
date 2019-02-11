using System;
using System.Windows.Input;

namespace RedSheeps.Wpf.Interactivity
{
    public interface INotification
    {
        event EventHandler Notified;
        void Notify();
    }

    public interface INotification<in TEventArgs> : INotification where TEventArgs : EventArgs
    {
        void Notify(TEventArgs eventArgs);
    }
}