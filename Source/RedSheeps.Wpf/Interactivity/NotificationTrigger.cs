using System;
using System.Windows;
using Microsoft.Xaml.Behaviors;

namespace RedSheeps.Wpf.Interactivity
{
    public class NotificationTrigger : TriggerBase<DependencyObject>
    {
        public static readonly DependencyProperty NotificationProperty = DependencyProperty.Register(
            "Notification", typeof(INotification), typeof(NotificationTrigger), new PropertyMetadata(default(INotification), OnNotificationChanged));

        public INotification Notification
        {
            get => (INotification) GetValue(NotificationProperty);
            set => SetValue(NotificationProperty, value);
        }

        private static void OnNotificationChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

            ((NotificationTrigger) d).UpdateNotification(
                (INotification)e.NewValue,
                (INotification)e.OldValue);
        }

        private void UpdateNotification(INotification newValue, INotification oldValue)
        {
            if (newValue != null) newValue.Notified += OnNotified;
            if (oldValue != null) oldValue.Notified -= OnNotified;
        }

        private void OnNotified(object sender, EventArgs e)
        {
            InvokeActions(e);
        }

        protected override void OnDetaching()
        {
            if (Notification != null) Notification.Notified -= OnNotified;
            base.OnDetaching();
        }
    }
}
