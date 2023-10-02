using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace QuanLyGhiDanh.Entitys
{
    [Table("PhanCongGiangDay")]
    public class PhanCongGiangDayEntity: Entity
    {
        
        [Key]
        public string maPhanCongGiangDay { get; set; }
        public string gioBatDauHoc { get; set; }
        public string gioKetThucHoc { get; set; }
        public string ngayHoc { get; set; }
        public DateTimeOffset ngayBatDau { get; set; }
        public DateTimeOffset ngayKetThuc { get; set; }

        [ForeignKey("MonHoc")]
        public string maMonHoc { get; set; }
        public virtual MonHocEntity? MonHoc { get; set; }

        [ForeignKey("LopHoc")]
        public string maLopHoc { get; set; }
        public virtual LopHocEntity? LopHoc { get; set; }

        [ForeignKey("GiangVien")]
        public string maGiangVien { get; set; }
        public virtual GiangVienEntity? GiangVien { get; set; }

    }
}
