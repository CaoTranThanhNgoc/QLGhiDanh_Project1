namespace QuanLyGhiDanh.Models
{
    public class GiangVienModel
    {
        public string maGiangVien { get; set; }
        public string maSoThue { get; set; }
        public string ho { get; set; }
        public string tenDemVaTen { get; set; }
        public DateTimeOffset ngaysinh { get; set; }
        public bool gioiTinh { get; set; }
        public int sdt { get; set; }
        public string email { get; set; }
        public string diaChi { get; set; }
        public string maMonHocChinh { get; set; }
        public string maMonHocKiemNhiem { get; set; }
        //public DateTimeOffset ngayHopTac { get; set; }
        public string matKhau { get; set; }
        public string anhNhanVien { get; set; }
        public string maNhanVien { get; set; }

    }
}
