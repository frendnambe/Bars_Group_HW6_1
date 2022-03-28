using Bars_Group_HW2;
using Bars_Group_HW2.bars_group_6_1;

string path = "C:\\Users\\gabdd\\OneDrive\\Рабочий стол\\Bars_Group_HW6";
ILogger fooLogger = new LocalFileLogger<Foo>(path);
fooLogger.LogInfo("Запуск программы");
fooLogger.LogWarning("Программа не отвечает");
fooLogger.LogError("Id == null",new DivideByZeroException());

ILogger foo_1Logger = new LocalFileLogger<Foo_1>(path);
foo_1Logger.LogWarning("Ошибка доступа к базе данных");
foo_1Logger.LogInfo("Программа работает нормально");
foo_1Logger.LogError("Id == -3", new ArgumentOutOfRangeException());
