using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyGhiDanh.Migrations
{
    /// <inheritdoc />
    public partial class QLGD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BangDiem",
                columns: table => new
                {
                    maDiem = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    diemTB = table.Column<double>(type: "float", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BangDiem", x => x.maDiem);
                });

            migrationBuilder.CreateTable(
                name: "DoanhThu",
                columns: table => new
                {
                    maDoanhThuTheoKy = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ngayThuHocPhi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoanhThu", x => x.maDoanhThuTheoKy);
                });

            migrationBuilder.CreateTable(
                name: "HocVien",
                columns: table => new
                {
                    maHocVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tenDemVaTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ngaysinh = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    gioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sdt = table.Column<int>(type: "int", nullable: false),
                    diaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tenPhuHuynh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    matKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    anhHocVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocVien", x => x.maHocVien);
                });

            migrationBuilder.CreateTable(
                name: "KhoaKhoi",
                columns: table => new
                {
                    maKhoa = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenKhoa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoaKhoi", x => x.maKhoa);
                });

            migrationBuilder.CreateTable(
                name: "LichNghi",
                columns: table => new
                {
                    maLich = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenLich = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lyDo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ngayBatDau = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ngayKetThuc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichNghi", x => x.maLich);
                });

            migrationBuilder.CreateTable(
                name: "LoaiDiem",
                columns: table => new
                {
                    maLoaiDiem = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenLoaiDiem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    heSo = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiDiem", x => x.maLoaiDiem);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDung",
                columns: table => new
                {
                    maNguoiDung = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenDangNhap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDung", x => x.maNguoiDung);
                });

            migrationBuilder.CreateTable(
                name: "PhongHoc",
                columns: table => new
                {
                    maPhong = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenPhong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trangThietBi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongHoc", x => x.maPhong);
                });

            migrationBuilder.CreateTable(
                name: "HocPhi",
                columns: table => new
                {
                    maPhieuHocPhi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    mucThuHocPhi = table.Column<double>(type: "float", nullable: false),
                    giamGia = table.Column<double>(type: "float", nullable: false),
                    ghiChu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    maDoanhThuTheoKy = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocPhi", x => x.maPhieuHocPhi);
                    table.ForeignKey(
                        name: "FK_HocPhi_DoanhThu_maDoanhThuTheoKy",
                        column: x => x.maDoanhThuTheoKy,
                        principalTable: "DoanhThu",
                        principalColumn: "maDoanhThuTheoKy",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LienHe",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tinNhan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    maHocVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    KeyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LienHe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LienHe_HocVien_maHocVien",
                        column: x => x.maHocVien,
                        principalTable: "HocVien",
                        principalColumn: "maHocVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ToBoMon",
                columns: table => new
                {
                    maBoMon = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenBoMon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    maKhoa = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToBoMon", x => x.maBoMon);
                    table.ForeignKey(
                        name: "FK_ToBoMon_KhoaKhoi_maKhoa",
                        column: x => x.maKhoa,
                        principalTable: "KhoaKhoi",
                        principalColumn: "maKhoa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LopHoc",
                columns: table => new
                {
                    maLopHoc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soLuongHocVien = table.Column<int>(type: "int", nullable: false),
                    hocPhi = table.Column<int>(type: "int", nullable: false),
                    mota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hinhLopHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    maLich = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHoc", x => x.maLopHoc);
                    table.ForeignKey(
                        name: "FK_LopHoc_LichNghi_maLich",
                        column: x => x.maLich,
                        principalTable: "LichNghi",
                        principalColumn: "maLich",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    maChucVu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenChucVu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    maNguoiDung = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.maChucVu);
                    table.ForeignKey(
                        name: "FK_ChucVu_NguoiDung_maNguoiDung",
                        column: x => x.maNguoiDung,
                        principalTable: "NguoiDung",
                        principalColumn: "maNguoiDung",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoaiHocPhi",
                columns: table => new
                {
                    maLoaiHocPhi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenLoaiHocPhi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    maPhieuHocPhi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiHocPhi", x => x.maLoaiHocPhi);
                    table.ForeignKey(
                        name: "FK_LoaiHocPhi_HocPhi_maPhieuHocPhi",
                        column: x => x.maPhieuHocPhi,
                        principalTable: "HocPhi",
                        principalColumn: "maPhieuHocPhi",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonHoc",
                columns: table => new
                {
                    maMonHoc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenMonHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    maBoMon = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonHoc", x => x.maMonHoc);
                    table.ForeignKey(
                        name: "FK_MonHoc_ToBoMon_maBoMon",
                        column: x => x.maBoMon,
                        principalTable: "ToBoMon",
                        principalColumn: "maBoMon",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HocVien_LopHoc",
                columns: table => new
                {
                    maLopHoc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maHocVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maDiem = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maPhieuHocPhi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocVien_LopHoc", x => new { x.maLopHoc, x.maHocVien });
                    table.ForeignKey(
                        name: "FK_HocVien_LopHoc_BangDiem_maDiem",
                        column: x => x.maDiem,
                        principalTable: "BangDiem",
                        principalColumn: "maDiem",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HocVien_LopHoc_HocPhi_maPhieuHocPhi",
                        column: x => x.maPhieuHocPhi,
                        principalTable: "HocPhi",
                        principalColumn: "maPhieuHocPhi",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HocVien_LopHoc_HocVien_maHocVien",
                        column: x => x.maHocVien,
                        principalTable: "HocVien",
                        principalColumn: "maHocVien",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HocVien_LopHoc_LopHoc_maLopHoc",
                        column: x => x.maLopHoc,
                        principalTable: "LopHoc",
                        principalColumn: "maLopHoc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LichHoc",
                columns: table => new
                {
                    maLichHoc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenLichHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    maLopHoc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichHoc", x => x.maLichHoc);
                    table.ForeignKey(
                        name: "FK_LichHoc_LopHoc_maLopHoc",
                        column: x => x.maLopHoc,
                        principalTable: "LopHoc",
                        principalColumn: "maLopHoc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhongHoc_LopHoc",
                columns: table => new
                {
                    maLopHoc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maPhong = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongHoc_LopHoc", x => new { x.maLopHoc, x.maPhong });
                    table.ForeignKey(
                        name: "FK_PhongHoc_LopHoc_LopHoc_maLopHoc",
                        column: x => x.maLopHoc,
                        principalTable: "LopHoc",
                        principalColumn: "maLopHoc",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhongHoc_LopHoc_PhongHoc_maPhong",
                        column: x => x.maPhong,
                        principalTable: "PhongHoc",
                        principalColumn: "maPhong",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    maNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tenDemVaTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ngaysinh = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    gioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sdt = table.Column<int>(type: "int", nullable: false),
                    diaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    maSoThue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ngayHopTac = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    anhNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    maChucVu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.maNhanVien);
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_maChucVu",
                        column: x => x.maChucVu,
                        principalTable: "ChucVu",
                        principalColumn: "maChucVu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoaiDiem_MonHoc",
                columns: table => new
                {
                    maLoaiDiem = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maMonHoc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    soCotDiem = table.Column<int>(type: "int", nullable: false),
                    soCotDiemBatBuoc = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiDiem_MonHoc", x => new { x.maLoaiDiem, x.maMonHoc });
                    table.ForeignKey(
                        name: "FK_LoaiDiem_MonHoc_LoaiDiem_maLoaiDiem",
                        column: x => x.maLoaiDiem,
                        principalTable: "LoaiDiem",
                        principalColumn: "maLoaiDiem",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoaiDiem_MonHoc_MonHoc_maMonHoc",
                        column: x => x.maMonHoc,
                        principalTable: "MonHoc",
                        principalColumn: "maMonHoc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonHoc_LopHoc",
                columns: table => new
                {
                    maLopHoc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maMonHoc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonHoc_LopHoc", x => new { x.maLopHoc, x.maMonHoc });
                    table.ForeignKey(
                        name: "FK_MonHoc_LopHoc_LopHoc_maLopHoc",
                        column: x => x.maLopHoc,
                        principalTable: "LopHoc",
                        principalColumn: "maLopHoc",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonHoc_LopHoc_MonHoc_maMonHoc",
                        column: x => x.maMonHoc,
                        principalTable: "MonHoc",
                        principalColumn: "maMonHoc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GiangVien",
                columns: table => new
                {
                    maGiangVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    matKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    maNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiangVien", x => x.maGiangVien);
                    table.ForeignKey(
                        name: "FK_GiangVien_NhanVien_maNhanVien",
                        column: x => x.maNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "maNhanVien");
                });

            migrationBuilder.CreateTable(
                name: "KhoaDaoTao",
                columns: table => new
                {
                    maKhoaDaoTao = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenKhoaDaoTao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ngayBatDau = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ngayKetThuc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    maNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoaDaoTao", x => x.maKhoaDaoTao);
                    table.ForeignKey(
                        name: "FK_KhoaDaoTao_NhanVien_maNhanVien",
                        column: x => x.maNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "maNhanVien");
                });

            migrationBuilder.CreateTable(
                name: "TinhLuong",
                columns: table => new
                {
                    maNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    phanTramLuongGiangVien = table.Column<double>(type: "float", nullable: false),
                    thucLanh = table.Column<double>(type: "float", nullable: false),
                    tongLuong = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinhLuong", x => x.maNhanVien);
                    table.ForeignKey(
                        name: "FK_TinhLuong_NhanVien_maNhanVien",
                        column: x => x.maNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "maNhanVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GiangVien_MonHoc",
                columns: table => new
                {
                    maGiangVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maMonHoc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiangVien_MonHoc", x => new { x.maGiangVien, x.maMonHoc });
                    table.ForeignKey(
                        name: "FK_GiangVien_MonHoc_GiangVien_maGiangVien",
                        column: x => x.maGiangVien,
                        principalTable: "GiangVien",
                        principalColumn: "maGiangVien",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GiangVien_MonHoc_MonHoc_maMonHoc",
                        column: x => x.maMonHoc,
                        principalTable: "MonHoc",
                        principalColumn: "maMonHoc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LichGiangDay",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maGiangVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    KeyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichGiangDay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LichGiangDay_GiangVien_maGiangVien",
                        column: x => x.maGiangVien,
                        principalTable: "GiangVien",
                        principalColumn: "maGiangVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhanCongGiangDay",
                columns: table => new
                {
                    maPhanCongGiangDay = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maMonHoc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maLopHoc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maGiangVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    gioBatDauHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gioKetThucHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ngayHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ngayBatDau = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ngayKetThuc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanCongGiangDay", x => new { x.maPhanCongGiangDay, x.maMonHoc, x.maLopHoc, x.maGiangVien });
                    table.ForeignKey(
                        name: "FK_PhanCongGiangDay_GiangVien_maGiangVien",
                        column: x => x.maGiangVien,
                        principalTable: "GiangVien",
                        principalColumn: "maGiangVien",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhanCongGiangDay_LopHoc_maLopHoc",
                        column: x => x.maLopHoc,
                        principalTable: "LopHoc",
                        principalColumn: "maLopHoc",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhanCongGiangDay_MonHoc_maMonHoc",
                        column: x => x.maMonHoc,
                        principalTable: "MonHoc",
                        principalColumn: "maMonHoc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonHoc_KhoaDaoTao",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maKhoaDaoTao = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maMonHoc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    KeyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonHoc_KhoaDaoTao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonHoc_KhoaDaoTao_KhoaDaoTao_maKhoaDaoTao",
                        column: x => x.maKhoaDaoTao,
                        principalTable: "KhoaDaoTao",
                        principalColumn: "maKhoaDaoTao",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonHoc_KhoaDaoTao_MonHoc_maMonHoc",
                        column: x => x.maMonHoc,
                        principalTable: "MonHoc",
                        principalColumn: "maMonHoc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhuCap",
                columns: table => new
                {
                    maPhuCap = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenPhuCap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phiPhuCap = table.Column<double>(type: "float", nullable: false),
                    maNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TinhLuongsmaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhuCap", x => x.maPhuCap);
                    table.ForeignKey(
                        name: "FK_PhuCap_TinhLuong_TinhLuongsmaNhanVien",
                        column: x => x.TinhLuongsmaNhanVien,
                        principalTable: "TinhLuong",
                        principalColumn: "maNhanVien");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChucVu_maNguoiDung",
                table: "ChucVu",
                column: "maNguoiDung");

            migrationBuilder.CreateIndex(
                name: "IX_GiangVien_maNhanVien",
                table: "GiangVien",
                column: "maNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_GiangVien_MonHoc_maMonHoc",
                table: "GiangVien_MonHoc",
                column: "maMonHoc");

            migrationBuilder.CreateIndex(
                name: "IX_HocPhi_maDoanhThuTheoKy",
                table: "HocPhi",
                column: "maDoanhThuTheoKy");

            migrationBuilder.CreateIndex(
                name: "IX_HocVien_LopHoc_maDiem",
                table: "HocVien_LopHoc",
                column: "maDiem");

            migrationBuilder.CreateIndex(
                name: "IX_HocVien_LopHoc_maHocVien",
                table: "HocVien_LopHoc",
                column: "maHocVien");

            migrationBuilder.CreateIndex(
                name: "IX_HocVien_LopHoc_maPhieuHocPhi",
                table: "HocVien_LopHoc",
                column: "maPhieuHocPhi");

            migrationBuilder.CreateIndex(
                name: "IX_KhoaDaoTao_maNhanVien",
                table: "KhoaDaoTao",
                column: "maNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_LichGiangDay_maGiangVien",
                table: "LichGiangDay",
                column: "maGiangVien");

            migrationBuilder.CreateIndex(
                name: "IX_LichHoc_maLopHoc",
                table: "LichHoc",
                column: "maLopHoc");

            migrationBuilder.CreateIndex(
                name: "IX_LienHe_maHocVien",
                table: "LienHe",
                column: "maHocVien");

            migrationBuilder.CreateIndex(
                name: "IX_LoaiDiem_MonHoc_maMonHoc",
                table: "LoaiDiem_MonHoc",
                column: "maMonHoc");

            migrationBuilder.CreateIndex(
                name: "IX_LoaiHocPhi_maPhieuHocPhi",
                table: "LoaiHocPhi",
                column: "maPhieuHocPhi");

            migrationBuilder.CreateIndex(
                name: "IX_LopHoc_maLich",
                table: "LopHoc",
                column: "maLich");

            migrationBuilder.CreateIndex(
                name: "IX_MonHoc_maBoMon",
                table: "MonHoc",
                column: "maBoMon");

            migrationBuilder.CreateIndex(
                name: "IX_MonHoc_KhoaDaoTao_maKhoaDaoTao",
                table: "MonHoc_KhoaDaoTao",
                column: "maKhoaDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_MonHoc_KhoaDaoTao_maMonHoc",
                table: "MonHoc_KhoaDaoTao",
                column: "maMonHoc");

            migrationBuilder.CreateIndex(
                name: "IX_MonHoc_LopHoc_maMonHoc",
                table: "MonHoc_LopHoc",
                column: "maMonHoc");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_maChucVu",
                table: "NhanVien",
                column: "maChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_PhanCongGiangDay_maGiangVien",
                table: "PhanCongGiangDay",
                column: "maGiangVien");

            migrationBuilder.CreateIndex(
                name: "IX_PhanCongGiangDay_maLopHoc",
                table: "PhanCongGiangDay",
                column: "maLopHoc");

            migrationBuilder.CreateIndex(
                name: "IX_PhanCongGiangDay_maMonHoc",
                table: "PhanCongGiangDay",
                column: "maMonHoc");

            migrationBuilder.CreateIndex(
                name: "IX_PhongHoc_LopHoc_maPhong",
                table: "PhongHoc_LopHoc",
                column: "maPhong");

            migrationBuilder.CreateIndex(
                name: "IX_PhuCap_TinhLuongsmaNhanVien",
                table: "PhuCap",
                column: "TinhLuongsmaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_ToBoMon_maKhoa",
                table: "ToBoMon",
                column: "maKhoa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GiangVien_MonHoc");

            migrationBuilder.DropTable(
                name: "HocVien_LopHoc");

            migrationBuilder.DropTable(
                name: "LichGiangDay");

            migrationBuilder.DropTable(
                name: "LichHoc");

            migrationBuilder.DropTable(
                name: "LienHe");

            migrationBuilder.DropTable(
                name: "LoaiDiem_MonHoc");

            migrationBuilder.DropTable(
                name: "LoaiHocPhi");

            migrationBuilder.DropTable(
                name: "MonHoc_KhoaDaoTao");

            migrationBuilder.DropTable(
                name: "MonHoc_LopHoc");

            migrationBuilder.DropTable(
                name: "PhanCongGiangDay");

            migrationBuilder.DropTable(
                name: "PhongHoc_LopHoc");

            migrationBuilder.DropTable(
                name: "PhuCap");

            migrationBuilder.DropTable(
                name: "BangDiem");

            migrationBuilder.DropTable(
                name: "HocVien");

            migrationBuilder.DropTable(
                name: "LoaiDiem");

            migrationBuilder.DropTable(
                name: "HocPhi");

            migrationBuilder.DropTable(
                name: "KhoaDaoTao");

            migrationBuilder.DropTable(
                name: "GiangVien");

            migrationBuilder.DropTable(
                name: "MonHoc");

            migrationBuilder.DropTable(
                name: "LopHoc");

            migrationBuilder.DropTable(
                name: "PhongHoc");

            migrationBuilder.DropTable(
                name: "TinhLuong");

            migrationBuilder.DropTable(
                name: "DoanhThu");

            migrationBuilder.DropTable(
                name: "ToBoMon");

            migrationBuilder.DropTable(
                name: "LichNghi");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "KhoaKhoi");

            migrationBuilder.DropTable(
                name: "ChucVu");

            migrationBuilder.DropTable(
                name: "NguoiDung");
        }
    }
}
