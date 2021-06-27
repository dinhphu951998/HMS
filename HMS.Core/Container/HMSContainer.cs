using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Core.Container
{
    public abstract class HMSContainer
    {
        public abstract T Resolve<T>();

        public abstract void RegisterAllNeeded();

    }
}
