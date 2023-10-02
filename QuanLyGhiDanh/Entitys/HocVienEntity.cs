using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Entitys
{
    [Table("HocVien")]
    public class HocVienEntity: Entity
    {
        [Key]
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
        public virtual ICollection<HocVien_LopHocEntity>? HocVien_LopHocs { get; set; }
        public virtual ICollection<LienHeEntity>? LienHes { get; set; }

    }
}
