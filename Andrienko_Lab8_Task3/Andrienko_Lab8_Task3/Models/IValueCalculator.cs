using System.Collections.Generic;
namespace Andrienko_Lab8_Task3.Models
{
    public interface IValueCalculator
    {
        decimal ValueProducts(IEnumerable<Product> products);
    }
}