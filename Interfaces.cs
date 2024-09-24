namespace Interfaces;

public interface ISingleton : IValue { }
public interface IScoped : IValue { }
public interface ITransient : IValue { }

public interface IValue
{
    Guid ID { get; }
}

public class Value : ISingleton, IScoped, ITransient
{
    public Guid ID { get; private set; } = Guid.NewGuid();
}