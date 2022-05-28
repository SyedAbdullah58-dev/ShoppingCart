using Microsoft.EntityFrameworkCore;

namespace ShoppingCart.Data
{
    public class ShoppingContext:DbContext

    {
        public ShoppingContext(DbContextOptions<ShoppingContext> options):base(options)
        {

        }

    }
}
