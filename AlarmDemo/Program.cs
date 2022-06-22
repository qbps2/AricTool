// See https://aka.ms/new-console-template for more information
using AricPackage;

Console.WriteLine("Hello, World!");

int doTimeFn1(string name, int id)
{
    Console.WriteLine("{0} {1} time out doTimeFn", name, id);
    return 0;
}

void doTimeFn2(string name, int id)
{
    Console.WriteLine("{0} {1} time out doTimeFn2", name, id);
    //return "";
}

AlarmClock alarm1 = new AlarmClock(doTimeFn1, "Alarm AAA", 1, true);
AlarmClock alarm2 = new AlarmClock(doTimeFn2, "Alarm BBB", 2, true);
alarm1.startAlarmClock(5);
alarm2.startAlarmClock(10);

Console.ReadLine();
