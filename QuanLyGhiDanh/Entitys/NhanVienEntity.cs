using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Entitys
{
    [Table("NhanVien")] // Quản Trị
    public class NhanVienEntity: Entity
    {
        [Key]
        public string maNhanVien { get; set; }
        public string ho { get; set; }
        public string tenDemVaTen { get; set; }
        public DateTimeOffset ngaysinh { get; set; }
        public bool gioiTinh { get; set; }
        public string email { get; set; }
        public int sdt { get; set; }
        public string diaChi { get; set; }
        public string maSoThue { get; set; }
        public DateTimeOffset ngayHopTac { get; set; }        
        public string anhNhanVien { get; set; }

        [ForeignKey("ChucVu")]
        public string maChucVu { get; set; }
        public virtual ChucVuEntity? ChucVu { get; set; }
        public virtual ICollection<GiangVienEntity>? GiangViens { get; set; }
        //public virtual ICollection<TinhLuongEntity>? TinhLuongs { get; set; }
        public virtual ICollection<KhoaDaoTaoEntity>? KhoaDaoTaos { get; set; }
    }
}
