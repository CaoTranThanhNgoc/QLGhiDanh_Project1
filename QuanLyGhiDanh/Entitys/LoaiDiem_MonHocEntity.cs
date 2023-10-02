using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Entitys
{
    [Table("LoaiDiem_MonHoc")]
    public class LoaiDiem_MonHocEntity: Entity
    {      
        public int soCotDiem { get; set; }
        public int soCotDiemBatBuoc { get; set; }

        [ForeignKey("LoaiDiem")]
        public string? maLoaiDiem { get; set; }
        public virtual LoaiDiemEntity? LoaiDiem { get; set; }

        [ForeignKey("MonHoc")]
        public string? maMonHoc { get; set; }
        public virtual MonHocEntity? MonHoc { get; set; }

    }
}
