using System;

namespace RedSheeps.Wpf.Interactivity
{
    public class Notification<TEventArgs> : INotification<TEventArgs> where TEventArgs : EventArgs
    {
        public event EventHandler Notified;

        public void Notify(TEventArgs eventArgs)
        {
            Notified?.Invoke(this, eventArgs);
        }

        public void Notify()
        {
            Notified?.Invoke(this, EventArgs.Empty);
        }
    }

    public class Notification : INotification
    {
        public event EventHandler Notified;
        public void Notify()
        {
            Notified?.Invoke(this, EventArgs.Empty);
        }
    }
}