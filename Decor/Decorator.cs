using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decor
{
    public abstract class Decorator : component
    {   
        private readonly component _component;
        public Decorator(component component)
        {
            _component = component;
        }

        public override void SendNotif()
        {
            _component.SendNotif();
        }

        public override void RecNotif()
        {
            _component.RecNotif();
        }

    }

    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(component component):base(component)
        {

        }

        public override void RecNotif()
        {
            base.RecNotif();
        }

        public override void SendNotif()
        {
            base.SendNotif();
            Console.WriteLine("Send Email");
        }


    }

    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(component component) : base(component)
        {

        }

        public override void RecNotif()
        {
            base.RecNotif();
        }

        public override void SendNotif()
        {
            base.SendNotif();
            Console.WriteLine("Phone");
        }
        
    }


}
