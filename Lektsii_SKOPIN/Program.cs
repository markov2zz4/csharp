//Контрвариантность обобщений.

Circle circle = new Circle();

IContainer<Shape> container = new Container<Shape>(circle);
//IContainer<Circle> container = new<Circle> (circle);

public abstract class Shape { }

public class Circle : Shape { }

public interface IContainer<T>
{
    T Figure { get; set; }
}

public class Container<T> : IContainer<T>
{
    public Container(Circle circle)
    {
        Circle = circle;
    }

    public T Figure { get; set; }
    public Circle Circle { get; }
}

