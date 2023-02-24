class Animal {
    // Properties
    // PRIVATE MEANS ONLY ACCESSIBLE IN THIS FILE, PUBLIC IS ACCESSIBLE ANYWHERE
    // create getters and setters shorthand
    public double height { get; set; }
    public double weight { get; set; }

    // question mark means nullable/optional
    public string? sound { get; set; }

    // specific getter and setter definition
    // YOU MUST GENERATE A PRIVATE FIELD AND PUBLIC SETTERS AND GETTERS. OTHERWISE, STACK OVERFLOW
    private string name;
    public string Name { 
        get { return name; }
        set { name = value; }
    }

    // manual constructor generation (AUTOMATICALLY GENERATED OTHERWISE)
    // NO ARGS CONSTRUCTOR
    public Animal() {
        this.height = 0;
        this.weight = 0;
        this.name = "N/A";
        this.sound = "N/A";
        numOfAnimals++;
    }

    // ARGS CONSTRUCTOR
    public Animal(double height, double weight, string name, string sound) {
        this.height = height;
        this.weight = weight;
        this.sound = sound;
        this.name = name;
        numOfAnimals++;
    }
    
    // static field (count number of instances of Animals, SHARED BY ALL ANIMALS)
    // AUTOMATICALLY CREATE GETTER AND SETTER METHODS LIKE THIS
    // OMIT "get;" FOR WRITE ONLY
    // OMIT "set;" FOR READ ONLY
    public static int numOfAnimals { get; set; } = 0;

    // INSTANCE EXCLUSIVE METHODS
    public string toString() {
        return String.Format("Name: {0}, Weight: {1}, Height: {2}, Sound: {3}", name, weight, height, sound);
    }

    // THE BELOW INTAKE SYNTAX SETS A DEFAULT VALUE
    public int getSum(int num1 = 1, int num2 = 2) {
        return num1 + num2;
    }

    // ADDING A SECOND INSTANCE WITH DIFFERENT DATA TYPE IS METHOD OVERLOADING, TO HANDLE MULTIPLE DATA TYPES
    public double getSum(double num1 = 1, double num2 = 2) {
        return num1 + num2;
    }
}