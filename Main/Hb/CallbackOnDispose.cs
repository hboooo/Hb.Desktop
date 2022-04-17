using System;
using System.Threading;

namespace Hb
{
    public class CallbackOnDispose : IDisposable
    {
        Action action;

        public CallbackOnDispose(Action action)
        {
            this.action = action;
            if (action == null) throw new ArgumentNullException("action");
        }

        public void Dispose()
        {
            Interlocked.Exchange(ref action, null)?.Invoke();
        }
    }
}
