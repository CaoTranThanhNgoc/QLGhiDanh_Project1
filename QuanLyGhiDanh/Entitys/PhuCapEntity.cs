using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Entitys
{
    [Table("PhuCap")]
    public class PhuCapEntity: Entity
    {
        [Key]
        public string maPhuCap { get; set; }
        public string tenPhuCap { get; set; }
        public double phiPhuCap { get; set; }

        [ForeignKey("TinhLuong")]
        public string maNhanVien { get; set; }
        public virtual TinhLuongEntity? TinhLuongs { get; set; }
    }
}
