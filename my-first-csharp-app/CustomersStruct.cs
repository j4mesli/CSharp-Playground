struct Customers {
    private string name;
    private double balance;
    private int id;

    public void createCustomer(string n, double b, int id) {
        this.name = n;
        this.balance = b;
        this.id = id;
    }

    public void showCustomer() {
        Console.WriteLine("Name: " + this.name);
        Console.WriteLine("Balance: " + this.balance);
        Console.WriteLine("ID: " + this.id);
    }
}