abstract class Shape {
    public abstract double area();
    
    // non-abstracted item requires a definition
    public void sayHi() { Console.WriteLine("Hello, world from the Shape abstraction!"); }
}