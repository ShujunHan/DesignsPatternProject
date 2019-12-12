using System;
using System.Collections.Generic;
using System.Text;

namespace Observers
{
    interface Subject
    {
        void Attach(ObServer obServer);

        void Detach(ObServer obServer);

        void NotifyObserver(object obj);
    }
}
