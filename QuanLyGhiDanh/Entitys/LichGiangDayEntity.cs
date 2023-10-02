using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Entitys
{
    [Table("LichGiangDay")]
    public class LichGiangDayEntity: Entity
    {
        [ForeignKey("GiangVien")]
        public string maGiangVien { get; set; }
        public virtual GiangVienEntity? GiangVien { get; set; }
    }
}
