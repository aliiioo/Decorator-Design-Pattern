using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decor
{
    public abstract class component
    {
        public abstract void SendNotif();
        public abstract void RecNotif();
    }

    public class ConcreteComponent : component
    {
        public override void RecNotif()
        {
            Console.WriteLine("Rec Notif");
        }

        public override void SendNotif()
        {
            Console.WriteLine("Send Notif in ConcreteComponet");
        }

        
    }
}
