using System;
using System.Collections.Generic;
using System.Text;

namespace Observers
{
    class ConcreaterSubject : Subject
    {

        private List<ObServer> obServerList = new List<ObServer>();
        
        public void Attach(ObServer obServer)
        {
            obServerList.Add(obServer);
        }

        public void Detach(ObServer obServer)
        {
            obServerList.Remove(obServer);
        }

        public void NotifyObserver(object obj)
        {
            foreach (ObServer item in obServerList)
            {
                item.OnUpdate(obj);
            }
        }
    }
}
