using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace RedSheeps.Wpf.Interactivity
{
    public class CloseWindowAction : TriggerAction<DependencyObject>
    {


        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register("Command", typeof(ICommand), typeof(CloseWindowAction), new PropertyMetadata(default(ICommand)));


        protected override void Invoke(object parameter)
        {
            if(Command == null)
            {
                Window.GetWindow(AssociatedObject)?.Close();
                return;
            }

            var eventArgs = new CloseWindowActionEventArgs();
            if(Command.CanExecute(eventArgs))
            {
                Command.Execute(eventArgs);
                if(!eventArgs.Handle)
                    Window.GetWindow(AssociatedObject)?.Close();
            }
        }
    }
}
