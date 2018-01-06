using System.Collections.Generic;
using MvcMusicStoreMyTrial.Models;

namespace MvcMusicStoreMyTrial.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}