using Admin.Models;
using Admin.Models.State;
using Newtonsoft.Json;
using Nome.Recieve;
namespace Admin.ControlData
{
    public class ReadJson
    {
        public static List<DonHang> getList(List<KhachHang> list)
        {
            string filePath = "";
            foreach (var i in list)
            {
                filePath = @"../Admin/StoreData/DonHang/" + i.IdKh + ".json";

                if (System.IO.File.Exists(filePath))
                {
                    string jsonContent = System.IO.File.ReadAllText(filePath);
                    // Đọc nội dung của tệp JSON
                    List<DonHang> productList = JsonConvert.DeserializeObject<List<DonHang>>(jsonContent);
                    return productList;
                }
            }
            return null;
        }
        public static List<OrderProduct> getListOrder(KhachHang kh)
        {
            string filePath = "";
            filePath = @"../Admin/StoreData/SanPhamDaDat/" + kh.IdDonHang + ".json";

            if (System.IO.File.Exists(filePath))
            {
                string jsonContent = System.IO.File.ReadAllText(filePath);
                // Đọc nội dung của tệp JSON
                List<OrderProduct> productList = JsonConvert.DeserializeObject<List<OrderProduct>>(jsonContent);
                return productList;
            }

            return null;
        }
        public static void UpdateStateDonHang(StateOrder state, KhachHang kh)
        {
            string json = JsonConvert.SerializeObject(state);
            string filePath = @"../Admin/DataStore/DonHangDaDuyet/" + kh.IdKh + ".json";
            System.IO.File.WriteAllText(filePath, json);
        }
    }
}
