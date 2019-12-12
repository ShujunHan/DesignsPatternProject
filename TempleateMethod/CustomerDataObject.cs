using System;
using System.Collections.Generic;
using System.Text;

namespace TempleateMethod
{
    class CustomerDataObject : DateObject
    {
        private string ConnectionString = 

        public override void Connect()
        {
            throw new NotImplementedException();
        }

        public override void Disconnect()
        {
            throw new NotImplementedException();
        }

        public override void Process()
        {
            throw new NotImplementedException();
        }

        public override void Select()
        {
            throw new NotImplementedException();
        }
    }
}
