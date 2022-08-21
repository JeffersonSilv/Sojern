using VersionManager;

Console.WriteLine("Comparing version 1.3 to 1.3.1 should return:" + VersionUtil.Compare("1.3", "1.3.1"));
Console.ReadKey();
