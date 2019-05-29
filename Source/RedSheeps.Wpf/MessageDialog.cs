using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
// ReSharper disable InconsistentNaming

namespace RedSheeps.Wpf
{
    public class MessageDialog
    {
        /// <summary>
        /// 親ウィンドウ
        /// </summary>
        private readonly Window _owner;

        /// <summary>
        /// フックハンドル
        /// </summary>
        private IntPtr _hookHandle = IntPtr.Zero;

        /// <summary>
        /// メッセージボックスを表示する
        /// </summary>
        public static MessageBoxResult Show(
            Window owner,
            string messageBoxText,
            string caption = "",
            MessageBoxButton button = MessageBoxButton.OK,
            MessageBoxImage icon = MessageBoxImage.None,
            MessageBoxResult defaultResult = MessageBoxResult.None,
            MessageBoxOptions options = MessageBoxOptions.None)
        {
            if (owner.WindowState == WindowState.Minimized)
            {
                return MessageBox.Show(owner, messageBoxText, caption, button, icon, defaultResult, options);
            }
            else
            {
                return new MessageDialog(owner).ShowInner(owner, messageBoxText, caption, button, icon, defaultResult, options);
            }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="window">Owner Window</param>
        private MessageDialog(Window window)
        {
            _owner = window;
        }

        /// <summary>
        /// メッセージボックスを表示する
        /// </summary>
        private MessageBoxResult ShowInner(
            Window owner,
            string messageBoxText,
            string caption,
            MessageBoxButton button,
            MessageBoxImage icon,
            MessageBoxResult defaultResult,
            MessageBoxOptions options)
        {
            // フックを設定する。
            var hwndSource = (HwndSource)PresentationSource.FromVisual(_owner);
            var hInstance = NativeMethods.GetWindowLong(hwndSource.Handle, NativeMethods.GWL_HINSTANCE);
            var threadId = NativeMethods.GetCurrentThreadId();
            _hookHandle = NativeMethods.SetWindowsHookEx(NativeMethods.WH_CBT, new NativeMethods.HOOKPROC(HookProc), hInstance, threadId);

            return MessageBox.Show(owner, messageBoxText, caption, button, icon, defaultResult, options);
        }

        /// <summary>
        /// フックプロシージャ
        /// </summary>
        /// <param name="nCode"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        private IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {

            if (nCode == NativeMethods.HCBT_ACTIVATE)
            {
                var rcForm = new NativeMethods.RECT(0, 0, 0, 0);
                var rcMsgBox = new NativeMethods.RECT(0, 0, 0, 0);

                var hwndSource = (HwndSource)HwndSource.FromVisual(_owner);
                NativeMethods.GetWindowRect(hwndSource.Handle, out rcForm);
                NativeMethods.GetWindowRect(wParam, out rcMsgBox);

                // センター位置を計算する。
                var x = (rcForm.Left + (rcForm.Right - rcForm.Left) / 2) - ((rcMsgBox.Right - rcMsgBox.Left) / 2);
                var y = (rcForm.Top + (rcForm.Bottom - rcForm.Top) / 2) - ((rcMsgBox.Bottom - rcMsgBox.Top) / 2);

                NativeMethods.SetWindowPos(wParam, 0, x, y, 0, 0, NativeMethods.SWP_NOSIZE | NativeMethods.SWP_NOZORDER | NativeMethods.SWP_NOACTIVATE);

                var result = NativeMethods.CallNextHookEx(_hookHandle, nCode, wParam, lParam);

                // フックを解除する。
                NativeMethods.UnhookWindowsHookEx(_hookHandle);
                _hookHandle = IntPtr.Zero;

                return result;

            }
            else
            {
                return NativeMethods.CallNextHookEx(_hookHandle, nCode, wParam, lParam);
            }
        }

        private static class NativeMethods
        {
            [DllImport("user32.dll")]
            public static extern IntPtr GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("kernel32.dll")]
            public static extern IntPtr GetCurrentThreadId();

            [DllImport("user32.dll")]
            public static extern IntPtr SetWindowsHookEx(int idHook, HOOKPROC lpfn, IntPtr hInstance, IntPtr threadId);

            [DllImport("user32.dll")]
            public static extern bool UnhookWindowsHookEx(IntPtr hHook);

            [DllImport("user32.dll")]
            public static extern IntPtr CallNextHookEx(IntPtr hHook, int nCode, IntPtr wParam, IntPtr lParam);

            [DllImport("user32.dll")]
            public static extern bool SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int X, int Y, int cx, int cy,
                uint uFlags);

            [DllImport("user32.dll")]
            public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

            public delegate IntPtr HOOKPROC(int nCode, IntPtr wParam, IntPtr lParam);

            public const int GWL_HINSTANCE = (-6);
            public const int WH_CBT = 5;
            public const int HCBT_ACTIVATE = 5;

            public const int SWP_NOSIZE = 0x0001;
            public const int SWP_NOZORDER = 0x0004;
            public const int SWP_NOACTIVATE = 0x0010;

            public struct RECT
            {
                public RECT(int left, int top, int right, int bottom)
                {
                    Left = left;
                    Top = top;
                    Right = right;
                    Bottom = bottom;
                }

                public int Left;
                public int Top;
                public int Right;
                public int Bottom;
            }
        }
    }
}