class Triangle : Shape {
    private double _base;
    private double height;

    public Triangle(double num1, double num2) {
        this._base = num1;
        this.height = num2;
    }

    // OVERRIDE AN ABSTRACT CLASS' METHOD
    public override double area() {
        return .5 * (height * _base);
    }
}