using Microsoft.EntityFrameworkCore;
using QuanLyGhiDanh.Entitys;

namespace QuanLyGhiDanh.AppDBContext
{
    public class DBContext: DbContext
    {
        public DBContext() { }
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }   


        public DbSet<BangDiemEntity> BangDiems { get; set;}
        public DbSet<ChucVuEntity> ChucVus { get; set;}
        public DbSet<DoanhThuEntity> DoanhThus { get; set;}
        public DbSet<GiangVien_MonHocEntity> GiangVien_MonHocs { get; set;}
        public DbSet<GiangVienEntity> GiangViens { get; set; }
        public DbSet<HocPhiEntity> HocPhis { get; set; }
        public DbSet<HocVien_LopHocEntity> HocVien_LopHocs { get; set; }
        public DbSet<HocVienEntity> HocViens { get; set;}
        public DbSet<KhoaDaoTaoEntity> KhoaDaoTaos { get; set; }
        public DbSet<KhoaKhoiEntity> KhoaKhois { get; set; }
        public DbSet<LichGiangDayEntity> LichGiangDays { get; set; }
        public DbSet<LichHocEntity> LichHocs { get; set;}
        public DbSet<LichNghiEntity> LichNghis { get; set;}
        public DbSet<LienHeEntity> LienHes { get; set; }
        public DbSet<LoaiDiem_MonHocEntity> LoaiDiem_MonHocs { get; set; }
        public DbSet<LoaiDiemEntity> LoaiDiems { get; set;}
        public DbSet<LoaiHocPhiEntity> LoaiHocPhis { get; set; }
        public DbSet<LopHocEntity> LopHocs { get; set; }
        public DbSet<MonHoc_KhoaDaoTaoEntity> MonHoc_KhoaDaoTaos { get; set; }
        public DbSet<MonHoc_LopHocEntity> MonHoc_LopHocs { get; set; }   
        public DbSet<MonHocEntity> MonHocs { get; set; }
        public DbSet<NguoiDungEntity> NguoiDungs { get;set; }
        public DbSet<NhanVienEntity> NhanViens { get; set;}
        public DbSet<PhanCongGiangDayEntity> PhanCongGiangDays { get; set; }
        public DbSet<PhongHoc_LopHocEntity> PhongHoc_LopHocs { get; set; }
        public DbSet<PhongHocEntity> PhongHocs { get; set;}
        public DbSet<PhuCapEntity> PhuCaps { get; set; }
        public DbSet<TinhLuongEntity> TinhLuongs { get; set; }
        public DbSet<ToBoMonEntity> ToBoMons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=DB_QuanLyGhiDanh;user=sa;pwd=123;Trusted_Connection=True;Trust Server Certificate=True; Integrated Security=false");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BangDiemEntity>()
                .HasKey(e => new { e.maDiem });

            modelBuilder.Entity<ChucVuEntity>()
                .HasKey(e => new { e.maChucVu });

            modelBuilder.Entity<DoanhThuEntity>()
                .HasKey(e => new { e.maDoanhThuTheoKy });

            modelBuilder.Entity<GiangVien_MonHocEntity>()
                .HasKey(e => new { e.maGiangVien, e.maMonHoc });

            modelBuilder.Entity<GiangVienEntity>()
                .HasKey(e => new { e.maGiangVien });

            modelBuilder.Entity<HocPhiEntity>()
                .HasKey(e => new { e.maPhieuHocPhi });

            modelBuilder.Entity<HocVien_LopHocEntity>()
                .HasKey(e => new { e.maLopHoc, e.maHocVien });

            modelBuilder.Entity<HocVienEntity>()
                .HasKey(e => new { e.maHocVien });

            modelBuilder.Entity<KhoaDaoTaoEntity>()
                .HasKey(e => new { e.maKhoaDaoTao });

            modelBuilder.Entity<KhoaKhoiEntity>()
                .HasKey(e => new { e.maKhoa });

            //modelBuilder.Entity<LichGiangDayEntity>()
            //    .HasKey(e => new { e.maGiangVien});

            modelBuilder.Entity<LichHocEntity>()
                .HasKey(e => new { e.maLichHoc });

            modelBuilder.Entity<LichNghiEntity>()
                .HasKey(e => new { e.maLich });

            //modelBuilder.Entity<LienHeEntity>()
            //    .HasKey(e => new { e.maHocVien });

            modelBuilder.Entity<LoaiDiem_MonHocEntity>()
                .HasKey(e => new { e.maLoaiDiem, e.maMonHoc });

            modelBuilder.Entity<LoaiDiemEntity>()
                .HasKey(e => new { e.maLoaiDiem });

            modelBuilder.Entity<LoaiHocPhiEntity>()
                .HasKey(e => new { e.maLoaiHocPhi });

            modelBuilder.Entity<LopHocEntity>()
                .HasKey(e => new { e.maLopHoc });

            //modelBuilder.Entity<MonHoc_KhoaDaoTaoEntity>()
            //    .HasKey(e => new { e.KhoaDaoTao, e.maMonHoc });

            modelBuilder.Entity<MonHoc_LopHocEntity>()
                .HasKey(e => new { e.maLopHoc, e.maMonHoc });

            modelBuilder.Entity<MonHocEntity>()
                .HasKey(e => new { e.maMonHoc});

            modelBuilder.Entity<NguoiDungEntity>()
               .HasKey(e => new { e.maNguoiDung});

            modelBuilder.Entity<NhanVienEntity>()
               .HasKey(e => new { e.maNhanVien});

            modelBuilder.Entity<PhanCongGiangDayEntity>()
               .HasKey(e => new { e.maPhanCongGiangDay, e.maMonHoc, e.maLopHoc, e.maGiangVien });

            modelBuilder.Entity<PhongHoc_LopHocEntity>()
                .HasKey(e => new { e.maLopHoc, e.maPhong });

            modelBuilder.Entity<PhongHocEntity>()
               .HasKey(e => new { e.maPhong });

            modelBuilder.Entity<PhuCapEntity>()
               .HasKey(e => new { e.maPhuCap });

            modelBuilder.Entity<TinhLuongEntity>()
               .HasKey(e => new { e.maNhanVien});

            modelBuilder.Entity<ToBoMonEntity>()
               .HasKey(e => new { e.maBoMon });

        }


    }
}
