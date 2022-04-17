using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace Hb.Presentation
{
    /// <summary>
    /// author     :habo
    /// date       :2022/4/18 0:20:17
    /// description:
    /// </summary>
    public class Desk : Application
    {
        private static DispatcherOperationCallback exitFrameCallback = new DispatcherOperationCallback(ExitFrame);
        /// <summary>
        /// 页面刷新
        /// </summary>
        public static void DoEvents()
        {
            DispatcherFrame nestedFrame = new DispatcherFrame();
            DispatcherOperation exitOperation = Dispatcher.CurrentDispatcher.BeginInvoke(DispatcherPriority.Background, exitFrameCallback, nestedFrame);
            Dispatcher.PushFrame(nestedFrame);
            if (exitOperation.Status != DispatcherOperationStatus.Completed)
            {
                exitOperation.Abort();
            }
        }

        private static Object ExitFrame(Object state)
        {
            DispatcherFrame frame = state as DispatcherFrame;
            frame.Continue = false;
            return null;
        }


        public static void UiInvoke(Action action)
        {
            if (Application.Current != null)
                Application.Current.Dispatcher.Invoke(action);
        }

        public static void UiInvoke(Action<object> action, object state)
        {
            if (Application.Current != null)
                Application.Current.Dispatcher.Invoke(action, state);
        }

        public static void Wait(Task task)
        {
            while (!task.Wait(10)) DoEvents();
        }
    }
}
