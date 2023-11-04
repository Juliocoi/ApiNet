public static class ProductRepository {

// criar e inicializa uma lista.
  public static List<Product> Products { get; set; } = Products = new List<Product>();


//Inicializa uma lista utilizando os dados mocados no appSettings.json
  public static void Init(IConfiguration configuration){
    var products = configuration.GetSection("Products").Get<List<Product>>();
    Products = products;
  }

  public static void Add(Product product){
    Products.Add(product);
  }

  public static Product getBy(string code){
    return Products.FirstOrDefault(p => p.Code == code);
  }

  public static void Remove(Product product){
    Products.Remove(product);
  }
}
