
using Decor;

Console.WriteLine(" ConcreteComponent");

var component = new ConcreteComponent();

Console.WriteLine("------------------------------");
var sendEmail=new ConcreteDecoratorA(component);
sendEmail.SendNotif();
sendEmail.RecNotif();

Console.WriteLine("-------------------------");
var sendSMS=new ConcreteDecoratorB(component);
sendSMS.SendNotif();






