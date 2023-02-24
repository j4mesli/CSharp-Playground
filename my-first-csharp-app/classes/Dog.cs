
// INHERITANCE OOP PRINCIPAL, use colon
class Dog : Animal {
    public string favFood { get; set; }

    // use the parent class' noArg constructor
    public Dog() : base() {
        this.favFood = "No Favorite Food";
    }

    // use the parent class' Arg constructor
    public Dog(double height, double weight, string name, string sound, string favFood) : base(height, weight, name, sound) {
        this.favFood = favFood;
    }

    // OVERRIDE PARENT CLASS' METHOD
    new public string toString() {
        return String.Format("Name: {0}, Weight: {1}, Height: {2}, Sound: {3}, Favorite Food: {4}", Name, weight, height, sound, favFood);
    }
}