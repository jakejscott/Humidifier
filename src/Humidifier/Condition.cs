using System;

namespace Humidifier
{
    public class Condition
    {
        public dynamic Fn { get; }

        public Condition(dynamic fn)
        {
            if (fn == null) throw new ArgumentNullException(nameof(fn));
            Fn = fn;
        }
    }
}