using ReportManager;

namespace ProductManager;

public interface IProduct
{
    string Label { get; set; }
    int Count { get; set; }
}

public class ProductItem : IProduct
{
    public string Label { get; set; }
    public int Count { get; set; }

    public ProductItem(string label, int count)
    {
        this.Label = label;
        this.Count = count;
    }
}


public class Product : Report
{
    public string Label { get; } = "Products";

    public List<ProductItem> Items { get;  }

    public List<ISubMenu> SubMenus { get; }

    private string GetCount ()
    {
        return Items.Count.ToString();

    }

    public Product()
    {
      this.Items=new List<ProductItem>()
        {
            new ProductItem("pen", 100),
            new ProductItem("jacket", 50),
            new ProductItem("umbrella", 658),
        };

      this.SubMenus=new List<ISubMenu>()
        {
            new SubMenu("get Count", GetCount),
        };
    }

}
