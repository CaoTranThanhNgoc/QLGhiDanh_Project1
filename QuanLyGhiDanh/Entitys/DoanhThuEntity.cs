using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Entitys
{
    [Table("DoanhThu")]
    public class DoanhThuEntity: Entity
    {
        [Key]
        public string maDoanhThuTheoKy { get; set; }
        public string ngayThuHocPhi { get; set; }
        public virtual ICollection<HocPhiEntity>? HocPhis { get; set; }
        
    }
}
