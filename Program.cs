using Assignment;
bool wrongProductName = true;

List<Products> products =
[
    new( "music", 0.06 ),
    new( "food", 0.12 ),
    new( "alcohol", 0.25 )
];


double Purchase(string product, double price)
{

    foreach (var p in products)
    {
        if (product.ToLower().Equals(p.ProductName))
        {
            wrongProductName = false;
            return price + (price * p.Vat);
        }
    }

    throw new ArgumentException("Product isnt in the list");
}

