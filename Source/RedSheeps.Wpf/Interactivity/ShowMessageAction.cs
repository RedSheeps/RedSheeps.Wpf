using System.Windows;
using System.Windows.Input;
using Microsoft.Xaml.Behaviors;

namespace RedSheeps.Wpf.Interactivity
{
    public class ShowMessageAction : TriggerAction<DependencyObject>
    {
        public static readonly DependencyProperty MessageProperty = DependencyProperty.Register(
            "Message", typeof(string), typeof(ShowMessageAction), new PropertyMetadata(default(string)));

        public string Message
        {
            get => (string) GetValue(MessageProperty);
            set => SetValue(MessageProperty, value);
        }

        public static readonly DependencyProperty CaptionProperty = DependencyProperty.Register(
            "Caption", typeof(string), typeof(ShowMessageAction), new PropertyMetadata(default(string)));

        public string Caption
        {
            get => (string) GetValue(CaptionProperty);
            set => SetValue(CaptionProperty, value);
        }

        public static readonly DependencyProperty MessageBoxButtonProperty = DependencyProperty.Register(
            "MessageBoxButton", typeof(MessageBoxButton), typeof(ShowMessageAction), new PropertyMetadata(default(MessageBoxButton)));

        public MessageBoxButton MessageBoxButton
        {
            get => (MessageBoxButton) GetValue(MessageBoxButtonProperty);
            set => SetValue(MessageBoxButtonProperty, value);
        }

        public static readonly DependencyProperty MessageBoxImageProperty = DependencyProperty.Register(
            "MessageBoxImage", typeof(MessageBoxImage), typeof(ShowMessageAction), new PropertyMetadata(default(MessageBoxImage)));

        public MessageBoxImage MessageBoxImage
        {
            get => (MessageBoxImage) GetValue(MessageBoxImageProperty);
            set => SetValue(MessageBoxImageProperty, value);
        }

        public static readonly DependencyProperty DefaultResultProperty = DependencyProperty.Register(
            "DefaultResult", typeof(MessageBoxResult), typeof(ShowMessageAction), new PropertyMetadata(MessageBoxResult.None));

        public MessageBoxResult DefaultResult
        {
            get => (MessageBoxResult ) GetValue(DefaultResultProperty);
            set => SetValue(DefaultResultProperty, value);
        }

        public static readonly DependencyProperty OptionsProperty = DependencyProperty.Register(
            "Options", typeof(MessageBoxOptions), typeof(ShowMessageAction), new PropertyMetadata(MessageBoxOptions.None));

        public MessageBoxOptions Options
        {
            get => (MessageBoxOptions) GetValue(OptionsProperty);
            set => SetValue(OptionsProperty, value);
        }

        public static readonly DependencyProperty PositiveCommandProperty = DependencyProperty.Register(
            "PositiveCommand", typeof(ICommand), typeof(ShowMessageAction), new PropertyMetadata(default(ICommand)));

        public ICommand PositiveCommand
        {
            get => (ICommand) GetValue(PositiveCommandProperty);
            set => SetValue(PositiveCommandProperty, value);
        }

        protected override void Invoke(object parameter)
        {
            var window = Window.GetWindow(AssociatedObject);
            var messageBoxResult = MessageDialog.Show(window, Message, Caption, MessageBoxButton, MessageBoxImage);
            if (parameter is ShowMessageEventArgs showMessageEventArgs)
                showMessageEventArgs.MessageBoxResult = messageBoxResult;

            if((messageBoxResult == MessageBoxResult.OK || messageBoxResult == MessageBoxResult.Yes)
                && PositiveCommand != null && PositiveCommand.CanExecute(null))
                PositiveCommand?.Execute(null);
        }
    }
}
