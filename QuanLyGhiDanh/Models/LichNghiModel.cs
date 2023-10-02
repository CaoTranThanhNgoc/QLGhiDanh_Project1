namespace QuanLyGhiDanh.Models
{
    public class LichNghiModel
    {
        public string maLich { get; set; }
        public string tenLich { get; set; }
        public string lyDo { get; set; }
        public DateTimeOffset ngayBatDau { get; set; }
        public DateTimeOffset ngayKetThuc { get; set; }
    }
}
