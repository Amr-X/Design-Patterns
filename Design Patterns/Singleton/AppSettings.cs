namespace Singleton;

// This is a Class that should only be one instance of it in the whole App
// It doesn't make sense to have more than one of Our AppSettings,
// If someone creates a new instance, He is changing his own AppSettings
// Other Example is Logger that outputs to some file (Universal Logger)
// Or, DataBase Connection - GameConfiguration,.. 
// 1- Hide Constructor, No one can create 
// 2- AppSettings itself creates itself and keeps instance of it (Static Field)
// 3- Expose that instance, When someone needs it => GetInstance()
public class AppSettings
{
    // Violate SRP <== It's like a factory method
    private static AppSettings _instance = null; // The Instance

    public static AppSettings Instance
    {
        // Not Thread Safe => Two threads access this at the same time creating two different AppSettings
        get
        {
            _instance ??= new AppSettings();
            return _instance;
        }
    }


    private AppSettings()
    {
        // Loads from somewhere
        // Or Set's Default Values
        AppName = "Default App Name";
        Version = "1.0.0";
        Theme = "Light";
    }


    public string AppName { get; set; }
    public string Version { get; set; }

    public string Theme { get; set; }
    // More
}

// The Lazy Way - It's thread safe
public sealed class LazyAppSettings
{
    private static readonly Lazy<LazyAppSettings> _instance = new(() =>
        new LazyAppSettings()); // Doesn't do anything -> Deferred Until _instance.Value is called - Calling the Func Provided

    public static LazyAppSettings Instance
    {
        get { return _instance.Value; }
    }

    private LazyAppSettings()
    {
        // 
    }
}