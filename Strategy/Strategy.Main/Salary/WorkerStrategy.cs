using System.Collections.Generic;

namespace Strategy.Main.Salary
{
    public class WorkerStrategy : ISalaryStrategy
    {
        public double Calculate(
            double @base, 
            double sumOfIncomes,
             double employeeIncome, 
             double importantCalculationFactor)
        {
            return @base + employeeIncome * importantCalculationFactor;
        }
    }
  public class Product
  {
    public string Name { get; set; }
  }

  public class Order
  {
    public List<Product> Products { get; set; }
    public Invoice Invoice { get; set; }
  }


  public class Invoice
  {
    public string Address { get; set; }
    public string Nip { get; set; }
  }

  public class OrderBuilder
  {
    private List<Product> _products;
    // many other parameters
    public void AddProduct(Product product)
    {
      _products.Add(product);
    }
    // and many other methods

    public Order Build() => new Order 
    {
      Products = _products,
      /* and many others */
    };
  }




}