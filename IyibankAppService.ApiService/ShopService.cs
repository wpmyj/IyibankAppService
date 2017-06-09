using IyibankAppService.Data.Infrastructure;
using IyibankAppService.Data.Repository;
using IyibankAppService.Models.Models;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.ApiService
{
    public interface IShopService
    {
        List<Shop> GetShops();

        Shop GetShop(int id);

        void AddShop(Shop Shop, bool commit = true);

        void UpdateShop(Shop Shop, bool commit = true);

        void DeleteShop(int id, bool commit = true);

    }

    public class ShopService : IShopService
    {
        private readonly IShopRepository ShopRepository;


        public ShopService(IShopRepository ShopRepository)
        {
            this.ShopRepository = ShopRepository;
        }

        public List<Shop> GetShops()
        {
            var Shops = ShopRepository.GetAll();
            return Shops.ToList();
        }

        public Shop GetShop(int id)
        {
            var Shop = ShopRepository.GetById(id);
            return Shop;
        }

        public void AddShop(Shop Shop, bool commit = true)
        {
            ShopRepository.Add(Shop);
        }

        public void UpdateShop(Shop Shop, bool commit = true)
        {
            ShopRepository.Modify(Shop);
        }

        public void DeleteShop(int id, bool commit = true)
        {
            ShopRepository.Delete(id);
        }

    }
}
