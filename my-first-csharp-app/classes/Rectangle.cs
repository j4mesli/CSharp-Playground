class Rectangle : Shape {
    private double length;
    private double width;

    public Rectangle(double num1, double num2) {
        this.length = num1;
        this.width = num2;
    }

    // OVERRIDE AN ABSTRACT CLASS' METHOD
    public override double area() {
        return length * width;
    }

    // OPERATOR OVERLOADING
    // basically define what the operator does on utilization of two items
    // EXAMPLE: ADDING TWO RECTANGLES TOGETHER
    public static Rectangle operator+ (Rectangle r1, Rectangle r2) {
        double rectLength = r1.length + r2.length;
        double rectWidth = r1.width + r2.width;

        return new Rectangle(rectLength, rectWidth);
    }
}