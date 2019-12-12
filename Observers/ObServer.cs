using System;
using System.Collections.Generic;
using System.Text;

namespace Observers
{
    public interface ObServer
    {
        void OnUpdate(object obj);
    }
}
