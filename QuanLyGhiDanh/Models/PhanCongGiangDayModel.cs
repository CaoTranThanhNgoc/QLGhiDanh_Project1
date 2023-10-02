namespace QuanLyGhiDanh.Models
{
    public class PhanCongGiangDayModel
    {
        public string maPhanCongGiangDay { get; set; }
        public string gioBatDauHoc { get; set; }
        public string gioKetThucHoc { get; set; }
        public string ngayHoc { get; set; }
        public DateTimeOffset ngayBatDau { get; set; }
        public DateTimeOffset ngayKetThuc { get; set; }
    }
}
