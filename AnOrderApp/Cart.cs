using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anorderapp
{
    class Cart
    {
        private List<string> cartItems;
        private List<string> paymentMethods;

        public void DisplayCartItems()
        {
            cartItems = new List<string>();

            if(cartItems != null )
            {
                foreach( string item in cartItems )
                {
                    cartItems.Add( item );
                }
            }
            else
            {
                Console.WriteLine("Your Cart Is Empty");
            }
        }
    }
}