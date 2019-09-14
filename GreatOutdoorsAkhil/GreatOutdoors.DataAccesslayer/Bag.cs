using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatOutdoors.DataAccesslayer
{
    public class Bag
    {
        public double CartValue;
        Product product = new Product(); //Product object

        public List<int> cart = new List<int>(); //cart with product id's

        public void AddToCart(int productId, int addToCartQuantity)
        {

            cart.Add(productId);


            CartValue += (product.Price * addToCartQuantity);
        }

        public void RemoveFromCart(int productId, int removeFromCartQuantity)
        {

            cart.Remove(productId);

            CartValue -= (product.Price * removeFromCartQuantity);
        }

        public int TotalQuantityOrdered(int addToCartQuantity, int removeFromCartQuantity)
        {
            return (addToCartQuantity - removeFromCartQuantity);
        }
    }
}
