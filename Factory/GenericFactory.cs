namespace Factory;

public class GenericFactory<T> where T : IProduct, new()
{
    public T Create()
    {
        return new T();
    }
}
