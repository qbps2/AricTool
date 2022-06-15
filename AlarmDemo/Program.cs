// See https://aka.ms/new-console-template for more information
using AricPackage;

Console.WriteLine("Hello, World!");

int doTimeFn(string name, int id)
{
    Console.WriteLine("{0} {1} time out", name, id);
    return 0;
}

AlarmClock alarm1 = new AlarmClock(doTimeFn, "Alarm AAA", 1);
AlarmClock alarm2 = new AlarmClock(doTimeFn, "Alarm BBB", 2);
alarm1.startAlarmClock(6);
alarm2.startAlarmClock(5);

//Thread.Sleep(30000);

Console.ReadLine();
