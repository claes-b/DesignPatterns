using Singleton;
using System.Threading.Tasks; //to get the Parallel class

var p1 = new Thread(() =>
{
    var s = SingletonClass.GetInstance();
    Console.WriteLine(s.InstanceId);
});
var p2 = new Thread(() =>
{
    var s = SingletonClass.GetInstance();
    Console.WriteLine(s.InstanceId);
});

p1.Start();
p2.Start();

p1.Join();
p2.Join();


//Parallel.For(0, 10, (i) => {
//    var s = SingletonClass.GetInstance();
//    Console.WriteLine(s.InstanceId);
//});



