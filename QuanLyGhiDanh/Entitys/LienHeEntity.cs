using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Entitys
{
    [Table("LienHe")]
    public class LienHeEntity: Entity
    {
        public string tinNhan { get; set; }

        [ForeignKey("HocVien")]
        public string maHocVien { get; set; }
        public virtual HocVienEntity? HocVien { get; set; }
    }
}
