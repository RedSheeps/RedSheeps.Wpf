using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Documents;
using System.Windows.Ink;
using System.ComponentModel;

namespace RedSheeps.Wpf.Interactivity {

	#region Calendars
	public static partial class Calendars {
        
        #region DisplayDateChanged
        public static readonly DependencyProperty DisplayDateChangedProperty =
            DependencyProperty.RegisterAttached("DisplayDateChanged", typeof(ICommand), typeof(Calendars), new FrameworkPropertyMetadata(OnDisplayDateChangedChanged));
        
        public static ICommand GetDisplayDateChanged(DependencyObject target)
        {
            return (ICommand)target.GetValue(DisplayDateChangedProperty);
        }
        
        public static void SetDisplayDateChanged(DependencyObject target, ICommand value)
        {
            target.SetValue(DisplayDateChangedProperty, value);
        }
        
        private static void OnDisplayDateChangedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Calendar target)
            {
                if (e.OldValue != null)
                {
                    target.DisplayDateChanged -= OnDisplayDateChanged;
                }
                if (e.NewValue != null)
                {
                    target.DisplayDateChanged += OnDisplayDateChanged;
                }
            }
        }
        
        private static void OnDisplayDateChanged(object o, CalendarDateChangedEventArgs eventArgs)
        {
            var command = GetDisplayDateChanged((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region DisplayDateChangedNotifyAddedDate
        public static readonly DependencyProperty DisplayDateChangedNotifyAddedDateProperty =
            DependencyProperty.RegisterAttached("DisplayDateChangedNotifyAddedDate", typeof(ICommand), typeof(Calendars), new FrameworkPropertyMetadata(OnDisplayDateChangedNotifyAddedDateChanged));
        
        public static ICommand GetDisplayDateChangedNotifyAddedDate(DependencyObject target)
        {
            return (ICommand)target.GetValue(DisplayDateChangedNotifyAddedDateProperty);
        }
        
        public static void SetDisplayDateChangedNotifyAddedDate(DependencyObject target, ICommand value)
        {
            target.SetValue(DisplayDateChangedNotifyAddedDateProperty, value);
        }
        
        private static void OnDisplayDateChangedNotifyAddedDateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Calendar target)
            {
                if (e.OldValue != null)
                {
                    target.DisplayDateChanged -= OnDisplayDateChangedNotifyAddedDate;
                }
                if (e.NewValue != null)
                {
                    target.DisplayDateChanged += OnDisplayDateChangedNotifyAddedDate;
                }
            }
        }
        
        private static void OnDisplayDateChangedNotifyAddedDate(object o, System.Windows.Controls.CalendarDateChangedEventArgs eventArgs)
        {
            var command = GetDisplayDateChangedNotifyAddedDate((DependencyObject)o);
            if (command.CanExecute(eventArgs.AddedDate))
                command.Execute(eventArgs.AddedDate);
        }
        #endregion
        
        #region DisplayDateChangedNotifyRemovedDate
        public static readonly DependencyProperty DisplayDateChangedNotifyRemovedDateProperty =
            DependencyProperty.RegisterAttached("DisplayDateChangedNotifyRemovedDate", typeof(ICommand), typeof(Calendars), new FrameworkPropertyMetadata(OnDisplayDateChangedNotifyRemovedDateChanged));
        
        public static ICommand GetDisplayDateChangedNotifyRemovedDate(DependencyObject target)
        {
            return (ICommand)target.GetValue(DisplayDateChangedNotifyRemovedDateProperty);
        }
        
        public static void SetDisplayDateChangedNotifyRemovedDate(DependencyObject target, ICommand value)
        {
            target.SetValue(DisplayDateChangedNotifyRemovedDateProperty, value);
        }
        
        private static void OnDisplayDateChangedNotifyRemovedDateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Calendar target)
            {
                if (e.OldValue != null)
                {
                    target.DisplayDateChanged -= OnDisplayDateChangedNotifyRemovedDate;
                }
                if (e.NewValue != null)
                {
                    target.DisplayDateChanged += OnDisplayDateChangedNotifyRemovedDate;
                }
            }
        }
        
        private static void OnDisplayDateChangedNotifyRemovedDate(object o, System.Windows.Controls.CalendarDateChangedEventArgs eventArgs)
        {
            var command = GetDisplayDateChangedNotifyRemovedDate((DependencyObject)o);
            if (command.CanExecute(eventArgs.RemovedDate))
                command.Execute(eventArgs.RemovedDate);
        }
        #endregion
        
        #region DisplayDateChangedNotifyRoutedEvent
        public static readonly DependencyProperty DisplayDateChangedNotifyRoutedEventProperty =
            DependencyProperty.RegisterAttached("DisplayDateChangedNotifyRoutedEvent", typeof(ICommand), typeof(Calendars), new FrameworkPropertyMetadata(OnDisplayDateChangedNotifyRoutedEventChanged));
        
        public static ICommand GetDisplayDateChangedNotifyRoutedEvent(DependencyObject target)
        {
            return (ICommand)target.GetValue(DisplayDateChangedNotifyRoutedEventProperty);
        }
        
        public static void SetDisplayDateChangedNotifyRoutedEvent(DependencyObject target, ICommand value)
        {
            target.SetValue(DisplayDateChangedNotifyRoutedEventProperty, value);
        }
        
        private static void OnDisplayDateChangedNotifyRoutedEventChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Calendar target)
            {
                if (e.OldValue != null)
                {
                    target.DisplayDateChanged -= OnDisplayDateChangedNotifyRoutedEvent;
                }
                if (e.NewValue != null)
                {
                    target.DisplayDateChanged += OnDisplayDateChangedNotifyRoutedEvent;
                }
            }
        }
        
        private static void OnDisplayDateChangedNotifyRoutedEvent(object o, System.Windows.Controls.CalendarDateChangedEventArgs eventArgs)
        {
            var command = GetDisplayDateChangedNotifyRoutedEvent((DependencyObject)o);
            if (command.CanExecute(eventArgs.RoutedEvent))
                command.Execute(eventArgs.RoutedEvent);
        }
        #endregion
        
        #region DisplayDateChangedNotifyHandled
        public static readonly DependencyProperty DisplayDateChangedNotifyHandledProperty =
            DependencyProperty.RegisterAttached("DisplayDateChangedNotifyHandled", typeof(ICommand), typeof(Calendars), new FrameworkPropertyMetadata(OnDisplayDateChangedNotifyHandledChanged));
        
        public static ICommand GetDisplayDateChangedNotifyHandled(DependencyObject target)
        {
            return (ICommand)target.GetValue(DisplayDateChangedNotifyHandledProperty);
        }
        
        public static void SetDisplayDateChangedNotifyHandled(DependencyObject target, ICommand value)
        {
            target.SetValue(DisplayDateChangedNotifyHandledProperty, value);
        }
        
        private static void OnDisplayDateChangedNotifyHandledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Calendar target)
            {
                if (e.OldValue != null)
                {
                    target.DisplayDateChanged -= OnDisplayDateChangedNotifyHandled;
                }
                if (e.NewValue != null)
                {
                    target.DisplayDateChanged += OnDisplayDateChangedNotifyHandled;
                }
            }
        }
        
        private static void OnDisplayDateChangedNotifyHandled(object o, System.Windows.Controls.CalendarDateChangedEventArgs eventArgs)
        {
            var command = GetDisplayDateChangedNotifyHandled((DependencyObject)o);
            if (command.CanExecute(eventArgs.Handled))
                command.Execute(eventArgs.Handled);
        }
        #endregion
        
        #region DisplayDateChangedNotifySource
        public static readonly DependencyProperty DisplayDateChangedNotifySourceProperty =
            DependencyProperty.RegisterAttached("DisplayDateChangedNotifySource", typeof(ICommand), typeof(Calendars), new FrameworkPropertyMetadata(OnDisplayDateChangedNotifySourceChanged));
        
        public static ICommand GetDisplayDateChangedNotifySource(DependencyObject target)
        {
            return (ICommand)target.GetValue(DisplayDateChangedNotifySourceProperty);
        }
        
        public static void SetDisplayDateChangedNotifySource(DependencyObject target, ICommand value)
        {
            target.SetValue(DisplayDateChangedNotifySourceProperty, value);
        }
        
        private static void OnDisplayDateChangedNotifySourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Calendar target)
            {
                if (e.OldValue != null)
                {
                    target.DisplayDateChanged -= OnDisplayDateChangedNotifySource;
                }
                if (e.NewValue != null)
                {
                    target.DisplayDateChanged += OnDisplayDateChangedNotifySource;
                }
            }
        }
        
        private static void OnDisplayDateChangedNotifySource(object o, System.Windows.Controls.CalendarDateChangedEventArgs eventArgs)
        {
            var command = GetDisplayDateChangedNotifySource((DependencyObject)o);
            if (command.CanExecute(eventArgs.Source))
                command.Execute(eventArgs.Source);
        }
        #endregion
        
        #region DisplayDateChangedNotifyOriginalSource
        public static readonly DependencyProperty DisplayDateChangedNotifyOriginalSourceProperty =
            DependencyProperty.RegisterAttached("DisplayDateChangedNotifyOriginalSource", typeof(ICommand), typeof(Calendars), new FrameworkPropertyMetadata(OnDisplayDateChangedNotifyOriginalSourceChanged));
        
        public static ICommand GetDisplayDateChangedNotifyOriginalSource(DependencyObject target)
        {
            return (ICommand)target.GetValue(DisplayDateChangedNotifyOriginalSourceProperty);
        }
        
        public static void SetDisplayDateChangedNotifyOriginalSource(DependencyObject target, ICommand value)
        {
            target.SetValue(DisplayDateChangedNotifyOriginalSourceProperty, value);
        }
        
        private static void OnDisplayDateChangedNotifyOriginalSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Calendar target)
            {
                if (e.OldValue != null)
                {
                    target.DisplayDateChanged -= OnDisplayDateChangedNotifyOriginalSource;
                }
                if (e.NewValue != null)
                {
                    target.DisplayDateChanged += OnDisplayDateChangedNotifyOriginalSource;
                }
            }
        }
        
        private static void OnDisplayDateChangedNotifyOriginalSource(object o, System.Windows.Controls.CalendarDateChangedEventArgs eventArgs)
        {
            var command = GetDisplayDateChangedNotifyOriginalSource((DependencyObject)o);
            if (command.CanExecute(eventArgs.OriginalSource))
                command.Execute(eventArgs.OriginalSource);
        }
        #endregion
        
        #region DisplayModeChanged
        public static readonly DependencyProperty DisplayModeChangedProperty =
            DependencyProperty.RegisterAttached("DisplayModeChanged", typeof(ICommand), typeof(Calendars), new FrameworkPropertyMetadata(OnDisplayModeChangedChanged));
        
        public static ICommand GetDisplayModeChanged(DependencyObject target)
        {
            return (ICommand)target.GetValue(DisplayModeChangedProperty);
        }
        
        public static void SetDisplayModeChanged(DependencyObject target, ICommand value)
        {
            target.SetValue(DisplayModeChangedProperty, value);
        }
        
        private static void OnDisplayModeChangedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Calendar target)
            {
                if (e.OldValue != null)
                {
                    target.DisplayModeChanged -= OnDisplayModeChanged;
                }
                if (e.NewValue != null)
                {
                    target.DisplayModeChanged += OnDisplayModeChanged;
                }
            }
        }
        
        private static void OnDisplayModeChanged(object o, CalendarModeChangedEventArgs eventArgs)
        {
            var command = GetDisplayModeChanged((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region DisplayModeChangedNotifyNewMode
        public static readonly DependencyProperty DisplayModeChangedNotifyNewModeProperty =
            DependencyProperty.RegisterAttached("DisplayModeChangedNotifyNewMode", typeof(ICommand), typeof(Calendars), new FrameworkPropertyMetadata(OnDisplayModeChangedNotifyNewModeChanged));
        
        public static ICommand GetDisplayModeChangedNotifyNewMode(DependencyObject target)
        {
            return (ICommand)target.GetValue(DisplayModeChangedNotifyNewModeProperty);
        }
        
        public static void SetDisplayModeChangedNotifyNewMode(DependencyObject target, ICommand value)
        {
            target.SetValue(DisplayModeChangedNotifyNewModeProperty, value);
        }
        
        private static void OnDisplayModeChangedNotifyNewModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Calendar target)
            {
                if (e.OldValue != null)
                {
                    target.DisplayModeChanged -= OnDisplayModeChangedNotifyNewMode;
                }
                if (e.NewValue != null)
                {
                    target.DisplayModeChanged += OnDisplayModeChangedNotifyNewMode;
                }
            }
        }
        
        private static void OnDisplayModeChangedNotifyNewMode(object o, System.Windows.Controls.CalendarModeChangedEventArgs eventArgs)
        {
            var command = GetDisplayModeChangedNotifyNewMode((DependencyObject)o);
            if (command.CanExecute(eventArgs.NewMode))
                command.Execute(eventArgs.NewMode);
        }
        #endregion
        
        #region DisplayModeChangedNotifyOldMode
        public static readonly DependencyProperty DisplayModeChangedNotifyOldModeProperty =
            DependencyProperty.RegisterAttached("DisplayModeChangedNotifyOldMode", typeof(ICommand), typeof(Calendars), new FrameworkPropertyMetadata(OnDisplayModeChangedNotifyOldModeChanged));
        
        public static ICommand GetDisplayModeChangedNotifyOldMode(DependencyObject target)
        {
            return (ICommand)target.GetValue(DisplayModeChangedNotifyOldModeProperty);
        }
        
        public static void SetDisplayModeChangedNotifyOldMode(DependencyObject target, ICommand value)
        {
            target.SetValue(DisplayModeChangedNotifyOldModeProperty, value);
        }
        
        private static void OnDisplayModeChangedNotifyOldModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Calendar target)
            {
                if (e.OldValue != null)
                {
                    target.DisplayModeChanged -= OnDisplayModeChangedNotifyOldMode;
                }
                if (e.NewValue != null)
                {
                    target.DisplayModeChanged += OnDisplayModeChangedNotifyOldMode;
                }
            }
        }
        
        private static void OnDisplayModeChangedNotifyOldMode(object o, System.Windows.Controls.CalendarModeChangedEventArgs eventArgs)
        {
            var command = GetDisplayModeChangedNotifyOldMode((DependencyObject)o);
            if (command.CanExecute(eventArgs.OldMode))
                command.Execute(eventArgs.OldMode);
        }
        #endregion
        
        #region DisplayModeChangedNotifyRoutedEvent
        public static readonly DependencyProperty DisplayModeChangedNotifyRoutedEventProperty =
            DependencyProperty.RegisterAttached("DisplayModeChangedNotifyRoutedEvent", typeof(ICommand), typeof(Calendars), new FrameworkPropertyMetadata(OnDisplayModeChangedNotifyRoutedEventChanged));
        
        public static ICommand GetDisplayModeChangedNotifyRoutedEvent(DependencyObject target)
        {
            return (ICommand)target.GetValue(DisplayModeChangedNotifyRoutedEventProperty);
        }
        
        public static void SetDisplayModeChangedNotifyRoutedEvent(DependencyObject target, ICommand value)
        {
            target.SetValue(DisplayModeChangedNotifyRoutedEventProperty, value);
        }
        
        private static void OnDisplayModeChangedNotifyRoutedEventChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Calendar target)
            {
                if (e.OldValue != null)
                {
                    target.DisplayModeChanged -= OnDisplayModeChangedNotifyRoutedEvent;
                }
                if (e.NewValue != null)
                {
                    target.DisplayModeChanged += OnDisplayModeChangedNotifyRoutedEvent;
                }
            }
        }
        
        private static void OnDisplayModeChangedNotifyRoutedEvent(object o, System.Windows.Controls.CalendarModeChangedEventArgs eventArgs)
        {
            var command = GetDisplayModeChangedNotifyRoutedEvent((DependencyObject)o);
            if (command.CanExecute(eventArgs.RoutedEvent))
                command.Execute(eventArgs.RoutedEvent);
        }
        #endregion
        
        #region DisplayModeChangedNotifyHandled
        public static readonly DependencyProperty DisplayModeChangedNotifyHandledProperty =
            DependencyProperty.RegisterAttached("DisplayModeChangedNotifyHandled", typeof(ICommand), typeof(Calendars), new FrameworkPropertyMetadata(OnDisplayModeChangedNotifyHandledChanged));
        
        public static ICommand GetDisplayModeChangedNotifyHandled(DependencyObject target)
        {
            return (ICommand)target.GetValue(DisplayModeChangedNotifyHandledProperty);
        }
        
        public static void SetDisplayModeChangedNotifyHandled(DependencyObject target, ICommand value)
        {
            target.SetValue(DisplayModeChangedNotifyHandledProperty, value);
        }
        
        private static void OnDisplayModeChangedNotifyHandledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Calendar target)
            {
                if (e.OldValue != null)
                {
                    target.DisplayModeChanged -= OnDisplayModeChangedNotifyHandled;
                }
                if (e.NewValue != null)
                {
                    target.DisplayModeChanged += OnDisplayModeChangedNotifyHandled;
                }
            }
        }
        
        private static void OnDisplayModeChangedNotifyHandled(object o, System.Windows.Controls.CalendarModeChangedEventArgs eventArgs)
        {
            var command = GetDisplayModeChangedNotifyHandled((DependencyObject)o);
            if (command.CanExecute(eventArgs.Handled))
                command.Execute(eventArgs.Handled);
        }
        #endregion
        
        #region DisplayModeChangedNotifySource
        public static readonly DependencyProperty DisplayModeChangedNotifySourceProperty =
            DependencyProperty.RegisterAttached("DisplayModeChangedNotifySource", typeof(ICommand), typeof(Calendars), new FrameworkPropertyMetadata(OnDisplayModeChangedNotifySourceChanged));
        
        public static ICommand GetDisplayModeChangedNotifySource(DependencyObject target)
        {
            return (ICommand)target.GetValue(DisplayModeChangedNotifySourceProperty);
        }
        
        public static void SetDisplayModeChangedNotifySource(DependencyObject target, ICommand value)
        {
            target.SetValue(DisplayModeChangedNotifySourceProperty, value);
        }
        
        private static void OnDisplayModeChangedNotifySourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Calendar target)
            {
                if (e.OldValue != null)
                {
                    target.DisplayModeChanged -= OnDisplayModeChangedNotifySource;
                }
                if (e.NewValue != null)
                {
                    target.DisplayModeChanged += OnDisplayModeChangedNotifySource;
                }
            }
        }
        
        private static void OnDisplayModeChangedNotifySource(object o, System.Windows.Controls.CalendarModeChangedEventArgs eventArgs)
        {
            var command = GetDisplayModeChangedNotifySource((DependencyObject)o);
            if (command.CanExecute(eventArgs.Source))
                command.Execute(eventArgs.Source);
        }
        #endregion
        
        #region DisplayModeChangedNotifyOriginalSource
        public static readonly DependencyProperty DisplayModeChangedNotifyOriginalSourceProperty =
            DependencyProperty.RegisterAttached("DisplayModeChangedNotifyOriginalSource", typeof(ICommand), typeof(Calendars), new FrameworkPropertyMetadata(OnDisplayModeChangedNotifyOriginalSourceChanged));
        
        public static ICommand GetDisplayModeChangedNotifyOriginalSource(DependencyObject target)
        {
            return (ICommand)target.GetValue(DisplayModeChangedNotifyOriginalSourceProperty);
        }
        
        public static void SetDisplayModeChangedNotifyOriginalSource(DependencyObject target, ICommand value)
        {
            target.SetValue(DisplayModeChangedNotifyOriginalSourceProperty, value);
        }
        
        private static void OnDisplayModeChangedNotifyOriginalSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Calendar target)
            {
                if (e.OldValue != null)
                {
                    target.DisplayModeChanged -= OnDisplayModeChangedNotifyOriginalSource;
                }
                if (e.NewValue != null)
                {
                    target.DisplayModeChanged += OnDisplayModeChangedNotifyOriginalSource;
                }
            }
        }
        
        private static void OnDisplayModeChangedNotifyOriginalSource(object o, System.Windows.Controls.CalendarModeChangedEventArgs eventArgs)
        {
            var command = GetDisplayModeChangedNotifyOriginalSource((DependencyObject)o);
            if (command.CanExecute(eventArgs.OriginalSource))
                command.Execute(eventArgs.OriginalSource);
        }
        #endregion
        
        #region SelectedDatesChanged
        public static readonly DependencyProperty SelectedDatesChangedProperty =
            DependencyProperty.RegisterAttached("SelectedDatesChanged", typeof(ICommand), typeof(Calendars), new FrameworkPropertyMetadata(OnSelectedDatesChangedChanged));
        
        public static ICommand GetSelectedDatesChanged(DependencyObject target)
        {
            return (ICommand)target.GetValue(SelectedDatesChangedProperty);
        }
        
        public static void SetSelectedDatesChanged(DependencyObject target, ICommand value)
        {
            target.SetValue(SelectedDatesChangedProperty, value);
        }
        
        private static void OnSelectedDatesChangedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Calendar target)
            {
                if (e.OldValue != null)
                {
                    target.SelectedDatesChanged -= OnSelectedDatesChanged;
                }
                if (e.NewValue != null)
                {
                    target.SelectedDatesChanged += OnSelectedDatesChanged;
                }
            }
        }
        
        private static void OnSelectedDatesChanged(object o, SelectionChangedEventArgs eventArgs)
        {
            var command = GetSelectedDatesChanged((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region SelectedDatesChangedNotifyRemovedItems
        public static readonly DependencyProperty SelectedDatesChangedNotifyRemovedItemsProperty =
            DependencyProperty.RegisterAttached("SelectedDatesChangedNotifyRemovedItems", typeof(ICommand), typeof(Calendars), new FrameworkPropertyMetadata(OnSelectedDatesChangedNotifyRemovedItemsChanged));
        
        public static ICommand GetSelectedDatesChangedNotifyRemovedItems(DependencyObject target)
        {
            return (ICommand)target.GetValue(SelectedDatesChangedNotifyRemovedItemsProperty);
        }
        
        public static void SetSelectedDatesChangedNotifyRemovedItems(DependencyObject target, ICommand value)
        {
            target.SetValue(SelectedDatesChangedNotifyRemovedItemsProperty, value);
        }
        
        private static void OnSelectedDatesChangedNotifyRemovedItemsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Calendar target)
            {
                if (e.OldValue != null)
                {
                    target.SelectedDatesChanged -= OnSelectedDatesChangedNotifyRemovedItems;
                }
                if (e.NewValue != null)
                {
                    target.SelectedDatesChanged += OnSelectedDatesChangedNotifyRemovedItems;
                }
            }
        }
        
        private static void OnSelectedDatesChangedNotifyRemovedItems(object o, System.Windows.Controls.SelectionChangedEventArgs eventArgs)
        {
            var command = GetSelectedDatesChangedNotifyRemovedItems((DependencyObject)o);
            if (command.CanExecute(eventArgs.RemovedItems))
                command.Execute(eventArgs.RemovedItems);
        }
        #endregion
        
        #region SelectedDatesChangedNotifyAddedItems
        public static readonly DependencyProperty SelectedDatesChangedNotifyAddedItemsProperty =
            DependencyProperty.RegisterAttached("SelectedDatesChangedNotifyAddedItems", typeof(ICommand), typeof(Calendars), new FrameworkPropertyMetadata(OnSelectedDatesChangedNotifyAddedItemsChanged));
        
        public static ICommand GetSelectedDatesChangedNotifyAddedItems(DependencyObject target)
        {
            return (ICommand)target.GetValue(SelectedDatesChangedNotifyAddedItemsProperty);
        }
        
        public static void SetSelectedDatesChangedNotifyAddedItems(DependencyObject target, ICommand value)
        {
            target.SetValue(SelectedDatesChangedNotifyAddedItemsProperty, value);
        }
        
        private static void OnSelectedDatesChangedNotifyAddedItemsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Calendar target)
            {
                if (e.OldValue != null)
                {
                    target.SelectedDatesChanged -= OnSelectedDatesChangedNotifyAddedItems;
                }
                if (e.NewValue != null)
                {
                    target.SelectedDatesChanged += OnSelectedDatesChangedNotifyAddedItems;
                }
            }
        }
        
        private static void OnSelectedDatesChangedNotifyAddedItems(object o, System.Windows.Controls.SelectionChangedEventArgs eventArgs)
        {
            var command = GetSelectedDatesChangedNotifyAddedItems((DependencyObject)o);
            if (command.CanExecute(eventArgs.AddedItems))
                command.Execute(eventArgs.AddedItems);
        }
        #endregion
        
        #region SelectedDatesChangedNotifyRoutedEvent
        public static readonly DependencyProperty SelectedDatesChangedNotifyRoutedEventProperty =
            DependencyProperty.RegisterAttached("SelectedDatesChangedNotifyRoutedEvent", typeof(ICommand), typeof(Calendars), new FrameworkPropertyMetadata(OnSelectedDatesChangedNotifyRoutedEventChanged));
        
        public static ICommand GetSelectedDatesChangedNotifyRoutedEvent(DependencyObject target)
        {
            return (ICommand)target.GetValue(SelectedDatesChangedNotifyRoutedEventProperty);
        }
        
        public static void SetSelectedDatesChangedNotifyRoutedEvent(DependencyObject target, ICommand value)
        {
            target.SetValue(SelectedDatesChangedNotifyRoutedEventProperty, value);
        }
        
        private static void OnSelectedDatesChangedNotifyRoutedEventChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Calendar target)
            {
                if (e.OldValue != null)
                {
                    target.SelectedDatesChanged -= OnSelectedDatesChangedNotifyRoutedEvent;
                }
                if (e.NewValue != null)
                {
                    target.SelectedDatesChanged += OnSelectedDatesChangedNotifyRoutedEvent;
                }
            }
        }
        
        private static void OnSelectedDatesChangedNotifyRoutedEvent(object o, System.Windows.Controls.SelectionChangedEventArgs eventArgs)
        {
            var command = GetSelectedDatesChangedNotifyRoutedEvent((DependencyObject)o);
            if (command.CanExecute(eventArgs.RoutedEvent))
                command.Execute(eventArgs.RoutedEvent);
        }
        #endregion
        
        #region SelectedDatesChangedNotifyHandled
        public static readonly DependencyProperty SelectedDatesChangedNotifyHandledProperty =
            DependencyProperty.RegisterAttached("SelectedDatesChangedNotifyHandled", typeof(ICommand), typeof(Calendars), new FrameworkPropertyMetadata(OnSelectedDatesChangedNotifyHandledChanged));
        
        public static ICommand GetSelectedDatesChangedNotifyHandled(DependencyObject target)
        {
            return (ICommand)target.GetValue(SelectedDatesChangedNotifyHandledProperty);
        }
        
        public static void SetSelectedDatesChangedNotifyHandled(DependencyObject target, ICommand value)
        {
            target.SetValue(SelectedDatesChangedNotifyHandledProperty, value);
        }
        
        private static void OnSelectedDatesChangedNotifyHandledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Calendar target)
            {
                if (e.OldValue != null)
                {
                    target.SelectedDatesChanged -= OnSelectedDatesChangedNotifyHandled;
                }
                if (e.NewValue != null)
                {
                    target.SelectedDatesChanged += OnSelectedDatesChangedNotifyHandled;
                }
            }
        }
        
        private static void OnSelectedDatesChangedNotifyHandled(object o, System.Windows.Controls.SelectionChangedEventArgs eventArgs)
        {
            var command = GetSelectedDatesChangedNotifyHandled((DependencyObject)o);
            if (command.CanExecute(eventArgs.Handled))
                command.Execute(eventArgs.Handled);
        }
        #endregion
        
        #region SelectedDatesChangedNotifySource
        public static readonly DependencyProperty SelectedDatesChangedNotifySourceProperty =
            DependencyProperty.RegisterAttached("SelectedDatesChangedNotifySource", typeof(ICommand), typeof(Calendars), new FrameworkPropertyMetadata(OnSelectedDatesChangedNotifySourceChanged));
        
        public static ICommand GetSelectedDatesChangedNotifySource(DependencyObject target)
        {
            return (ICommand)target.GetValue(SelectedDatesChangedNotifySourceProperty);
        }
        
        public static void SetSelectedDatesChangedNotifySource(DependencyObject target, ICommand value)
        {
            target.SetValue(SelectedDatesChangedNotifySourceProperty, value);
        }
        
        private static void OnSelectedDatesChangedNotifySourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Calendar target)
            {
                if (e.OldValue != null)
                {
                    target.SelectedDatesChanged -= OnSelectedDatesChangedNotifySource;
                }
                if (e.NewValue != null)
                {
                    target.SelectedDatesChanged += OnSelectedDatesChangedNotifySource;
                }
            }
        }
        
        private static void OnSelectedDatesChangedNotifySource(object o, System.Windows.Controls.SelectionChangedEventArgs eventArgs)
        {
            var command = GetSelectedDatesChangedNotifySource((DependencyObject)o);
            if (command.CanExecute(eventArgs.Source))
                command.Execute(eventArgs.Source);
        }
        #endregion
        
        #region SelectedDatesChangedNotifyOriginalSource
        public static readonly DependencyProperty SelectedDatesChangedNotifyOriginalSourceProperty =
            DependencyProperty.RegisterAttached("SelectedDatesChangedNotifyOriginalSource", typeof(ICommand), typeof(Calendars), new FrameworkPropertyMetadata(OnSelectedDatesChangedNotifyOriginalSourceChanged));
        
        public static ICommand GetSelectedDatesChangedNotifyOriginalSource(DependencyObject target)
        {
            return (ICommand)target.GetValue(SelectedDatesChangedNotifyOriginalSourceProperty);
        }
        
        public static void SetSelectedDatesChangedNotifyOriginalSource(DependencyObject target, ICommand value)
        {
            target.SetValue(SelectedDatesChangedNotifyOriginalSourceProperty, value);
        }
        
        private static void OnSelectedDatesChangedNotifyOriginalSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Calendar target)
            {
                if (e.OldValue != null)
                {
                    target.SelectedDatesChanged -= OnSelectedDatesChangedNotifyOriginalSource;
                }
                if (e.NewValue != null)
                {
                    target.SelectedDatesChanged += OnSelectedDatesChangedNotifyOriginalSource;
                }
            }
        }
        
        private static void OnSelectedDatesChangedNotifyOriginalSource(object o, System.Windows.Controls.SelectionChangedEventArgs eventArgs)
        {
            var command = GetSelectedDatesChangedNotifyOriginalSource((DependencyObject)o);
            if (command.CanExecute(eventArgs.OriginalSource))
                command.Execute(eventArgs.OriginalSource);
        }
        #endregion
        
        #region SelectionModeChanged
        public static readonly DependencyProperty SelectionModeChangedProperty =
            DependencyProperty.RegisterAttached("SelectionModeChanged", typeof(ICommand), typeof(Calendars), new FrameworkPropertyMetadata(OnSelectionModeChangedChanged));
        
        public static ICommand GetSelectionModeChanged(DependencyObject target)
        {
            return (ICommand)target.GetValue(SelectionModeChangedProperty);
        }
        
        public static void SetSelectionModeChanged(DependencyObject target, ICommand value)
        {
            target.SetValue(SelectionModeChangedProperty, value);
        }
        
        private static void OnSelectionModeChangedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Calendar target)
            {
                if (e.OldValue != null)
                {
                    target.SelectionModeChanged -= OnSelectionModeChanged;
                }
                if (e.NewValue != null)
                {
                    target.SelectionModeChanged += OnSelectionModeChanged;
                }
            }
        }
        
        private static void OnSelectionModeChanged(object o, EventArgs eventArgs)
        {
            var command = GetSelectionModeChanged((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region ComboBoxs
	public static partial class ComboBoxs {
        
        #region DropDownClosed
        public static readonly DependencyProperty DropDownClosedProperty =
            DependencyProperty.RegisterAttached("DropDownClosed", typeof(ICommand), typeof(ComboBoxs), new FrameworkPropertyMetadata(OnDropDownClosedChanged));
        
        public static ICommand GetDropDownClosed(DependencyObject target)
        {
            return (ICommand)target.GetValue(DropDownClosedProperty);
        }
        
        public static void SetDropDownClosed(DependencyObject target, ICommand value)
        {
            target.SetValue(DropDownClosedProperty, value);
        }
        
        private static void OnDropDownClosedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ComboBox target)
            {
                if (e.OldValue != null)
                {
                    target.DropDownClosed -= OnDropDownClosed;
                }
                if (e.NewValue != null)
                {
                    target.DropDownClosed += OnDropDownClosed;
                }
            }
        }
        
        private static void OnDropDownClosed(object o, EventArgs eventArgs)
        {
            var command = GetDropDownClosed((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region DropDownOpened
        public static readonly DependencyProperty DropDownOpenedProperty =
            DependencyProperty.RegisterAttached("DropDownOpened", typeof(ICommand), typeof(ComboBoxs), new FrameworkPropertyMetadata(OnDropDownOpenedChanged));
        
        public static ICommand GetDropDownOpened(DependencyObject target)
        {
            return (ICommand)target.GetValue(DropDownOpenedProperty);
        }
        
        public static void SetDropDownOpened(DependencyObject target, ICommand value)
        {
            target.SetValue(DropDownOpenedProperty, value);
        }
        
        private static void OnDropDownOpenedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ComboBox target)
            {
                if (e.OldValue != null)
                {
                    target.DropDownOpened -= OnDropDownOpened;
                }
                if (e.NewValue != null)
                {
                    target.DropDownOpened += OnDropDownOpened;
                }
            }
        }
        
        private static void OnDropDownOpened(object o, EventArgs eventArgs)
        {
            var command = GetDropDownOpened((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region ContextMenus
	public static partial class ContextMenus {
        
        #region Closed
        public static readonly DependencyProperty ClosedProperty =
            DependencyProperty.RegisterAttached("Closed", typeof(ICommand), typeof(ContextMenus), new FrameworkPropertyMetadata(OnClosedChanged));
        
        public static ICommand GetClosed(DependencyObject target)
        {
            return (ICommand)target.GetValue(ClosedProperty);
        }
        
        public static void SetClosed(DependencyObject target, ICommand value)
        {
            target.SetValue(ClosedProperty, value);
        }
        
        private static void OnClosedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ContextMenu target)
            {
                if (e.OldValue != null)
                {
                    target.Closed -= OnClosed;
                }
                if (e.NewValue != null)
                {
                    target.Closed += OnClosed;
                }
            }
        }
        
        private static void OnClosed(object o, RoutedEventArgs eventArgs)
        {
            var command = GetClosed((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Opened
        public static readonly DependencyProperty OpenedProperty =
            DependencyProperty.RegisterAttached("Opened", typeof(ICommand), typeof(ContextMenus), new FrameworkPropertyMetadata(OnOpenedChanged));
        
        public static ICommand GetOpened(DependencyObject target)
        {
            return (ICommand)target.GetValue(OpenedProperty);
        }
        
        public static void SetOpened(DependencyObject target, ICommand value)
        {
            target.SetValue(OpenedProperty, value);
        }
        
        private static void OnOpenedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ContextMenu target)
            {
                if (e.OldValue != null)
                {
                    target.Opened -= OnOpened;
                }
                if (e.NewValue != null)
                {
                    target.Opened += OnOpened;
                }
            }
        }
        
        private static void OnOpened(object o, RoutedEventArgs eventArgs)
        {
            var command = GetOpened((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region Controls
	public static partial class Controls {
        
        #region MouseDoubleClick
        public static readonly DependencyProperty MouseDoubleClickProperty =
            DependencyProperty.RegisterAttached("MouseDoubleClick", typeof(ICommand), typeof(Controls), new FrameworkPropertyMetadata(OnMouseDoubleClickChanged));
        
        public static ICommand GetMouseDoubleClick(DependencyObject target)
        {
            return (ICommand)target.GetValue(MouseDoubleClickProperty);
        }
        
        public static void SetMouseDoubleClick(DependencyObject target, ICommand value)
        {
            target.SetValue(MouseDoubleClickProperty, value);
        }
        
        private static void OnMouseDoubleClickChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Control target)
            {
                if (e.OldValue != null)
                {
                    target.MouseDoubleClick -= OnMouseDoubleClick;
                }
                if (e.NewValue != null)
                {
                    target.MouseDoubleClick += OnMouseDoubleClick;
                }
            }
        }
        
        private static void OnMouseDoubleClick(object o, MouseButtonEventArgs eventArgs)
        {
            var command = GetMouseDoubleClick((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region PreviewMouseDoubleClick
        public static readonly DependencyProperty PreviewMouseDoubleClickProperty =
            DependencyProperty.RegisterAttached("PreviewMouseDoubleClick", typeof(ICommand), typeof(Controls), new FrameworkPropertyMetadata(OnPreviewMouseDoubleClickChanged));
        
        public static ICommand GetPreviewMouseDoubleClick(DependencyObject target)
        {
            return (ICommand)target.GetValue(PreviewMouseDoubleClickProperty);
        }
        
        public static void SetPreviewMouseDoubleClick(DependencyObject target, ICommand value)
        {
            target.SetValue(PreviewMouseDoubleClickProperty, value);
        }
        
        private static void OnPreviewMouseDoubleClickChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Control target)
            {
                if (e.OldValue != null)
                {
                    target.PreviewMouseDoubleClick -= OnPreviewMouseDoubleClick;
                }
                if (e.NewValue != null)
                {
                    target.PreviewMouseDoubleClick += OnPreviewMouseDoubleClick;
                }
            }
        }
        
        private static void OnPreviewMouseDoubleClick(object o, MouseButtonEventArgs eventArgs)
        {
            var command = GetPreviewMouseDoubleClick((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region DataGrids
	public static partial class DataGrids {
        
        #region AddingNewItem
        public static readonly DependencyProperty AddingNewItemProperty =
            DependencyProperty.RegisterAttached("AddingNewItem", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnAddingNewItemChanged));
        
        public static ICommand GetAddingNewItem(DependencyObject target)
        {
            return (ICommand)target.GetValue(AddingNewItemProperty);
        }
        
        public static void SetAddingNewItem(DependencyObject target, ICommand value)
        {
            target.SetValue(AddingNewItemProperty, value);
        }
        
        private static void OnAddingNewItemChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.AddingNewItem -= OnAddingNewItem;
                }
                if (e.NewValue != null)
                {
                    target.AddingNewItem += OnAddingNewItem;
                }
            }
        }
        
        private static void OnAddingNewItem(object o, AddingNewItemEventArgs eventArgs)
        {
            var command = GetAddingNewItem((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region AddingNewItemNotifyNewItem
        public static readonly DependencyProperty AddingNewItemNotifyNewItemProperty =
            DependencyProperty.RegisterAttached("AddingNewItemNotifyNewItem", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnAddingNewItemNotifyNewItemChanged));
        
        public static ICommand GetAddingNewItemNotifyNewItem(DependencyObject target)
        {
            return (ICommand)target.GetValue(AddingNewItemNotifyNewItemProperty);
        }
        
        public static void SetAddingNewItemNotifyNewItem(DependencyObject target, ICommand value)
        {
            target.SetValue(AddingNewItemNotifyNewItemProperty, value);
        }
        
        private static void OnAddingNewItemNotifyNewItemChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.AddingNewItem -= OnAddingNewItemNotifyNewItem;
                }
                if (e.NewValue != null)
                {
                    target.AddingNewItem += OnAddingNewItemNotifyNewItem;
                }
            }
        }
        
        private static void OnAddingNewItemNotifyNewItem(object o, System.Windows.Controls.AddingNewItemEventArgs eventArgs)
        {
            var command = GetAddingNewItemNotifyNewItem((DependencyObject)o);
            if (command.CanExecute(eventArgs.NewItem))
                command.Execute(eventArgs.NewItem);
        }
        #endregion
        
        #region AutoGeneratedColumns
        public static readonly DependencyProperty AutoGeneratedColumnsProperty =
            DependencyProperty.RegisterAttached("AutoGeneratedColumns", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnAutoGeneratedColumnsChanged));
        
        public static ICommand GetAutoGeneratedColumns(DependencyObject target)
        {
            return (ICommand)target.GetValue(AutoGeneratedColumnsProperty);
        }
        
        public static void SetAutoGeneratedColumns(DependencyObject target, ICommand value)
        {
            target.SetValue(AutoGeneratedColumnsProperty, value);
        }
        
        private static void OnAutoGeneratedColumnsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.AutoGeneratedColumns -= OnAutoGeneratedColumns;
                }
                if (e.NewValue != null)
                {
                    target.AutoGeneratedColumns += OnAutoGeneratedColumns;
                }
            }
        }
        
        private static void OnAutoGeneratedColumns(object o, EventArgs eventArgs)
        {
            var command = GetAutoGeneratedColumns((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region AutoGeneratingColumn
        public static readonly DependencyProperty AutoGeneratingColumnProperty =
            DependencyProperty.RegisterAttached("AutoGeneratingColumn", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnAutoGeneratingColumnChanged));
        
        public static ICommand GetAutoGeneratingColumn(DependencyObject target)
        {
            return (ICommand)target.GetValue(AutoGeneratingColumnProperty);
        }
        
        public static void SetAutoGeneratingColumn(DependencyObject target, ICommand value)
        {
            target.SetValue(AutoGeneratingColumnProperty, value);
        }
        
        private static void OnAutoGeneratingColumnChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.AutoGeneratingColumn -= OnAutoGeneratingColumn;
                }
                if (e.NewValue != null)
                {
                    target.AutoGeneratingColumn += OnAutoGeneratingColumn;
                }
            }
        }
        
        private static void OnAutoGeneratingColumn(object o, DataGridAutoGeneratingColumnEventArgs eventArgs)
        {
            var command = GetAutoGeneratingColumn((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region AutoGeneratingColumnNotifyColumn
        public static readonly DependencyProperty AutoGeneratingColumnNotifyColumnProperty =
            DependencyProperty.RegisterAttached("AutoGeneratingColumnNotifyColumn", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnAutoGeneratingColumnNotifyColumnChanged));
        
        public static ICommand GetAutoGeneratingColumnNotifyColumn(DependencyObject target)
        {
            return (ICommand)target.GetValue(AutoGeneratingColumnNotifyColumnProperty);
        }
        
        public static void SetAutoGeneratingColumnNotifyColumn(DependencyObject target, ICommand value)
        {
            target.SetValue(AutoGeneratingColumnNotifyColumnProperty, value);
        }
        
        private static void OnAutoGeneratingColumnNotifyColumnChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.AutoGeneratingColumn -= OnAutoGeneratingColumnNotifyColumn;
                }
                if (e.NewValue != null)
                {
                    target.AutoGeneratingColumn += OnAutoGeneratingColumnNotifyColumn;
                }
            }
        }
        
        private static void OnAutoGeneratingColumnNotifyColumn(object o, System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs eventArgs)
        {
            var command = GetAutoGeneratingColumnNotifyColumn((DependencyObject)o);
            if (command.CanExecute(eventArgs.Column))
                command.Execute(eventArgs.Column);
        }
        #endregion
        
        #region AutoGeneratingColumnNotifyPropertyName
        public static readonly DependencyProperty AutoGeneratingColumnNotifyPropertyNameProperty =
            DependencyProperty.RegisterAttached("AutoGeneratingColumnNotifyPropertyName", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnAutoGeneratingColumnNotifyPropertyNameChanged));
        
        public static ICommand GetAutoGeneratingColumnNotifyPropertyName(DependencyObject target)
        {
            return (ICommand)target.GetValue(AutoGeneratingColumnNotifyPropertyNameProperty);
        }
        
        public static void SetAutoGeneratingColumnNotifyPropertyName(DependencyObject target, ICommand value)
        {
            target.SetValue(AutoGeneratingColumnNotifyPropertyNameProperty, value);
        }
        
        private static void OnAutoGeneratingColumnNotifyPropertyNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.AutoGeneratingColumn -= OnAutoGeneratingColumnNotifyPropertyName;
                }
                if (e.NewValue != null)
                {
                    target.AutoGeneratingColumn += OnAutoGeneratingColumnNotifyPropertyName;
                }
            }
        }
        
        private static void OnAutoGeneratingColumnNotifyPropertyName(object o, System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs eventArgs)
        {
            var command = GetAutoGeneratingColumnNotifyPropertyName((DependencyObject)o);
            if (command.CanExecute(eventArgs.PropertyName))
                command.Execute(eventArgs.PropertyName);
        }
        #endregion
        
        #region AutoGeneratingColumnNotifyPropertyType
        public static readonly DependencyProperty AutoGeneratingColumnNotifyPropertyTypeProperty =
            DependencyProperty.RegisterAttached("AutoGeneratingColumnNotifyPropertyType", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnAutoGeneratingColumnNotifyPropertyTypeChanged));
        
        public static ICommand GetAutoGeneratingColumnNotifyPropertyType(DependencyObject target)
        {
            return (ICommand)target.GetValue(AutoGeneratingColumnNotifyPropertyTypeProperty);
        }
        
        public static void SetAutoGeneratingColumnNotifyPropertyType(DependencyObject target, ICommand value)
        {
            target.SetValue(AutoGeneratingColumnNotifyPropertyTypeProperty, value);
        }
        
        private static void OnAutoGeneratingColumnNotifyPropertyTypeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.AutoGeneratingColumn -= OnAutoGeneratingColumnNotifyPropertyType;
                }
                if (e.NewValue != null)
                {
                    target.AutoGeneratingColumn += OnAutoGeneratingColumnNotifyPropertyType;
                }
            }
        }
        
        private static void OnAutoGeneratingColumnNotifyPropertyType(object o, System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs eventArgs)
        {
            var command = GetAutoGeneratingColumnNotifyPropertyType((DependencyObject)o);
            if (command.CanExecute(eventArgs.PropertyType))
                command.Execute(eventArgs.PropertyType);
        }
        #endregion
        
        #region AutoGeneratingColumnNotifyPropertyDescriptor
        public static readonly DependencyProperty AutoGeneratingColumnNotifyPropertyDescriptorProperty =
            DependencyProperty.RegisterAttached("AutoGeneratingColumnNotifyPropertyDescriptor", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnAutoGeneratingColumnNotifyPropertyDescriptorChanged));
        
        public static ICommand GetAutoGeneratingColumnNotifyPropertyDescriptor(DependencyObject target)
        {
            return (ICommand)target.GetValue(AutoGeneratingColumnNotifyPropertyDescriptorProperty);
        }
        
        public static void SetAutoGeneratingColumnNotifyPropertyDescriptor(DependencyObject target, ICommand value)
        {
            target.SetValue(AutoGeneratingColumnNotifyPropertyDescriptorProperty, value);
        }
        
        private static void OnAutoGeneratingColumnNotifyPropertyDescriptorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.AutoGeneratingColumn -= OnAutoGeneratingColumnNotifyPropertyDescriptor;
                }
                if (e.NewValue != null)
                {
                    target.AutoGeneratingColumn += OnAutoGeneratingColumnNotifyPropertyDescriptor;
                }
            }
        }
        
        private static void OnAutoGeneratingColumnNotifyPropertyDescriptor(object o, System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs eventArgs)
        {
            var command = GetAutoGeneratingColumnNotifyPropertyDescriptor((DependencyObject)o);
            if (command.CanExecute(eventArgs.PropertyDescriptor))
                command.Execute(eventArgs.PropertyDescriptor);
        }
        #endregion
        
        #region AutoGeneratingColumnNotifyCancel
        public static readonly DependencyProperty AutoGeneratingColumnNotifyCancelProperty =
            DependencyProperty.RegisterAttached("AutoGeneratingColumnNotifyCancel", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnAutoGeneratingColumnNotifyCancelChanged));
        
        public static ICommand GetAutoGeneratingColumnNotifyCancel(DependencyObject target)
        {
            return (ICommand)target.GetValue(AutoGeneratingColumnNotifyCancelProperty);
        }
        
        public static void SetAutoGeneratingColumnNotifyCancel(DependencyObject target, ICommand value)
        {
            target.SetValue(AutoGeneratingColumnNotifyCancelProperty, value);
        }
        
        private static void OnAutoGeneratingColumnNotifyCancelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.AutoGeneratingColumn -= OnAutoGeneratingColumnNotifyCancel;
                }
                if (e.NewValue != null)
                {
                    target.AutoGeneratingColumn += OnAutoGeneratingColumnNotifyCancel;
                }
            }
        }
        
        private static void OnAutoGeneratingColumnNotifyCancel(object o, System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs eventArgs)
        {
            var command = GetAutoGeneratingColumnNotifyCancel((DependencyObject)o);
            if (command.CanExecute(eventArgs.Cancel))
                command.Execute(eventArgs.Cancel);
        }
        #endregion
        
        #region BeginningEdit
        public static readonly DependencyProperty BeginningEditProperty =
            DependencyProperty.RegisterAttached("BeginningEdit", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnBeginningEditChanged));
        
        public static ICommand GetBeginningEdit(DependencyObject target)
        {
            return (ICommand)target.GetValue(BeginningEditProperty);
        }
        
        public static void SetBeginningEdit(DependencyObject target, ICommand value)
        {
            target.SetValue(BeginningEditProperty, value);
        }
        
        private static void OnBeginningEditChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.BeginningEdit -= OnBeginningEdit;
                }
                if (e.NewValue != null)
                {
                    target.BeginningEdit += OnBeginningEdit;
                }
            }
        }
        
        private static void OnBeginningEdit(object o, DataGridBeginningEditEventArgs eventArgs)
        {
            var command = GetBeginningEdit((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region BeginningEditNotifyCancel
        public static readonly DependencyProperty BeginningEditNotifyCancelProperty =
            DependencyProperty.RegisterAttached("BeginningEditNotifyCancel", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnBeginningEditNotifyCancelChanged));
        
        public static ICommand GetBeginningEditNotifyCancel(DependencyObject target)
        {
            return (ICommand)target.GetValue(BeginningEditNotifyCancelProperty);
        }
        
        public static void SetBeginningEditNotifyCancel(DependencyObject target, ICommand value)
        {
            target.SetValue(BeginningEditNotifyCancelProperty, value);
        }
        
        private static void OnBeginningEditNotifyCancelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.BeginningEdit -= OnBeginningEditNotifyCancel;
                }
                if (e.NewValue != null)
                {
                    target.BeginningEdit += OnBeginningEditNotifyCancel;
                }
            }
        }
        
        private static void OnBeginningEditNotifyCancel(object o, System.Windows.Controls.DataGridBeginningEditEventArgs eventArgs)
        {
            var command = GetBeginningEditNotifyCancel((DependencyObject)o);
            if (command.CanExecute(eventArgs.Cancel))
                command.Execute(eventArgs.Cancel);
        }
        #endregion
        
        #region BeginningEditNotifyColumn
        public static readonly DependencyProperty BeginningEditNotifyColumnProperty =
            DependencyProperty.RegisterAttached("BeginningEditNotifyColumn", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnBeginningEditNotifyColumnChanged));
        
        public static ICommand GetBeginningEditNotifyColumn(DependencyObject target)
        {
            return (ICommand)target.GetValue(BeginningEditNotifyColumnProperty);
        }
        
        public static void SetBeginningEditNotifyColumn(DependencyObject target, ICommand value)
        {
            target.SetValue(BeginningEditNotifyColumnProperty, value);
        }
        
        private static void OnBeginningEditNotifyColumnChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.BeginningEdit -= OnBeginningEditNotifyColumn;
                }
                if (e.NewValue != null)
                {
                    target.BeginningEdit += OnBeginningEditNotifyColumn;
                }
            }
        }
        
        private static void OnBeginningEditNotifyColumn(object o, System.Windows.Controls.DataGridBeginningEditEventArgs eventArgs)
        {
            var command = GetBeginningEditNotifyColumn((DependencyObject)o);
            if (command.CanExecute(eventArgs.Column))
                command.Execute(eventArgs.Column);
        }
        #endregion
        
        #region BeginningEditNotifyRow
        public static readonly DependencyProperty BeginningEditNotifyRowProperty =
            DependencyProperty.RegisterAttached("BeginningEditNotifyRow", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnBeginningEditNotifyRowChanged));
        
        public static ICommand GetBeginningEditNotifyRow(DependencyObject target)
        {
            return (ICommand)target.GetValue(BeginningEditNotifyRowProperty);
        }
        
        public static void SetBeginningEditNotifyRow(DependencyObject target, ICommand value)
        {
            target.SetValue(BeginningEditNotifyRowProperty, value);
        }
        
        private static void OnBeginningEditNotifyRowChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.BeginningEdit -= OnBeginningEditNotifyRow;
                }
                if (e.NewValue != null)
                {
                    target.BeginningEdit += OnBeginningEditNotifyRow;
                }
            }
        }
        
        private static void OnBeginningEditNotifyRow(object o, System.Windows.Controls.DataGridBeginningEditEventArgs eventArgs)
        {
            var command = GetBeginningEditNotifyRow((DependencyObject)o);
            if (command.CanExecute(eventArgs.Row))
                command.Execute(eventArgs.Row);
        }
        #endregion
        
        #region BeginningEditNotifyEditingEventArgs
        public static readonly DependencyProperty BeginningEditNotifyEditingEventArgsProperty =
            DependencyProperty.RegisterAttached("BeginningEditNotifyEditingEventArgs", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnBeginningEditNotifyEditingEventArgsChanged));
        
        public static ICommand GetBeginningEditNotifyEditingEventArgs(DependencyObject target)
        {
            return (ICommand)target.GetValue(BeginningEditNotifyEditingEventArgsProperty);
        }
        
        public static void SetBeginningEditNotifyEditingEventArgs(DependencyObject target, ICommand value)
        {
            target.SetValue(BeginningEditNotifyEditingEventArgsProperty, value);
        }
        
        private static void OnBeginningEditNotifyEditingEventArgsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.BeginningEdit -= OnBeginningEditNotifyEditingEventArgs;
                }
                if (e.NewValue != null)
                {
                    target.BeginningEdit += OnBeginningEditNotifyEditingEventArgs;
                }
            }
        }
        
        private static void OnBeginningEditNotifyEditingEventArgs(object o, System.Windows.Controls.DataGridBeginningEditEventArgs eventArgs)
        {
            var command = GetBeginningEditNotifyEditingEventArgs((DependencyObject)o);
            if (command.CanExecute(eventArgs.EditingEventArgs))
                command.Execute(eventArgs.EditingEventArgs);
        }
        #endregion
        
        #region CellEditEnding
        public static readonly DependencyProperty CellEditEndingProperty =
            DependencyProperty.RegisterAttached("CellEditEnding", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnCellEditEndingChanged));
        
        public static ICommand GetCellEditEnding(DependencyObject target)
        {
            return (ICommand)target.GetValue(CellEditEndingProperty);
        }
        
        public static void SetCellEditEnding(DependencyObject target, ICommand value)
        {
            target.SetValue(CellEditEndingProperty, value);
        }
        
        private static void OnCellEditEndingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.CellEditEnding -= OnCellEditEnding;
                }
                if (e.NewValue != null)
                {
                    target.CellEditEnding += OnCellEditEnding;
                }
            }
        }
        
        private static void OnCellEditEnding(object o, DataGridCellEditEndingEventArgs eventArgs)
        {
            var command = GetCellEditEnding((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region CellEditEndingNotifyCancel
        public static readonly DependencyProperty CellEditEndingNotifyCancelProperty =
            DependencyProperty.RegisterAttached("CellEditEndingNotifyCancel", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnCellEditEndingNotifyCancelChanged));
        
        public static ICommand GetCellEditEndingNotifyCancel(DependencyObject target)
        {
            return (ICommand)target.GetValue(CellEditEndingNotifyCancelProperty);
        }
        
        public static void SetCellEditEndingNotifyCancel(DependencyObject target, ICommand value)
        {
            target.SetValue(CellEditEndingNotifyCancelProperty, value);
        }
        
        private static void OnCellEditEndingNotifyCancelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.CellEditEnding -= OnCellEditEndingNotifyCancel;
                }
                if (e.NewValue != null)
                {
                    target.CellEditEnding += OnCellEditEndingNotifyCancel;
                }
            }
        }
        
        private static void OnCellEditEndingNotifyCancel(object o, System.Windows.Controls.DataGridCellEditEndingEventArgs eventArgs)
        {
            var command = GetCellEditEndingNotifyCancel((DependencyObject)o);
            if (command.CanExecute(eventArgs.Cancel))
                command.Execute(eventArgs.Cancel);
        }
        #endregion
        
        #region CellEditEndingNotifyColumn
        public static readonly DependencyProperty CellEditEndingNotifyColumnProperty =
            DependencyProperty.RegisterAttached("CellEditEndingNotifyColumn", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnCellEditEndingNotifyColumnChanged));
        
        public static ICommand GetCellEditEndingNotifyColumn(DependencyObject target)
        {
            return (ICommand)target.GetValue(CellEditEndingNotifyColumnProperty);
        }
        
        public static void SetCellEditEndingNotifyColumn(DependencyObject target, ICommand value)
        {
            target.SetValue(CellEditEndingNotifyColumnProperty, value);
        }
        
        private static void OnCellEditEndingNotifyColumnChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.CellEditEnding -= OnCellEditEndingNotifyColumn;
                }
                if (e.NewValue != null)
                {
                    target.CellEditEnding += OnCellEditEndingNotifyColumn;
                }
            }
        }
        
        private static void OnCellEditEndingNotifyColumn(object o, System.Windows.Controls.DataGridCellEditEndingEventArgs eventArgs)
        {
            var command = GetCellEditEndingNotifyColumn((DependencyObject)o);
            if (command.CanExecute(eventArgs.Column))
                command.Execute(eventArgs.Column);
        }
        #endregion
        
        #region CellEditEndingNotifyRow
        public static readonly DependencyProperty CellEditEndingNotifyRowProperty =
            DependencyProperty.RegisterAttached("CellEditEndingNotifyRow", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnCellEditEndingNotifyRowChanged));
        
        public static ICommand GetCellEditEndingNotifyRow(DependencyObject target)
        {
            return (ICommand)target.GetValue(CellEditEndingNotifyRowProperty);
        }
        
        public static void SetCellEditEndingNotifyRow(DependencyObject target, ICommand value)
        {
            target.SetValue(CellEditEndingNotifyRowProperty, value);
        }
        
        private static void OnCellEditEndingNotifyRowChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.CellEditEnding -= OnCellEditEndingNotifyRow;
                }
                if (e.NewValue != null)
                {
                    target.CellEditEnding += OnCellEditEndingNotifyRow;
                }
            }
        }
        
        private static void OnCellEditEndingNotifyRow(object o, System.Windows.Controls.DataGridCellEditEndingEventArgs eventArgs)
        {
            var command = GetCellEditEndingNotifyRow((DependencyObject)o);
            if (command.CanExecute(eventArgs.Row))
                command.Execute(eventArgs.Row);
        }
        #endregion
        
        #region CellEditEndingNotifyEditingElement
        public static readonly DependencyProperty CellEditEndingNotifyEditingElementProperty =
            DependencyProperty.RegisterAttached("CellEditEndingNotifyEditingElement", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnCellEditEndingNotifyEditingElementChanged));
        
        public static ICommand GetCellEditEndingNotifyEditingElement(DependencyObject target)
        {
            return (ICommand)target.GetValue(CellEditEndingNotifyEditingElementProperty);
        }
        
        public static void SetCellEditEndingNotifyEditingElement(DependencyObject target, ICommand value)
        {
            target.SetValue(CellEditEndingNotifyEditingElementProperty, value);
        }
        
        private static void OnCellEditEndingNotifyEditingElementChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.CellEditEnding -= OnCellEditEndingNotifyEditingElement;
                }
                if (e.NewValue != null)
                {
                    target.CellEditEnding += OnCellEditEndingNotifyEditingElement;
                }
            }
        }
        
        private static void OnCellEditEndingNotifyEditingElement(object o, System.Windows.Controls.DataGridCellEditEndingEventArgs eventArgs)
        {
            var command = GetCellEditEndingNotifyEditingElement((DependencyObject)o);
            if (command.CanExecute(eventArgs.EditingElement))
                command.Execute(eventArgs.EditingElement);
        }
        #endregion
        
        #region CellEditEndingNotifyEditAction
        public static readonly DependencyProperty CellEditEndingNotifyEditActionProperty =
            DependencyProperty.RegisterAttached("CellEditEndingNotifyEditAction", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnCellEditEndingNotifyEditActionChanged));
        
        public static ICommand GetCellEditEndingNotifyEditAction(DependencyObject target)
        {
            return (ICommand)target.GetValue(CellEditEndingNotifyEditActionProperty);
        }
        
        public static void SetCellEditEndingNotifyEditAction(DependencyObject target, ICommand value)
        {
            target.SetValue(CellEditEndingNotifyEditActionProperty, value);
        }
        
        private static void OnCellEditEndingNotifyEditActionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.CellEditEnding -= OnCellEditEndingNotifyEditAction;
                }
                if (e.NewValue != null)
                {
                    target.CellEditEnding += OnCellEditEndingNotifyEditAction;
                }
            }
        }
        
        private static void OnCellEditEndingNotifyEditAction(object o, System.Windows.Controls.DataGridCellEditEndingEventArgs eventArgs)
        {
            var command = GetCellEditEndingNotifyEditAction((DependencyObject)o);
            if (command.CanExecute(eventArgs.EditAction))
                command.Execute(eventArgs.EditAction);
        }
        #endregion
        
        #region ColumnDisplayIndexChanged
        public static readonly DependencyProperty ColumnDisplayIndexChangedProperty =
            DependencyProperty.RegisterAttached("ColumnDisplayIndexChanged", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnDisplayIndexChangedChanged));
        
        public static ICommand GetColumnDisplayIndexChanged(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnDisplayIndexChangedProperty);
        }
        
        public static void SetColumnDisplayIndexChanged(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnDisplayIndexChangedProperty, value);
        }
        
        private static void OnColumnDisplayIndexChangedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnDisplayIndexChanged -= OnColumnDisplayIndexChanged;
                }
                if (e.NewValue != null)
                {
                    target.ColumnDisplayIndexChanged += OnColumnDisplayIndexChanged;
                }
            }
        }
        
        private static void OnColumnDisplayIndexChanged(object o, DataGridColumnEventArgs eventArgs)
        {
            var command = GetColumnDisplayIndexChanged((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region ColumnDisplayIndexChangedNotifyColumn
        public static readonly DependencyProperty ColumnDisplayIndexChangedNotifyColumnProperty =
            DependencyProperty.RegisterAttached("ColumnDisplayIndexChangedNotifyColumn", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnDisplayIndexChangedNotifyColumnChanged));
        
        public static ICommand GetColumnDisplayIndexChangedNotifyColumn(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnDisplayIndexChangedNotifyColumnProperty);
        }
        
        public static void SetColumnDisplayIndexChangedNotifyColumn(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnDisplayIndexChangedNotifyColumnProperty, value);
        }
        
        private static void OnColumnDisplayIndexChangedNotifyColumnChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnDisplayIndexChanged -= OnColumnDisplayIndexChangedNotifyColumn;
                }
                if (e.NewValue != null)
                {
                    target.ColumnDisplayIndexChanged += OnColumnDisplayIndexChangedNotifyColumn;
                }
            }
        }
        
        private static void OnColumnDisplayIndexChangedNotifyColumn(object o, System.Windows.Controls.DataGridColumnEventArgs eventArgs)
        {
            var command = GetColumnDisplayIndexChangedNotifyColumn((DependencyObject)o);
            if (command.CanExecute(eventArgs.Column))
                command.Execute(eventArgs.Column);
        }
        #endregion
        
        #region ColumnHeaderDragCompleted
        public static readonly DependencyProperty ColumnHeaderDragCompletedProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderDragCompleted", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnHeaderDragCompletedChanged));
        
        public static ICommand GetColumnHeaderDragCompleted(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnHeaderDragCompletedProperty);
        }
        
        public static void SetColumnHeaderDragCompleted(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnHeaderDragCompletedProperty, value);
        }
        
        private static void OnColumnHeaderDragCompletedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnHeaderDragCompleted -= OnColumnHeaderDragCompleted;
                }
                if (e.NewValue != null)
                {
                    target.ColumnHeaderDragCompleted += OnColumnHeaderDragCompleted;
                }
            }
        }
        
        private static void OnColumnHeaderDragCompleted(object o, DragCompletedEventArgs eventArgs)
        {
            var command = GetColumnHeaderDragCompleted((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region ColumnHeaderDragCompletedNotifyHorizontalChange
        public static readonly DependencyProperty ColumnHeaderDragCompletedNotifyHorizontalChangeProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderDragCompletedNotifyHorizontalChange", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnHeaderDragCompletedNotifyHorizontalChangeChanged));
        
        public static ICommand GetColumnHeaderDragCompletedNotifyHorizontalChange(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnHeaderDragCompletedNotifyHorizontalChangeProperty);
        }
        
        public static void SetColumnHeaderDragCompletedNotifyHorizontalChange(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnHeaderDragCompletedNotifyHorizontalChangeProperty, value);
        }
        
        private static void OnColumnHeaderDragCompletedNotifyHorizontalChangeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnHeaderDragCompleted -= OnColumnHeaderDragCompletedNotifyHorizontalChange;
                }
                if (e.NewValue != null)
                {
                    target.ColumnHeaderDragCompleted += OnColumnHeaderDragCompletedNotifyHorizontalChange;
                }
            }
        }
        
        private static void OnColumnHeaderDragCompletedNotifyHorizontalChange(object o, System.Windows.Controls.Primitives.DragCompletedEventArgs eventArgs)
        {
            var command = GetColumnHeaderDragCompletedNotifyHorizontalChange((DependencyObject)o);
            if (command.CanExecute(eventArgs.HorizontalChange))
                command.Execute(eventArgs.HorizontalChange);
        }
        #endregion
        
        #region ColumnHeaderDragCompletedNotifyVerticalChange
        public static readonly DependencyProperty ColumnHeaderDragCompletedNotifyVerticalChangeProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderDragCompletedNotifyVerticalChange", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnHeaderDragCompletedNotifyVerticalChangeChanged));
        
        public static ICommand GetColumnHeaderDragCompletedNotifyVerticalChange(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnHeaderDragCompletedNotifyVerticalChangeProperty);
        }
        
        public static void SetColumnHeaderDragCompletedNotifyVerticalChange(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnHeaderDragCompletedNotifyVerticalChangeProperty, value);
        }
        
        private static void OnColumnHeaderDragCompletedNotifyVerticalChangeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnHeaderDragCompleted -= OnColumnHeaderDragCompletedNotifyVerticalChange;
                }
                if (e.NewValue != null)
                {
                    target.ColumnHeaderDragCompleted += OnColumnHeaderDragCompletedNotifyVerticalChange;
                }
            }
        }
        
        private static void OnColumnHeaderDragCompletedNotifyVerticalChange(object o, System.Windows.Controls.Primitives.DragCompletedEventArgs eventArgs)
        {
            var command = GetColumnHeaderDragCompletedNotifyVerticalChange((DependencyObject)o);
            if (command.CanExecute(eventArgs.VerticalChange))
                command.Execute(eventArgs.VerticalChange);
        }
        #endregion
        
        #region ColumnHeaderDragCompletedNotifyCanceled
        public static readonly DependencyProperty ColumnHeaderDragCompletedNotifyCanceledProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderDragCompletedNotifyCanceled", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnHeaderDragCompletedNotifyCanceledChanged));
        
        public static ICommand GetColumnHeaderDragCompletedNotifyCanceled(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnHeaderDragCompletedNotifyCanceledProperty);
        }
        
        public static void SetColumnHeaderDragCompletedNotifyCanceled(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnHeaderDragCompletedNotifyCanceledProperty, value);
        }
        
        private static void OnColumnHeaderDragCompletedNotifyCanceledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnHeaderDragCompleted -= OnColumnHeaderDragCompletedNotifyCanceled;
                }
                if (e.NewValue != null)
                {
                    target.ColumnHeaderDragCompleted += OnColumnHeaderDragCompletedNotifyCanceled;
                }
            }
        }
        
        private static void OnColumnHeaderDragCompletedNotifyCanceled(object o, System.Windows.Controls.Primitives.DragCompletedEventArgs eventArgs)
        {
            var command = GetColumnHeaderDragCompletedNotifyCanceled((DependencyObject)o);
            if (command.CanExecute(eventArgs.Canceled))
                command.Execute(eventArgs.Canceled);
        }
        #endregion
        
        #region ColumnHeaderDragCompletedNotifyRoutedEvent
        public static readonly DependencyProperty ColumnHeaderDragCompletedNotifyRoutedEventProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderDragCompletedNotifyRoutedEvent", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnHeaderDragCompletedNotifyRoutedEventChanged));
        
        public static ICommand GetColumnHeaderDragCompletedNotifyRoutedEvent(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnHeaderDragCompletedNotifyRoutedEventProperty);
        }
        
        public static void SetColumnHeaderDragCompletedNotifyRoutedEvent(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnHeaderDragCompletedNotifyRoutedEventProperty, value);
        }
        
        private static void OnColumnHeaderDragCompletedNotifyRoutedEventChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnHeaderDragCompleted -= OnColumnHeaderDragCompletedNotifyRoutedEvent;
                }
                if (e.NewValue != null)
                {
                    target.ColumnHeaderDragCompleted += OnColumnHeaderDragCompletedNotifyRoutedEvent;
                }
            }
        }
        
        private static void OnColumnHeaderDragCompletedNotifyRoutedEvent(object o, System.Windows.Controls.Primitives.DragCompletedEventArgs eventArgs)
        {
            var command = GetColumnHeaderDragCompletedNotifyRoutedEvent((DependencyObject)o);
            if (command.CanExecute(eventArgs.RoutedEvent))
                command.Execute(eventArgs.RoutedEvent);
        }
        #endregion
        
        #region ColumnHeaderDragCompletedNotifyHandled
        public static readonly DependencyProperty ColumnHeaderDragCompletedNotifyHandledProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderDragCompletedNotifyHandled", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnHeaderDragCompletedNotifyHandledChanged));
        
        public static ICommand GetColumnHeaderDragCompletedNotifyHandled(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnHeaderDragCompletedNotifyHandledProperty);
        }
        
        public static void SetColumnHeaderDragCompletedNotifyHandled(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnHeaderDragCompletedNotifyHandledProperty, value);
        }
        
        private static void OnColumnHeaderDragCompletedNotifyHandledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnHeaderDragCompleted -= OnColumnHeaderDragCompletedNotifyHandled;
                }
                if (e.NewValue != null)
                {
                    target.ColumnHeaderDragCompleted += OnColumnHeaderDragCompletedNotifyHandled;
                }
            }
        }
        
        private static void OnColumnHeaderDragCompletedNotifyHandled(object o, System.Windows.Controls.Primitives.DragCompletedEventArgs eventArgs)
        {
            var command = GetColumnHeaderDragCompletedNotifyHandled((DependencyObject)o);
            if (command.CanExecute(eventArgs.Handled))
                command.Execute(eventArgs.Handled);
        }
        #endregion
        
        #region ColumnHeaderDragCompletedNotifySource
        public static readonly DependencyProperty ColumnHeaderDragCompletedNotifySourceProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderDragCompletedNotifySource", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnHeaderDragCompletedNotifySourceChanged));
        
        public static ICommand GetColumnHeaderDragCompletedNotifySource(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnHeaderDragCompletedNotifySourceProperty);
        }
        
        public static void SetColumnHeaderDragCompletedNotifySource(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnHeaderDragCompletedNotifySourceProperty, value);
        }
        
        private static void OnColumnHeaderDragCompletedNotifySourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnHeaderDragCompleted -= OnColumnHeaderDragCompletedNotifySource;
                }
                if (e.NewValue != null)
                {
                    target.ColumnHeaderDragCompleted += OnColumnHeaderDragCompletedNotifySource;
                }
            }
        }
        
        private static void OnColumnHeaderDragCompletedNotifySource(object o, System.Windows.Controls.Primitives.DragCompletedEventArgs eventArgs)
        {
            var command = GetColumnHeaderDragCompletedNotifySource((DependencyObject)o);
            if (command.CanExecute(eventArgs.Source))
                command.Execute(eventArgs.Source);
        }
        #endregion
        
        #region ColumnHeaderDragCompletedNotifyOriginalSource
        public static readonly DependencyProperty ColumnHeaderDragCompletedNotifyOriginalSourceProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderDragCompletedNotifyOriginalSource", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnHeaderDragCompletedNotifyOriginalSourceChanged));
        
        public static ICommand GetColumnHeaderDragCompletedNotifyOriginalSource(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnHeaderDragCompletedNotifyOriginalSourceProperty);
        }
        
        public static void SetColumnHeaderDragCompletedNotifyOriginalSource(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnHeaderDragCompletedNotifyOriginalSourceProperty, value);
        }
        
        private static void OnColumnHeaderDragCompletedNotifyOriginalSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnHeaderDragCompleted -= OnColumnHeaderDragCompletedNotifyOriginalSource;
                }
                if (e.NewValue != null)
                {
                    target.ColumnHeaderDragCompleted += OnColumnHeaderDragCompletedNotifyOriginalSource;
                }
            }
        }
        
        private static void OnColumnHeaderDragCompletedNotifyOriginalSource(object o, System.Windows.Controls.Primitives.DragCompletedEventArgs eventArgs)
        {
            var command = GetColumnHeaderDragCompletedNotifyOriginalSource((DependencyObject)o);
            if (command.CanExecute(eventArgs.OriginalSource))
                command.Execute(eventArgs.OriginalSource);
        }
        #endregion
        
        #region ColumnHeaderDragDelta
        public static readonly DependencyProperty ColumnHeaderDragDeltaProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderDragDelta", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnHeaderDragDeltaChanged));
        
        public static ICommand GetColumnHeaderDragDelta(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnHeaderDragDeltaProperty);
        }
        
        public static void SetColumnHeaderDragDelta(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnHeaderDragDeltaProperty, value);
        }
        
        private static void OnColumnHeaderDragDeltaChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnHeaderDragDelta -= OnColumnHeaderDragDelta;
                }
                if (e.NewValue != null)
                {
                    target.ColumnHeaderDragDelta += OnColumnHeaderDragDelta;
                }
            }
        }
        
        private static void OnColumnHeaderDragDelta(object o, DragDeltaEventArgs eventArgs)
        {
            var command = GetColumnHeaderDragDelta((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region ColumnHeaderDragDeltaNotifyHorizontalChange
        public static readonly DependencyProperty ColumnHeaderDragDeltaNotifyHorizontalChangeProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderDragDeltaNotifyHorizontalChange", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnHeaderDragDeltaNotifyHorizontalChangeChanged));
        
        public static ICommand GetColumnHeaderDragDeltaNotifyHorizontalChange(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnHeaderDragDeltaNotifyHorizontalChangeProperty);
        }
        
        public static void SetColumnHeaderDragDeltaNotifyHorizontalChange(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnHeaderDragDeltaNotifyHorizontalChangeProperty, value);
        }
        
        private static void OnColumnHeaderDragDeltaNotifyHorizontalChangeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnHeaderDragDelta -= OnColumnHeaderDragDeltaNotifyHorizontalChange;
                }
                if (e.NewValue != null)
                {
                    target.ColumnHeaderDragDelta += OnColumnHeaderDragDeltaNotifyHorizontalChange;
                }
            }
        }
        
        private static void OnColumnHeaderDragDeltaNotifyHorizontalChange(object o, System.Windows.Controls.Primitives.DragDeltaEventArgs eventArgs)
        {
            var command = GetColumnHeaderDragDeltaNotifyHorizontalChange((DependencyObject)o);
            if (command.CanExecute(eventArgs.HorizontalChange))
                command.Execute(eventArgs.HorizontalChange);
        }
        #endregion
        
        #region ColumnHeaderDragDeltaNotifyVerticalChange
        public static readonly DependencyProperty ColumnHeaderDragDeltaNotifyVerticalChangeProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderDragDeltaNotifyVerticalChange", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnHeaderDragDeltaNotifyVerticalChangeChanged));
        
        public static ICommand GetColumnHeaderDragDeltaNotifyVerticalChange(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnHeaderDragDeltaNotifyVerticalChangeProperty);
        }
        
        public static void SetColumnHeaderDragDeltaNotifyVerticalChange(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnHeaderDragDeltaNotifyVerticalChangeProperty, value);
        }
        
        private static void OnColumnHeaderDragDeltaNotifyVerticalChangeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnHeaderDragDelta -= OnColumnHeaderDragDeltaNotifyVerticalChange;
                }
                if (e.NewValue != null)
                {
                    target.ColumnHeaderDragDelta += OnColumnHeaderDragDeltaNotifyVerticalChange;
                }
            }
        }
        
        private static void OnColumnHeaderDragDeltaNotifyVerticalChange(object o, System.Windows.Controls.Primitives.DragDeltaEventArgs eventArgs)
        {
            var command = GetColumnHeaderDragDeltaNotifyVerticalChange((DependencyObject)o);
            if (command.CanExecute(eventArgs.VerticalChange))
                command.Execute(eventArgs.VerticalChange);
        }
        #endregion
        
        #region ColumnHeaderDragDeltaNotifyRoutedEvent
        public static readonly DependencyProperty ColumnHeaderDragDeltaNotifyRoutedEventProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderDragDeltaNotifyRoutedEvent", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnHeaderDragDeltaNotifyRoutedEventChanged));
        
        public static ICommand GetColumnHeaderDragDeltaNotifyRoutedEvent(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnHeaderDragDeltaNotifyRoutedEventProperty);
        }
        
        public static void SetColumnHeaderDragDeltaNotifyRoutedEvent(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnHeaderDragDeltaNotifyRoutedEventProperty, value);
        }
        
        private static void OnColumnHeaderDragDeltaNotifyRoutedEventChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnHeaderDragDelta -= OnColumnHeaderDragDeltaNotifyRoutedEvent;
                }
                if (e.NewValue != null)
                {
                    target.ColumnHeaderDragDelta += OnColumnHeaderDragDeltaNotifyRoutedEvent;
                }
            }
        }
        
        private static void OnColumnHeaderDragDeltaNotifyRoutedEvent(object o, System.Windows.Controls.Primitives.DragDeltaEventArgs eventArgs)
        {
            var command = GetColumnHeaderDragDeltaNotifyRoutedEvent((DependencyObject)o);
            if (command.CanExecute(eventArgs.RoutedEvent))
                command.Execute(eventArgs.RoutedEvent);
        }
        #endregion
        
        #region ColumnHeaderDragDeltaNotifyHandled
        public static readonly DependencyProperty ColumnHeaderDragDeltaNotifyHandledProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderDragDeltaNotifyHandled", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnHeaderDragDeltaNotifyHandledChanged));
        
        public static ICommand GetColumnHeaderDragDeltaNotifyHandled(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnHeaderDragDeltaNotifyHandledProperty);
        }
        
        public static void SetColumnHeaderDragDeltaNotifyHandled(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnHeaderDragDeltaNotifyHandledProperty, value);
        }
        
        private static void OnColumnHeaderDragDeltaNotifyHandledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnHeaderDragDelta -= OnColumnHeaderDragDeltaNotifyHandled;
                }
                if (e.NewValue != null)
                {
                    target.ColumnHeaderDragDelta += OnColumnHeaderDragDeltaNotifyHandled;
                }
            }
        }
        
        private static void OnColumnHeaderDragDeltaNotifyHandled(object o, System.Windows.Controls.Primitives.DragDeltaEventArgs eventArgs)
        {
            var command = GetColumnHeaderDragDeltaNotifyHandled((DependencyObject)o);
            if (command.CanExecute(eventArgs.Handled))
                command.Execute(eventArgs.Handled);
        }
        #endregion
        
        #region ColumnHeaderDragDeltaNotifySource
        public static readonly DependencyProperty ColumnHeaderDragDeltaNotifySourceProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderDragDeltaNotifySource", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnHeaderDragDeltaNotifySourceChanged));
        
        public static ICommand GetColumnHeaderDragDeltaNotifySource(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnHeaderDragDeltaNotifySourceProperty);
        }
        
        public static void SetColumnHeaderDragDeltaNotifySource(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnHeaderDragDeltaNotifySourceProperty, value);
        }
        
        private static void OnColumnHeaderDragDeltaNotifySourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnHeaderDragDelta -= OnColumnHeaderDragDeltaNotifySource;
                }
                if (e.NewValue != null)
                {
                    target.ColumnHeaderDragDelta += OnColumnHeaderDragDeltaNotifySource;
                }
            }
        }
        
        private static void OnColumnHeaderDragDeltaNotifySource(object o, System.Windows.Controls.Primitives.DragDeltaEventArgs eventArgs)
        {
            var command = GetColumnHeaderDragDeltaNotifySource((DependencyObject)o);
            if (command.CanExecute(eventArgs.Source))
                command.Execute(eventArgs.Source);
        }
        #endregion
        
        #region ColumnHeaderDragDeltaNotifyOriginalSource
        public static readonly DependencyProperty ColumnHeaderDragDeltaNotifyOriginalSourceProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderDragDeltaNotifyOriginalSource", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnHeaderDragDeltaNotifyOriginalSourceChanged));
        
        public static ICommand GetColumnHeaderDragDeltaNotifyOriginalSource(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnHeaderDragDeltaNotifyOriginalSourceProperty);
        }
        
        public static void SetColumnHeaderDragDeltaNotifyOriginalSource(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnHeaderDragDeltaNotifyOriginalSourceProperty, value);
        }
        
        private static void OnColumnHeaderDragDeltaNotifyOriginalSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnHeaderDragDelta -= OnColumnHeaderDragDeltaNotifyOriginalSource;
                }
                if (e.NewValue != null)
                {
                    target.ColumnHeaderDragDelta += OnColumnHeaderDragDeltaNotifyOriginalSource;
                }
            }
        }
        
        private static void OnColumnHeaderDragDeltaNotifyOriginalSource(object o, System.Windows.Controls.Primitives.DragDeltaEventArgs eventArgs)
        {
            var command = GetColumnHeaderDragDeltaNotifyOriginalSource((DependencyObject)o);
            if (command.CanExecute(eventArgs.OriginalSource))
                command.Execute(eventArgs.OriginalSource);
        }
        #endregion
        
        #region ColumnHeaderDragStarted
        public static readonly DependencyProperty ColumnHeaderDragStartedProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderDragStarted", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnHeaderDragStartedChanged));
        
        public static ICommand GetColumnHeaderDragStarted(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnHeaderDragStartedProperty);
        }
        
        public static void SetColumnHeaderDragStarted(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnHeaderDragStartedProperty, value);
        }
        
        private static void OnColumnHeaderDragStartedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnHeaderDragStarted -= OnColumnHeaderDragStarted;
                }
                if (e.NewValue != null)
                {
                    target.ColumnHeaderDragStarted += OnColumnHeaderDragStarted;
                }
            }
        }
        
        private static void OnColumnHeaderDragStarted(object o, DragStartedEventArgs eventArgs)
        {
            var command = GetColumnHeaderDragStarted((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region ColumnHeaderDragStartedNotifyHorizontalOffset
        public static readonly DependencyProperty ColumnHeaderDragStartedNotifyHorizontalOffsetProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderDragStartedNotifyHorizontalOffset", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnHeaderDragStartedNotifyHorizontalOffsetChanged));
        
        public static ICommand GetColumnHeaderDragStartedNotifyHorizontalOffset(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnHeaderDragStartedNotifyHorizontalOffsetProperty);
        }
        
        public static void SetColumnHeaderDragStartedNotifyHorizontalOffset(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnHeaderDragStartedNotifyHorizontalOffsetProperty, value);
        }
        
        private static void OnColumnHeaderDragStartedNotifyHorizontalOffsetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnHeaderDragStarted -= OnColumnHeaderDragStartedNotifyHorizontalOffset;
                }
                if (e.NewValue != null)
                {
                    target.ColumnHeaderDragStarted += OnColumnHeaderDragStartedNotifyHorizontalOffset;
                }
            }
        }
        
        private static void OnColumnHeaderDragStartedNotifyHorizontalOffset(object o, System.Windows.Controls.Primitives.DragStartedEventArgs eventArgs)
        {
            var command = GetColumnHeaderDragStartedNotifyHorizontalOffset((DependencyObject)o);
            if (command.CanExecute(eventArgs.HorizontalOffset))
                command.Execute(eventArgs.HorizontalOffset);
        }
        #endregion
        
        #region ColumnHeaderDragStartedNotifyVerticalOffset
        public static readonly DependencyProperty ColumnHeaderDragStartedNotifyVerticalOffsetProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderDragStartedNotifyVerticalOffset", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnHeaderDragStartedNotifyVerticalOffsetChanged));
        
        public static ICommand GetColumnHeaderDragStartedNotifyVerticalOffset(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnHeaderDragStartedNotifyVerticalOffsetProperty);
        }
        
        public static void SetColumnHeaderDragStartedNotifyVerticalOffset(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnHeaderDragStartedNotifyVerticalOffsetProperty, value);
        }
        
        private static void OnColumnHeaderDragStartedNotifyVerticalOffsetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnHeaderDragStarted -= OnColumnHeaderDragStartedNotifyVerticalOffset;
                }
                if (e.NewValue != null)
                {
                    target.ColumnHeaderDragStarted += OnColumnHeaderDragStartedNotifyVerticalOffset;
                }
            }
        }
        
        private static void OnColumnHeaderDragStartedNotifyVerticalOffset(object o, System.Windows.Controls.Primitives.DragStartedEventArgs eventArgs)
        {
            var command = GetColumnHeaderDragStartedNotifyVerticalOffset((DependencyObject)o);
            if (command.CanExecute(eventArgs.VerticalOffset))
                command.Execute(eventArgs.VerticalOffset);
        }
        #endregion
        
        #region ColumnHeaderDragStartedNotifyRoutedEvent
        public static readonly DependencyProperty ColumnHeaderDragStartedNotifyRoutedEventProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderDragStartedNotifyRoutedEvent", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnHeaderDragStartedNotifyRoutedEventChanged));
        
        public static ICommand GetColumnHeaderDragStartedNotifyRoutedEvent(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnHeaderDragStartedNotifyRoutedEventProperty);
        }
        
        public static void SetColumnHeaderDragStartedNotifyRoutedEvent(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnHeaderDragStartedNotifyRoutedEventProperty, value);
        }
        
        private static void OnColumnHeaderDragStartedNotifyRoutedEventChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnHeaderDragStarted -= OnColumnHeaderDragStartedNotifyRoutedEvent;
                }
                if (e.NewValue != null)
                {
                    target.ColumnHeaderDragStarted += OnColumnHeaderDragStartedNotifyRoutedEvent;
                }
            }
        }
        
        private static void OnColumnHeaderDragStartedNotifyRoutedEvent(object o, System.Windows.Controls.Primitives.DragStartedEventArgs eventArgs)
        {
            var command = GetColumnHeaderDragStartedNotifyRoutedEvent((DependencyObject)o);
            if (command.CanExecute(eventArgs.RoutedEvent))
                command.Execute(eventArgs.RoutedEvent);
        }
        #endregion
        
        #region ColumnHeaderDragStartedNotifyHandled
        public static readonly DependencyProperty ColumnHeaderDragStartedNotifyHandledProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderDragStartedNotifyHandled", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnHeaderDragStartedNotifyHandledChanged));
        
        public static ICommand GetColumnHeaderDragStartedNotifyHandled(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnHeaderDragStartedNotifyHandledProperty);
        }
        
        public static void SetColumnHeaderDragStartedNotifyHandled(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnHeaderDragStartedNotifyHandledProperty, value);
        }
        
        private static void OnColumnHeaderDragStartedNotifyHandledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnHeaderDragStarted -= OnColumnHeaderDragStartedNotifyHandled;
                }
                if (e.NewValue != null)
                {
                    target.ColumnHeaderDragStarted += OnColumnHeaderDragStartedNotifyHandled;
                }
            }
        }
        
        private static void OnColumnHeaderDragStartedNotifyHandled(object o, System.Windows.Controls.Primitives.DragStartedEventArgs eventArgs)
        {
            var command = GetColumnHeaderDragStartedNotifyHandled((DependencyObject)o);
            if (command.CanExecute(eventArgs.Handled))
                command.Execute(eventArgs.Handled);
        }
        #endregion
        
        #region ColumnHeaderDragStartedNotifySource
        public static readonly DependencyProperty ColumnHeaderDragStartedNotifySourceProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderDragStartedNotifySource", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnHeaderDragStartedNotifySourceChanged));
        
        public static ICommand GetColumnHeaderDragStartedNotifySource(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnHeaderDragStartedNotifySourceProperty);
        }
        
        public static void SetColumnHeaderDragStartedNotifySource(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnHeaderDragStartedNotifySourceProperty, value);
        }
        
        private static void OnColumnHeaderDragStartedNotifySourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnHeaderDragStarted -= OnColumnHeaderDragStartedNotifySource;
                }
                if (e.NewValue != null)
                {
                    target.ColumnHeaderDragStarted += OnColumnHeaderDragStartedNotifySource;
                }
            }
        }
        
        private static void OnColumnHeaderDragStartedNotifySource(object o, System.Windows.Controls.Primitives.DragStartedEventArgs eventArgs)
        {
            var command = GetColumnHeaderDragStartedNotifySource((DependencyObject)o);
            if (command.CanExecute(eventArgs.Source))
                command.Execute(eventArgs.Source);
        }
        #endregion
        
        #region ColumnHeaderDragStartedNotifyOriginalSource
        public static readonly DependencyProperty ColumnHeaderDragStartedNotifyOriginalSourceProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderDragStartedNotifyOriginalSource", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnHeaderDragStartedNotifyOriginalSourceChanged));
        
        public static ICommand GetColumnHeaderDragStartedNotifyOriginalSource(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnHeaderDragStartedNotifyOriginalSourceProperty);
        }
        
        public static void SetColumnHeaderDragStartedNotifyOriginalSource(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnHeaderDragStartedNotifyOriginalSourceProperty, value);
        }
        
        private static void OnColumnHeaderDragStartedNotifyOriginalSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnHeaderDragStarted -= OnColumnHeaderDragStartedNotifyOriginalSource;
                }
                if (e.NewValue != null)
                {
                    target.ColumnHeaderDragStarted += OnColumnHeaderDragStartedNotifyOriginalSource;
                }
            }
        }
        
        private static void OnColumnHeaderDragStartedNotifyOriginalSource(object o, System.Windows.Controls.Primitives.DragStartedEventArgs eventArgs)
        {
            var command = GetColumnHeaderDragStartedNotifyOriginalSource((DependencyObject)o);
            if (command.CanExecute(eventArgs.OriginalSource))
                command.Execute(eventArgs.OriginalSource);
        }
        #endregion
        
        #region ColumnReordered
        public static readonly DependencyProperty ColumnReorderedProperty =
            DependencyProperty.RegisterAttached("ColumnReordered", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnReorderedChanged));
        
        public static ICommand GetColumnReordered(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnReorderedProperty);
        }
        
        public static void SetColumnReordered(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnReorderedProperty, value);
        }
        
        private static void OnColumnReorderedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnReordered -= OnColumnReordered;
                }
                if (e.NewValue != null)
                {
                    target.ColumnReordered += OnColumnReordered;
                }
            }
        }
        
        private static void OnColumnReordered(object o, DataGridColumnEventArgs eventArgs)
        {
            var command = GetColumnReordered((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region ColumnReorderedNotifyColumn
        public static readonly DependencyProperty ColumnReorderedNotifyColumnProperty =
            DependencyProperty.RegisterAttached("ColumnReorderedNotifyColumn", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnReorderedNotifyColumnChanged));
        
        public static ICommand GetColumnReorderedNotifyColumn(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnReorderedNotifyColumnProperty);
        }
        
        public static void SetColumnReorderedNotifyColumn(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnReorderedNotifyColumnProperty, value);
        }
        
        private static void OnColumnReorderedNotifyColumnChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnReordered -= OnColumnReorderedNotifyColumn;
                }
                if (e.NewValue != null)
                {
                    target.ColumnReordered += OnColumnReorderedNotifyColumn;
                }
            }
        }
        
        private static void OnColumnReorderedNotifyColumn(object o, System.Windows.Controls.DataGridColumnEventArgs eventArgs)
        {
            var command = GetColumnReorderedNotifyColumn((DependencyObject)o);
            if (command.CanExecute(eventArgs.Column))
                command.Execute(eventArgs.Column);
        }
        #endregion
        
        #region ColumnReordering
        public static readonly DependencyProperty ColumnReorderingProperty =
            DependencyProperty.RegisterAttached("ColumnReordering", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnReorderingChanged));
        
        public static ICommand GetColumnReordering(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnReorderingProperty);
        }
        
        public static void SetColumnReordering(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnReorderingProperty, value);
        }
        
        private static void OnColumnReorderingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnReordering -= OnColumnReordering;
                }
                if (e.NewValue != null)
                {
                    target.ColumnReordering += OnColumnReordering;
                }
            }
        }
        
        private static void OnColumnReordering(object o, DataGridColumnReorderingEventArgs eventArgs)
        {
            var command = GetColumnReordering((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region ColumnReorderingNotifyCancel
        public static readonly DependencyProperty ColumnReorderingNotifyCancelProperty =
            DependencyProperty.RegisterAttached("ColumnReorderingNotifyCancel", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnReorderingNotifyCancelChanged));
        
        public static ICommand GetColumnReorderingNotifyCancel(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnReorderingNotifyCancelProperty);
        }
        
        public static void SetColumnReorderingNotifyCancel(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnReorderingNotifyCancelProperty, value);
        }
        
        private static void OnColumnReorderingNotifyCancelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnReordering -= OnColumnReorderingNotifyCancel;
                }
                if (e.NewValue != null)
                {
                    target.ColumnReordering += OnColumnReorderingNotifyCancel;
                }
            }
        }
        
        private static void OnColumnReorderingNotifyCancel(object o, System.Windows.Controls.DataGridColumnReorderingEventArgs eventArgs)
        {
            var command = GetColumnReorderingNotifyCancel((DependencyObject)o);
            if (command.CanExecute(eventArgs.Cancel))
                command.Execute(eventArgs.Cancel);
        }
        #endregion
        
        #region ColumnReorderingNotifyDropLocationIndicator
        public static readonly DependencyProperty ColumnReorderingNotifyDropLocationIndicatorProperty =
            DependencyProperty.RegisterAttached("ColumnReorderingNotifyDropLocationIndicator", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnReorderingNotifyDropLocationIndicatorChanged));
        
        public static ICommand GetColumnReorderingNotifyDropLocationIndicator(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnReorderingNotifyDropLocationIndicatorProperty);
        }
        
        public static void SetColumnReorderingNotifyDropLocationIndicator(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnReorderingNotifyDropLocationIndicatorProperty, value);
        }
        
        private static void OnColumnReorderingNotifyDropLocationIndicatorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnReordering -= OnColumnReorderingNotifyDropLocationIndicator;
                }
                if (e.NewValue != null)
                {
                    target.ColumnReordering += OnColumnReorderingNotifyDropLocationIndicator;
                }
            }
        }
        
        private static void OnColumnReorderingNotifyDropLocationIndicator(object o, System.Windows.Controls.DataGridColumnReorderingEventArgs eventArgs)
        {
            var command = GetColumnReorderingNotifyDropLocationIndicator((DependencyObject)o);
            if (command.CanExecute(eventArgs.DropLocationIndicator))
                command.Execute(eventArgs.DropLocationIndicator);
        }
        #endregion
        
        #region ColumnReorderingNotifyDragIndicator
        public static readonly DependencyProperty ColumnReorderingNotifyDragIndicatorProperty =
            DependencyProperty.RegisterAttached("ColumnReorderingNotifyDragIndicator", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnReorderingNotifyDragIndicatorChanged));
        
        public static ICommand GetColumnReorderingNotifyDragIndicator(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnReorderingNotifyDragIndicatorProperty);
        }
        
        public static void SetColumnReorderingNotifyDragIndicator(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnReorderingNotifyDragIndicatorProperty, value);
        }
        
        private static void OnColumnReorderingNotifyDragIndicatorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnReordering -= OnColumnReorderingNotifyDragIndicator;
                }
                if (e.NewValue != null)
                {
                    target.ColumnReordering += OnColumnReorderingNotifyDragIndicator;
                }
            }
        }
        
        private static void OnColumnReorderingNotifyDragIndicator(object o, System.Windows.Controls.DataGridColumnReorderingEventArgs eventArgs)
        {
            var command = GetColumnReorderingNotifyDragIndicator((DependencyObject)o);
            if (command.CanExecute(eventArgs.DragIndicator))
                command.Execute(eventArgs.DragIndicator);
        }
        #endregion
        
        #region ColumnReorderingNotifyColumn
        public static readonly DependencyProperty ColumnReorderingNotifyColumnProperty =
            DependencyProperty.RegisterAttached("ColumnReorderingNotifyColumn", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnColumnReorderingNotifyColumnChanged));
        
        public static ICommand GetColumnReorderingNotifyColumn(DependencyObject target)
        {
            return (ICommand)target.GetValue(ColumnReorderingNotifyColumnProperty);
        }
        
        public static void SetColumnReorderingNotifyColumn(DependencyObject target, ICommand value)
        {
            target.SetValue(ColumnReorderingNotifyColumnProperty, value);
        }
        
        private static void OnColumnReorderingNotifyColumnChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.ColumnReordering -= OnColumnReorderingNotifyColumn;
                }
                if (e.NewValue != null)
                {
                    target.ColumnReordering += OnColumnReorderingNotifyColumn;
                }
            }
        }
        
        private static void OnColumnReorderingNotifyColumn(object o, System.Windows.Controls.DataGridColumnReorderingEventArgs eventArgs)
        {
            var command = GetColumnReorderingNotifyColumn((DependencyObject)o);
            if (command.CanExecute(eventArgs.Column))
                command.Execute(eventArgs.Column);
        }
        #endregion
        
        #region CopyingRowClipboardContent
        public static readonly DependencyProperty CopyingRowClipboardContentProperty =
            DependencyProperty.RegisterAttached("CopyingRowClipboardContent", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnCopyingRowClipboardContentChanged));
        
        public static ICommand GetCopyingRowClipboardContent(DependencyObject target)
        {
            return (ICommand)target.GetValue(CopyingRowClipboardContentProperty);
        }
        
        public static void SetCopyingRowClipboardContent(DependencyObject target, ICommand value)
        {
            target.SetValue(CopyingRowClipboardContentProperty, value);
        }
        
        private static void OnCopyingRowClipboardContentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.CopyingRowClipboardContent -= OnCopyingRowClipboardContent;
                }
                if (e.NewValue != null)
                {
                    target.CopyingRowClipboardContent += OnCopyingRowClipboardContent;
                }
            }
        }
        
        private static void OnCopyingRowClipboardContent(object o, DataGridRowClipboardEventArgs eventArgs)
        {
            var command = GetCopyingRowClipboardContent((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region CopyingRowClipboardContentNotifyItem
        public static readonly DependencyProperty CopyingRowClipboardContentNotifyItemProperty =
            DependencyProperty.RegisterAttached("CopyingRowClipboardContentNotifyItem", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnCopyingRowClipboardContentNotifyItemChanged));
        
        public static ICommand GetCopyingRowClipboardContentNotifyItem(DependencyObject target)
        {
            return (ICommand)target.GetValue(CopyingRowClipboardContentNotifyItemProperty);
        }
        
        public static void SetCopyingRowClipboardContentNotifyItem(DependencyObject target, ICommand value)
        {
            target.SetValue(CopyingRowClipboardContentNotifyItemProperty, value);
        }
        
        private static void OnCopyingRowClipboardContentNotifyItemChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.CopyingRowClipboardContent -= OnCopyingRowClipboardContentNotifyItem;
                }
                if (e.NewValue != null)
                {
                    target.CopyingRowClipboardContent += OnCopyingRowClipboardContentNotifyItem;
                }
            }
        }
        
        private static void OnCopyingRowClipboardContentNotifyItem(object o, System.Windows.Controls.DataGridRowClipboardEventArgs eventArgs)
        {
            var command = GetCopyingRowClipboardContentNotifyItem((DependencyObject)o);
            if (command.CanExecute(eventArgs.Item))
                command.Execute(eventArgs.Item);
        }
        #endregion
        
        #region CopyingRowClipboardContentNotifyClipboardRowContent
        public static readonly DependencyProperty CopyingRowClipboardContentNotifyClipboardRowContentProperty =
            DependencyProperty.RegisterAttached("CopyingRowClipboardContentNotifyClipboardRowContent", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnCopyingRowClipboardContentNotifyClipboardRowContentChanged));
        
        public static ICommand GetCopyingRowClipboardContentNotifyClipboardRowContent(DependencyObject target)
        {
            return (ICommand)target.GetValue(CopyingRowClipboardContentNotifyClipboardRowContentProperty);
        }
        
        public static void SetCopyingRowClipboardContentNotifyClipboardRowContent(DependencyObject target, ICommand value)
        {
            target.SetValue(CopyingRowClipboardContentNotifyClipboardRowContentProperty, value);
        }
        
        private static void OnCopyingRowClipboardContentNotifyClipboardRowContentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.CopyingRowClipboardContent -= OnCopyingRowClipboardContentNotifyClipboardRowContent;
                }
                if (e.NewValue != null)
                {
                    target.CopyingRowClipboardContent += OnCopyingRowClipboardContentNotifyClipboardRowContent;
                }
            }
        }
        
        private static void OnCopyingRowClipboardContentNotifyClipboardRowContent(object o, System.Windows.Controls.DataGridRowClipboardEventArgs eventArgs)
        {
            var command = GetCopyingRowClipboardContentNotifyClipboardRowContent((DependencyObject)o);
            if (command.CanExecute(eventArgs.ClipboardRowContent))
                command.Execute(eventArgs.ClipboardRowContent);
        }
        #endregion
        
        #region CopyingRowClipboardContentNotifyStartColumnDisplayIndex
        public static readonly DependencyProperty CopyingRowClipboardContentNotifyStartColumnDisplayIndexProperty =
            DependencyProperty.RegisterAttached("CopyingRowClipboardContentNotifyStartColumnDisplayIndex", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnCopyingRowClipboardContentNotifyStartColumnDisplayIndexChanged));
        
        public static ICommand GetCopyingRowClipboardContentNotifyStartColumnDisplayIndex(DependencyObject target)
        {
            return (ICommand)target.GetValue(CopyingRowClipboardContentNotifyStartColumnDisplayIndexProperty);
        }
        
        public static void SetCopyingRowClipboardContentNotifyStartColumnDisplayIndex(DependencyObject target, ICommand value)
        {
            target.SetValue(CopyingRowClipboardContentNotifyStartColumnDisplayIndexProperty, value);
        }
        
        private static void OnCopyingRowClipboardContentNotifyStartColumnDisplayIndexChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.CopyingRowClipboardContent -= OnCopyingRowClipboardContentNotifyStartColumnDisplayIndex;
                }
                if (e.NewValue != null)
                {
                    target.CopyingRowClipboardContent += OnCopyingRowClipboardContentNotifyStartColumnDisplayIndex;
                }
            }
        }
        
        private static void OnCopyingRowClipboardContentNotifyStartColumnDisplayIndex(object o, System.Windows.Controls.DataGridRowClipboardEventArgs eventArgs)
        {
            var command = GetCopyingRowClipboardContentNotifyStartColumnDisplayIndex((DependencyObject)o);
            if (command.CanExecute(eventArgs.StartColumnDisplayIndex))
                command.Execute(eventArgs.StartColumnDisplayIndex);
        }
        #endregion
        
        #region CopyingRowClipboardContentNotifyEndColumnDisplayIndex
        public static readonly DependencyProperty CopyingRowClipboardContentNotifyEndColumnDisplayIndexProperty =
            DependencyProperty.RegisterAttached("CopyingRowClipboardContentNotifyEndColumnDisplayIndex", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnCopyingRowClipboardContentNotifyEndColumnDisplayIndexChanged));
        
        public static ICommand GetCopyingRowClipboardContentNotifyEndColumnDisplayIndex(DependencyObject target)
        {
            return (ICommand)target.GetValue(CopyingRowClipboardContentNotifyEndColumnDisplayIndexProperty);
        }
        
        public static void SetCopyingRowClipboardContentNotifyEndColumnDisplayIndex(DependencyObject target, ICommand value)
        {
            target.SetValue(CopyingRowClipboardContentNotifyEndColumnDisplayIndexProperty, value);
        }
        
        private static void OnCopyingRowClipboardContentNotifyEndColumnDisplayIndexChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.CopyingRowClipboardContent -= OnCopyingRowClipboardContentNotifyEndColumnDisplayIndex;
                }
                if (e.NewValue != null)
                {
                    target.CopyingRowClipboardContent += OnCopyingRowClipboardContentNotifyEndColumnDisplayIndex;
                }
            }
        }
        
        private static void OnCopyingRowClipboardContentNotifyEndColumnDisplayIndex(object o, System.Windows.Controls.DataGridRowClipboardEventArgs eventArgs)
        {
            var command = GetCopyingRowClipboardContentNotifyEndColumnDisplayIndex((DependencyObject)o);
            if (command.CanExecute(eventArgs.EndColumnDisplayIndex))
                command.Execute(eventArgs.EndColumnDisplayIndex);
        }
        #endregion
        
        #region CopyingRowClipboardContentNotifyIsColumnHeadersRow
        public static readonly DependencyProperty CopyingRowClipboardContentNotifyIsColumnHeadersRowProperty =
            DependencyProperty.RegisterAttached("CopyingRowClipboardContentNotifyIsColumnHeadersRow", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnCopyingRowClipboardContentNotifyIsColumnHeadersRowChanged));
        
        public static ICommand GetCopyingRowClipboardContentNotifyIsColumnHeadersRow(DependencyObject target)
        {
            return (ICommand)target.GetValue(CopyingRowClipboardContentNotifyIsColumnHeadersRowProperty);
        }
        
        public static void SetCopyingRowClipboardContentNotifyIsColumnHeadersRow(DependencyObject target, ICommand value)
        {
            target.SetValue(CopyingRowClipboardContentNotifyIsColumnHeadersRowProperty, value);
        }
        
        private static void OnCopyingRowClipboardContentNotifyIsColumnHeadersRowChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.CopyingRowClipboardContent -= OnCopyingRowClipboardContentNotifyIsColumnHeadersRow;
                }
                if (e.NewValue != null)
                {
                    target.CopyingRowClipboardContent += OnCopyingRowClipboardContentNotifyIsColumnHeadersRow;
                }
            }
        }
        
        private static void OnCopyingRowClipboardContentNotifyIsColumnHeadersRow(object o, System.Windows.Controls.DataGridRowClipboardEventArgs eventArgs)
        {
            var command = GetCopyingRowClipboardContentNotifyIsColumnHeadersRow((DependencyObject)o);
            if (command.CanExecute(eventArgs.IsColumnHeadersRow))
                command.Execute(eventArgs.IsColumnHeadersRow);
        }
        #endregion
        
        #region CurrentCellChanged
        public static readonly DependencyProperty CurrentCellChangedProperty =
            DependencyProperty.RegisterAttached("CurrentCellChanged", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnCurrentCellChangedChanged));
        
        public static ICommand GetCurrentCellChanged(DependencyObject target)
        {
            return (ICommand)target.GetValue(CurrentCellChangedProperty);
        }
        
        public static void SetCurrentCellChanged(DependencyObject target, ICommand value)
        {
            target.SetValue(CurrentCellChangedProperty, value);
        }
        
        private static void OnCurrentCellChangedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.CurrentCellChanged -= OnCurrentCellChanged;
                }
                if (e.NewValue != null)
                {
                    target.CurrentCellChanged += OnCurrentCellChanged;
                }
            }
        }
        
        private static void OnCurrentCellChanged(object o, EventArgs eventArgs)
        {
            var command = GetCurrentCellChanged((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region InitializingNewItem
        public static readonly DependencyProperty InitializingNewItemProperty =
            DependencyProperty.RegisterAttached("InitializingNewItem", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnInitializingNewItemChanged));
        
        public static ICommand GetInitializingNewItem(DependencyObject target)
        {
            return (ICommand)target.GetValue(InitializingNewItemProperty);
        }
        
        public static void SetInitializingNewItem(DependencyObject target, ICommand value)
        {
            target.SetValue(InitializingNewItemProperty, value);
        }
        
        private static void OnInitializingNewItemChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.InitializingNewItem -= OnInitializingNewItem;
                }
                if (e.NewValue != null)
                {
                    target.InitializingNewItem += OnInitializingNewItem;
                }
            }
        }
        
        private static void OnInitializingNewItem(object o, InitializingNewItemEventArgs eventArgs)
        {
            var command = GetInitializingNewItem((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region LoadingRow
        public static readonly DependencyProperty LoadingRowProperty =
            DependencyProperty.RegisterAttached("LoadingRow", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnLoadingRowChanged));
        
        public static ICommand GetLoadingRow(DependencyObject target)
        {
            return (ICommand)target.GetValue(LoadingRowProperty);
        }
        
        public static void SetLoadingRow(DependencyObject target, ICommand value)
        {
            target.SetValue(LoadingRowProperty, value);
        }
        
        private static void OnLoadingRowChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.LoadingRow -= OnLoadingRow;
                }
                if (e.NewValue != null)
                {
                    target.LoadingRow += OnLoadingRow;
                }
            }
        }
        
        private static void OnLoadingRow(object o, DataGridRowEventArgs eventArgs)
        {
            var command = GetLoadingRow((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region LoadingRowNotifyRow
        public static readonly DependencyProperty LoadingRowNotifyRowProperty =
            DependencyProperty.RegisterAttached("LoadingRowNotifyRow", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnLoadingRowNotifyRowChanged));
        
        public static ICommand GetLoadingRowNotifyRow(DependencyObject target)
        {
            return (ICommand)target.GetValue(LoadingRowNotifyRowProperty);
        }
        
        public static void SetLoadingRowNotifyRow(DependencyObject target, ICommand value)
        {
            target.SetValue(LoadingRowNotifyRowProperty, value);
        }
        
        private static void OnLoadingRowNotifyRowChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.LoadingRow -= OnLoadingRowNotifyRow;
                }
                if (e.NewValue != null)
                {
                    target.LoadingRow += OnLoadingRowNotifyRow;
                }
            }
        }
        
        private static void OnLoadingRowNotifyRow(object o, System.Windows.Controls.DataGridRowEventArgs eventArgs)
        {
            var command = GetLoadingRowNotifyRow((DependencyObject)o);
            if (command.CanExecute(eventArgs.Row))
                command.Execute(eventArgs.Row);
        }
        #endregion
        
        #region LoadingRowDetails
        public static readonly DependencyProperty LoadingRowDetailsProperty =
            DependencyProperty.RegisterAttached("LoadingRowDetails", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnLoadingRowDetailsChanged));
        
        public static ICommand GetLoadingRowDetails(DependencyObject target)
        {
            return (ICommand)target.GetValue(LoadingRowDetailsProperty);
        }
        
        public static void SetLoadingRowDetails(DependencyObject target, ICommand value)
        {
            target.SetValue(LoadingRowDetailsProperty, value);
        }
        
        private static void OnLoadingRowDetailsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.LoadingRowDetails -= OnLoadingRowDetails;
                }
                if (e.NewValue != null)
                {
                    target.LoadingRowDetails += OnLoadingRowDetails;
                }
            }
        }
        
        private static void OnLoadingRowDetails(object o, DataGridRowDetailsEventArgs eventArgs)
        {
            var command = GetLoadingRowDetails((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region LoadingRowDetailsNotifyDetailsElement
        public static readonly DependencyProperty LoadingRowDetailsNotifyDetailsElementProperty =
            DependencyProperty.RegisterAttached("LoadingRowDetailsNotifyDetailsElement", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnLoadingRowDetailsNotifyDetailsElementChanged));
        
        public static ICommand GetLoadingRowDetailsNotifyDetailsElement(DependencyObject target)
        {
            return (ICommand)target.GetValue(LoadingRowDetailsNotifyDetailsElementProperty);
        }
        
        public static void SetLoadingRowDetailsNotifyDetailsElement(DependencyObject target, ICommand value)
        {
            target.SetValue(LoadingRowDetailsNotifyDetailsElementProperty, value);
        }
        
        private static void OnLoadingRowDetailsNotifyDetailsElementChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.LoadingRowDetails -= OnLoadingRowDetailsNotifyDetailsElement;
                }
                if (e.NewValue != null)
                {
                    target.LoadingRowDetails += OnLoadingRowDetailsNotifyDetailsElement;
                }
            }
        }
        
        private static void OnLoadingRowDetailsNotifyDetailsElement(object o, System.Windows.Controls.DataGridRowDetailsEventArgs eventArgs)
        {
            var command = GetLoadingRowDetailsNotifyDetailsElement((DependencyObject)o);
            if (command.CanExecute(eventArgs.DetailsElement))
                command.Execute(eventArgs.DetailsElement);
        }
        #endregion
        
        #region LoadingRowDetailsNotifyRow
        public static readonly DependencyProperty LoadingRowDetailsNotifyRowProperty =
            DependencyProperty.RegisterAttached("LoadingRowDetailsNotifyRow", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnLoadingRowDetailsNotifyRowChanged));
        
        public static ICommand GetLoadingRowDetailsNotifyRow(DependencyObject target)
        {
            return (ICommand)target.GetValue(LoadingRowDetailsNotifyRowProperty);
        }
        
        public static void SetLoadingRowDetailsNotifyRow(DependencyObject target, ICommand value)
        {
            target.SetValue(LoadingRowDetailsNotifyRowProperty, value);
        }
        
        private static void OnLoadingRowDetailsNotifyRowChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.LoadingRowDetails -= OnLoadingRowDetailsNotifyRow;
                }
                if (e.NewValue != null)
                {
                    target.LoadingRowDetails += OnLoadingRowDetailsNotifyRow;
                }
            }
        }
        
        private static void OnLoadingRowDetailsNotifyRow(object o, System.Windows.Controls.DataGridRowDetailsEventArgs eventArgs)
        {
            var command = GetLoadingRowDetailsNotifyRow((DependencyObject)o);
            if (command.CanExecute(eventArgs.Row))
                command.Execute(eventArgs.Row);
        }
        #endregion
        
        #region PreparingCellForEdit
        public static readonly DependencyProperty PreparingCellForEditProperty =
            DependencyProperty.RegisterAttached("PreparingCellForEdit", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnPreparingCellForEditChanged));
        
        public static ICommand GetPreparingCellForEdit(DependencyObject target)
        {
            return (ICommand)target.GetValue(PreparingCellForEditProperty);
        }
        
        public static void SetPreparingCellForEdit(DependencyObject target, ICommand value)
        {
            target.SetValue(PreparingCellForEditProperty, value);
        }
        
        private static void OnPreparingCellForEditChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.PreparingCellForEdit -= OnPreparingCellForEdit;
                }
                if (e.NewValue != null)
                {
                    target.PreparingCellForEdit += OnPreparingCellForEdit;
                }
            }
        }
        
        private static void OnPreparingCellForEdit(object o, DataGridPreparingCellForEditEventArgs eventArgs)
        {
            var command = GetPreparingCellForEdit((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region PreparingCellForEditNotifyColumn
        public static readonly DependencyProperty PreparingCellForEditNotifyColumnProperty =
            DependencyProperty.RegisterAttached("PreparingCellForEditNotifyColumn", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnPreparingCellForEditNotifyColumnChanged));
        
        public static ICommand GetPreparingCellForEditNotifyColumn(DependencyObject target)
        {
            return (ICommand)target.GetValue(PreparingCellForEditNotifyColumnProperty);
        }
        
        public static void SetPreparingCellForEditNotifyColumn(DependencyObject target, ICommand value)
        {
            target.SetValue(PreparingCellForEditNotifyColumnProperty, value);
        }
        
        private static void OnPreparingCellForEditNotifyColumnChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.PreparingCellForEdit -= OnPreparingCellForEditNotifyColumn;
                }
                if (e.NewValue != null)
                {
                    target.PreparingCellForEdit += OnPreparingCellForEditNotifyColumn;
                }
            }
        }
        
        private static void OnPreparingCellForEditNotifyColumn(object o, System.Windows.Controls.DataGridPreparingCellForEditEventArgs eventArgs)
        {
            var command = GetPreparingCellForEditNotifyColumn((DependencyObject)o);
            if (command.CanExecute(eventArgs.Column))
                command.Execute(eventArgs.Column);
        }
        #endregion
        
        #region PreparingCellForEditNotifyRow
        public static readonly DependencyProperty PreparingCellForEditNotifyRowProperty =
            DependencyProperty.RegisterAttached("PreparingCellForEditNotifyRow", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnPreparingCellForEditNotifyRowChanged));
        
        public static ICommand GetPreparingCellForEditNotifyRow(DependencyObject target)
        {
            return (ICommand)target.GetValue(PreparingCellForEditNotifyRowProperty);
        }
        
        public static void SetPreparingCellForEditNotifyRow(DependencyObject target, ICommand value)
        {
            target.SetValue(PreparingCellForEditNotifyRowProperty, value);
        }
        
        private static void OnPreparingCellForEditNotifyRowChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.PreparingCellForEdit -= OnPreparingCellForEditNotifyRow;
                }
                if (e.NewValue != null)
                {
                    target.PreparingCellForEdit += OnPreparingCellForEditNotifyRow;
                }
            }
        }
        
        private static void OnPreparingCellForEditNotifyRow(object o, System.Windows.Controls.DataGridPreparingCellForEditEventArgs eventArgs)
        {
            var command = GetPreparingCellForEditNotifyRow((DependencyObject)o);
            if (command.CanExecute(eventArgs.Row))
                command.Execute(eventArgs.Row);
        }
        #endregion
        
        #region PreparingCellForEditNotifyEditingEventArgs
        public static readonly DependencyProperty PreparingCellForEditNotifyEditingEventArgsProperty =
            DependencyProperty.RegisterAttached("PreparingCellForEditNotifyEditingEventArgs", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnPreparingCellForEditNotifyEditingEventArgsChanged));
        
        public static ICommand GetPreparingCellForEditNotifyEditingEventArgs(DependencyObject target)
        {
            return (ICommand)target.GetValue(PreparingCellForEditNotifyEditingEventArgsProperty);
        }
        
        public static void SetPreparingCellForEditNotifyEditingEventArgs(DependencyObject target, ICommand value)
        {
            target.SetValue(PreparingCellForEditNotifyEditingEventArgsProperty, value);
        }
        
        private static void OnPreparingCellForEditNotifyEditingEventArgsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.PreparingCellForEdit -= OnPreparingCellForEditNotifyEditingEventArgs;
                }
                if (e.NewValue != null)
                {
                    target.PreparingCellForEdit += OnPreparingCellForEditNotifyEditingEventArgs;
                }
            }
        }
        
        private static void OnPreparingCellForEditNotifyEditingEventArgs(object o, System.Windows.Controls.DataGridPreparingCellForEditEventArgs eventArgs)
        {
            var command = GetPreparingCellForEditNotifyEditingEventArgs((DependencyObject)o);
            if (command.CanExecute(eventArgs.EditingEventArgs))
                command.Execute(eventArgs.EditingEventArgs);
        }
        #endregion
        
        #region PreparingCellForEditNotifyEditingElement
        public static readonly DependencyProperty PreparingCellForEditNotifyEditingElementProperty =
            DependencyProperty.RegisterAttached("PreparingCellForEditNotifyEditingElement", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnPreparingCellForEditNotifyEditingElementChanged));
        
        public static ICommand GetPreparingCellForEditNotifyEditingElement(DependencyObject target)
        {
            return (ICommand)target.GetValue(PreparingCellForEditNotifyEditingElementProperty);
        }
        
        public static void SetPreparingCellForEditNotifyEditingElement(DependencyObject target, ICommand value)
        {
            target.SetValue(PreparingCellForEditNotifyEditingElementProperty, value);
        }
        
        private static void OnPreparingCellForEditNotifyEditingElementChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.PreparingCellForEdit -= OnPreparingCellForEditNotifyEditingElement;
                }
                if (e.NewValue != null)
                {
                    target.PreparingCellForEdit += OnPreparingCellForEditNotifyEditingElement;
                }
            }
        }
        
        private static void OnPreparingCellForEditNotifyEditingElement(object o, System.Windows.Controls.DataGridPreparingCellForEditEventArgs eventArgs)
        {
            var command = GetPreparingCellForEditNotifyEditingElement((DependencyObject)o);
            if (command.CanExecute(eventArgs.EditingElement))
                command.Execute(eventArgs.EditingElement);
        }
        #endregion
        
        #region RowDetailsVisibilityChanged
        public static readonly DependencyProperty RowDetailsVisibilityChangedProperty =
            DependencyProperty.RegisterAttached("RowDetailsVisibilityChanged", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnRowDetailsVisibilityChangedChanged));
        
        public static ICommand GetRowDetailsVisibilityChanged(DependencyObject target)
        {
            return (ICommand)target.GetValue(RowDetailsVisibilityChangedProperty);
        }
        
        public static void SetRowDetailsVisibilityChanged(DependencyObject target, ICommand value)
        {
            target.SetValue(RowDetailsVisibilityChangedProperty, value);
        }
        
        private static void OnRowDetailsVisibilityChangedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.RowDetailsVisibilityChanged -= OnRowDetailsVisibilityChanged;
                }
                if (e.NewValue != null)
                {
                    target.RowDetailsVisibilityChanged += OnRowDetailsVisibilityChanged;
                }
            }
        }
        
        private static void OnRowDetailsVisibilityChanged(object o, DataGridRowDetailsEventArgs eventArgs)
        {
            var command = GetRowDetailsVisibilityChanged((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region RowDetailsVisibilityChangedNotifyDetailsElement
        public static readonly DependencyProperty RowDetailsVisibilityChangedNotifyDetailsElementProperty =
            DependencyProperty.RegisterAttached("RowDetailsVisibilityChangedNotifyDetailsElement", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnRowDetailsVisibilityChangedNotifyDetailsElementChanged));
        
        public static ICommand GetRowDetailsVisibilityChangedNotifyDetailsElement(DependencyObject target)
        {
            return (ICommand)target.GetValue(RowDetailsVisibilityChangedNotifyDetailsElementProperty);
        }
        
        public static void SetRowDetailsVisibilityChangedNotifyDetailsElement(DependencyObject target, ICommand value)
        {
            target.SetValue(RowDetailsVisibilityChangedNotifyDetailsElementProperty, value);
        }
        
        private static void OnRowDetailsVisibilityChangedNotifyDetailsElementChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.RowDetailsVisibilityChanged -= OnRowDetailsVisibilityChangedNotifyDetailsElement;
                }
                if (e.NewValue != null)
                {
                    target.RowDetailsVisibilityChanged += OnRowDetailsVisibilityChangedNotifyDetailsElement;
                }
            }
        }
        
        private static void OnRowDetailsVisibilityChangedNotifyDetailsElement(object o, System.Windows.Controls.DataGridRowDetailsEventArgs eventArgs)
        {
            var command = GetRowDetailsVisibilityChangedNotifyDetailsElement((DependencyObject)o);
            if (command.CanExecute(eventArgs.DetailsElement))
                command.Execute(eventArgs.DetailsElement);
        }
        #endregion
        
        #region RowDetailsVisibilityChangedNotifyRow
        public static readonly DependencyProperty RowDetailsVisibilityChangedNotifyRowProperty =
            DependencyProperty.RegisterAttached("RowDetailsVisibilityChangedNotifyRow", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnRowDetailsVisibilityChangedNotifyRowChanged));
        
        public static ICommand GetRowDetailsVisibilityChangedNotifyRow(DependencyObject target)
        {
            return (ICommand)target.GetValue(RowDetailsVisibilityChangedNotifyRowProperty);
        }
        
        public static void SetRowDetailsVisibilityChangedNotifyRow(DependencyObject target, ICommand value)
        {
            target.SetValue(RowDetailsVisibilityChangedNotifyRowProperty, value);
        }
        
        private static void OnRowDetailsVisibilityChangedNotifyRowChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.RowDetailsVisibilityChanged -= OnRowDetailsVisibilityChangedNotifyRow;
                }
                if (e.NewValue != null)
                {
                    target.RowDetailsVisibilityChanged += OnRowDetailsVisibilityChangedNotifyRow;
                }
            }
        }
        
        private static void OnRowDetailsVisibilityChangedNotifyRow(object o, System.Windows.Controls.DataGridRowDetailsEventArgs eventArgs)
        {
            var command = GetRowDetailsVisibilityChangedNotifyRow((DependencyObject)o);
            if (command.CanExecute(eventArgs.Row))
                command.Execute(eventArgs.Row);
        }
        #endregion
        
        #region RowEditEnding
        public static readonly DependencyProperty RowEditEndingProperty =
            DependencyProperty.RegisterAttached("RowEditEnding", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnRowEditEndingChanged));
        
        public static ICommand GetRowEditEnding(DependencyObject target)
        {
            return (ICommand)target.GetValue(RowEditEndingProperty);
        }
        
        public static void SetRowEditEnding(DependencyObject target, ICommand value)
        {
            target.SetValue(RowEditEndingProperty, value);
        }
        
        private static void OnRowEditEndingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.RowEditEnding -= OnRowEditEnding;
                }
                if (e.NewValue != null)
                {
                    target.RowEditEnding += OnRowEditEnding;
                }
            }
        }
        
        private static void OnRowEditEnding(object o, DataGridRowEditEndingEventArgs eventArgs)
        {
            var command = GetRowEditEnding((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region RowEditEndingNotifyCancel
        public static readonly DependencyProperty RowEditEndingNotifyCancelProperty =
            DependencyProperty.RegisterAttached("RowEditEndingNotifyCancel", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnRowEditEndingNotifyCancelChanged));
        
        public static ICommand GetRowEditEndingNotifyCancel(DependencyObject target)
        {
            return (ICommand)target.GetValue(RowEditEndingNotifyCancelProperty);
        }
        
        public static void SetRowEditEndingNotifyCancel(DependencyObject target, ICommand value)
        {
            target.SetValue(RowEditEndingNotifyCancelProperty, value);
        }
        
        private static void OnRowEditEndingNotifyCancelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.RowEditEnding -= OnRowEditEndingNotifyCancel;
                }
                if (e.NewValue != null)
                {
                    target.RowEditEnding += OnRowEditEndingNotifyCancel;
                }
            }
        }
        
        private static void OnRowEditEndingNotifyCancel(object o, System.Windows.Controls.DataGridRowEditEndingEventArgs eventArgs)
        {
            var command = GetRowEditEndingNotifyCancel((DependencyObject)o);
            if (command.CanExecute(eventArgs.Cancel))
                command.Execute(eventArgs.Cancel);
        }
        #endregion
        
        #region RowEditEndingNotifyRow
        public static readonly DependencyProperty RowEditEndingNotifyRowProperty =
            DependencyProperty.RegisterAttached("RowEditEndingNotifyRow", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnRowEditEndingNotifyRowChanged));
        
        public static ICommand GetRowEditEndingNotifyRow(DependencyObject target)
        {
            return (ICommand)target.GetValue(RowEditEndingNotifyRowProperty);
        }
        
        public static void SetRowEditEndingNotifyRow(DependencyObject target, ICommand value)
        {
            target.SetValue(RowEditEndingNotifyRowProperty, value);
        }
        
        private static void OnRowEditEndingNotifyRowChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.RowEditEnding -= OnRowEditEndingNotifyRow;
                }
                if (e.NewValue != null)
                {
                    target.RowEditEnding += OnRowEditEndingNotifyRow;
                }
            }
        }
        
        private static void OnRowEditEndingNotifyRow(object o, System.Windows.Controls.DataGridRowEditEndingEventArgs eventArgs)
        {
            var command = GetRowEditEndingNotifyRow((DependencyObject)o);
            if (command.CanExecute(eventArgs.Row))
                command.Execute(eventArgs.Row);
        }
        #endregion
        
        #region RowEditEndingNotifyEditAction
        public static readonly DependencyProperty RowEditEndingNotifyEditActionProperty =
            DependencyProperty.RegisterAttached("RowEditEndingNotifyEditAction", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnRowEditEndingNotifyEditActionChanged));
        
        public static ICommand GetRowEditEndingNotifyEditAction(DependencyObject target)
        {
            return (ICommand)target.GetValue(RowEditEndingNotifyEditActionProperty);
        }
        
        public static void SetRowEditEndingNotifyEditAction(DependencyObject target, ICommand value)
        {
            target.SetValue(RowEditEndingNotifyEditActionProperty, value);
        }
        
        private static void OnRowEditEndingNotifyEditActionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.RowEditEnding -= OnRowEditEndingNotifyEditAction;
                }
                if (e.NewValue != null)
                {
                    target.RowEditEnding += OnRowEditEndingNotifyEditAction;
                }
            }
        }
        
        private static void OnRowEditEndingNotifyEditAction(object o, System.Windows.Controls.DataGridRowEditEndingEventArgs eventArgs)
        {
            var command = GetRowEditEndingNotifyEditAction((DependencyObject)o);
            if (command.CanExecute(eventArgs.EditAction))
                command.Execute(eventArgs.EditAction);
        }
        #endregion
        
        #region SelectedCellsChanged
        public static readonly DependencyProperty SelectedCellsChangedProperty =
            DependencyProperty.RegisterAttached("SelectedCellsChanged", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnSelectedCellsChangedChanged));
        
        public static ICommand GetSelectedCellsChanged(DependencyObject target)
        {
            return (ICommand)target.GetValue(SelectedCellsChangedProperty);
        }
        
        public static void SetSelectedCellsChanged(DependencyObject target, ICommand value)
        {
            target.SetValue(SelectedCellsChangedProperty, value);
        }
        
        private static void OnSelectedCellsChangedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.SelectedCellsChanged -= OnSelectedCellsChanged;
                }
                if (e.NewValue != null)
                {
                    target.SelectedCellsChanged += OnSelectedCellsChanged;
                }
            }
        }
        
        private static void OnSelectedCellsChanged(object o, SelectedCellsChangedEventArgs eventArgs)
        {
            var command = GetSelectedCellsChanged((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Sorting
        public static readonly DependencyProperty SortingProperty =
            DependencyProperty.RegisterAttached("Sorting", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnSortingChanged));
        
        public static ICommand GetSorting(DependencyObject target)
        {
            return (ICommand)target.GetValue(SortingProperty);
        }
        
        public static void SetSorting(DependencyObject target, ICommand value)
        {
            target.SetValue(SortingProperty, value);
        }
        
        private static void OnSortingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.Sorting -= OnSorting;
                }
                if (e.NewValue != null)
                {
                    target.Sorting += OnSorting;
                }
            }
        }
        
        private static void OnSorting(object o, DataGridSortingEventArgs eventArgs)
        {
            var command = GetSorting((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region UnloadingRow
        public static readonly DependencyProperty UnloadingRowProperty =
            DependencyProperty.RegisterAttached("UnloadingRow", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnUnloadingRowChanged));
        
        public static ICommand GetUnloadingRow(DependencyObject target)
        {
            return (ICommand)target.GetValue(UnloadingRowProperty);
        }
        
        public static void SetUnloadingRow(DependencyObject target, ICommand value)
        {
            target.SetValue(UnloadingRowProperty, value);
        }
        
        private static void OnUnloadingRowChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.UnloadingRow -= OnUnloadingRow;
                }
                if (e.NewValue != null)
                {
                    target.UnloadingRow += OnUnloadingRow;
                }
            }
        }
        
        private static void OnUnloadingRow(object o, DataGridRowEventArgs eventArgs)
        {
            var command = GetUnloadingRow((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region UnloadingRowNotifyRow
        public static readonly DependencyProperty UnloadingRowNotifyRowProperty =
            DependencyProperty.RegisterAttached("UnloadingRowNotifyRow", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnUnloadingRowNotifyRowChanged));
        
        public static ICommand GetUnloadingRowNotifyRow(DependencyObject target)
        {
            return (ICommand)target.GetValue(UnloadingRowNotifyRowProperty);
        }
        
        public static void SetUnloadingRowNotifyRow(DependencyObject target, ICommand value)
        {
            target.SetValue(UnloadingRowNotifyRowProperty, value);
        }
        
        private static void OnUnloadingRowNotifyRowChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.UnloadingRow -= OnUnloadingRowNotifyRow;
                }
                if (e.NewValue != null)
                {
                    target.UnloadingRow += OnUnloadingRowNotifyRow;
                }
            }
        }
        
        private static void OnUnloadingRowNotifyRow(object o, System.Windows.Controls.DataGridRowEventArgs eventArgs)
        {
            var command = GetUnloadingRowNotifyRow((DependencyObject)o);
            if (command.CanExecute(eventArgs.Row))
                command.Execute(eventArgs.Row);
        }
        #endregion
        
        #region UnloadingRowDetails
        public static readonly DependencyProperty UnloadingRowDetailsProperty =
            DependencyProperty.RegisterAttached("UnloadingRowDetails", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnUnloadingRowDetailsChanged));
        
        public static ICommand GetUnloadingRowDetails(DependencyObject target)
        {
            return (ICommand)target.GetValue(UnloadingRowDetailsProperty);
        }
        
        public static void SetUnloadingRowDetails(DependencyObject target, ICommand value)
        {
            target.SetValue(UnloadingRowDetailsProperty, value);
        }
        
        private static void OnUnloadingRowDetailsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.UnloadingRowDetails -= OnUnloadingRowDetails;
                }
                if (e.NewValue != null)
                {
                    target.UnloadingRowDetails += OnUnloadingRowDetails;
                }
            }
        }
        
        private static void OnUnloadingRowDetails(object o, DataGridRowDetailsEventArgs eventArgs)
        {
            var command = GetUnloadingRowDetails((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region UnloadingRowDetailsNotifyDetailsElement
        public static readonly DependencyProperty UnloadingRowDetailsNotifyDetailsElementProperty =
            DependencyProperty.RegisterAttached("UnloadingRowDetailsNotifyDetailsElement", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnUnloadingRowDetailsNotifyDetailsElementChanged));
        
        public static ICommand GetUnloadingRowDetailsNotifyDetailsElement(DependencyObject target)
        {
            return (ICommand)target.GetValue(UnloadingRowDetailsNotifyDetailsElementProperty);
        }
        
        public static void SetUnloadingRowDetailsNotifyDetailsElement(DependencyObject target, ICommand value)
        {
            target.SetValue(UnloadingRowDetailsNotifyDetailsElementProperty, value);
        }
        
        private static void OnUnloadingRowDetailsNotifyDetailsElementChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.UnloadingRowDetails -= OnUnloadingRowDetailsNotifyDetailsElement;
                }
                if (e.NewValue != null)
                {
                    target.UnloadingRowDetails += OnUnloadingRowDetailsNotifyDetailsElement;
                }
            }
        }
        
        private static void OnUnloadingRowDetailsNotifyDetailsElement(object o, System.Windows.Controls.DataGridRowDetailsEventArgs eventArgs)
        {
            var command = GetUnloadingRowDetailsNotifyDetailsElement((DependencyObject)o);
            if (command.CanExecute(eventArgs.DetailsElement))
                command.Execute(eventArgs.DetailsElement);
        }
        #endregion
        
        #region UnloadingRowDetailsNotifyRow
        public static readonly DependencyProperty UnloadingRowDetailsNotifyRowProperty =
            DependencyProperty.RegisterAttached("UnloadingRowDetailsNotifyRow", typeof(ICommand), typeof(DataGrids), new FrameworkPropertyMetadata(OnUnloadingRowDetailsNotifyRowChanged));
        
        public static ICommand GetUnloadingRowDetailsNotifyRow(DependencyObject target)
        {
            return (ICommand)target.GetValue(UnloadingRowDetailsNotifyRowProperty);
        }
        
        public static void SetUnloadingRowDetailsNotifyRow(DependencyObject target, ICommand value)
        {
            target.SetValue(UnloadingRowDetailsNotifyRowProperty, value);
        }
        
        private static void OnUnloadingRowDetailsNotifyRowChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid target)
            {
                if (e.OldValue != null)
                {
                    target.UnloadingRowDetails -= OnUnloadingRowDetailsNotifyRow;
                }
                if (e.NewValue != null)
                {
                    target.UnloadingRowDetails += OnUnloadingRowDetailsNotifyRow;
                }
            }
        }
        
        private static void OnUnloadingRowDetailsNotifyRow(object o, System.Windows.Controls.DataGridRowDetailsEventArgs eventArgs)
        {
            var command = GetUnloadingRowDetailsNotifyRow((DependencyObject)o);
            if (command.CanExecute(eventArgs.Row))
                command.Execute(eventArgs.Row);
        }
        #endregion
	}
	#endregion

	#region DataGridCells
	public static partial class DataGridCells {
        
        #region Selected
        public static readonly DependencyProperty SelectedProperty =
            DependencyProperty.RegisterAttached("Selected", typeof(ICommand), typeof(DataGridCells), new FrameworkPropertyMetadata(OnSelectedChanged));
        
        public static ICommand GetSelected(DependencyObject target)
        {
            return (ICommand)target.GetValue(SelectedProperty);
        }
        
        public static void SetSelected(DependencyObject target, ICommand value)
        {
            target.SetValue(SelectedProperty, value);
        }
        
        private static void OnSelectedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGridCell target)
            {
                if (e.OldValue != null)
                {
                    target.Selected -= OnSelected;
                }
                if (e.NewValue != null)
                {
                    target.Selected += OnSelected;
                }
            }
        }
        
        private static void OnSelected(object o, RoutedEventArgs eventArgs)
        {
            var command = GetSelected((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Unselected
        public static readonly DependencyProperty UnselectedProperty =
            DependencyProperty.RegisterAttached("Unselected", typeof(ICommand), typeof(DataGridCells), new FrameworkPropertyMetadata(OnUnselectedChanged));
        
        public static ICommand GetUnselected(DependencyObject target)
        {
            return (ICommand)target.GetValue(UnselectedProperty);
        }
        
        public static void SetUnselected(DependencyObject target, ICommand value)
        {
            target.SetValue(UnselectedProperty, value);
        }
        
        private static void OnUnselectedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGridCell target)
            {
                if (e.OldValue != null)
                {
                    target.Unselected -= OnUnselected;
                }
                if (e.NewValue != null)
                {
                    target.Unselected += OnUnselected;
                }
            }
        }
        
        private static void OnUnselected(object o, RoutedEventArgs eventArgs)
        {
            var command = GetUnselected((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region DataGridRows
	public static partial class DataGridRows {
        
        #region Selected
        public static readonly DependencyProperty SelectedProperty =
            DependencyProperty.RegisterAttached("Selected", typeof(ICommand), typeof(DataGridRows), new FrameworkPropertyMetadata(OnSelectedChanged));
        
        public static ICommand GetSelected(DependencyObject target)
        {
            return (ICommand)target.GetValue(SelectedProperty);
        }
        
        public static void SetSelected(DependencyObject target, ICommand value)
        {
            target.SetValue(SelectedProperty, value);
        }
        
        private static void OnSelectedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGridRow target)
            {
                if (e.OldValue != null)
                {
                    target.Selected -= OnSelected;
                }
                if (e.NewValue != null)
                {
                    target.Selected += OnSelected;
                }
            }
        }
        
        private static void OnSelected(object o, RoutedEventArgs eventArgs)
        {
            var command = GetSelected((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Unselected
        public static readonly DependencyProperty UnselectedProperty =
            DependencyProperty.RegisterAttached("Unselected", typeof(ICommand), typeof(DataGridRows), new FrameworkPropertyMetadata(OnUnselectedChanged));
        
        public static ICommand GetUnselected(DependencyObject target)
        {
            return (ICommand)target.GetValue(UnselectedProperty);
        }
        
        public static void SetUnselected(DependencyObject target, ICommand value)
        {
            target.SetValue(UnselectedProperty, value);
        }
        
        private static void OnUnselectedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGridRow target)
            {
                if (e.OldValue != null)
                {
                    target.Unselected -= OnUnselected;
                }
                if (e.NewValue != null)
                {
                    target.Unselected += OnUnselected;
                }
            }
        }
        
        private static void OnUnselected(object o, RoutedEventArgs eventArgs)
        {
            var command = GetUnselected((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region DatePickers
	public static partial class DatePickers {
        
        #region CalendarClosed
        public static readonly DependencyProperty CalendarClosedProperty =
            DependencyProperty.RegisterAttached("CalendarClosed", typeof(ICommand), typeof(DatePickers), new FrameworkPropertyMetadata(OnCalendarClosedChanged));
        
        public static ICommand GetCalendarClosed(DependencyObject target)
        {
            return (ICommand)target.GetValue(CalendarClosedProperty);
        }
        
        public static void SetCalendarClosed(DependencyObject target, ICommand value)
        {
            target.SetValue(CalendarClosedProperty, value);
        }
        
        private static void OnCalendarClosedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DatePicker target)
            {
                if (e.OldValue != null)
                {
                    target.CalendarClosed -= OnCalendarClosed;
                }
                if (e.NewValue != null)
                {
                    target.CalendarClosed += OnCalendarClosed;
                }
            }
        }
        
        private static void OnCalendarClosed(object o, RoutedEventArgs eventArgs)
        {
            var command = GetCalendarClosed((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region CalendarOpened
        public static readonly DependencyProperty CalendarOpenedProperty =
            DependencyProperty.RegisterAttached("CalendarOpened", typeof(ICommand), typeof(DatePickers), new FrameworkPropertyMetadata(OnCalendarOpenedChanged));
        
        public static ICommand GetCalendarOpened(DependencyObject target)
        {
            return (ICommand)target.GetValue(CalendarOpenedProperty);
        }
        
        public static void SetCalendarOpened(DependencyObject target, ICommand value)
        {
            target.SetValue(CalendarOpenedProperty, value);
        }
        
        private static void OnCalendarOpenedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DatePicker target)
            {
                if (e.OldValue != null)
                {
                    target.CalendarOpened -= OnCalendarOpened;
                }
                if (e.NewValue != null)
                {
                    target.CalendarOpened += OnCalendarOpened;
                }
            }
        }
        
        private static void OnCalendarOpened(object o, RoutedEventArgs eventArgs)
        {
            var command = GetCalendarOpened((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region DateValidationError
        public static readonly DependencyProperty DateValidationErrorProperty =
            DependencyProperty.RegisterAttached("DateValidationError", typeof(ICommand), typeof(DatePickers), new FrameworkPropertyMetadata(OnDateValidationErrorChanged));
        
        public static ICommand GetDateValidationError(DependencyObject target)
        {
            return (ICommand)target.GetValue(DateValidationErrorProperty);
        }
        
        public static void SetDateValidationError(DependencyObject target, ICommand value)
        {
            target.SetValue(DateValidationErrorProperty, value);
        }
        
        private static void OnDateValidationErrorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DatePicker target)
            {
                if (e.OldValue != null)
                {
                    target.DateValidationError -= OnDateValidationError;
                }
                if (e.NewValue != null)
                {
                    target.DateValidationError += OnDateValidationError;
                }
            }
        }
        
        private static void OnDateValidationError(object o, DatePickerDateValidationErrorEventArgs eventArgs)
        {
            var command = GetDateValidationError((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region DateValidationErrorNotifyException
        public static readonly DependencyProperty DateValidationErrorNotifyExceptionProperty =
            DependencyProperty.RegisterAttached("DateValidationErrorNotifyException", typeof(ICommand), typeof(DatePickers), new FrameworkPropertyMetadata(OnDateValidationErrorNotifyExceptionChanged));
        
        public static ICommand GetDateValidationErrorNotifyException(DependencyObject target)
        {
            return (ICommand)target.GetValue(DateValidationErrorNotifyExceptionProperty);
        }
        
        public static void SetDateValidationErrorNotifyException(DependencyObject target, ICommand value)
        {
            target.SetValue(DateValidationErrorNotifyExceptionProperty, value);
        }
        
        private static void OnDateValidationErrorNotifyExceptionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DatePicker target)
            {
                if (e.OldValue != null)
                {
                    target.DateValidationError -= OnDateValidationErrorNotifyException;
                }
                if (e.NewValue != null)
                {
                    target.DateValidationError += OnDateValidationErrorNotifyException;
                }
            }
        }
        
        private static void OnDateValidationErrorNotifyException(object o, System.Windows.Controls.DatePickerDateValidationErrorEventArgs eventArgs)
        {
            var command = GetDateValidationErrorNotifyException((DependencyObject)o);
            if (command.CanExecute(eventArgs.Exception))
                command.Execute(eventArgs.Exception);
        }
        #endregion
        
        #region DateValidationErrorNotifyText
        public static readonly DependencyProperty DateValidationErrorNotifyTextProperty =
            DependencyProperty.RegisterAttached("DateValidationErrorNotifyText", typeof(ICommand), typeof(DatePickers), new FrameworkPropertyMetadata(OnDateValidationErrorNotifyTextChanged));
        
        public static ICommand GetDateValidationErrorNotifyText(DependencyObject target)
        {
            return (ICommand)target.GetValue(DateValidationErrorNotifyTextProperty);
        }
        
        public static void SetDateValidationErrorNotifyText(DependencyObject target, ICommand value)
        {
            target.SetValue(DateValidationErrorNotifyTextProperty, value);
        }
        
        private static void OnDateValidationErrorNotifyTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DatePicker target)
            {
                if (e.OldValue != null)
                {
                    target.DateValidationError -= OnDateValidationErrorNotifyText;
                }
                if (e.NewValue != null)
                {
                    target.DateValidationError += OnDateValidationErrorNotifyText;
                }
            }
        }
        
        private static void OnDateValidationErrorNotifyText(object o, System.Windows.Controls.DatePickerDateValidationErrorEventArgs eventArgs)
        {
            var command = GetDateValidationErrorNotifyText((DependencyObject)o);
            if (command.CanExecute(eventArgs.Text))
                command.Execute(eventArgs.Text);
        }
        #endregion
        
        #region DateValidationErrorNotifyThrowException
        public static readonly DependencyProperty DateValidationErrorNotifyThrowExceptionProperty =
            DependencyProperty.RegisterAttached("DateValidationErrorNotifyThrowException", typeof(ICommand), typeof(DatePickers), new FrameworkPropertyMetadata(OnDateValidationErrorNotifyThrowExceptionChanged));
        
        public static ICommand GetDateValidationErrorNotifyThrowException(DependencyObject target)
        {
            return (ICommand)target.GetValue(DateValidationErrorNotifyThrowExceptionProperty);
        }
        
        public static void SetDateValidationErrorNotifyThrowException(DependencyObject target, ICommand value)
        {
            target.SetValue(DateValidationErrorNotifyThrowExceptionProperty, value);
        }
        
        private static void OnDateValidationErrorNotifyThrowExceptionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DatePicker target)
            {
                if (e.OldValue != null)
                {
                    target.DateValidationError -= OnDateValidationErrorNotifyThrowException;
                }
                if (e.NewValue != null)
                {
                    target.DateValidationError += OnDateValidationErrorNotifyThrowException;
                }
            }
        }
        
        private static void OnDateValidationErrorNotifyThrowException(object o, System.Windows.Controls.DatePickerDateValidationErrorEventArgs eventArgs)
        {
            var command = GetDateValidationErrorNotifyThrowException((DependencyObject)o);
            if (command.CanExecute(eventArgs.ThrowException))
                command.Execute(eventArgs.ThrowException);
        }
        #endregion
        
        #region SelectedDateChanged
        public static readonly DependencyProperty SelectedDateChangedProperty =
            DependencyProperty.RegisterAttached("SelectedDateChanged", typeof(ICommand), typeof(DatePickers), new FrameworkPropertyMetadata(OnSelectedDateChangedChanged));
        
        public static ICommand GetSelectedDateChanged(DependencyObject target)
        {
            return (ICommand)target.GetValue(SelectedDateChangedProperty);
        }
        
        public static void SetSelectedDateChanged(DependencyObject target, ICommand value)
        {
            target.SetValue(SelectedDateChangedProperty, value);
        }
        
        private static void OnSelectedDateChangedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DatePicker target)
            {
                if (e.OldValue != null)
                {
                    target.SelectedDateChanged -= OnSelectedDateChanged;
                }
                if (e.NewValue != null)
                {
                    target.SelectedDateChanged += OnSelectedDateChanged;
                }
            }
        }
        
        private static void OnSelectedDateChanged(object o, SelectionChangedEventArgs eventArgs)
        {
            var command = GetSelectedDateChanged((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region SelectedDateChangedNotifyRemovedItems
        public static readonly DependencyProperty SelectedDateChangedNotifyRemovedItemsProperty =
            DependencyProperty.RegisterAttached("SelectedDateChangedNotifyRemovedItems", typeof(ICommand), typeof(DatePickers), new FrameworkPropertyMetadata(OnSelectedDateChangedNotifyRemovedItemsChanged));
        
        public static ICommand GetSelectedDateChangedNotifyRemovedItems(DependencyObject target)
        {
            return (ICommand)target.GetValue(SelectedDateChangedNotifyRemovedItemsProperty);
        }
        
        public static void SetSelectedDateChangedNotifyRemovedItems(DependencyObject target, ICommand value)
        {
            target.SetValue(SelectedDateChangedNotifyRemovedItemsProperty, value);
        }
        
        private static void OnSelectedDateChangedNotifyRemovedItemsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DatePicker target)
            {
                if (e.OldValue != null)
                {
                    target.SelectedDateChanged -= OnSelectedDateChangedNotifyRemovedItems;
                }
                if (e.NewValue != null)
                {
                    target.SelectedDateChanged += OnSelectedDateChangedNotifyRemovedItems;
                }
            }
        }
        
        private static void OnSelectedDateChangedNotifyRemovedItems(object o, System.Windows.Controls.SelectionChangedEventArgs eventArgs)
        {
            var command = GetSelectedDateChangedNotifyRemovedItems((DependencyObject)o);
            if (command.CanExecute(eventArgs.RemovedItems))
                command.Execute(eventArgs.RemovedItems);
        }
        #endregion
        
        #region SelectedDateChangedNotifyAddedItems
        public static readonly DependencyProperty SelectedDateChangedNotifyAddedItemsProperty =
            DependencyProperty.RegisterAttached("SelectedDateChangedNotifyAddedItems", typeof(ICommand), typeof(DatePickers), new FrameworkPropertyMetadata(OnSelectedDateChangedNotifyAddedItemsChanged));
        
        public static ICommand GetSelectedDateChangedNotifyAddedItems(DependencyObject target)
        {
            return (ICommand)target.GetValue(SelectedDateChangedNotifyAddedItemsProperty);
        }
        
        public static void SetSelectedDateChangedNotifyAddedItems(DependencyObject target, ICommand value)
        {
            target.SetValue(SelectedDateChangedNotifyAddedItemsProperty, value);
        }
        
        private static void OnSelectedDateChangedNotifyAddedItemsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DatePicker target)
            {
                if (e.OldValue != null)
                {
                    target.SelectedDateChanged -= OnSelectedDateChangedNotifyAddedItems;
                }
                if (e.NewValue != null)
                {
                    target.SelectedDateChanged += OnSelectedDateChangedNotifyAddedItems;
                }
            }
        }
        
        private static void OnSelectedDateChangedNotifyAddedItems(object o, System.Windows.Controls.SelectionChangedEventArgs eventArgs)
        {
            var command = GetSelectedDateChangedNotifyAddedItems((DependencyObject)o);
            if (command.CanExecute(eventArgs.AddedItems))
                command.Execute(eventArgs.AddedItems);
        }
        #endregion
        
        #region SelectedDateChangedNotifyRoutedEvent
        public static readonly DependencyProperty SelectedDateChangedNotifyRoutedEventProperty =
            DependencyProperty.RegisterAttached("SelectedDateChangedNotifyRoutedEvent", typeof(ICommand), typeof(DatePickers), new FrameworkPropertyMetadata(OnSelectedDateChangedNotifyRoutedEventChanged));
        
        public static ICommand GetSelectedDateChangedNotifyRoutedEvent(DependencyObject target)
        {
            return (ICommand)target.GetValue(SelectedDateChangedNotifyRoutedEventProperty);
        }
        
        public static void SetSelectedDateChangedNotifyRoutedEvent(DependencyObject target, ICommand value)
        {
            target.SetValue(SelectedDateChangedNotifyRoutedEventProperty, value);
        }
        
        private static void OnSelectedDateChangedNotifyRoutedEventChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DatePicker target)
            {
                if (e.OldValue != null)
                {
                    target.SelectedDateChanged -= OnSelectedDateChangedNotifyRoutedEvent;
                }
                if (e.NewValue != null)
                {
                    target.SelectedDateChanged += OnSelectedDateChangedNotifyRoutedEvent;
                }
            }
        }
        
        private static void OnSelectedDateChangedNotifyRoutedEvent(object o, System.Windows.Controls.SelectionChangedEventArgs eventArgs)
        {
            var command = GetSelectedDateChangedNotifyRoutedEvent((DependencyObject)o);
            if (command.CanExecute(eventArgs.RoutedEvent))
                command.Execute(eventArgs.RoutedEvent);
        }
        #endregion
        
        #region SelectedDateChangedNotifyHandled
        public static readonly DependencyProperty SelectedDateChangedNotifyHandledProperty =
            DependencyProperty.RegisterAttached("SelectedDateChangedNotifyHandled", typeof(ICommand), typeof(DatePickers), new FrameworkPropertyMetadata(OnSelectedDateChangedNotifyHandledChanged));
        
        public static ICommand GetSelectedDateChangedNotifyHandled(DependencyObject target)
        {
            return (ICommand)target.GetValue(SelectedDateChangedNotifyHandledProperty);
        }
        
        public static void SetSelectedDateChangedNotifyHandled(DependencyObject target, ICommand value)
        {
            target.SetValue(SelectedDateChangedNotifyHandledProperty, value);
        }
        
        private static void OnSelectedDateChangedNotifyHandledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DatePicker target)
            {
                if (e.OldValue != null)
                {
                    target.SelectedDateChanged -= OnSelectedDateChangedNotifyHandled;
                }
                if (e.NewValue != null)
                {
                    target.SelectedDateChanged += OnSelectedDateChangedNotifyHandled;
                }
            }
        }
        
        private static void OnSelectedDateChangedNotifyHandled(object o, System.Windows.Controls.SelectionChangedEventArgs eventArgs)
        {
            var command = GetSelectedDateChangedNotifyHandled((DependencyObject)o);
            if (command.CanExecute(eventArgs.Handled))
                command.Execute(eventArgs.Handled);
        }
        #endregion
        
        #region SelectedDateChangedNotifySource
        public static readonly DependencyProperty SelectedDateChangedNotifySourceProperty =
            DependencyProperty.RegisterAttached("SelectedDateChangedNotifySource", typeof(ICommand), typeof(DatePickers), new FrameworkPropertyMetadata(OnSelectedDateChangedNotifySourceChanged));
        
        public static ICommand GetSelectedDateChangedNotifySource(DependencyObject target)
        {
            return (ICommand)target.GetValue(SelectedDateChangedNotifySourceProperty);
        }
        
        public static void SetSelectedDateChangedNotifySource(DependencyObject target, ICommand value)
        {
            target.SetValue(SelectedDateChangedNotifySourceProperty, value);
        }
        
        private static void OnSelectedDateChangedNotifySourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DatePicker target)
            {
                if (e.OldValue != null)
                {
                    target.SelectedDateChanged -= OnSelectedDateChangedNotifySource;
                }
                if (e.NewValue != null)
                {
                    target.SelectedDateChanged += OnSelectedDateChangedNotifySource;
                }
            }
        }
        
        private static void OnSelectedDateChangedNotifySource(object o, System.Windows.Controls.SelectionChangedEventArgs eventArgs)
        {
            var command = GetSelectedDateChangedNotifySource((DependencyObject)o);
            if (command.CanExecute(eventArgs.Source))
                command.Execute(eventArgs.Source);
        }
        #endregion
        
        #region SelectedDateChangedNotifyOriginalSource
        public static readonly DependencyProperty SelectedDateChangedNotifyOriginalSourceProperty =
            DependencyProperty.RegisterAttached("SelectedDateChangedNotifyOriginalSource", typeof(ICommand), typeof(DatePickers), new FrameworkPropertyMetadata(OnSelectedDateChangedNotifyOriginalSourceChanged));
        
        public static ICommand GetSelectedDateChangedNotifyOriginalSource(DependencyObject target)
        {
            return (ICommand)target.GetValue(SelectedDateChangedNotifyOriginalSourceProperty);
        }
        
        public static void SetSelectedDateChangedNotifyOriginalSource(DependencyObject target, ICommand value)
        {
            target.SetValue(SelectedDateChangedNotifyOriginalSourceProperty, value);
        }
        
        private static void OnSelectedDateChangedNotifyOriginalSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DatePicker target)
            {
                if (e.OldValue != null)
                {
                    target.SelectedDateChanged -= OnSelectedDateChangedNotifyOriginalSource;
                }
                if (e.NewValue != null)
                {
                    target.SelectedDateChanged += OnSelectedDateChangedNotifyOriginalSource;
                }
            }
        }
        
        private static void OnSelectedDateChangedNotifyOriginalSource(object o, System.Windows.Controls.SelectionChangedEventArgs eventArgs)
        {
            var command = GetSelectedDateChangedNotifyOriginalSource((DependencyObject)o);
            if (command.CanExecute(eventArgs.OriginalSource))
                command.Execute(eventArgs.OriginalSource);
        }
        #endregion
	}
	#endregion

	#region Expanders
	public static partial class Expanders {
        
        #region Collapsed
        public static readonly DependencyProperty CollapsedProperty =
            DependencyProperty.RegisterAttached("Collapsed", typeof(ICommand), typeof(Expanders), new FrameworkPropertyMetadata(OnCollapsedChanged));
        
        public static ICommand GetCollapsed(DependencyObject target)
        {
            return (ICommand)target.GetValue(CollapsedProperty);
        }
        
        public static void SetCollapsed(DependencyObject target, ICommand value)
        {
            target.SetValue(CollapsedProperty, value);
        }
        
        private static void OnCollapsedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Expander target)
            {
                if (e.OldValue != null)
                {
                    target.Collapsed -= OnCollapsed;
                }
                if (e.NewValue != null)
                {
                    target.Collapsed += OnCollapsed;
                }
            }
        }
        
        private static void OnCollapsed(object o, RoutedEventArgs eventArgs)
        {
            var command = GetCollapsed((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Expanded
        public static readonly DependencyProperty ExpandedProperty =
            DependencyProperty.RegisterAttached("Expanded", typeof(ICommand), typeof(Expanders), new FrameworkPropertyMetadata(OnExpandedChanged));
        
        public static ICommand GetExpanded(DependencyObject target)
        {
            return (ICommand)target.GetValue(ExpandedProperty);
        }
        
        public static void SetExpanded(DependencyObject target, ICommand value)
        {
            target.SetValue(ExpandedProperty, value);
        }
        
        private static void OnExpandedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Expander target)
            {
                if (e.OldValue != null)
                {
                    target.Expanded -= OnExpanded;
                }
                if (e.NewValue != null)
                {
                    target.Expanded += OnExpanded;
                }
            }
        }
        
        private static void OnExpanded(object o, RoutedEventArgs eventArgs)
        {
            var command = GetExpanded((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region Frames
	public static partial class Frames {
        
        #region ContentRendered
        public static readonly DependencyProperty ContentRenderedProperty =
            DependencyProperty.RegisterAttached("ContentRendered", typeof(ICommand), typeof(Frames), new FrameworkPropertyMetadata(OnContentRenderedChanged));
        
        public static ICommand GetContentRendered(DependencyObject target)
        {
            return (ICommand)target.GetValue(ContentRenderedProperty);
        }
        
        public static void SetContentRendered(DependencyObject target, ICommand value)
        {
            target.SetValue(ContentRenderedProperty, value);
        }
        
        private static void OnContentRenderedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Frame target)
            {
                if (e.OldValue != null)
                {
                    target.ContentRendered -= OnContentRendered;
                }
                if (e.NewValue != null)
                {
                    target.ContentRendered += OnContentRendered;
                }
            }
        }
        
        private static void OnContentRendered(object o, EventArgs eventArgs)
        {
            var command = GetContentRendered((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region FragmentNavigation
        public static readonly DependencyProperty FragmentNavigationProperty =
            DependencyProperty.RegisterAttached("FragmentNavigation", typeof(ICommand), typeof(Frames), new FrameworkPropertyMetadata(OnFragmentNavigationChanged));
        
        public static ICommand GetFragmentNavigation(DependencyObject target)
        {
            return (ICommand)target.GetValue(FragmentNavigationProperty);
        }
        
        public static void SetFragmentNavigation(DependencyObject target, ICommand value)
        {
            target.SetValue(FragmentNavigationProperty, value);
        }
        
        private static void OnFragmentNavigationChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Frame target)
            {
                if (e.OldValue != null)
                {
                    target.FragmentNavigation -= OnFragmentNavigation;
                }
                if (e.NewValue != null)
                {
                    target.FragmentNavigation += OnFragmentNavigation;
                }
            }
        }
        
        private static void OnFragmentNavigation(object o, FragmentNavigationEventArgs eventArgs)
        {
            var command = GetFragmentNavigation((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region LoadCompleted
        public static readonly DependencyProperty LoadCompletedProperty =
            DependencyProperty.RegisterAttached("LoadCompleted", typeof(ICommand), typeof(Frames), new FrameworkPropertyMetadata(OnLoadCompletedChanged));
        
        public static ICommand GetLoadCompleted(DependencyObject target)
        {
            return (ICommand)target.GetValue(LoadCompletedProperty);
        }
        
        public static void SetLoadCompleted(DependencyObject target, ICommand value)
        {
            target.SetValue(LoadCompletedProperty, value);
        }
        
        private static void OnLoadCompletedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Frame target)
            {
                if (e.OldValue != null)
                {
                    target.LoadCompleted -= OnLoadCompleted;
                }
                if (e.NewValue != null)
                {
                    target.LoadCompleted += OnLoadCompleted;
                }
            }
        }
        
        private static void OnLoadCompleted(object o, NavigationEventArgs eventArgs)
        {
            var command = GetLoadCompleted((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Navigated
        public static readonly DependencyProperty NavigatedProperty =
            DependencyProperty.RegisterAttached("Navigated", typeof(ICommand), typeof(Frames), new FrameworkPropertyMetadata(OnNavigatedChanged));
        
        public static ICommand GetNavigated(DependencyObject target)
        {
            return (ICommand)target.GetValue(NavigatedProperty);
        }
        
        public static void SetNavigated(DependencyObject target, ICommand value)
        {
            target.SetValue(NavigatedProperty, value);
        }
        
        private static void OnNavigatedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Frame target)
            {
                if (e.OldValue != null)
                {
                    target.Navigated -= OnNavigated;
                }
                if (e.NewValue != null)
                {
                    target.Navigated += OnNavigated;
                }
            }
        }
        
        private static void OnNavigated(object o, NavigationEventArgs eventArgs)
        {
            var command = GetNavigated((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Navigating
        public static readonly DependencyProperty NavigatingProperty =
            DependencyProperty.RegisterAttached("Navigating", typeof(ICommand), typeof(Frames), new FrameworkPropertyMetadata(OnNavigatingChanged));
        
        public static ICommand GetNavigating(DependencyObject target)
        {
            return (ICommand)target.GetValue(NavigatingProperty);
        }
        
        public static void SetNavigating(DependencyObject target, ICommand value)
        {
            target.SetValue(NavigatingProperty, value);
        }
        
        private static void OnNavigatingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Frame target)
            {
                if (e.OldValue != null)
                {
                    target.Navigating -= OnNavigating;
                }
                if (e.NewValue != null)
                {
                    target.Navigating += OnNavigating;
                }
            }
        }
        
        private static void OnNavigating(object o, NavigatingCancelEventArgs eventArgs)
        {
            var command = GetNavigating((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region NavigationFailed
        public static readonly DependencyProperty NavigationFailedProperty =
            DependencyProperty.RegisterAttached("NavigationFailed", typeof(ICommand), typeof(Frames), new FrameworkPropertyMetadata(OnNavigationFailedChanged));
        
        public static ICommand GetNavigationFailed(DependencyObject target)
        {
            return (ICommand)target.GetValue(NavigationFailedProperty);
        }
        
        public static void SetNavigationFailed(DependencyObject target, ICommand value)
        {
            target.SetValue(NavigationFailedProperty, value);
        }
        
        private static void OnNavigationFailedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Frame target)
            {
                if (e.OldValue != null)
                {
                    target.NavigationFailed -= OnNavigationFailed;
                }
                if (e.NewValue != null)
                {
                    target.NavigationFailed += OnNavigationFailed;
                }
            }
        }
        
        private static void OnNavigationFailed(object o, NavigationFailedEventArgs eventArgs)
        {
            var command = GetNavigationFailed((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region NavigationProgress
        public static readonly DependencyProperty NavigationProgressProperty =
            DependencyProperty.RegisterAttached("NavigationProgress", typeof(ICommand), typeof(Frames), new FrameworkPropertyMetadata(OnNavigationProgressChanged));
        
        public static ICommand GetNavigationProgress(DependencyObject target)
        {
            return (ICommand)target.GetValue(NavigationProgressProperty);
        }
        
        public static void SetNavigationProgress(DependencyObject target, ICommand value)
        {
            target.SetValue(NavigationProgressProperty, value);
        }
        
        private static void OnNavigationProgressChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Frame target)
            {
                if (e.OldValue != null)
                {
                    target.NavigationProgress -= OnNavigationProgress;
                }
                if (e.NewValue != null)
                {
                    target.NavigationProgress += OnNavigationProgress;
                }
            }
        }
        
        private static void OnNavigationProgress(object o, NavigationProgressEventArgs eventArgs)
        {
            var command = GetNavigationProgress((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region NavigationStopped
        public static readonly DependencyProperty NavigationStoppedProperty =
            DependencyProperty.RegisterAttached("NavigationStopped", typeof(ICommand), typeof(Frames), new FrameworkPropertyMetadata(OnNavigationStoppedChanged));
        
        public static ICommand GetNavigationStopped(DependencyObject target)
        {
            return (ICommand)target.GetValue(NavigationStoppedProperty);
        }
        
        public static void SetNavigationStopped(DependencyObject target, ICommand value)
        {
            target.SetValue(NavigationStoppedProperty, value);
        }
        
        private static void OnNavigationStoppedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Frame target)
            {
                if (e.OldValue != null)
                {
                    target.NavigationStopped -= OnNavigationStopped;
                }
                if (e.NewValue != null)
                {
                    target.NavigationStopped += OnNavigationStopped;
                }
            }
        }
        
        private static void OnNavigationStopped(object o, NavigationEventArgs eventArgs)
        {
            var command = GetNavigationStopped((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region Images
	public static partial class Images {
        
        #region ImageFailed
        public static readonly DependencyProperty ImageFailedProperty =
            DependencyProperty.RegisterAttached("ImageFailed", typeof(ICommand), typeof(Images), new FrameworkPropertyMetadata(OnImageFailedChanged));
        
        public static ICommand GetImageFailed(DependencyObject target)
        {
            return (ICommand)target.GetValue(ImageFailedProperty);
        }
        
        public static void SetImageFailed(DependencyObject target, ICommand value)
        {
            target.SetValue(ImageFailedProperty, value);
        }
        
        private static void OnImageFailedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Image target)
            {
                if (e.OldValue != null)
                {
                    target.ImageFailed -= OnImageFailed;
                }
                if (e.NewValue != null)
                {
                    target.ImageFailed += OnImageFailed;
                }
            }
        }
        
        private static void OnImageFailed(object o, ExceptionRoutedEventArgs eventArgs)
        {
            var command = GetImageFailed((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region ImageFailedNotifyErrorException
        public static readonly DependencyProperty ImageFailedNotifyErrorExceptionProperty =
            DependencyProperty.RegisterAttached("ImageFailedNotifyErrorException", typeof(ICommand), typeof(Images), new FrameworkPropertyMetadata(OnImageFailedNotifyErrorExceptionChanged));
        
        public static ICommand GetImageFailedNotifyErrorException(DependencyObject target)
        {
            return (ICommand)target.GetValue(ImageFailedNotifyErrorExceptionProperty);
        }
        
        public static void SetImageFailedNotifyErrorException(DependencyObject target, ICommand value)
        {
            target.SetValue(ImageFailedNotifyErrorExceptionProperty, value);
        }
        
        private static void OnImageFailedNotifyErrorExceptionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Image target)
            {
                if (e.OldValue != null)
                {
                    target.ImageFailed -= OnImageFailedNotifyErrorException;
                }
                if (e.NewValue != null)
                {
                    target.ImageFailed += OnImageFailedNotifyErrorException;
                }
            }
        }
        
        private static void OnImageFailedNotifyErrorException(object o, System.Windows.ExceptionRoutedEventArgs eventArgs)
        {
            var command = GetImageFailedNotifyErrorException((DependencyObject)o);
            if (command.CanExecute(eventArgs.ErrorException))
                command.Execute(eventArgs.ErrorException);
        }
        #endregion
        
        #region ImageFailedNotifyRoutedEvent
        public static readonly DependencyProperty ImageFailedNotifyRoutedEventProperty =
            DependencyProperty.RegisterAttached("ImageFailedNotifyRoutedEvent", typeof(ICommand), typeof(Images), new FrameworkPropertyMetadata(OnImageFailedNotifyRoutedEventChanged));
        
        public static ICommand GetImageFailedNotifyRoutedEvent(DependencyObject target)
        {
            return (ICommand)target.GetValue(ImageFailedNotifyRoutedEventProperty);
        }
        
        public static void SetImageFailedNotifyRoutedEvent(DependencyObject target, ICommand value)
        {
            target.SetValue(ImageFailedNotifyRoutedEventProperty, value);
        }
        
        private static void OnImageFailedNotifyRoutedEventChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Image target)
            {
                if (e.OldValue != null)
                {
                    target.ImageFailed -= OnImageFailedNotifyRoutedEvent;
                }
                if (e.NewValue != null)
                {
                    target.ImageFailed += OnImageFailedNotifyRoutedEvent;
                }
            }
        }
        
        private static void OnImageFailedNotifyRoutedEvent(object o, System.Windows.ExceptionRoutedEventArgs eventArgs)
        {
            var command = GetImageFailedNotifyRoutedEvent((DependencyObject)o);
            if (command.CanExecute(eventArgs.RoutedEvent))
                command.Execute(eventArgs.RoutedEvent);
        }
        #endregion
        
        #region ImageFailedNotifyHandled
        public static readonly DependencyProperty ImageFailedNotifyHandledProperty =
            DependencyProperty.RegisterAttached("ImageFailedNotifyHandled", typeof(ICommand), typeof(Images), new FrameworkPropertyMetadata(OnImageFailedNotifyHandledChanged));
        
        public static ICommand GetImageFailedNotifyHandled(DependencyObject target)
        {
            return (ICommand)target.GetValue(ImageFailedNotifyHandledProperty);
        }
        
        public static void SetImageFailedNotifyHandled(DependencyObject target, ICommand value)
        {
            target.SetValue(ImageFailedNotifyHandledProperty, value);
        }
        
        private static void OnImageFailedNotifyHandledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Image target)
            {
                if (e.OldValue != null)
                {
                    target.ImageFailed -= OnImageFailedNotifyHandled;
                }
                if (e.NewValue != null)
                {
                    target.ImageFailed += OnImageFailedNotifyHandled;
                }
            }
        }
        
        private static void OnImageFailedNotifyHandled(object o, System.Windows.ExceptionRoutedEventArgs eventArgs)
        {
            var command = GetImageFailedNotifyHandled((DependencyObject)o);
            if (command.CanExecute(eventArgs.Handled))
                command.Execute(eventArgs.Handled);
        }
        #endregion
        
        #region ImageFailedNotifySource
        public static readonly DependencyProperty ImageFailedNotifySourceProperty =
            DependencyProperty.RegisterAttached("ImageFailedNotifySource", typeof(ICommand), typeof(Images), new FrameworkPropertyMetadata(OnImageFailedNotifySourceChanged));
        
        public static ICommand GetImageFailedNotifySource(DependencyObject target)
        {
            return (ICommand)target.GetValue(ImageFailedNotifySourceProperty);
        }
        
        public static void SetImageFailedNotifySource(DependencyObject target, ICommand value)
        {
            target.SetValue(ImageFailedNotifySourceProperty, value);
        }
        
        private static void OnImageFailedNotifySourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Image target)
            {
                if (e.OldValue != null)
                {
                    target.ImageFailed -= OnImageFailedNotifySource;
                }
                if (e.NewValue != null)
                {
                    target.ImageFailed += OnImageFailedNotifySource;
                }
            }
        }
        
        private static void OnImageFailedNotifySource(object o, System.Windows.ExceptionRoutedEventArgs eventArgs)
        {
            var command = GetImageFailedNotifySource((DependencyObject)o);
            if (command.CanExecute(eventArgs.Source))
                command.Execute(eventArgs.Source);
        }
        #endregion
        
        #region ImageFailedNotifyOriginalSource
        public static readonly DependencyProperty ImageFailedNotifyOriginalSourceProperty =
            DependencyProperty.RegisterAttached("ImageFailedNotifyOriginalSource", typeof(ICommand), typeof(Images), new FrameworkPropertyMetadata(OnImageFailedNotifyOriginalSourceChanged));
        
        public static ICommand GetImageFailedNotifyOriginalSource(DependencyObject target)
        {
            return (ICommand)target.GetValue(ImageFailedNotifyOriginalSourceProperty);
        }
        
        public static void SetImageFailedNotifyOriginalSource(DependencyObject target, ICommand value)
        {
            target.SetValue(ImageFailedNotifyOriginalSourceProperty, value);
        }
        
        private static void OnImageFailedNotifyOriginalSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Image target)
            {
                if (e.OldValue != null)
                {
                    target.ImageFailed -= OnImageFailedNotifyOriginalSource;
                }
                if (e.NewValue != null)
                {
                    target.ImageFailed += OnImageFailedNotifyOriginalSource;
                }
            }
        }
        
        private static void OnImageFailedNotifyOriginalSource(object o, System.Windows.ExceptionRoutedEventArgs eventArgs)
        {
            var command = GetImageFailedNotifyOriginalSource((DependencyObject)o);
            if (command.CanExecute(eventArgs.OriginalSource))
                command.Execute(eventArgs.OriginalSource);
        }
        #endregion
	}
	#endregion

	#region InkCanvases
	public static partial class InkCanvases {
        
        #region ActiveEditingModeChanged
        public static readonly DependencyProperty ActiveEditingModeChangedProperty =
            DependencyProperty.RegisterAttached("ActiveEditingModeChanged", typeof(ICommand), typeof(InkCanvases), new FrameworkPropertyMetadata(OnActiveEditingModeChangedChanged));
        
        public static ICommand GetActiveEditingModeChanged(DependencyObject target)
        {
            return (ICommand)target.GetValue(ActiveEditingModeChangedProperty);
        }
        
        public static void SetActiveEditingModeChanged(DependencyObject target, ICommand value)
        {
            target.SetValue(ActiveEditingModeChangedProperty, value);
        }
        
        private static void OnActiveEditingModeChangedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is InkCanvas target)
            {
                if (e.OldValue != null)
                {
                    target.ActiveEditingModeChanged -= OnActiveEditingModeChanged;
                }
                if (e.NewValue != null)
                {
                    target.ActiveEditingModeChanged += OnActiveEditingModeChanged;
                }
            }
        }
        
        private static void OnActiveEditingModeChanged(object o, RoutedEventArgs eventArgs)
        {
            var command = GetActiveEditingModeChanged((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region DefaultDrawingAttributesReplaced
        public static readonly DependencyProperty DefaultDrawingAttributesReplacedProperty =
            DependencyProperty.RegisterAttached("DefaultDrawingAttributesReplaced", typeof(ICommand), typeof(InkCanvases), new FrameworkPropertyMetadata(OnDefaultDrawingAttributesReplacedChanged));
        
        public static ICommand GetDefaultDrawingAttributesReplaced(DependencyObject target)
        {
            return (ICommand)target.GetValue(DefaultDrawingAttributesReplacedProperty);
        }
        
        public static void SetDefaultDrawingAttributesReplaced(DependencyObject target, ICommand value)
        {
            target.SetValue(DefaultDrawingAttributesReplacedProperty, value);
        }
        
        private static void OnDefaultDrawingAttributesReplacedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is InkCanvas target)
            {
                if (e.OldValue != null)
                {
                    target.DefaultDrawingAttributesReplaced -= OnDefaultDrawingAttributesReplaced;
                }
                if (e.NewValue != null)
                {
                    target.DefaultDrawingAttributesReplaced += OnDefaultDrawingAttributesReplaced;
                }
            }
        }
        
        private static void OnDefaultDrawingAttributesReplaced(object o, DrawingAttributesReplacedEventArgs eventArgs)
        {
            var command = GetDefaultDrawingAttributesReplaced((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region EditingModeChanged
        public static readonly DependencyProperty EditingModeChangedProperty =
            DependencyProperty.RegisterAttached("EditingModeChanged", typeof(ICommand), typeof(InkCanvases), new FrameworkPropertyMetadata(OnEditingModeChangedChanged));
        
        public static ICommand GetEditingModeChanged(DependencyObject target)
        {
            return (ICommand)target.GetValue(EditingModeChangedProperty);
        }
        
        public static void SetEditingModeChanged(DependencyObject target, ICommand value)
        {
            target.SetValue(EditingModeChangedProperty, value);
        }
        
        private static void OnEditingModeChangedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is InkCanvas target)
            {
                if (e.OldValue != null)
                {
                    target.EditingModeChanged -= OnEditingModeChanged;
                }
                if (e.NewValue != null)
                {
                    target.EditingModeChanged += OnEditingModeChanged;
                }
            }
        }
        
        private static void OnEditingModeChanged(object o, RoutedEventArgs eventArgs)
        {
            var command = GetEditingModeChanged((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region EditingModeInvertedChanged
        public static readonly DependencyProperty EditingModeInvertedChangedProperty =
            DependencyProperty.RegisterAttached("EditingModeInvertedChanged", typeof(ICommand), typeof(InkCanvases), new FrameworkPropertyMetadata(OnEditingModeInvertedChangedChanged));
        
        public static ICommand GetEditingModeInvertedChanged(DependencyObject target)
        {
            return (ICommand)target.GetValue(EditingModeInvertedChangedProperty);
        }
        
        public static void SetEditingModeInvertedChanged(DependencyObject target, ICommand value)
        {
            target.SetValue(EditingModeInvertedChangedProperty, value);
        }
        
        private static void OnEditingModeInvertedChangedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is InkCanvas target)
            {
                if (e.OldValue != null)
                {
                    target.EditingModeInvertedChanged -= OnEditingModeInvertedChanged;
                }
                if (e.NewValue != null)
                {
                    target.EditingModeInvertedChanged += OnEditingModeInvertedChanged;
                }
            }
        }
        
        private static void OnEditingModeInvertedChanged(object o, RoutedEventArgs eventArgs)
        {
            var command = GetEditingModeInvertedChanged((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Gesture
        public static readonly DependencyProperty GestureProperty =
            DependencyProperty.RegisterAttached("Gesture", typeof(ICommand), typeof(InkCanvases), new FrameworkPropertyMetadata(OnGestureChanged));
        
        public static ICommand GetGesture(DependencyObject target)
        {
            return (ICommand)target.GetValue(GestureProperty);
        }
        
        public static void SetGesture(DependencyObject target, ICommand value)
        {
            target.SetValue(GestureProperty, value);
        }
        
        private static void OnGestureChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is InkCanvas target)
            {
                if (e.OldValue != null)
                {
                    target.Gesture -= OnGesture;
                }
                if (e.NewValue != null)
                {
                    target.Gesture += OnGesture;
                }
            }
        }
        
        private static void OnGesture(object o, InkCanvasGestureEventArgs eventArgs)
        {
            var command = GetGesture((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region SelectionChanged
        public static readonly DependencyProperty SelectionChangedProperty =
            DependencyProperty.RegisterAttached("SelectionChanged", typeof(ICommand), typeof(InkCanvases), new FrameworkPropertyMetadata(OnSelectionChangedChanged));
        
        public static ICommand GetSelectionChanged(DependencyObject target)
        {
            return (ICommand)target.GetValue(SelectionChangedProperty);
        }
        
        public static void SetSelectionChanged(DependencyObject target, ICommand value)
        {
            target.SetValue(SelectionChangedProperty, value);
        }
        
        private static void OnSelectionChangedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is InkCanvas target)
            {
                if (e.OldValue != null)
                {
                    target.SelectionChanged -= OnSelectionChanged;
                }
                if (e.NewValue != null)
                {
                    target.SelectionChanged += OnSelectionChanged;
                }
            }
        }
        
        private static void OnSelectionChanged(object o, EventArgs eventArgs)
        {
            var command = GetSelectionChanged((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region SelectionChanging
        public static readonly DependencyProperty SelectionChangingProperty =
            DependencyProperty.RegisterAttached("SelectionChanging", typeof(ICommand), typeof(InkCanvases), new FrameworkPropertyMetadata(OnSelectionChangingChanged));
        
        public static ICommand GetSelectionChanging(DependencyObject target)
        {
            return (ICommand)target.GetValue(SelectionChangingProperty);
        }
        
        public static void SetSelectionChanging(DependencyObject target, ICommand value)
        {
            target.SetValue(SelectionChangingProperty, value);
        }
        
        private static void OnSelectionChangingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is InkCanvas target)
            {
                if (e.OldValue != null)
                {
                    target.SelectionChanging -= OnSelectionChanging;
                }
                if (e.NewValue != null)
                {
                    target.SelectionChanging += OnSelectionChanging;
                }
            }
        }
        
        private static void OnSelectionChanging(object o, InkCanvasSelectionChangingEventArgs eventArgs)
        {
            var command = GetSelectionChanging((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region SelectionMoved
        public static readonly DependencyProperty SelectionMovedProperty =
            DependencyProperty.RegisterAttached("SelectionMoved", typeof(ICommand), typeof(InkCanvases), new FrameworkPropertyMetadata(OnSelectionMovedChanged));
        
        public static ICommand GetSelectionMoved(DependencyObject target)
        {
            return (ICommand)target.GetValue(SelectionMovedProperty);
        }
        
        public static void SetSelectionMoved(DependencyObject target, ICommand value)
        {
            target.SetValue(SelectionMovedProperty, value);
        }
        
        private static void OnSelectionMovedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is InkCanvas target)
            {
                if (e.OldValue != null)
                {
                    target.SelectionMoved -= OnSelectionMoved;
                }
                if (e.NewValue != null)
                {
                    target.SelectionMoved += OnSelectionMoved;
                }
            }
        }
        
        private static void OnSelectionMoved(object o, EventArgs eventArgs)
        {
            var command = GetSelectionMoved((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region SelectionMoving
        public static readonly DependencyProperty SelectionMovingProperty =
            DependencyProperty.RegisterAttached("SelectionMoving", typeof(ICommand), typeof(InkCanvases), new FrameworkPropertyMetadata(OnSelectionMovingChanged));
        
        public static ICommand GetSelectionMoving(DependencyObject target)
        {
            return (ICommand)target.GetValue(SelectionMovingProperty);
        }
        
        public static void SetSelectionMoving(DependencyObject target, ICommand value)
        {
            target.SetValue(SelectionMovingProperty, value);
        }
        
        private static void OnSelectionMovingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is InkCanvas target)
            {
                if (e.OldValue != null)
                {
                    target.SelectionMoving -= OnSelectionMoving;
                }
                if (e.NewValue != null)
                {
                    target.SelectionMoving += OnSelectionMoving;
                }
            }
        }
        
        private static void OnSelectionMoving(object o, InkCanvasSelectionEditingEventArgs eventArgs)
        {
            var command = GetSelectionMoving((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region SelectionResized
        public static readonly DependencyProperty SelectionResizedProperty =
            DependencyProperty.RegisterAttached("SelectionResized", typeof(ICommand), typeof(InkCanvases), new FrameworkPropertyMetadata(OnSelectionResizedChanged));
        
        public static ICommand GetSelectionResized(DependencyObject target)
        {
            return (ICommand)target.GetValue(SelectionResizedProperty);
        }
        
        public static void SetSelectionResized(DependencyObject target, ICommand value)
        {
            target.SetValue(SelectionResizedProperty, value);
        }
        
        private static void OnSelectionResizedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is InkCanvas target)
            {
                if (e.OldValue != null)
                {
                    target.SelectionResized -= OnSelectionResized;
                }
                if (e.NewValue != null)
                {
                    target.SelectionResized += OnSelectionResized;
                }
            }
        }
        
        private static void OnSelectionResized(object o, EventArgs eventArgs)
        {
            var command = GetSelectionResized((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region SelectionResizing
        public static readonly DependencyProperty SelectionResizingProperty =
            DependencyProperty.RegisterAttached("SelectionResizing", typeof(ICommand), typeof(InkCanvases), new FrameworkPropertyMetadata(OnSelectionResizingChanged));
        
        public static ICommand GetSelectionResizing(DependencyObject target)
        {
            return (ICommand)target.GetValue(SelectionResizingProperty);
        }
        
        public static void SetSelectionResizing(DependencyObject target, ICommand value)
        {
            target.SetValue(SelectionResizingProperty, value);
        }
        
        private static void OnSelectionResizingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is InkCanvas target)
            {
                if (e.OldValue != null)
                {
                    target.SelectionResizing -= OnSelectionResizing;
                }
                if (e.NewValue != null)
                {
                    target.SelectionResizing += OnSelectionResizing;
                }
            }
        }
        
        private static void OnSelectionResizing(object o, InkCanvasSelectionEditingEventArgs eventArgs)
        {
            var command = GetSelectionResizing((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region StrokeCollected
        public static readonly DependencyProperty StrokeCollectedProperty =
            DependencyProperty.RegisterAttached("StrokeCollected", typeof(ICommand), typeof(InkCanvases), new FrameworkPropertyMetadata(OnStrokeCollectedChanged));
        
        public static ICommand GetStrokeCollected(DependencyObject target)
        {
            return (ICommand)target.GetValue(StrokeCollectedProperty);
        }
        
        public static void SetStrokeCollected(DependencyObject target, ICommand value)
        {
            target.SetValue(StrokeCollectedProperty, value);
        }
        
        private static void OnStrokeCollectedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is InkCanvas target)
            {
                if (e.OldValue != null)
                {
                    target.StrokeCollected -= OnStrokeCollected;
                }
                if (e.NewValue != null)
                {
                    target.StrokeCollected += OnStrokeCollected;
                }
            }
        }
        
        private static void OnStrokeCollected(object o, InkCanvasStrokeCollectedEventArgs eventArgs)
        {
            var command = GetStrokeCollected((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region StrokeErased
        public static readonly DependencyProperty StrokeErasedProperty =
            DependencyProperty.RegisterAttached("StrokeErased", typeof(ICommand), typeof(InkCanvases), new FrameworkPropertyMetadata(OnStrokeErasedChanged));
        
        public static ICommand GetStrokeErased(DependencyObject target)
        {
            return (ICommand)target.GetValue(StrokeErasedProperty);
        }
        
        public static void SetStrokeErased(DependencyObject target, ICommand value)
        {
            target.SetValue(StrokeErasedProperty, value);
        }
        
        private static void OnStrokeErasedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is InkCanvas target)
            {
                if (e.OldValue != null)
                {
                    target.StrokeErased -= OnStrokeErased;
                }
                if (e.NewValue != null)
                {
                    target.StrokeErased += OnStrokeErased;
                }
            }
        }
        
        private static void OnStrokeErased(object o, RoutedEventArgs eventArgs)
        {
            var command = GetStrokeErased((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region StrokeErasing
        public static readonly DependencyProperty StrokeErasingProperty =
            DependencyProperty.RegisterAttached("StrokeErasing", typeof(ICommand), typeof(InkCanvases), new FrameworkPropertyMetadata(OnStrokeErasingChanged));
        
        public static ICommand GetStrokeErasing(DependencyObject target)
        {
            return (ICommand)target.GetValue(StrokeErasingProperty);
        }
        
        public static void SetStrokeErasing(DependencyObject target, ICommand value)
        {
            target.SetValue(StrokeErasingProperty, value);
        }
        
        private static void OnStrokeErasingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is InkCanvas target)
            {
                if (e.OldValue != null)
                {
                    target.StrokeErasing -= OnStrokeErasing;
                }
                if (e.NewValue != null)
                {
                    target.StrokeErasing += OnStrokeErasing;
                }
            }
        }
        
        private static void OnStrokeErasing(object o, InkCanvasStrokeErasingEventArgs eventArgs)
        {
            var command = GetStrokeErasing((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region StrokesReplaced
        public static readonly DependencyProperty StrokesReplacedProperty =
            DependencyProperty.RegisterAttached("StrokesReplaced", typeof(ICommand), typeof(InkCanvases), new FrameworkPropertyMetadata(OnStrokesReplacedChanged));
        
        public static ICommand GetStrokesReplaced(DependencyObject target)
        {
            return (ICommand)target.GetValue(StrokesReplacedProperty);
        }
        
        public static void SetStrokesReplaced(DependencyObject target, ICommand value)
        {
            target.SetValue(StrokesReplacedProperty, value);
        }
        
        private static void OnStrokesReplacedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is InkCanvas target)
            {
                if (e.OldValue != null)
                {
                    target.StrokesReplaced -= OnStrokesReplaced;
                }
                if (e.NewValue != null)
                {
                    target.StrokesReplaced += OnStrokesReplaced;
                }
            }
        }
        
        private static void OnStrokesReplaced(object o, InkCanvasStrokesReplacedEventArgs eventArgs)
        {
            var command = GetStrokesReplaced((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region ListBoxItems
	public static partial class ListBoxItems {
        
        #region Selected
        public static readonly DependencyProperty SelectedProperty =
            DependencyProperty.RegisterAttached("Selected", typeof(ICommand), typeof(ListBoxItems), new FrameworkPropertyMetadata(OnSelectedChanged));
        
        public static ICommand GetSelected(DependencyObject target)
        {
            return (ICommand)target.GetValue(SelectedProperty);
        }
        
        public static void SetSelected(DependencyObject target, ICommand value)
        {
            target.SetValue(SelectedProperty, value);
        }
        
        private static void OnSelectedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ListBoxItem target)
            {
                if (e.OldValue != null)
                {
                    target.Selected -= OnSelected;
                }
                if (e.NewValue != null)
                {
                    target.Selected += OnSelected;
                }
            }
        }
        
        private static void OnSelected(object o, RoutedEventArgs eventArgs)
        {
            var command = GetSelected((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Unselected
        public static readonly DependencyProperty UnselectedProperty =
            DependencyProperty.RegisterAttached("Unselected", typeof(ICommand), typeof(ListBoxItems), new FrameworkPropertyMetadata(OnUnselectedChanged));
        
        public static ICommand GetUnselected(DependencyObject target)
        {
            return (ICommand)target.GetValue(UnselectedProperty);
        }
        
        public static void SetUnselected(DependencyObject target, ICommand value)
        {
            target.SetValue(UnselectedProperty, value);
        }
        
        private static void OnUnselectedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ListBoxItem target)
            {
                if (e.OldValue != null)
                {
                    target.Unselected -= OnUnselected;
                }
                if (e.NewValue != null)
                {
                    target.Unselected += OnUnselected;
                }
            }
        }
        
        private static void OnUnselected(object o, RoutedEventArgs eventArgs)
        {
            var command = GetUnselected((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region MediaElements
	public static partial class MediaElements {
        
        #region BufferingEnded
        public static readonly DependencyProperty BufferingEndedProperty =
            DependencyProperty.RegisterAttached("BufferingEnded", typeof(ICommand), typeof(MediaElements), new FrameworkPropertyMetadata(OnBufferingEndedChanged));
        
        public static ICommand GetBufferingEnded(DependencyObject target)
        {
            return (ICommand)target.GetValue(BufferingEndedProperty);
        }
        
        public static void SetBufferingEnded(DependencyObject target, ICommand value)
        {
            target.SetValue(BufferingEndedProperty, value);
        }
        
        private static void OnBufferingEndedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is MediaElement target)
            {
                if (e.OldValue != null)
                {
                    target.BufferingEnded -= OnBufferingEnded;
                }
                if (e.NewValue != null)
                {
                    target.BufferingEnded += OnBufferingEnded;
                }
            }
        }
        
        private static void OnBufferingEnded(object o, RoutedEventArgs eventArgs)
        {
            var command = GetBufferingEnded((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region BufferingStarted
        public static readonly DependencyProperty BufferingStartedProperty =
            DependencyProperty.RegisterAttached("BufferingStarted", typeof(ICommand), typeof(MediaElements), new FrameworkPropertyMetadata(OnBufferingStartedChanged));
        
        public static ICommand GetBufferingStarted(DependencyObject target)
        {
            return (ICommand)target.GetValue(BufferingStartedProperty);
        }
        
        public static void SetBufferingStarted(DependencyObject target, ICommand value)
        {
            target.SetValue(BufferingStartedProperty, value);
        }
        
        private static void OnBufferingStartedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is MediaElement target)
            {
                if (e.OldValue != null)
                {
                    target.BufferingStarted -= OnBufferingStarted;
                }
                if (e.NewValue != null)
                {
                    target.BufferingStarted += OnBufferingStarted;
                }
            }
        }
        
        private static void OnBufferingStarted(object o, RoutedEventArgs eventArgs)
        {
            var command = GetBufferingStarted((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region MediaEnded
        public static readonly DependencyProperty MediaEndedProperty =
            DependencyProperty.RegisterAttached("MediaEnded", typeof(ICommand), typeof(MediaElements), new FrameworkPropertyMetadata(OnMediaEndedChanged));
        
        public static ICommand GetMediaEnded(DependencyObject target)
        {
            return (ICommand)target.GetValue(MediaEndedProperty);
        }
        
        public static void SetMediaEnded(DependencyObject target, ICommand value)
        {
            target.SetValue(MediaEndedProperty, value);
        }
        
        private static void OnMediaEndedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is MediaElement target)
            {
                if (e.OldValue != null)
                {
                    target.MediaEnded -= OnMediaEnded;
                }
                if (e.NewValue != null)
                {
                    target.MediaEnded += OnMediaEnded;
                }
            }
        }
        
        private static void OnMediaEnded(object o, RoutedEventArgs eventArgs)
        {
            var command = GetMediaEnded((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region MediaFailed
        public static readonly DependencyProperty MediaFailedProperty =
            DependencyProperty.RegisterAttached("MediaFailed", typeof(ICommand), typeof(MediaElements), new FrameworkPropertyMetadata(OnMediaFailedChanged));
        
        public static ICommand GetMediaFailed(DependencyObject target)
        {
            return (ICommand)target.GetValue(MediaFailedProperty);
        }
        
        public static void SetMediaFailed(DependencyObject target, ICommand value)
        {
            target.SetValue(MediaFailedProperty, value);
        }
        
        private static void OnMediaFailedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is MediaElement target)
            {
                if (e.OldValue != null)
                {
                    target.MediaFailed -= OnMediaFailed;
                }
                if (e.NewValue != null)
                {
                    target.MediaFailed += OnMediaFailed;
                }
            }
        }
        
        private static void OnMediaFailed(object o, ExceptionRoutedEventArgs eventArgs)
        {
            var command = GetMediaFailed((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region MediaFailedNotifyErrorException
        public static readonly DependencyProperty MediaFailedNotifyErrorExceptionProperty =
            DependencyProperty.RegisterAttached("MediaFailedNotifyErrorException", typeof(ICommand), typeof(MediaElements), new FrameworkPropertyMetadata(OnMediaFailedNotifyErrorExceptionChanged));
        
        public static ICommand GetMediaFailedNotifyErrorException(DependencyObject target)
        {
            return (ICommand)target.GetValue(MediaFailedNotifyErrorExceptionProperty);
        }
        
        public static void SetMediaFailedNotifyErrorException(DependencyObject target, ICommand value)
        {
            target.SetValue(MediaFailedNotifyErrorExceptionProperty, value);
        }
        
        private static void OnMediaFailedNotifyErrorExceptionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is MediaElement target)
            {
                if (e.OldValue != null)
                {
                    target.MediaFailed -= OnMediaFailedNotifyErrorException;
                }
                if (e.NewValue != null)
                {
                    target.MediaFailed += OnMediaFailedNotifyErrorException;
                }
            }
        }
        
        private static void OnMediaFailedNotifyErrorException(object o, System.Windows.ExceptionRoutedEventArgs eventArgs)
        {
            var command = GetMediaFailedNotifyErrorException((DependencyObject)o);
            if (command.CanExecute(eventArgs.ErrorException))
                command.Execute(eventArgs.ErrorException);
        }
        #endregion
        
        #region MediaFailedNotifyRoutedEvent
        public static readonly DependencyProperty MediaFailedNotifyRoutedEventProperty =
            DependencyProperty.RegisterAttached("MediaFailedNotifyRoutedEvent", typeof(ICommand), typeof(MediaElements), new FrameworkPropertyMetadata(OnMediaFailedNotifyRoutedEventChanged));
        
        public static ICommand GetMediaFailedNotifyRoutedEvent(DependencyObject target)
        {
            return (ICommand)target.GetValue(MediaFailedNotifyRoutedEventProperty);
        }
        
        public static void SetMediaFailedNotifyRoutedEvent(DependencyObject target, ICommand value)
        {
            target.SetValue(MediaFailedNotifyRoutedEventProperty, value);
        }
        
        private static void OnMediaFailedNotifyRoutedEventChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is MediaElement target)
            {
                if (e.OldValue != null)
                {
                    target.MediaFailed -= OnMediaFailedNotifyRoutedEvent;
                }
                if (e.NewValue != null)
                {
                    target.MediaFailed += OnMediaFailedNotifyRoutedEvent;
                }
            }
        }
        
        private static void OnMediaFailedNotifyRoutedEvent(object o, System.Windows.ExceptionRoutedEventArgs eventArgs)
        {
            var command = GetMediaFailedNotifyRoutedEvent((DependencyObject)o);
            if (command.CanExecute(eventArgs.RoutedEvent))
                command.Execute(eventArgs.RoutedEvent);
        }
        #endregion
        
        #region MediaFailedNotifyHandled
        public static readonly DependencyProperty MediaFailedNotifyHandledProperty =
            DependencyProperty.RegisterAttached("MediaFailedNotifyHandled", typeof(ICommand), typeof(MediaElements), new FrameworkPropertyMetadata(OnMediaFailedNotifyHandledChanged));
        
        public static ICommand GetMediaFailedNotifyHandled(DependencyObject target)
        {
            return (ICommand)target.GetValue(MediaFailedNotifyHandledProperty);
        }
        
        public static void SetMediaFailedNotifyHandled(DependencyObject target, ICommand value)
        {
            target.SetValue(MediaFailedNotifyHandledProperty, value);
        }
        
        private static void OnMediaFailedNotifyHandledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is MediaElement target)
            {
                if (e.OldValue != null)
                {
                    target.MediaFailed -= OnMediaFailedNotifyHandled;
                }
                if (e.NewValue != null)
                {
                    target.MediaFailed += OnMediaFailedNotifyHandled;
                }
            }
        }
        
        private static void OnMediaFailedNotifyHandled(object o, System.Windows.ExceptionRoutedEventArgs eventArgs)
        {
            var command = GetMediaFailedNotifyHandled((DependencyObject)o);
            if (command.CanExecute(eventArgs.Handled))
                command.Execute(eventArgs.Handled);
        }
        #endregion
        
        #region MediaFailedNotifySource
        public static readonly DependencyProperty MediaFailedNotifySourceProperty =
            DependencyProperty.RegisterAttached("MediaFailedNotifySource", typeof(ICommand), typeof(MediaElements), new FrameworkPropertyMetadata(OnMediaFailedNotifySourceChanged));
        
        public static ICommand GetMediaFailedNotifySource(DependencyObject target)
        {
            return (ICommand)target.GetValue(MediaFailedNotifySourceProperty);
        }
        
        public static void SetMediaFailedNotifySource(DependencyObject target, ICommand value)
        {
            target.SetValue(MediaFailedNotifySourceProperty, value);
        }
        
        private static void OnMediaFailedNotifySourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is MediaElement target)
            {
                if (e.OldValue != null)
                {
                    target.MediaFailed -= OnMediaFailedNotifySource;
                }
                if (e.NewValue != null)
                {
                    target.MediaFailed += OnMediaFailedNotifySource;
                }
            }
        }
        
        private static void OnMediaFailedNotifySource(object o, System.Windows.ExceptionRoutedEventArgs eventArgs)
        {
            var command = GetMediaFailedNotifySource((DependencyObject)o);
            if (command.CanExecute(eventArgs.Source))
                command.Execute(eventArgs.Source);
        }
        #endregion
        
        #region MediaFailedNotifyOriginalSource
        public static readonly DependencyProperty MediaFailedNotifyOriginalSourceProperty =
            DependencyProperty.RegisterAttached("MediaFailedNotifyOriginalSource", typeof(ICommand), typeof(MediaElements), new FrameworkPropertyMetadata(OnMediaFailedNotifyOriginalSourceChanged));
        
        public static ICommand GetMediaFailedNotifyOriginalSource(DependencyObject target)
        {
            return (ICommand)target.GetValue(MediaFailedNotifyOriginalSourceProperty);
        }
        
        public static void SetMediaFailedNotifyOriginalSource(DependencyObject target, ICommand value)
        {
            target.SetValue(MediaFailedNotifyOriginalSourceProperty, value);
        }
        
        private static void OnMediaFailedNotifyOriginalSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is MediaElement target)
            {
                if (e.OldValue != null)
                {
                    target.MediaFailed -= OnMediaFailedNotifyOriginalSource;
                }
                if (e.NewValue != null)
                {
                    target.MediaFailed += OnMediaFailedNotifyOriginalSource;
                }
            }
        }
        
        private static void OnMediaFailedNotifyOriginalSource(object o, System.Windows.ExceptionRoutedEventArgs eventArgs)
        {
            var command = GetMediaFailedNotifyOriginalSource((DependencyObject)o);
            if (command.CanExecute(eventArgs.OriginalSource))
                command.Execute(eventArgs.OriginalSource);
        }
        #endregion
        
        #region MediaOpened
        public static readonly DependencyProperty MediaOpenedProperty =
            DependencyProperty.RegisterAttached("MediaOpened", typeof(ICommand), typeof(MediaElements), new FrameworkPropertyMetadata(OnMediaOpenedChanged));
        
        public static ICommand GetMediaOpened(DependencyObject target)
        {
            return (ICommand)target.GetValue(MediaOpenedProperty);
        }
        
        public static void SetMediaOpened(DependencyObject target, ICommand value)
        {
            target.SetValue(MediaOpenedProperty, value);
        }
        
        private static void OnMediaOpenedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is MediaElement target)
            {
                if (e.OldValue != null)
                {
                    target.MediaOpened -= OnMediaOpened;
                }
                if (e.NewValue != null)
                {
                    target.MediaOpened += OnMediaOpened;
                }
            }
        }
        
        private static void OnMediaOpened(object o, RoutedEventArgs eventArgs)
        {
            var command = GetMediaOpened((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region ScriptCommand
        public static readonly DependencyProperty ScriptCommandProperty =
            DependencyProperty.RegisterAttached("ScriptCommand", typeof(ICommand), typeof(MediaElements), new FrameworkPropertyMetadata(OnScriptCommandChanged));
        
        public static ICommand GetScriptCommand(DependencyObject target)
        {
            return (ICommand)target.GetValue(ScriptCommandProperty);
        }
        
        public static void SetScriptCommand(DependencyObject target, ICommand value)
        {
            target.SetValue(ScriptCommandProperty, value);
        }
        
        private static void OnScriptCommandChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is MediaElement target)
            {
                if (e.OldValue != null)
                {
                    target.ScriptCommand -= OnScriptCommand;
                }
                if (e.NewValue != null)
                {
                    target.ScriptCommand += OnScriptCommand;
                }
            }
        }
        
        private static void OnScriptCommand(object o, MediaScriptCommandRoutedEventArgs eventArgs)
        {
            var command = GetScriptCommand((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region ScriptCommandNotifyParameterType
        public static readonly DependencyProperty ScriptCommandNotifyParameterTypeProperty =
            DependencyProperty.RegisterAttached("ScriptCommandNotifyParameterType", typeof(ICommand), typeof(MediaElements), new FrameworkPropertyMetadata(OnScriptCommandNotifyParameterTypeChanged));
        
        public static ICommand GetScriptCommandNotifyParameterType(DependencyObject target)
        {
            return (ICommand)target.GetValue(ScriptCommandNotifyParameterTypeProperty);
        }
        
        public static void SetScriptCommandNotifyParameterType(DependencyObject target, ICommand value)
        {
            target.SetValue(ScriptCommandNotifyParameterTypeProperty, value);
        }
        
        private static void OnScriptCommandNotifyParameterTypeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is MediaElement target)
            {
                if (e.OldValue != null)
                {
                    target.ScriptCommand -= OnScriptCommandNotifyParameterType;
                }
                if (e.NewValue != null)
                {
                    target.ScriptCommand += OnScriptCommandNotifyParameterType;
                }
            }
        }
        
        private static void OnScriptCommandNotifyParameterType(object o, System.Windows.MediaScriptCommandRoutedEventArgs eventArgs)
        {
            var command = GetScriptCommandNotifyParameterType((DependencyObject)o);
            if (command.CanExecute(eventArgs.ParameterType))
                command.Execute(eventArgs.ParameterType);
        }
        #endregion
        
        #region ScriptCommandNotifyParameterValue
        public static readonly DependencyProperty ScriptCommandNotifyParameterValueProperty =
            DependencyProperty.RegisterAttached("ScriptCommandNotifyParameterValue", typeof(ICommand), typeof(MediaElements), new FrameworkPropertyMetadata(OnScriptCommandNotifyParameterValueChanged));
        
        public static ICommand GetScriptCommandNotifyParameterValue(DependencyObject target)
        {
            return (ICommand)target.GetValue(ScriptCommandNotifyParameterValueProperty);
        }
        
        public static void SetScriptCommandNotifyParameterValue(DependencyObject target, ICommand value)
        {
            target.SetValue(ScriptCommandNotifyParameterValueProperty, value);
        }
        
        private static void OnScriptCommandNotifyParameterValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is MediaElement target)
            {
                if (e.OldValue != null)
                {
                    target.ScriptCommand -= OnScriptCommandNotifyParameterValue;
                }
                if (e.NewValue != null)
                {
                    target.ScriptCommand += OnScriptCommandNotifyParameterValue;
                }
            }
        }
        
        private static void OnScriptCommandNotifyParameterValue(object o, System.Windows.MediaScriptCommandRoutedEventArgs eventArgs)
        {
            var command = GetScriptCommandNotifyParameterValue((DependencyObject)o);
            if (command.CanExecute(eventArgs.ParameterValue))
                command.Execute(eventArgs.ParameterValue);
        }
        #endregion
        
        #region ScriptCommandNotifyRoutedEvent
        public static readonly DependencyProperty ScriptCommandNotifyRoutedEventProperty =
            DependencyProperty.RegisterAttached("ScriptCommandNotifyRoutedEvent", typeof(ICommand), typeof(MediaElements), new FrameworkPropertyMetadata(OnScriptCommandNotifyRoutedEventChanged));
        
        public static ICommand GetScriptCommandNotifyRoutedEvent(DependencyObject target)
        {
            return (ICommand)target.GetValue(ScriptCommandNotifyRoutedEventProperty);
        }
        
        public static void SetScriptCommandNotifyRoutedEvent(DependencyObject target, ICommand value)
        {
            target.SetValue(ScriptCommandNotifyRoutedEventProperty, value);
        }
        
        private static void OnScriptCommandNotifyRoutedEventChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is MediaElement target)
            {
                if (e.OldValue != null)
                {
                    target.ScriptCommand -= OnScriptCommandNotifyRoutedEvent;
                }
                if (e.NewValue != null)
                {
                    target.ScriptCommand += OnScriptCommandNotifyRoutedEvent;
                }
            }
        }
        
        private static void OnScriptCommandNotifyRoutedEvent(object o, System.Windows.MediaScriptCommandRoutedEventArgs eventArgs)
        {
            var command = GetScriptCommandNotifyRoutedEvent((DependencyObject)o);
            if (command.CanExecute(eventArgs.RoutedEvent))
                command.Execute(eventArgs.RoutedEvent);
        }
        #endregion
        
        #region ScriptCommandNotifyHandled
        public static readonly DependencyProperty ScriptCommandNotifyHandledProperty =
            DependencyProperty.RegisterAttached("ScriptCommandNotifyHandled", typeof(ICommand), typeof(MediaElements), new FrameworkPropertyMetadata(OnScriptCommandNotifyHandledChanged));
        
        public static ICommand GetScriptCommandNotifyHandled(DependencyObject target)
        {
            return (ICommand)target.GetValue(ScriptCommandNotifyHandledProperty);
        }
        
        public static void SetScriptCommandNotifyHandled(DependencyObject target, ICommand value)
        {
            target.SetValue(ScriptCommandNotifyHandledProperty, value);
        }
        
        private static void OnScriptCommandNotifyHandledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is MediaElement target)
            {
                if (e.OldValue != null)
                {
                    target.ScriptCommand -= OnScriptCommandNotifyHandled;
                }
                if (e.NewValue != null)
                {
                    target.ScriptCommand += OnScriptCommandNotifyHandled;
                }
            }
        }
        
        private static void OnScriptCommandNotifyHandled(object o, System.Windows.MediaScriptCommandRoutedEventArgs eventArgs)
        {
            var command = GetScriptCommandNotifyHandled((DependencyObject)o);
            if (command.CanExecute(eventArgs.Handled))
                command.Execute(eventArgs.Handled);
        }
        #endregion
        
        #region ScriptCommandNotifySource
        public static readonly DependencyProperty ScriptCommandNotifySourceProperty =
            DependencyProperty.RegisterAttached("ScriptCommandNotifySource", typeof(ICommand), typeof(MediaElements), new FrameworkPropertyMetadata(OnScriptCommandNotifySourceChanged));
        
        public static ICommand GetScriptCommandNotifySource(DependencyObject target)
        {
            return (ICommand)target.GetValue(ScriptCommandNotifySourceProperty);
        }
        
        public static void SetScriptCommandNotifySource(DependencyObject target, ICommand value)
        {
            target.SetValue(ScriptCommandNotifySourceProperty, value);
        }
        
        private static void OnScriptCommandNotifySourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is MediaElement target)
            {
                if (e.OldValue != null)
                {
                    target.ScriptCommand -= OnScriptCommandNotifySource;
                }
                if (e.NewValue != null)
                {
                    target.ScriptCommand += OnScriptCommandNotifySource;
                }
            }
        }
        
        private static void OnScriptCommandNotifySource(object o, System.Windows.MediaScriptCommandRoutedEventArgs eventArgs)
        {
            var command = GetScriptCommandNotifySource((DependencyObject)o);
            if (command.CanExecute(eventArgs.Source))
                command.Execute(eventArgs.Source);
        }
        #endregion
        
        #region ScriptCommandNotifyOriginalSource
        public static readonly DependencyProperty ScriptCommandNotifyOriginalSourceProperty =
            DependencyProperty.RegisterAttached("ScriptCommandNotifyOriginalSource", typeof(ICommand), typeof(MediaElements), new FrameworkPropertyMetadata(OnScriptCommandNotifyOriginalSourceChanged));
        
        public static ICommand GetScriptCommandNotifyOriginalSource(DependencyObject target)
        {
            return (ICommand)target.GetValue(ScriptCommandNotifyOriginalSourceProperty);
        }
        
        public static void SetScriptCommandNotifyOriginalSource(DependencyObject target, ICommand value)
        {
            target.SetValue(ScriptCommandNotifyOriginalSourceProperty, value);
        }
        
        private static void OnScriptCommandNotifyOriginalSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is MediaElement target)
            {
                if (e.OldValue != null)
                {
                    target.ScriptCommand -= OnScriptCommandNotifyOriginalSource;
                }
                if (e.NewValue != null)
                {
                    target.ScriptCommand += OnScriptCommandNotifyOriginalSource;
                }
            }
        }
        
        private static void OnScriptCommandNotifyOriginalSource(object o, System.Windows.MediaScriptCommandRoutedEventArgs eventArgs)
        {
            var command = GetScriptCommandNotifyOriginalSource((DependencyObject)o);
            if (command.CanExecute(eventArgs.OriginalSource))
                command.Execute(eventArgs.OriginalSource);
        }
        #endregion
	}
	#endregion

	#region MenuItems
	public static partial class MenuItems {
        
        #region Checked
        public static readonly DependencyProperty CheckedProperty =
            DependencyProperty.RegisterAttached("Checked", typeof(ICommand), typeof(MenuItems), new FrameworkPropertyMetadata(OnCheckedChanged));
        
        public static ICommand GetChecked(DependencyObject target)
        {
            return (ICommand)target.GetValue(CheckedProperty);
        }
        
        public static void SetChecked(DependencyObject target, ICommand value)
        {
            target.SetValue(CheckedProperty, value);
        }
        
        private static void OnCheckedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is MenuItem target)
            {
                if (e.OldValue != null)
                {
                    target.Checked -= OnChecked;
                }
                if (e.NewValue != null)
                {
                    target.Checked += OnChecked;
                }
            }
        }
        
        private static void OnChecked(object o, RoutedEventArgs eventArgs)
        {
            var command = GetChecked((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Click
        public static readonly DependencyProperty ClickProperty =
            DependencyProperty.RegisterAttached("Click", typeof(ICommand), typeof(MenuItems), new FrameworkPropertyMetadata(OnClickChanged));
        
        public static ICommand GetClick(DependencyObject target)
        {
            return (ICommand)target.GetValue(ClickProperty);
        }
        
        public static void SetClick(DependencyObject target, ICommand value)
        {
            target.SetValue(ClickProperty, value);
        }
        
        private static void OnClickChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is MenuItem target)
            {
                if (e.OldValue != null)
                {
                    target.Click -= OnClick;
                }
                if (e.NewValue != null)
                {
                    target.Click += OnClick;
                }
            }
        }
        
        private static void OnClick(object o, RoutedEventArgs eventArgs)
        {
            var command = GetClick((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region SubmenuClosed
        public static readonly DependencyProperty SubmenuClosedProperty =
            DependencyProperty.RegisterAttached("SubmenuClosed", typeof(ICommand), typeof(MenuItems), new FrameworkPropertyMetadata(OnSubmenuClosedChanged));
        
        public static ICommand GetSubmenuClosed(DependencyObject target)
        {
            return (ICommand)target.GetValue(SubmenuClosedProperty);
        }
        
        public static void SetSubmenuClosed(DependencyObject target, ICommand value)
        {
            target.SetValue(SubmenuClosedProperty, value);
        }
        
        private static void OnSubmenuClosedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is MenuItem target)
            {
                if (e.OldValue != null)
                {
                    target.SubmenuClosed -= OnSubmenuClosed;
                }
                if (e.NewValue != null)
                {
                    target.SubmenuClosed += OnSubmenuClosed;
                }
            }
        }
        
        private static void OnSubmenuClosed(object o, RoutedEventArgs eventArgs)
        {
            var command = GetSubmenuClosed((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region SubmenuOpened
        public static readonly DependencyProperty SubmenuOpenedProperty =
            DependencyProperty.RegisterAttached("SubmenuOpened", typeof(ICommand), typeof(MenuItems), new FrameworkPropertyMetadata(OnSubmenuOpenedChanged));
        
        public static ICommand GetSubmenuOpened(DependencyObject target)
        {
            return (ICommand)target.GetValue(SubmenuOpenedProperty);
        }
        
        public static void SetSubmenuOpened(DependencyObject target, ICommand value)
        {
            target.SetValue(SubmenuOpenedProperty, value);
        }
        
        private static void OnSubmenuOpenedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is MenuItem target)
            {
                if (e.OldValue != null)
                {
                    target.SubmenuOpened -= OnSubmenuOpened;
                }
                if (e.NewValue != null)
                {
                    target.SubmenuOpened += OnSubmenuOpened;
                }
            }
        }
        
        private static void OnSubmenuOpened(object o, RoutedEventArgs eventArgs)
        {
            var command = GetSubmenuOpened((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Unchecked
        public static readonly DependencyProperty UncheckedProperty =
            DependencyProperty.RegisterAttached("Unchecked", typeof(ICommand), typeof(MenuItems), new FrameworkPropertyMetadata(OnUncheckedChanged));
        
        public static ICommand GetUnchecked(DependencyObject target)
        {
            return (ICommand)target.GetValue(UncheckedProperty);
        }
        
        public static void SetUnchecked(DependencyObject target, ICommand value)
        {
            target.SetValue(UncheckedProperty, value);
        }
        
        private static void OnUncheckedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is MenuItem target)
            {
                if (e.OldValue != null)
                {
                    target.Unchecked -= OnUnchecked;
                }
                if (e.NewValue != null)
                {
                    target.Unchecked += OnUnchecked;
                }
            }
        }
        
        private static void OnUnchecked(object o, RoutedEventArgs eventArgs)
        {
            var command = GetUnchecked((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region PasswordBoxs
	public static partial class PasswordBoxs {
        
        #region PasswordChanged
        public static readonly DependencyProperty PasswordChangedProperty =
            DependencyProperty.RegisterAttached("PasswordChanged", typeof(ICommand), typeof(PasswordBoxs), new FrameworkPropertyMetadata(OnPasswordChangedChanged));
        
        public static ICommand GetPasswordChanged(DependencyObject target)
        {
            return (ICommand)target.GetValue(PasswordChangedProperty);
        }
        
        public static void SetPasswordChanged(DependencyObject target, ICommand value)
        {
            target.SetValue(PasswordChangedProperty, value);
        }
        
        private static void OnPasswordChangedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is PasswordBox target)
            {
                if (e.OldValue != null)
                {
                    target.PasswordChanged -= OnPasswordChanged;
                }
                if (e.NewValue != null)
                {
                    target.PasswordChanged += OnPasswordChanged;
                }
            }
        }
        
        private static void OnPasswordChanged(object o, RoutedEventArgs eventArgs)
        {
            var command = GetPasswordChanged((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region ButtonBases
	public static partial class ButtonBases {
        
        #region Click
        public static readonly DependencyProperty ClickProperty =
            DependencyProperty.RegisterAttached("Click", typeof(ICommand), typeof(ButtonBases), new FrameworkPropertyMetadata(OnClickChanged));
        
        public static ICommand GetClick(DependencyObject target)
        {
            return (ICommand)target.GetValue(ClickProperty);
        }
        
        public static void SetClick(DependencyObject target, ICommand value)
        {
            target.SetValue(ClickProperty, value);
        }
        
        private static void OnClickChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ButtonBase target)
            {
                if (e.OldValue != null)
                {
                    target.Click -= OnClick;
                }
                if (e.NewValue != null)
                {
                    target.Click += OnClick;
                }
            }
        }
        
        private static void OnClick(object o, RoutedEventArgs eventArgs)
        {
            var command = GetClick((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region DocumentPageViews
	public static partial class DocumentPageViews {
        
        #region PageConnected
        public static readonly DependencyProperty PageConnectedProperty =
            DependencyProperty.RegisterAttached("PageConnected", typeof(ICommand), typeof(DocumentPageViews), new FrameworkPropertyMetadata(OnPageConnectedChanged));
        
        public static ICommand GetPageConnected(DependencyObject target)
        {
            return (ICommand)target.GetValue(PageConnectedProperty);
        }
        
        public static void SetPageConnected(DependencyObject target, ICommand value)
        {
            target.SetValue(PageConnectedProperty, value);
        }
        
        private static void OnPageConnectedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DocumentPageView target)
            {
                if (e.OldValue != null)
                {
                    target.PageConnected -= OnPageConnected;
                }
                if (e.NewValue != null)
                {
                    target.PageConnected += OnPageConnected;
                }
            }
        }
        
        private static void OnPageConnected(object o, EventArgs eventArgs)
        {
            var command = GetPageConnected((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region PageDisconnected
        public static readonly DependencyProperty PageDisconnectedProperty =
            DependencyProperty.RegisterAttached("PageDisconnected", typeof(ICommand), typeof(DocumentPageViews), new FrameworkPropertyMetadata(OnPageDisconnectedChanged));
        
        public static ICommand GetPageDisconnected(DependencyObject target)
        {
            return (ICommand)target.GetValue(PageDisconnectedProperty);
        }
        
        public static void SetPageDisconnected(DependencyObject target, ICommand value)
        {
            target.SetValue(PageDisconnectedProperty, value);
        }
        
        private static void OnPageDisconnectedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DocumentPageView target)
            {
                if (e.OldValue != null)
                {
                    target.PageDisconnected -= OnPageDisconnected;
                }
                if (e.NewValue != null)
                {
                    target.PageDisconnected += OnPageDisconnected;
                }
            }
        }
        
        private static void OnPageDisconnected(object o, EventArgs eventArgs)
        {
            var command = GetPageDisconnected((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region DocumentViewerBases
	public static partial class DocumentViewerBases {
        
        #region PageViewsChanged
        public static readonly DependencyProperty PageViewsChangedProperty =
            DependencyProperty.RegisterAttached("PageViewsChanged", typeof(ICommand), typeof(DocumentViewerBases), new FrameworkPropertyMetadata(OnPageViewsChangedChanged));
        
        public static ICommand GetPageViewsChanged(DependencyObject target)
        {
            return (ICommand)target.GetValue(PageViewsChangedProperty);
        }
        
        public static void SetPageViewsChanged(DependencyObject target, ICommand value)
        {
            target.SetValue(PageViewsChangedProperty, value);
        }
        
        private static void OnPageViewsChangedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DocumentViewerBase target)
            {
                if (e.OldValue != null)
                {
                    target.PageViewsChanged -= OnPageViewsChanged;
                }
                if (e.NewValue != null)
                {
                    target.PageViewsChanged += OnPageViewsChanged;
                }
            }
        }
        
        private static void OnPageViewsChanged(object o, EventArgs eventArgs)
        {
            var command = GetPageViewsChanged((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region Popups
	public static partial class Popups {
        
        #region Closed
        public static readonly DependencyProperty ClosedProperty =
            DependencyProperty.RegisterAttached("Closed", typeof(ICommand), typeof(Popups), new FrameworkPropertyMetadata(OnClosedChanged));
        
        public static ICommand GetClosed(DependencyObject target)
        {
            return (ICommand)target.GetValue(ClosedProperty);
        }
        
        public static void SetClosed(DependencyObject target, ICommand value)
        {
            target.SetValue(ClosedProperty, value);
        }
        
        private static void OnClosedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Popup target)
            {
                if (e.OldValue != null)
                {
                    target.Closed -= OnClosed;
                }
                if (e.NewValue != null)
                {
                    target.Closed += OnClosed;
                }
            }
        }
        
        private static void OnClosed(object o, EventArgs eventArgs)
        {
            var command = GetClosed((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Opened
        public static readonly DependencyProperty OpenedProperty =
            DependencyProperty.RegisterAttached("Opened", typeof(ICommand), typeof(Popups), new FrameworkPropertyMetadata(OnOpenedChanged));
        
        public static ICommand GetOpened(DependencyObject target)
        {
            return (ICommand)target.GetValue(OpenedProperty);
        }
        
        public static void SetOpened(DependencyObject target, ICommand value)
        {
            target.SetValue(OpenedProperty, value);
        }
        
        private static void OnOpenedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Popup target)
            {
                if (e.OldValue != null)
                {
                    target.Opened -= OnOpened;
                }
                if (e.NewValue != null)
                {
                    target.Opened += OnOpened;
                }
            }
        }
        
        private static void OnOpened(object o, EventArgs eventArgs)
        {
            var command = GetOpened((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region ScrollBars
	public static partial class ScrollBars {
        
        #region Scroll
        public static readonly DependencyProperty ScrollProperty =
            DependencyProperty.RegisterAttached("Scroll", typeof(ICommand), typeof(ScrollBars), new FrameworkPropertyMetadata(OnScrollChanged));
        
        public static ICommand GetScroll(DependencyObject target)
        {
            return (ICommand)target.GetValue(ScrollProperty);
        }
        
        public static void SetScroll(DependencyObject target, ICommand value)
        {
            target.SetValue(ScrollProperty, value);
        }
        
        private static void OnScrollChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ScrollBar target)
            {
                if (e.OldValue != null)
                {
                    target.Scroll -= OnScroll;
                }
                if (e.NewValue != null)
                {
                    target.Scroll += OnScroll;
                }
            }
        }
        
        private static void OnScroll(object o, ScrollEventArgs eventArgs)
        {
            var command = GetScroll((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region Selectors
	public static partial class Selectors {
        
        #region SelectionChanged
        public static readonly DependencyProperty SelectionChangedProperty =
            DependencyProperty.RegisterAttached("SelectionChanged", typeof(ICommand), typeof(Selectors), new FrameworkPropertyMetadata(OnSelectionChangedChanged));
        
        public static ICommand GetSelectionChanged(DependencyObject target)
        {
            return (ICommand)target.GetValue(SelectionChangedProperty);
        }
        
        public static void SetSelectionChanged(DependencyObject target, ICommand value)
        {
            target.SetValue(SelectionChangedProperty, value);
        }
        
        private static void OnSelectionChangedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Selector target)
            {
                if (e.OldValue != null)
                {
                    target.SelectionChanged -= OnSelectionChanged;
                }
                if (e.NewValue != null)
                {
                    target.SelectionChanged += OnSelectionChanged;
                }
            }
        }
        
        private static void OnSelectionChanged(object o, SelectionChangedEventArgs eventArgs)
        {
            var command = GetSelectionChanged((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region TextBoxBases
	public static partial class TextBoxBases {
        
        #region SelectionChanged
        public static readonly DependencyProperty SelectionChangedProperty =
            DependencyProperty.RegisterAttached("SelectionChanged", typeof(ICommand), typeof(TextBoxBases), new FrameworkPropertyMetadata(OnSelectionChangedChanged));
        
        public static ICommand GetSelectionChanged(DependencyObject target)
        {
            return (ICommand)target.GetValue(SelectionChangedProperty);
        }
        
        public static void SetSelectionChanged(DependencyObject target, ICommand value)
        {
            target.SetValue(SelectionChangedProperty, value);
        }
        
        private static void OnSelectionChangedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is TextBoxBase target)
            {
                if (e.OldValue != null)
                {
                    target.SelectionChanged -= OnSelectionChanged;
                }
                if (e.NewValue != null)
                {
                    target.SelectionChanged += OnSelectionChanged;
                }
            }
        }
        
        private static void OnSelectionChanged(object o, RoutedEventArgs eventArgs)
        {
            var command = GetSelectionChanged((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region TextChanged
        public static readonly DependencyProperty TextChangedProperty =
            DependencyProperty.RegisterAttached("TextChanged", typeof(ICommand), typeof(TextBoxBases), new FrameworkPropertyMetadata(OnTextChangedChanged));
        
        public static ICommand GetTextChanged(DependencyObject target)
        {
            return (ICommand)target.GetValue(TextChangedProperty);
        }
        
        public static void SetTextChanged(DependencyObject target, ICommand value)
        {
            target.SetValue(TextChangedProperty, value);
        }
        
        private static void OnTextChangedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is TextBoxBase target)
            {
                if (e.OldValue != null)
                {
                    target.TextChanged -= OnTextChanged;
                }
                if (e.NewValue != null)
                {
                    target.TextChanged += OnTextChanged;
                }
            }
        }
        
        private static void OnTextChanged(object o, TextChangedEventArgs eventArgs)
        {
            var command = GetTextChanged((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region Thumbs
	public static partial class Thumbs {
        
        #region DragCompleted
        public static readonly DependencyProperty DragCompletedProperty =
            DependencyProperty.RegisterAttached("DragCompleted", typeof(ICommand), typeof(Thumbs), new FrameworkPropertyMetadata(OnDragCompletedChanged));
        
        public static ICommand GetDragCompleted(DependencyObject target)
        {
            return (ICommand)target.GetValue(DragCompletedProperty);
        }
        
        public static void SetDragCompleted(DependencyObject target, ICommand value)
        {
            target.SetValue(DragCompletedProperty, value);
        }
        
        private static void OnDragCompletedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Thumb target)
            {
                if (e.OldValue != null)
                {
                    target.DragCompleted -= OnDragCompleted;
                }
                if (e.NewValue != null)
                {
                    target.DragCompleted += OnDragCompleted;
                }
            }
        }
        
        private static void OnDragCompleted(object o, DragCompletedEventArgs eventArgs)
        {
            var command = GetDragCompleted((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region DragDelta
        public static readonly DependencyProperty DragDeltaProperty =
            DependencyProperty.RegisterAttached("DragDelta", typeof(ICommand), typeof(Thumbs), new FrameworkPropertyMetadata(OnDragDeltaChanged));
        
        public static ICommand GetDragDelta(DependencyObject target)
        {
            return (ICommand)target.GetValue(DragDeltaProperty);
        }
        
        public static void SetDragDelta(DependencyObject target, ICommand value)
        {
            target.SetValue(DragDeltaProperty, value);
        }
        
        private static void OnDragDeltaChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Thumb target)
            {
                if (e.OldValue != null)
                {
                    target.DragDelta -= OnDragDelta;
                }
                if (e.NewValue != null)
                {
                    target.DragDelta += OnDragDelta;
                }
            }
        }
        
        private static void OnDragDelta(object o, DragDeltaEventArgs eventArgs)
        {
            var command = GetDragDelta((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region DragStarted
        public static readonly DependencyProperty DragStartedProperty =
            DependencyProperty.RegisterAttached("DragStarted", typeof(ICommand), typeof(Thumbs), new FrameworkPropertyMetadata(OnDragStartedChanged));
        
        public static ICommand GetDragStarted(DependencyObject target)
        {
            return (ICommand)target.GetValue(DragStartedProperty);
        }
        
        public static void SetDragStarted(DependencyObject target, ICommand value)
        {
            target.SetValue(DragStartedProperty, value);
        }
        
        private static void OnDragStartedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Thumb target)
            {
                if (e.OldValue != null)
                {
                    target.DragStarted -= OnDragStarted;
                }
                if (e.NewValue != null)
                {
                    target.DragStarted += OnDragStarted;
                }
            }
        }
        
        private static void OnDragStarted(object o, DragStartedEventArgs eventArgs)
        {
            var command = GetDragStarted((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region ToggleButtons
	public static partial class ToggleButtons {
        
        #region Checked
        public static readonly DependencyProperty CheckedProperty =
            DependencyProperty.RegisterAttached("Checked", typeof(ICommand), typeof(ToggleButtons), new FrameworkPropertyMetadata(OnCheckedChanged));
        
        public static ICommand GetChecked(DependencyObject target)
        {
            return (ICommand)target.GetValue(CheckedProperty);
        }
        
        public static void SetChecked(DependencyObject target, ICommand value)
        {
            target.SetValue(CheckedProperty, value);
        }
        
        private static void OnCheckedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ToggleButton target)
            {
                if (e.OldValue != null)
                {
                    target.Checked -= OnChecked;
                }
                if (e.NewValue != null)
                {
                    target.Checked += OnChecked;
                }
            }
        }
        
        private static void OnChecked(object o, RoutedEventArgs eventArgs)
        {
            var command = GetChecked((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Indeterminate
        public static readonly DependencyProperty IndeterminateProperty =
            DependencyProperty.RegisterAttached("Indeterminate", typeof(ICommand), typeof(ToggleButtons), new FrameworkPropertyMetadata(OnIndeterminateChanged));
        
        public static ICommand GetIndeterminate(DependencyObject target)
        {
            return (ICommand)target.GetValue(IndeterminateProperty);
        }
        
        public static void SetIndeterminate(DependencyObject target, ICommand value)
        {
            target.SetValue(IndeterminateProperty, value);
        }
        
        private static void OnIndeterminateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ToggleButton target)
            {
                if (e.OldValue != null)
                {
                    target.Indeterminate -= OnIndeterminate;
                }
                if (e.NewValue != null)
                {
                    target.Indeterminate += OnIndeterminate;
                }
            }
        }
        
        private static void OnIndeterminate(object o, RoutedEventArgs eventArgs)
        {
            var command = GetIndeterminate((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Unchecked
        public static readonly DependencyProperty UncheckedProperty =
            DependencyProperty.RegisterAttached("Unchecked", typeof(ICommand), typeof(ToggleButtons), new FrameworkPropertyMetadata(OnUncheckedChanged));
        
        public static ICommand GetUnchecked(DependencyObject target)
        {
            return (ICommand)target.GetValue(UncheckedProperty);
        }
        
        public static void SetUnchecked(DependencyObject target, ICommand value)
        {
            target.SetValue(UncheckedProperty, value);
        }
        
        private static void OnUncheckedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ToggleButton target)
            {
                if (e.OldValue != null)
                {
                    target.Unchecked -= OnUnchecked;
                }
                if (e.NewValue != null)
                {
                    target.Unchecked += OnUnchecked;
                }
            }
        }
        
        private static void OnUnchecked(object o, RoutedEventArgs eventArgs)
        {
            var command = GetUnchecked((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region ScrollViewers
	public static partial class ScrollViewers {
        
        #region ScrollChanged
        public static readonly DependencyProperty ScrollChangedProperty =
            DependencyProperty.RegisterAttached("ScrollChanged", typeof(ICommand), typeof(ScrollViewers), new FrameworkPropertyMetadata(OnScrollChangedChanged));
        
        public static ICommand GetScrollChanged(DependencyObject target)
        {
            return (ICommand)target.GetValue(ScrollChangedProperty);
        }
        
        public static void SetScrollChanged(DependencyObject target, ICommand value)
        {
            target.SetValue(ScrollChangedProperty, value);
        }
        
        private static void OnScrollChangedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ScrollViewer target)
            {
                if (e.OldValue != null)
                {
                    target.ScrollChanged -= OnScrollChanged;
                }
                if (e.NewValue != null)
                {
                    target.ScrollChanged += OnScrollChanged;
                }
            }
        }
        
        private static void OnScrollChanged(object o, ScrollChangedEventArgs eventArgs)
        {
            var command = GetScrollChanged((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region ToolTips
	public static partial class ToolTips {
        
        #region Closed
        public static readonly DependencyProperty ClosedProperty =
            DependencyProperty.RegisterAttached("Closed", typeof(ICommand), typeof(ToolTips), new FrameworkPropertyMetadata(OnClosedChanged));
        
        public static ICommand GetClosed(DependencyObject target)
        {
            return (ICommand)target.GetValue(ClosedProperty);
        }
        
        public static void SetClosed(DependencyObject target, ICommand value)
        {
            target.SetValue(ClosedProperty, value);
        }
        
        private static void OnClosedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ToolTip target)
            {
                if (e.OldValue != null)
                {
                    target.Closed -= OnClosed;
                }
                if (e.NewValue != null)
                {
                    target.Closed += OnClosed;
                }
            }
        }
        
        private static void OnClosed(object o, RoutedEventArgs eventArgs)
        {
            var command = GetClosed((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Opened
        public static readonly DependencyProperty OpenedProperty =
            DependencyProperty.RegisterAttached("Opened", typeof(ICommand), typeof(ToolTips), new FrameworkPropertyMetadata(OnOpenedChanged));
        
        public static ICommand GetOpened(DependencyObject target)
        {
            return (ICommand)target.GetValue(OpenedProperty);
        }
        
        public static void SetOpened(DependencyObject target, ICommand value)
        {
            target.SetValue(OpenedProperty, value);
        }
        
        private static void OnOpenedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ToolTip target)
            {
                if (e.OldValue != null)
                {
                    target.Opened -= OnOpened;
                }
                if (e.NewValue != null)
                {
                    target.Opened += OnOpened;
                }
            }
        }
        
        private static void OnOpened(object o, RoutedEventArgs eventArgs)
        {
            var command = GetOpened((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region TreeViewItems
	public static partial class TreeViewItems {
        
        #region Collapsed
        public static readonly DependencyProperty CollapsedProperty =
            DependencyProperty.RegisterAttached("Collapsed", typeof(ICommand), typeof(TreeViewItems), new FrameworkPropertyMetadata(OnCollapsedChanged));
        
        public static ICommand GetCollapsed(DependencyObject target)
        {
            return (ICommand)target.GetValue(CollapsedProperty);
        }
        
        public static void SetCollapsed(DependencyObject target, ICommand value)
        {
            target.SetValue(CollapsedProperty, value);
        }
        
        private static void OnCollapsedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is TreeViewItem target)
            {
                if (e.OldValue != null)
                {
                    target.Collapsed -= OnCollapsed;
                }
                if (e.NewValue != null)
                {
                    target.Collapsed += OnCollapsed;
                }
            }
        }
        
        private static void OnCollapsed(object o, RoutedEventArgs eventArgs)
        {
            var command = GetCollapsed((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Expanded
        public static readonly DependencyProperty ExpandedProperty =
            DependencyProperty.RegisterAttached("Expanded", typeof(ICommand), typeof(TreeViewItems), new FrameworkPropertyMetadata(OnExpandedChanged));
        
        public static ICommand GetExpanded(DependencyObject target)
        {
            return (ICommand)target.GetValue(ExpandedProperty);
        }
        
        public static void SetExpanded(DependencyObject target, ICommand value)
        {
            target.SetValue(ExpandedProperty, value);
        }
        
        private static void OnExpandedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is TreeViewItem target)
            {
                if (e.OldValue != null)
                {
                    target.Expanded -= OnExpanded;
                }
                if (e.NewValue != null)
                {
                    target.Expanded += OnExpanded;
                }
            }
        }
        
        private static void OnExpanded(object o, RoutedEventArgs eventArgs)
        {
            var command = GetExpanded((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Selected
        public static readonly DependencyProperty SelectedProperty =
            DependencyProperty.RegisterAttached("Selected", typeof(ICommand), typeof(TreeViewItems), new FrameworkPropertyMetadata(OnSelectedChanged));
        
        public static ICommand GetSelected(DependencyObject target)
        {
            return (ICommand)target.GetValue(SelectedProperty);
        }
        
        public static void SetSelected(DependencyObject target, ICommand value)
        {
            target.SetValue(SelectedProperty, value);
        }
        
        private static void OnSelectedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is TreeViewItem target)
            {
                if (e.OldValue != null)
                {
                    target.Selected -= OnSelected;
                }
                if (e.NewValue != null)
                {
                    target.Selected += OnSelected;
                }
            }
        }
        
        private static void OnSelected(object o, RoutedEventArgs eventArgs)
        {
            var command = GetSelected((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Unselected
        public static readonly DependencyProperty UnselectedProperty =
            DependencyProperty.RegisterAttached("Unselected", typeof(ICommand), typeof(TreeViewItems), new FrameworkPropertyMetadata(OnUnselectedChanged));
        
        public static ICommand GetUnselected(DependencyObject target)
        {
            return (ICommand)target.GetValue(UnselectedProperty);
        }
        
        public static void SetUnselected(DependencyObject target, ICommand value)
        {
            target.SetValue(UnselectedProperty, value);
        }
        
        private static void OnUnselectedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is TreeViewItem target)
            {
                if (e.OldValue != null)
                {
                    target.Unselected -= OnUnselected;
                }
                if (e.NewValue != null)
                {
                    target.Unselected += OnUnselected;
                }
            }
        }
        
        private static void OnUnselected(object o, RoutedEventArgs eventArgs)
        {
            var command = GetUnselected((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region WebBrowsers
	public static partial class WebBrowsers {
        
        #region LoadCompleted
        public static readonly DependencyProperty LoadCompletedProperty =
            DependencyProperty.RegisterAttached("LoadCompleted", typeof(ICommand), typeof(WebBrowsers), new FrameworkPropertyMetadata(OnLoadCompletedChanged));
        
        public static ICommand GetLoadCompleted(DependencyObject target)
        {
            return (ICommand)target.GetValue(LoadCompletedProperty);
        }
        
        public static void SetLoadCompleted(DependencyObject target, ICommand value)
        {
            target.SetValue(LoadCompletedProperty, value);
        }
        
        private static void OnLoadCompletedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is WebBrowser target)
            {
                if (e.OldValue != null)
                {
                    target.LoadCompleted -= OnLoadCompleted;
                }
                if (e.NewValue != null)
                {
                    target.LoadCompleted += OnLoadCompleted;
                }
            }
        }
        
        private static void OnLoadCompleted(object o, NavigationEventArgs eventArgs)
        {
            var command = GetLoadCompleted((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Navigated
        public static readonly DependencyProperty NavigatedProperty =
            DependencyProperty.RegisterAttached("Navigated", typeof(ICommand), typeof(WebBrowsers), new FrameworkPropertyMetadata(OnNavigatedChanged));
        
        public static ICommand GetNavigated(DependencyObject target)
        {
            return (ICommand)target.GetValue(NavigatedProperty);
        }
        
        public static void SetNavigated(DependencyObject target, ICommand value)
        {
            target.SetValue(NavigatedProperty, value);
        }
        
        private static void OnNavigatedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is WebBrowser target)
            {
                if (e.OldValue != null)
                {
                    target.Navigated -= OnNavigated;
                }
                if (e.NewValue != null)
                {
                    target.Navigated += OnNavigated;
                }
            }
        }
        
        private static void OnNavigated(object o, NavigationEventArgs eventArgs)
        {
            var command = GetNavigated((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Navigating
        public static readonly DependencyProperty NavigatingProperty =
            DependencyProperty.RegisterAttached("Navigating", typeof(ICommand), typeof(WebBrowsers), new FrameworkPropertyMetadata(OnNavigatingChanged));
        
        public static ICommand GetNavigating(DependencyObject target)
        {
            return (ICommand)target.GetValue(NavigatingProperty);
        }
        
        public static void SetNavigating(DependencyObject target, ICommand value)
        {
            target.SetValue(NavigatingProperty, value);
        }
        
        private static void OnNavigatingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is WebBrowser target)
            {
                if (e.OldValue != null)
                {
                    target.Navigating -= OnNavigating;
                }
                if (e.NewValue != null)
                {
                    target.Navigating += OnNavigating;
                }
            }
        }
        
        private static void OnNavigating(object o, NavigatingCancelEventArgs eventArgs)
        {
            var command = GetNavigating((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region PageContents
	public static partial class PageContents {
        
        #region GetPageRootCompleted
        public static readonly DependencyProperty GetPageRootCompletedProperty =
            DependencyProperty.RegisterAttached("GetPageRootCompleted", typeof(ICommand), typeof(PageContents), new FrameworkPropertyMetadata(OnGetPageRootCompletedChanged));
        
        public static ICommand GetGetPageRootCompleted(DependencyObject target)
        {
            return (ICommand)target.GetValue(GetPageRootCompletedProperty);
        }
        
        public static void SetGetPageRootCompleted(DependencyObject target, ICommand value)
        {
            target.SetValue(GetPageRootCompletedProperty, value);
        }
        
        private static void OnGetPageRootCompletedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is PageContent target)
            {
                if (e.OldValue != null)
                {
                    target.GetPageRootCompleted -= OnGetPageRootCompleted;
                }
                if (e.NewValue != null)
                {
                    target.GetPageRootCompleted += OnGetPageRootCompleted;
                }
            }
        }
        
        private static void OnGetPageRootCompleted(object o, GetPageRootCompletedEventArgs eventArgs)
        {
            var command = GetGetPageRootCompleted((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region FrameworkElements
	public static partial class FrameworkElements {
        
        #region ContextMenuClosing
        public static readonly DependencyProperty ContextMenuClosingProperty =
            DependencyProperty.RegisterAttached("ContextMenuClosing", typeof(ICommand), typeof(FrameworkElements), new FrameworkPropertyMetadata(OnContextMenuClosingChanged));
        
        public static ICommand GetContextMenuClosing(DependencyObject target)
        {
            return (ICommand)target.GetValue(ContextMenuClosingProperty);
        }
        
        public static void SetContextMenuClosing(DependencyObject target, ICommand value)
        {
            target.SetValue(ContextMenuClosingProperty, value);
        }
        
        private static void OnContextMenuClosingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement target)
            {
                if (e.OldValue != null)
                {
                    target.ContextMenuClosing -= OnContextMenuClosing;
                }
                if (e.NewValue != null)
                {
                    target.ContextMenuClosing += OnContextMenuClosing;
                }
            }
        }
        
        private static void OnContextMenuClosing(object o, ContextMenuEventArgs eventArgs)
        {
            var command = GetContextMenuClosing((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region ContextMenuOpening
        public static readonly DependencyProperty ContextMenuOpeningProperty =
            DependencyProperty.RegisterAttached("ContextMenuOpening", typeof(ICommand), typeof(FrameworkElements), new FrameworkPropertyMetadata(OnContextMenuOpeningChanged));
        
        public static ICommand GetContextMenuOpening(DependencyObject target)
        {
            return (ICommand)target.GetValue(ContextMenuOpeningProperty);
        }
        
        public static void SetContextMenuOpening(DependencyObject target, ICommand value)
        {
            target.SetValue(ContextMenuOpeningProperty, value);
        }
        
        private static void OnContextMenuOpeningChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement target)
            {
                if (e.OldValue != null)
                {
                    target.ContextMenuOpening -= OnContextMenuOpening;
                }
                if (e.NewValue != null)
                {
                    target.ContextMenuOpening += OnContextMenuOpening;
                }
            }
        }
        
        private static void OnContextMenuOpening(object o, ContextMenuEventArgs eventArgs)
        {
            var command = GetContextMenuOpening((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region DataContextChanged
        public static readonly DependencyProperty DataContextChangedProperty =
            DependencyProperty.RegisterAttached("DataContextChanged", typeof(ICommand), typeof(FrameworkElements), new FrameworkPropertyMetadata(OnDataContextChangedChanged));
        
        public static ICommand GetDataContextChanged(DependencyObject target)
        {
            return (ICommand)target.GetValue(DataContextChangedProperty);
        }
        
        public static void SetDataContextChanged(DependencyObject target, ICommand value)
        {
            target.SetValue(DataContextChangedProperty, value);
        }
        
        private static void OnDataContextChangedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement target)
            {
                if (e.OldValue != null)
                {
                    target.DataContextChanged -= OnDataContextChanged;
                }
                if (e.NewValue != null)
                {
                    target.DataContextChanged += OnDataContextChanged;
                }
            }
        }
        
        private static void OnDataContextChanged(object o, DependencyPropertyChangedEventArgs eventArgs)
        {
            var command = GetDataContextChanged((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Initialized
        public static readonly DependencyProperty InitializedProperty =
            DependencyProperty.RegisterAttached("Initialized", typeof(ICommand), typeof(FrameworkElements), new FrameworkPropertyMetadata(OnInitializedChanged));
        
        public static ICommand GetInitialized(DependencyObject target)
        {
            return (ICommand)target.GetValue(InitializedProperty);
        }
        
        public static void SetInitialized(DependencyObject target, ICommand value)
        {
            target.SetValue(InitializedProperty, value);
        }
        
        private static void OnInitializedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement target)
            {
                if (e.OldValue != null)
                {
                    target.Initialized -= OnInitialized;
                }
                if (e.NewValue != null)
                {
                    target.Initialized += OnInitialized;
                }
            }
        }
        
        private static void OnInitialized(object o, EventArgs eventArgs)
        {
            var command = GetInitialized((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Loaded
        public static readonly DependencyProperty LoadedProperty =
            DependencyProperty.RegisterAttached("Loaded", typeof(ICommand), typeof(FrameworkElements), new FrameworkPropertyMetadata(OnLoadedChanged));
        
        public static ICommand GetLoaded(DependencyObject target)
        {
            return (ICommand)target.GetValue(LoadedProperty);
        }
        
        public static void SetLoaded(DependencyObject target, ICommand value)
        {
            target.SetValue(LoadedProperty, value);
        }
        
        private static void OnLoadedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement target)
            {
                if (e.OldValue != null)
                {
                    target.Loaded -= OnLoaded;
                }
                if (e.NewValue != null)
                {
                    target.Loaded += OnLoaded;
                }
            }
        }
        
        private static void OnLoaded(object o, RoutedEventArgs eventArgs)
        {
            var command = GetLoaded((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region RequestBringIntoView
        public static readonly DependencyProperty RequestBringIntoViewProperty =
            DependencyProperty.RegisterAttached("RequestBringIntoView", typeof(ICommand), typeof(FrameworkElements), new FrameworkPropertyMetadata(OnRequestBringIntoViewChanged));
        
        public static ICommand GetRequestBringIntoView(DependencyObject target)
        {
            return (ICommand)target.GetValue(RequestBringIntoViewProperty);
        }
        
        public static void SetRequestBringIntoView(DependencyObject target, ICommand value)
        {
            target.SetValue(RequestBringIntoViewProperty, value);
        }
        
        private static void OnRequestBringIntoViewChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement target)
            {
                if (e.OldValue != null)
                {
                    target.RequestBringIntoView -= OnRequestBringIntoView;
                }
                if (e.NewValue != null)
                {
                    target.RequestBringIntoView += OnRequestBringIntoView;
                }
            }
        }
        
        private static void OnRequestBringIntoView(object o, RequestBringIntoViewEventArgs eventArgs)
        {
            var command = GetRequestBringIntoView((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region SizeChanged
        public static readonly DependencyProperty SizeChangedProperty =
            DependencyProperty.RegisterAttached("SizeChanged", typeof(ICommand), typeof(FrameworkElements), new FrameworkPropertyMetadata(OnSizeChangedChanged));
        
        public static ICommand GetSizeChanged(DependencyObject target)
        {
            return (ICommand)target.GetValue(SizeChangedProperty);
        }
        
        public static void SetSizeChanged(DependencyObject target, ICommand value)
        {
            target.SetValue(SizeChangedProperty, value);
        }
        
        private static void OnSizeChangedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement target)
            {
                if (e.OldValue != null)
                {
                    target.SizeChanged -= OnSizeChanged;
                }
                if (e.NewValue != null)
                {
                    target.SizeChanged += OnSizeChanged;
                }
            }
        }
        
        private static void OnSizeChanged(object o, SizeChangedEventArgs eventArgs)
        {
            var command = GetSizeChanged((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region SourceUpdated
        public static readonly DependencyProperty SourceUpdatedProperty =
            DependencyProperty.RegisterAttached("SourceUpdated", typeof(ICommand), typeof(FrameworkElements), new FrameworkPropertyMetadata(OnSourceUpdatedChanged));
        
        public static ICommand GetSourceUpdated(DependencyObject target)
        {
            return (ICommand)target.GetValue(SourceUpdatedProperty);
        }
        
        public static void SetSourceUpdated(DependencyObject target, ICommand value)
        {
            target.SetValue(SourceUpdatedProperty, value);
        }
        
        private static void OnSourceUpdatedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement target)
            {
                if (e.OldValue != null)
                {
                    target.SourceUpdated -= OnSourceUpdated;
                }
                if (e.NewValue != null)
                {
                    target.SourceUpdated += OnSourceUpdated;
                }
            }
        }
        
        private static void OnSourceUpdated(object o, DataTransferEventArgs eventArgs)
        {
            var command = GetSourceUpdated((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region SourceUpdatedNotifyTargetObject
        public static readonly DependencyProperty SourceUpdatedNotifyTargetObjectProperty =
            DependencyProperty.RegisterAttached("SourceUpdatedNotifyTargetObject", typeof(ICommand), typeof(FrameworkElements), new FrameworkPropertyMetadata(OnSourceUpdatedNotifyTargetObjectChanged));
        
        public static ICommand GetSourceUpdatedNotifyTargetObject(DependencyObject target)
        {
            return (ICommand)target.GetValue(SourceUpdatedNotifyTargetObjectProperty);
        }
        
        public static void SetSourceUpdatedNotifyTargetObject(DependencyObject target, ICommand value)
        {
            target.SetValue(SourceUpdatedNotifyTargetObjectProperty, value);
        }
        
        private static void OnSourceUpdatedNotifyTargetObjectChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement target)
            {
                if (e.OldValue != null)
                {
                    target.SourceUpdated -= OnSourceUpdatedNotifyTargetObject;
                }
                if (e.NewValue != null)
                {
                    target.SourceUpdated += OnSourceUpdatedNotifyTargetObject;
                }
            }
        }
        
        private static void OnSourceUpdatedNotifyTargetObject(object o, System.Windows.Data.DataTransferEventArgs eventArgs)
        {
            var command = GetSourceUpdatedNotifyTargetObject((DependencyObject)o);
            if (command.CanExecute(eventArgs.TargetObject))
                command.Execute(eventArgs.TargetObject);
        }
        #endregion
        
        #region SourceUpdatedNotifyProperty
        public static readonly DependencyProperty SourceUpdatedNotifyPropertyProperty =
            DependencyProperty.RegisterAttached("SourceUpdatedNotifyProperty", typeof(ICommand), typeof(FrameworkElements), new FrameworkPropertyMetadata(OnSourceUpdatedNotifyPropertyChanged));
        
        public static ICommand GetSourceUpdatedNotifyProperty(DependencyObject target)
        {
            return (ICommand)target.GetValue(SourceUpdatedNotifyPropertyProperty);
        }
        
        public static void SetSourceUpdatedNotifyProperty(DependencyObject target, ICommand value)
        {
            target.SetValue(SourceUpdatedNotifyPropertyProperty, value);
        }
        
        private static void OnSourceUpdatedNotifyPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement target)
            {
                if (e.OldValue != null)
                {
                    target.SourceUpdated -= OnSourceUpdatedNotifyProperty;
                }
                if (e.NewValue != null)
                {
                    target.SourceUpdated += OnSourceUpdatedNotifyProperty;
                }
            }
        }
        
        private static void OnSourceUpdatedNotifyProperty(object o, System.Windows.Data.DataTransferEventArgs eventArgs)
        {
            var command = GetSourceUpdatedNotifyProperty((DependencyObject)o);
            if (command.CanExecute(eventArgs.Property))
                command.Execute(eventArgs.Property);
        }
        #endregion
        
        #region SourceUpdatedNotifyRoutedEvent
        public static readonly DependencyProperty SourceUpdatedNotifyRoutedEventProperty =
            DependencyProperty.RegisterAttached("SourceUpdatedNotifyRoutedEvent", typeof(ICommand), typeof(FrameworkElements), new FrameworkPropertyMetadata(OnSourceUpdatedNotifyRoutedEventChanged));
        
        public static ICommand GetSourceUpdatedNotifyRoutedEvent(DependencyObject target)
        {
            return (ICommand)target.GetValue(SourceUpdatedNotifyRoutedEventProperty);
        }
        
        public static void SetSourceUpdatedNotifyRoutedEvent(DependencyObject target, ICommand value)
        {
            target.SetValue(SourceUpdatedNotifyRoutedEventProperty, value);
        }
        
        private static void OnSourceUpdatedNotifyRoutedEventChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement target)
            {
                if (e.OldValue != null)
                {
                    target.SourceUpdated -= OnSourceUpdatedNotifyRoutedEvent;
                }
                if (e.NewValue != null)
                {
                    target.SourceUpdated += OnSourceUpdatedNotifyRoutedEvent;
                }
            }
        }
        
        private static void OnSourceUpdatedNotifyRoutedEvent(object o, System.Windows.Data.DataTransferEventArgs eventArgs)
        {
            var command = GetSourceUpdatedNotifyRoutedEvent((DependencyObject)o);
            if (command.CanExecute(eventArgs.RoutedEvent))
                command.Execute(eventArgs.RoutedEvent);
        }
        #endregion
        
        #region SourceUpdatedNotifyHandled
        public static readonly DependencyProperty SourceUpdatedNotifyHandledProperty =
            DependencyProperty.RegisterAttached("SourceUpdatedNotifyHandled", typeof(ICommand), typeof(FrameworkElements), new FrameworkPropertyMetadata(OnSourceUpdatedNotifyHandledChanged));
        
        public static ICommand GetSourceUpdatedNotifyHandled(DependencyObject target)
        {
            return (ICommand)target.GetValue(SourceUpdatedNotifyHandledProperty);
        }
        
        public static void SetSourceUpdatedNotifyHandled(DependencyObject target, ICommand value)
        {
            target.SetValue(SourceUpdatedNotifyHandledProperty, value);
        }
        
        private static void OnSourceUpdatedNotifyHandledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement target)
            {
                if (e.OldValue != null)
                {
                    target.SourceUpdated -= OnSourceUpdatedNotifyHandled;
                }
                if (e.NewValue != null)
                {
                    target.SourceUpdated += OnSourceUpdatedNotifyHandled;
                }
            }
        }
        
        private static void OnSourceUpdatedNotifyHandled(object o, System.Windows.Data.DataTransferEventArgs eventArgs)
        {
            var command = GetSourceUpdatedNotifyHandled((DependencyObject)o);
            if (command.CanExecute(eventArgs.Handled))
                command.Execute(eventArgs.Handled);
        }
        #endregion
        
        #region SourceUpdatedNotifySource
        public static readonly DependencyProperty SourceUpdatedNotifySourceProperty =
            DependencyProperty.RegisterAttached("SourceUpdatedNotifySource", typeof(ICommand), typeof(FrameworkElements), new FrameworkPropertyMetadata(OnSourceUpdatedNotifySourceChanged));
        
        public static ICommand GetSourceUpdatedNotifySource(DependencyObject target)
        {
            return (ICommand)target.GetValue(SourceUpdatedNotifySourceProperty);
        }
        
        public static void SetSourceUpdatedNotifySource(DependencyObject target, ICommand value)
        {
            target.SetValue(SourceUpdatedNotifySourceProperty, value);
        }
        
        private static void OnSourceUpdatedNotifySourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement target)
            {
                if (e.OldValue != null)
                {
                    target.SourceUpdated -= OnSourceUpdatedNotifySource;
                }
                if (e.NewValue != null)
                {
                    target.SourceUpdated += OnSourceUpdatedNotifySource;
                }
            }
        }
        
        private static void OnSourceUpdatedNotifySource(object o, System.Windows.Data.DataTransferEventArgs eventArgs)
        {
            var command = GetSourceUpdatedNotifySource((DependencyObject)o);
            if (command.CanExecute(eventArgs.Source))
                command.Execute(eventArgs.Source);
        }
        #endregion
        
        #region SourceUpdatedNotifyOriginalSource
        public static readonly DependencyProperty SourceUpdatedNotifyOriginalSourceProperty =
            DependencyProperty.RegisterAttached("SourceUpdatedNotifyOriginalSource", typeof(ICommand), typeof(FrameworkElements), new FrameworkPropertyMetadata(OnSourceUpdatedNotifyOriginalSourceChanged));
        
        public static ICommand GetSourceUpdatedNotifyOriginalSource(DependencyObject target)
        {
            return (ICommand)target.GetValue(SourceUpdatedNotifyOriginalSourceProperty);
        }
        
        public static void SetSourceUpdatedNotifyOriginalSource(DependencyObject target, ICommand value)
        {
            target.SetValue(SourceUpdatedNotifyOriginalSourceProperty, value);
        }
        
        private static void OnSourceUpdatedNotifyOriginalSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement target)
            {
                if (e.OldValue != null)
                {
                    target.SourceUpdated -= OnSourceUpdatedNotifyOriginalSource;
                }
                if (e.NewValue != null)
                {
                    target.SourceUpdated += OnSourceUpdatedNotifyOriginalSource;
                }
            }
        }
        
        private static void OnSourceUpdatedNotifyOriginalSource(object o, System.Windows.Data.DataTransferEventArgs eventArgs)
        {
            var command = GetSourceUpdatedNotifyOriginalSource((DependencyObject)o);
            if (command.CanExecute(eventArgs.OriginalSource))
                command.Execute(eventArgs.OriginalSource);
        }
        #endregion
        
        #region TargetUpdated
        public static readonly DependencyProperty TargetUpdatedProperty =
            DependencyProperty.RegisterAttached("TargetUpdated", typeof(ICommand), typeof(FrameworkElements), new FrameworkPropertyMetadata(OnTargetUpdatedChanged));
        
        public static ICommand GetTargetUpdated(DependencyObject target)
        {
            return (ICommand)target.GetValue(TargetUpdatedProperty);
        }
        
        public static void SetTargetUpdated(DependencyObject target, ICommand value)
        {
            target.SetValue(TargetUpdatedProperty, value);
        }
        
        private static void OnTargetUpdatedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement target)
            {
                if (e.OldValue != null)
                {
                    target.TargetUpdated -= OnTargetUpdated;
                }
                if (e.NewValue != null)
                {
                    target.TargetUpdated += OnTargetUpdated;
                }
            }
        }
        
        private static void OnTargetUpdated(object o, DataTransferEventArgs eventArgs)
        {
            var command = GetTargetUpdated((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region TargetUpdatedNotifyTargetObject
        public static readonly DependencyProperty TargetUpdatedNotifyTargetObjectProperty =
            DependencyProperty.RegisterAttached("TargetUpdatedNotifyTargetObject", typeof(ICommand), typeof(FrameworkElements), new FrameworkPropertyMetadata(OnTargetUpdatedNotifyTargetObjectChanged));
        
        public static ICommand GetTargetUpdatedNotifyTargetObject(DependencyObject target)
        {
            return (ICommand)target.GetValue(TargetUpdatedNotifyTargetObjectProperty);
        }
        
        public static void SetTargetUpdatedNotifyTargetObject(DependencyObject target, ICommand value)
        {
            target.SetValue(TargetUpdatedNotifyTargetObjectProperty, value);
        }
        
        private static void OnTargetUpdatedNotifyTargetObjectChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement target)
            {
                if (e.OldValue != null)
                {
                    target.TargetUpdated -= OnTargetUpdatedNotifyTargetObject;
                }
                if (e.NewValue != null)
                {
                    target.TargetUpdated += OnTargetUpdatedNotifyTargetObject;
                }
            }
        }
        
        private static void OnTargetUpdatedNotifyTargetObject(object o, System.Windows.Data.DataTransferEventArgs eventArgs)
        {
            var command = GetTargetUpdatedNotifyTargetObject((DependencyObject)o);
            if (command.CanExecute(eventArgs.TargetObject))
                command.Execute(eventArgs.TargetObject);
        }
        #endregion
        
        #region TargetUpdatedNotifyProperty
        public static readonly DependencyProperty TargetUpdatedNotifyPropertyProperty =
            DependencyProperty.RegisterAttached("TargetUpdatedNotifyProperty", typeof(ICommand), typeof(FrameworkElements), new FrameworkPropertyMetadata(OnTargetUpdatedNotifyPropertyChanged));
        
        public static ICommand GetTargetUpdatedNotifyProperty(DependencyObject target)
        {
            return (ICommand)target.GetValue(TargetUpdatedNotifyPropertyProperty);
        }
        
        public static void SetTargetUpdatedNotifyProperty(DependencyObject target, ICommand value)
        {
            target.SetValue(TargetUpdatedNotifyPropertyProperty, value);
        }
        
        private static void OnTargetUpdatedNotifyPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement target)
            {
                if (e.OldValue != null)
                {
                    target.TargetUpdated -= OnTargetUpdatedNotifyProperty;
                }
                if (e.NewValue != null)
                {
                    target.TargetUpdated += OnTargetUpdatedNotifyProperty;
                }
            }
        }
        
        private static void OnTargetUpdatedNotifyProperty(object o, System.Windows.Data.DataTransferEventArgs eventArgs)
        {
            var command = GetTargetUpdatedNotifyProperty((DependencyObject)o);
            if (command.CanExecute(eventArgs.Property))
                command.Execute(eventArgs.Property);
        }
        #endregion
        
        #region TargetUpdatedNotifyRoutedEvent
        public static readonly DependencyProperty TargetUpdatedNotifyRoutedEventProperty =
            DependencyProperty.RegisterAttached("TargetUpdatedNotifyRoutedEvent", typeof(ICommand), typeof(FrameworkElements), new FrameworkPropertyMetadata(OnTargetUpdatedNotifyRoutedEventChanged));
        
        public static ICommand GetTargetUpdatedNotifyRoutedEvent(DependencyObject target)
        {
            return (ICommand)target.GetValue(TargetUpdatedNotifyRoutedEventProperty);
        }
        
        public static void SetTargetUpdatedNotifyRoutedEvent(DependencyObject target, ICommand value)
        {
            target.SetValue(TargetUpdatedNotifyRoutedEventProperty, value);
        }
        
        private static void OnTargetUpdatedNotifyRoutedEventChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement target)
            {
                if (e.OldValue != null)
                {
                    target.TargetUpdated -= OnTargetUpdatedNotifyRoutedEvent;
                }
                if (e.NewValue != null)
                {
                    target.TargetUpdated += OnTargetUpdatedNotifyRoutedEvent;
                }
            }
        }
        
        private static void OnTargetUpdatedNotifyRoutedEvent(object o, System.Windows.Data.DataTransferEventArgs eventArgs)
        {
            var command = GetTargetUpdatedNotifyRoutedEvent((DependencyObject)o);
            if (command.CanExecute(eventArgs.RoutedEvent))
                command.Execute(eventArgs.RoutedEvent);
        }
        #endregion
        
        #region TargetUpdatedNotifyHandled
        public static readonly DependencyProperty TargetUpdatedNotifyHandledProperty =
            DependencyProperty.RegisterAttached("TargetUpdatedNotifyHandled", typeof(ICommand), typeof(FrameworkElements), new FrameworkPropertyMetadata(OnTargetUpdatedNotifyHandledChanged));
        
        public static ICommand GetTargetUpdatedNotifyHandled(DependencyObject target)
        {
            return (ICommand)target.GetValue(TargetUpdatedNotifyHandledProperty);
        }
        
        public static void SetTargetUpdatedNotifyHandled(DependencyObject target, ICommand value)
        {
            target.SetValue(TargetUpdatedNotifyHandledProperty, value);
        }
        
        private static void OnTargetUpdatedNotifyHandledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement target)
            {
                if (e.OldValue != null)
                {
                    target.TargetUpdated -= OnTargetUpdatedNotifyHandled;
                }
                if (e.NewValue != null)
                {
                    target.TargetUpdated += OnTargetUpdatedNotifyHandled;
                }
            }
        }
        
        private static void OnTargetUpdatedNotifyHandled(object o, System.Windows.Data.DataTransferEventArgs eventArgs)
        {
            var command = GetTargetUpdatedNotifyHandled((DependencyObject)o);
            if (command.CanExecute(eventArgs.Handled))
                command.Execute(eventArgs.Handled);
        }
        #endregion
        
        #region TargetUpdatedNotifySource
        public static readonly DependencyProperty TargetUpdatedNotifySourceProperty =
            DependencyProperty.RegisterAttached("TargetUpdatedNotifySource", typeof(ICommand), typeof(FrameworkElements), new FrameworkPropertyMetadata(OnTargetUpdatedNotifySourceChanged));
        
        public static ICommand GetTargetUpdatedNotifySource(DependencyObject target)
        {
            return (ICommand)target.GetValue(TargetUpdatedNotifySourceProperty);
        }
        
        public static void SetTargetUpdatedNotifySource(DependencyObject target, ICommand value)
        {
            target.SetValue(TargetUpdatedNotifySourceProperty, value);
        }
        
        private static void OnTargetUpdatedNotifySourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement target)
            {
                if (e.OldValue != null)
                {
                    target.TargetUpdated -= OnTargetUpdatedNotifySource;
                }
                if (e.NewValue != null)
                {
                    target.TargetUpdated += OnTargetUpdatedNotifySource;
                }
            }
        }
        
        private static void OnTargetUpdatedNotifySource(object o, System.Windows.Data.DataTransferEventArgs eventArgs)
        {
            var command = GetTargetUpdatedNotifySource((DependencyObject)o);
            if (command.CanExecute(eventArgs.Source))
                command.Execute(eventArgs.Source);
        }
        #endregion
        
        #region TargetUpdatedNotifyOriginalSource
        public static readonly DependencyProperty TargetUpdatedNotifyOriginalSourceProperty =
            DependencyProperty.RegisterAttached("TargetUpdatedNotifyOriginalSource", typeof(ICommand), typeof(FrameworkElements), new FrameworkPropertyMetadata(OnTargetUpdatedNotifyOriginalSourceChanged));
        
        public static ICommand GetTargetUpdatedNotifyOriginalSource(DependencyObject target)
        {
            return (ICommand)target.GetValue(TargetUpdatedNotifyOriginalSourceProperty);
        }
        
        public static void SetTargetUpdatedNotifyOriginalSource(DependencyObject target, ICommand value)
        {
            target.SetValue(TargetUpdatedNotifyOriginalSourceProperty, value);
        }
        
        private static void OnTargetUpdatedNotifyOriginalSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement target)
            {
                if (e.OldValue != null)
                {
                    target.TargetUpdated -= OnTargetUpdatedNotifyOriginalSource;
                }
                if (e.NewValue != null)
                {
                    target.TargetUpdated += OnTargetUpdatedNotifyOriginalSource;
                }
            }
        }
        
        private static void OnTargetUpdatedNotifyOriginalSource(object o, System.Windows.Data.DataTransferEventArgs eventArgs)
        {
            var command = GetTargetUpdatedNotifyOriginalSource((DependencyObject)o);
            if (command.CanExecute(eventArgs.OriginalSource))
                command.Execute(eventArgs.OriginalSource);
        }
        #endregion
        
        #region ToolTipClosing
        public static readonly DependencyProperty ToolTipClosingProperty =
            DependencyProperty.RegisterAttached("ToolTipClosing", typeof(ICommand), typeof(FrameworkElements), new FrameworkPropertyMetadata(OnToolTipClosingChanged));
        
        public static ICommand GetToolTipClosing(DependencyObject target)
        {
            return (ICommand)target.GetValue(ToolTipClosingProperty);
        }
        
        public static void SetToolTipClosing(DependencyObject target, ICommand value)
        {
            target.SetValue(ToolTipClosingProperty, value);
        }
        
        private static void OnToolTipClosingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement target)
            {
                if (e.OldValue != null)
                {
                    target.ToolTipClosing -= OnToolTipClosing;
                }
                if (e.NewValue != null)
                {
                    target.ToolTipClosing += OnToolTipClosing;
                }
            }
        }
        
        private static void OnToolTipClosing(object o, ToolTipEventArgs eventArgs)
        {
            var command = GetToolTipClosing((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region ToolTipOpening
        public static readonly DependencyProperty ToolTipOpeningProperty =
            DependencyProperty.RegisterAttached("ToolTipOpening", typeof(ICommand), typeof(FrameworkElements), new FrameworkPropertyMetadata(OnToolTipOpeningChanged));
        
        public static ICommand GetToolTipOpening(DependencyObject target)
        {
            return (ICommand)target.GetValue(ToolTipOpeningProperty);
        }
        
        public static void SetToolTipOpening(DependencyObject target, ICommand value)
        {
            target.SetValue(ToolTipOpeningProperty, value);
        }
        
        private static void OnToolTipOpeningChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement target)
            {
                if (e.OldValue != null)
                {
                    target.ToolTipOpening -= OnToolTipOpening;
                }
                if (e.NewValue != null)
                {
                    target.ToolTipOpening += OnToolTipOpening;
                }
            }
        }
        
        private static void OnToolTipOpening(object o, ToolTipEventArgs eventArgs)
        {
            var command = GetToolTipOpening((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Unloaded
        public static readonly DependencyProperty UnloadedProperty =
            DependencyProperty.RegisterAttached("Unloaded", typeof(ICommand), typeof(FrameworkElements), new FrameworkPropertyMetadata(OnUnloadedChanged));
        
        public static ICommand GetUnloaded(DependencyObject target)
        {
            return (ICommand)target.GetValue(UnloadedProperty);
        }
        
        public static void SetUnloaded(DependencyObject target, ICommand value)
        {
            target.SetValue(UnloadedProperty, value);
        }
        
        private static void OnUnloadedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement target)
            {
                if (e.OldValue != null)
                {
                    target.Unloaded -= OnUnloaded;
                }
                if (e.NewValue != null)
                {
                    target.Unloaded += OnUnloaded;
                }
            }
        }
        
        private static void OnUnloaded(object o, RoutedEventArgs eventArgs)
        {
            var command = GetUnloaded((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region NavigationWindows
	public static partial class NavigationWindows {
        
        #region FragmentNavigation
        public static readonly DependencyProperty FragmentNavigationProperty =
            DependencyProperty.RegisterAttached("FragmentNavigation", typeof(ICommand), typeof(NavigationWindows), new FrameworkPropertyMetadata(OnFragmentNavigationChanged));
        
        public static ICommand GetFragmentNavigation(DependencyObject target)
        {
            return (ICommand)target.GetValue(FragmentNavigationProperty);
        }
        
        public static void SetFragmentNavigation(DependencyObject target, ICommand value)
        {
            target.SetValue(FragmentNavigationProperty, value);
        }
        
        private static void OnFragmentNavigationChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is NavigationWindow target)
            {
                if (e.OldValue != null)
                {
                    target.FragmentNavigation -= OnFragmentNavigation;
                }
                if (e.NewValue != null)
                {
                    target.FragmentNavigation += OnFragmentNavigation;
                }
            }
        }
        
        private static void OnFragmentNavigation(object o, FragmentNavigationEventArgs eventArgs)
        {
            var command = GetFragmentNavigation((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region LoadCompleted
        public static readonly DependencyProperty LoadCompletedProperty =
            DependencyProperty.RegisterAttached("LoadCompleted", typeof(ICommand), typeof(NavigationWindows), new FrameworkPropertyMetadata(OnLoadCompletedChanged));
        
        public static ICommand GetLoadCompleted(DependencyObject target)
        {
            return (ICommand)target.GetValue(LoadCompletedProperty);
        }
        
        public static void SetLoadCompleted(DependencyObject target, ICommand value)
        {
            target.SetValue(LoadCompletedProperty, value);
        }
        
        private static void OnLoadCompletedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is NavigationWindow target)
            {
                if (e.OldValue != null)
                {
                    target.LoadCompleted -= OnLoadCompleted;
                }
                if (e.NewValue != null)
                {
                    target.LoadCompleted += OnLoadCompleted;
                }
            }
        }
        
        private static void OnLoadCompleted(object o, NavigationEventArgs eventArgs)
        {
            var command = GetLoadCompleted((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Navigated
        public static readonly DependencyProperty NavigatedProperty =
            DependencyProperty.RegisterAttached("Navigated", typeof(ICommand), typeof(NavigationWindows), new FrameworkPropertyMetadata(OnNavigatedChanged));
        
        public static ICommand GetNavigated(DependencyObject target)
        {
            return (ICommand)target.GetValue(NavigatedProperty);
        }
        
        public static void SetNavigated(DependencyObject target, ICommand value)
        {
            target.SetValue(NavigatedProperty, value);
        }
        
        private static void OnNavigatedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is NavigationWindow target)
            {
                if (e.OldValue != null)
                {
                    target.Navigated -= OnNavigated;
                }
                if (e.NewValue != null)
                {
                    target.Navigated += OnNavigated;
                }
            }
        }
        
        private static void OnNavigated(object o, NavigationEventArgs eventArgs)
        {
            var command = GetNavigated((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Navigating
        public static readonly DependencyProperty NavigatingProperty =
            DependencyProperty.RegisterAttached("Navigating", typeof(ICommand), typeof(NavigationWindows), new FrameworkPropertyMetadata(OnNavigatingChanged));
        
        public static ICommand GetNavigating(DependencyObject target)
        {
            return (ICommand)target.GetValue(NavigatingProperty);
        }
        
        public static void SetNavigating(DependencyObject target, ICommand value)
        {
            target.SetValue(NavigatingProperty, value);
        }
        
        private static void OnNavigatingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is NavigationWindow target)
            {
                if (e.OldValue != null)
                {
                    target.Navigating -= OnNavigating;
                }
                if (e.NewValue != null)
                {
                    target.Navigating += OnNavigating;
                }
            }
        }
        
        private static void OnNavigating(object o, NavigatingCancelEventArgs eventArgs)
        {
            var command = GetNavigating((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region NavigationFailed
        public static readonly DependencyProperty NavigationFailedProperty =
            DependencyProperty.RegisterAttached("NavigationFailed", typeof(ICommand), typeof(NavigationWindows), new FrameworkPropertyMetadata(OnNavigationFailedChanged));
        
        public static ICommand GetNavigationFailed(DependencyObject target)
        {
            return (ICommand)target.GetValue(NavigationFailedProperty);
        }
        
        public static void SetNavigationFailed(DependencyObject target, ICommand value)
        {
            target.SetValue(NavigationFailedProperty, value);
        }
        
        private static void OnNavigationFailedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is NavigationWindow target)
            {
                if (e.OldValue != null)
                {
                    target.NavigationFailed -= OnNavigationFailed;
                }
                if (e.NewValue != null)
                {
                    target.NavigationFailed += OnNavigationFailed;
                }
            }
        }
        
        private static void OnNavigationFailed(object o, NavigationFailedEventArgs eventArgs)
        {
            var command = GetNavigationFailed((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region NavigationProgress
        public static readonly DependencyProperty NavigationProgressProperty =
            DependencyProperty.RegisterAttached("NavigationProgress", typeof(ICommand), typeof(NavigationWindows), new FrameworkPropertyMetadata(OnNavigationProgressChanged));
        
        public static ICommand GetNavigationProgress(DependencyObject target)
        {
            return (ICommand)target.GetValue(NavigationProgressProperty);
        }
        
        public static void SetNavigationProgress(DependencyObject target, ICommand value)
        {
            target.SetValue(NavigationProgressProperty, value);
        }
        
        private static void OnNavigationProgressChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is NavigationWindow target)
            {
                if (e.OldValue != null)
                {
                    target.NavigationProgress -= OnNavigationProgress;
                }
                if (e.NewValue != null)
                {
                    target.NavigationProgress += OnNavigationProgress;
                }
            }
        }
        
        private static void OnNavigationProgress(object o, NavigationProgressEventArgs eventArgs)
        {
            var command = GetNavigationProgress((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region NavigationStopped
        public static readonly DependencyProperty NavigationStoppedProperty =
            DependencyProperty.RegisterAttached("NavigationStopped", typeof(ICommand), typeof(NavigationWindows), new FrameworkPropertyMetadata(OnNavigationStoppedChanged));
        
        public static ICommand GetNavigationStopped(DependencyObject target)
        {
            return (ICommand)target.GetValue(NavigationStoppedProperty);
        }
        
        public static void SetNavigationStopped(DependencyObject target, ICommand value)
        {
            target.SetValue(NavigationStoppedProperty, value);
        }
        
        private static void OnNavigationStoppedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is NavigationWindow target)
            {
                if (e.OldValue != null)
                {
                    target.NavigationStopped -= OnNavigationStopped;
                }
                if (e.NewValue != null)
                {
                    target.NavigationStopped += OnNavigationStopped;
                }
            }
        }
        
        private static void OnNavigationStopped(object o, NavigationEventArgs eventArgs)
        {
            var command = GetNavigationStopped((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region Windows
	public static partial class Windows {
        
        #region Activated
        public static readonly DependencyProperty ActivatedProperty =
            DependencyProperty.RegisterAttached("Activated", typeof(ICommand), typeof(Windows), new FrameworkPropertyMetadata(OnActivatedChanged));
        
        public static ICommand GetActivated(DependencyObject target)
        {
            return (ICommand)target.GetValue(ActivatedProperty);
        }
        
        public static void SetActivated(DependencyObject target, ICommand value)
        {
            target.SetValue(ActivatedProperty, value);
        }
        
        private static void OnActivatedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Window target)
            {
                if (e.OldValue != null)
                {
                    target.Activated -= OnActivated;
                }
                if (e.NewValue != null)
                {
                    target.Activated += OnActivated;
                }
            }
        }
        
        private static void OnActivated(object o, EventArgs eventArgs)
        {
            var command = GetActivated((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Closed
        public static readonly DependencyProperty ClosedProperty =
            DependencyProperty.RegisterAttached("Closed", typeof(ICommand), typeof(Windows), new FrameworkPropertyMetadata(OnClosedChanged));
        
        public static ICommand GetClosed(DependencyObject target)
        {
            return (ICommand)target.GetValue(ClosedProperty);
        }
        
        public static void SetClosed(DependencyObject target, ICommand value)
        {
            target.SetValue(ClosedProperty, value);
        }
        
        private static void OnClosedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Window target)
            {
                if (e.OldValue != null)
                {
                    target.Closed -= OnClosed;
                }
                if (e.NewValue != null)
                {
                    target.Closed += OnClosed;
                }
            }
        }
        
        private static void OnClosed(object o, EventArgs eventArgs)
        {
            var command = GetClosed((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Closing
        public static readonly DependencyProperty ClosingProperty =
            DependencyProperty.RegisterAttached("Closing", typeof(ICommand), typeof(Windows), new FrameworkPropertyMetadata(OnClosingChanged));
        
        public static ICommand GetClosing(DependencyObject target)
        {
            return (ICommand)target.GetValue(ClosingProperty);
        }
        
        public static void SetClosing(DependencyObject target, ICommand value)
        {
            target.SetValue(ClosingProperty, value);
        }
        
        private static void OnClosingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Window target)
            {
                if (e.OldValue != null)
                {
                    target.Closing -= OnClosing;
                }
                if (e.NewValue != null)
                {
                    target.Closing += OnClosing;
                }
            }
        }
        
        private static void OnClosing(object o, CancelEventArgs eventArgs)
        {
            var command = GetClosing((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region ContentRendered
        public static readonly DependencyProperty ContentRenderedProperty =
            DependencyProperty.RegisterAttached("ContentRendered", typeof(ICommand), typeof(Windows), new FrameworkPropertyMetadata(OnContentRenderedChanged));
        
        public static ICommand GetContentRendered(DependencyObject target)
        {
            return (ICommand)target.GetValue(ContentRenderedProperty);
        }
        
        public static void SetContentRendered(DependencyObject target, ICommand value)
        {
            target.SetValue(ContentRenderedProperty, value);
        }
        
        private static void OnContentRenderedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Window target)
            {
                if (e.OldValue != null)
                {
                    target.ContentRendered -= OnContentRendered;
                }
                if (e.NewValue != null)
                {
                    target.ContentRendered += OnContentRendered;
                }
            }
        }
        
        private static void OnContentRendered(object o, EventArgs eventArgs)
        {
            var command = GetContentRendered((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Deactivated
        public static readonly DependencyProperty DeactivatedProperty =
            DependencyProperty.RegisterAttached("Deactivated", typeof(ICommand), typeof(Windows), new FrameworkPropertyMetadata(OnDeactivatedChanged));
        
        public static ICommand GetDeactivated(DependencyObject target)
        {
            return (ICommand)target.GetValue(DeactivatedProperty);
        }
        
        public static void SetDeactivated(DependencyObject target, ICommand value)
        {
            target.SetValue(DeactivatedProperty, value);
        }
        
        private static void OnDeactivatedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Window target)
            {
                if (e.OldValue != null)
                {
                    target.Deactivated -= OnDeactivated;
                }
                if (e.NewValue != null)
                {
                    target.Deactivated += OnDeactivated;
                }
            }
        }
        
        private static void OnDeactivated(object o, EventArgs eventArgs)
        {
            var command = GetDeactivated((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region LocationChanged
        public static readonly DependencyProperty LocationChangedProperty =
            DependencyProperty.RegisterAttached("LocationChanged", typeof(ICommand), typeof(Windows), new FrameworkPropertyMetadata(OnLocationChangedChanged));
        
        public static ICommand GetLocationChanged(DependencyObject target)
        {
            return (ICommand)target.GetValue(LocationChangedProperty);
        }
        
        public static void SetLocationChanged(DependencyObject target, ICommand value)
        {
            target.SetValue(LocationChangedProperty, value);
        }
        
        private static void OnLocationChangedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Window target)
            {
                if (e.OldValue != null)
                {
                    target.LocationChanged -= OnLocationChanged;
                }
                if (e.NewValue != null)
                {
                    target.LocationChanged += OnLocationChanged;
                }
            }
        }
        
        private static void OnLocationChanged(object o, EventArgs eventArgs)
        {
            var command = GetLocationChanged((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region SourceInitialized
        public static readonly DependencyProperty SourceInitializedProperty =
            DependencyProperty.RegisterAttached("SourceInitialized", typeof(ICommand), typeof(Windows), new FrameworkPropertyMetadata(OnSourceInitializedChanged));
        
        public static ICommand GetSourceInitialized(DependencyObject target)
        {
            return (ICommand)target.GetValue(SourceInitializedProperty);
        }
        
        public static void SetSourceInitialized(DependencyObject target, ICommand value)
        {
            target.SetValue(SourceInitializedProperty, value);
        }
        
        private static void OnSourceInitializedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Window target)
            {
                if (e.OldValue != null)
                {
                    target.SourceInitialized -= OnSourceInitialized;
                }
                if (e.NewValue != null)
                {
                    target.SourceInitialized += OnSourceInitialized;
                }
            }
        }
        
        private static void OnSourceInitialized(object o, EventArgs eventArgs)
        {
            var command = GetSourceInitialized((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region StateChanged
        public static readonly DependencyProperty StateChangedProperty =
            DependencyProperty.RegisterAttached("StateChanged", typeof(ICommand), typeof(Windows), new FrameworkPropertyMetadata(OnStateChangedChanged));
        
        public static ICommand GetStateChanged(DependencyObject target)
        {
            return (ICommand)target.GetValue(StateChangedProperty);
        }
        
        public static void SetStateChanged(DependencyObject target, ICommand value)
        {
            target.SetValue(StateChangedProperty, value);
        }
        
        private static void OnStateChangedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Window target)
            {
                if (e.OldValue != null)
                {
                    target.StateChanged -= OnStateChanged;
                }
                if (e.NewValue != null)
                {
                    target.StateChanged += OnStateChanged;
                }
            }
        }
        
        private static void OnStateChanged(object o, EventArgs eventArgs)
        {
            var command = GetStateChanged((DependencyObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion
}
