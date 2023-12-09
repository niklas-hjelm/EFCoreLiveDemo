using DataAccess;

namespace StoreUI;

/*
 TODO: Detta är ett ganska dåligt sätt att göra det på. Det är bättre att använda Dependency Injection.
        Men vi har inte gått igenom Service Provider i .NET Core än.
        Så detta är en placeholder för att kunna använda sig av en DbContext i våra Repositories.
 */
public static class ApplicationContextManager
{
    public static ProductContext? Context { get; private set; }

    public static void Initialize(ProductContext context)
    {
        Context = context;
    }
}