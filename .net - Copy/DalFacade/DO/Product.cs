namespace DO;
public record Product
    (int id,
    string name,
    Category category,
    double price,
    int amount)
{ 
    public Product() : this(0, "", Category.Rings, 0.0, 0) { }
}