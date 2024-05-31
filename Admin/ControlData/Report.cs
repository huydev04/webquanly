using Admin.Models;
using Nome.Recieve;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace Admin.ControlData
{
    public static class Report
    {
        public static void CreateWordReport(KhachHang kh, DonHang p, List<OrderProduct> orders)
        {
            // Tạo một tài liệu mới
            string path = "Report" + kh.IdKh + ".docx";
            using (var document = DocX.Create("Report" + kh.IdKh + ".docx"))
            {
                // Thêm tiêu đề
                document.InsertParagraph("Đơn hàng")
                        .FontSize(18)
                        .Bold()
                        .Alignment = Alignment.center;

                // Thêm đoạn văn bản
                document.InsertParagraph("Họ tên khách hàng: " + kh.HoTenKh + ";");
                document.InsertParagraph("Địa chỉ nhân hàng: " + p.DiaChiNhanHang + ";");
                var table = document.AddTable(orders.Count + 1, 4);
                table.Design = TableDesign.LightListAccent1;

                // Thêm tiêu đề cột
                table.Rows[0].Cells[0].Paragraphs[0].Append("Mã đơn hàng").Bold();
                table.Rows[0].Cells[1].Paragraphs[0].Append("Tên sản phẩm").Bold();
                table.Rows[0].Cells[2].Paragraphs[0].Append("Số lượng").Bold();
                table.Rows[0].Cells[3].Paragraphs[0].Append("Giá").Bold();
                for (int i = 0; i < orders.Count; i++)
                {
                    table.Rows[i + 1].Cells[0].Paragraphs[0].Append(orders[i].Id.ToString());
                    table.Rows[i + 1].Cells[1].Paragraphs[0].Append(orders[i].TenSanPham);
                    table.Rows[i + 1].Cells[2].Paragraphs[0].Append(orders[i].SoLuong.ToString());
                    table.Rows[i + 1].Cells[3].Paragraphs[0].Append(orders[i].Gia.ToString());
                }
                document.InsertTable(table);
                // Đường dẫn nơi file sẽ được lưu trên máy chủ
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "reports", path);

                // Đảm bảo thư mục tồn tại
                var directory = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                // Lưu tài liệu trực tiếp vào file
                document.SaveAs(filePath);
            }
        }

    }
}
