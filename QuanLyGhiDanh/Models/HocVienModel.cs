namespace QuanLyGhiDanh.Models
{
    public class HocVienModel
    {
        public string maHocVien { get; set; }
        public string ho { get; set; }
        public string tenDemVaTen { get; set; }
        public DateTimeOffset ngaysinh { get; set; }
        public bool gioiTinh { get; set; }
        public string email { get; set; }
        public int sdt { get; set; }
        public string diaChi { get; set; }
        public string tenPhuHuynh { get; set; }
        public string matKhau { get; set; }
        public string anhHocVien { get; set; }
    }
}
