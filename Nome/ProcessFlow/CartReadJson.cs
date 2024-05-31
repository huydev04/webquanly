using Newtonsoft.Json;
using Nome.Models;
using Nome.Recieve;

namespace Nome.ProcessFlow
{
    public static class CartReadJson
    {
        public static List<OrderProduct> getList()
        {
            string filePath = "";
            foreach (var i in UserState.statelogin)
            {
                filePath = @"../Admin/StoreData/" + i.IdKh + ".json";
            }
            if (System.IO.File.Exists(filePath))
            {
                string jsonContent = System.IO.File.ReadAllText(filePath);
                // Đọc nội dung của tệp JSON
                List<OrderProduct> productList = JsonConvert.DeserializeObject<List<OrderProduct>>(jsonContent);
                return productList;
            }
            else
            {
                return null;
            }
        }

        public static void setList(List<OrderProduct> orderList)

        {
            string json = JsonConvert.SerializeObject(orderList);
            string filePath = @"../Admin/StoreData/" + UserState.UserLog().IdKh + ".json";
            System.IO.File.WriteAllText(filePath, json);
        }
        public static void setOrderList(List<DonHang> Dh)

        {
            string json = JsonConvert.SerializeObject(Dh);
            string filePath = @"../Admin/StoreData/DonHang/" + UserState.UserLog().IdKh + ".json";
            System.IO.File.WriteAllText(filePath, json);
        }
        public static void SaveOrderList(List<OrderProduct> Dh)

        {
            string json = JsonConvert.SerializeObject(Dh);
            string filePath = @"../Admin/StoreData/SanPhamDaDat/" + UserState.UserLog().IdKh + ".json";
            System.IO.File.WriteAllText(filePath, json);
        }
    }
}
