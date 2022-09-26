public class Singleton<T> where T : new()
{
    //private static Singleton<T> i;
    public static T instance {get; private set;}
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new T();
            }

            return instance;
        }
    }
}