



public abstract class SingletonBase<T> 
    where T : SingletonBase<T>, new() 
{
    private static T instance = null;
    private static readonly object padlock = new object();

    protected SingletonBase()
    {

    }

    public static T Instance
    {
        get
        {
            lock (padlock)
            {
                if(instance == null)
                {
                    instance = new T();
                }
                return instance;
            }
        }
    }
}
