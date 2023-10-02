using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Entitys
{
    [Table("TinhLuong")]
    public class TinhLuongEntity
    {
        public double phanTramLuongGiangVien { get; set; }
        public double thucLanh { get; set; }
        public double tongLuong { get; set; }
        public virtual ICollection<PhuCapEntity>? PhuCaps { get; set; }
        [ForeignKey("NhanVien")]
        public string maNhanVien { get; set; }
        public virtual NhanVienEntity? NhanVien { get; set; }

        //[ForeignKey("KhoaDaoTao")]
        //public string maKhoaDaoTao { get; set; }
        //public virtual NhanVienEntity? KhoaDaoTao { get; set; }

    }
}
