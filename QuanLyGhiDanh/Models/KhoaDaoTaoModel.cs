namespace QuanLyGhiDanh.Models
{
    public class KhoaDaoTaoModel
    {
        public string maKhoaDaoTao { get; set; }
        public string tenKhoaDaoTao { get; set; }
        public DateTimeOffset ngayBatDau { get; set; }
        public DateTimeOffset ngayKetThuc { get; set; }
    }
}
