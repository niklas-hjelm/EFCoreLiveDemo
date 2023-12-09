using DataAccess;

namespace StoreUI;

public static class ApplicationContextManager
{
    public static ProductContext? Context { get; private set; }

    public static void Initialize(ProductContext context)
    {
        Context = context;
    }
}