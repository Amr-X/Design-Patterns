using Singleton;
using Singleton.Ambient_Context;

#region Bad

//AppSettings appSettings = new();
// appSettings.AppName = "My App";
// appSettings.Version = "2.0.0";

// Somewhere else 
// AppSettings appSet = new(); // A Different AppSettings????
// appSet.AppName = "My App2";
// appSet.Version = "2.0.0.0";

#endregion

#region Good

// No Should be able to create AppSettings, It's only one

// First time
var settings = AppSettings.Instance;
settings.AppName = "ld;fkaj";
settings.Version = "23424";

// 
var settings2 = AppSettings.Instance;
settings.AppName = "Proper Name";
settings.Version = "2.13.123";

#endregion

#region NoContext

// Normal Processor - Look at the class
var pNoContext = new ProcessorNoContext();
pNoContext.DoWork("Amr");
// logger.Log("Amr","SomeMassage"); 

#endregion

#region WithContext

// The Context  
ProcessorContext.PersonName = "Amr";

var p = new Processor();
p.DoWork();

// It's aware of the processor context too
var logger = new Logger();
logger.Log("SomeMassage");

// Change Context
ProcessorContext.PersonName = "Other Name";

#endregion

#region WithStackContext

// You can now use it with "Using"
using var context1 = new ProcessorContextStack("Amr");
// Do your work here
var processor1 = new Processor();
processor1.DoWork();
var logger1 = new Logger();
logger1.Log("Some message Withing context 1");

using (var context2 = new ProcessorContextStack("Other Name"))
{
// Uses the new context
    var logger2 = new Logger();
    logger2.Log("Some message Withing context 2");
} // End of new context

// Back to context 1 => Name: "Amr"
logger1.Log("Some message Withing context 1 after context 2");

#endregion
