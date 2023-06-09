﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1_DAL.QuanLyDBContext;

#nullable disable

namespace _1_DAL.Migrations
{
    [DbContext(typeof(QuanLyDatabaseContext))]
    partial class QuanLyDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_1_DAL.Entities.DichVu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoaiDichVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("dichVus");
                });

            modelBuilder.Entity("_1_DAL.Entities.HangDT", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("hangDTs");
                });

            modelBuilder.Entity("_1_DAL.Entities.HoaDon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("KhachHangId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("NhanVienId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("KhachHangId");

                    b.HasIndex("NhanVienId");

                    b.ToTable("hoaDons");
                });

            modelBuilder.Entity("_1_DAL.Entities.HoaDonCT", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DichVuId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HoaDonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("IntoMoney")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("KhuyenMaiId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("SanPhamId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DichVuId");

                    b.HasIndex("HoaDonId");

                    b.HasIndex("KhuyenMaiId");

                    b.HasIndex("SanPhamId");

                    b.ToTable("hoaDonCTs");
                });

            modelBuilder.Entity("_1_DAL.Entities.KhachHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Point")
                        .HasColumnType("int");

                    b.Property<bool>("Sex")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("_1_DAL.Entities.KhuyenMai", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ChiSo")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("khuyenMais");
                });

            modelBuilder.Entity("_1_DAL.Entities.LoaiDT", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("loaiDTs");
                });

            modelBuilder.Entity("_1_DAL.Entities.NhaCungCap", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("nhaCungCaps");
                });

            modelBuilder.Entity("_1_DAL.Entities.NhaCungCapCT", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("NhaCungCapId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SanPhamId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("NhaCungCapId");

                    b.HasIndex("SanPhamId");

                    b.ToTable("nhaCungCapCTs");
                });

            modelBuilder.Entity("_1_DAL.Entities.NhanVien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("LinkImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Sex")
                        .HasColumnType("bit");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("nhanViens");
                });

            modelBuilder.Entity("_1_DAL.Entities.SanPham", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descriptions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("HangDTId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("ImportPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("KhuyenMaiId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LinkAnh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("LoaiDTId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("NhaCungCapCTId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HangDTId");

                    b.HasIndex("LoaiDTId");

                    b.ToTable("sanPhams");
                });

            modelBuilder.Entity("_1_DAL.Entities.HoaDon", b =>
                {
                    b.HasOne("_1_DAL.Entities.KhachHang", "KhachHang")
                        .WithMany("HoaDons")
                        .HasForeignKey("KhachHangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL.Entities.NhanVien", "NhanVien")
                        .WithMany("HoaDons")
                        .HasForeignKey("NhanVienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("_1_DAL.Entities.HoaDonCT", b =>
                {
                    b.HasOne("_1_DAL.Entities.DichVu", "DichVu")
                        .WithMany("HoaDonCTs")
                        .HasForeignKey("DichVuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL.Entities.HoaDon", "HoaDon")
                        .WithMany("HoaDonCTs")
                        .HasForeignKey("HoaDonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL.Entities.KhuyenMai", "KhuyenMai")
                        .WithMany("HoaDonCTs")
                        .HasForeignKey("KhuyenMaiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL.Entities.SanPham", "SanPham")
                        .WithMany("HoaDonCTs")
                        .HasForeignKey("SanPhamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DichVu");

                    b.Navigation("HoaDon");

                    b.Navigation("KhuyenMai");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("_1_DAL.Entities.NhaCungCapCT", b =>
                {
                    b.HasOne("_1_DAL.Entities.NhaCungCap", "NhaCungCap")
                        .WithMany("NhaCungCapCTs")
                        .HasForeignKey("NhaCungCapId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL.Entities.SanPham", "SanPham")
                        .WithMany("NhaCungCapCTs")
                        .HasForeignKey("SanPhamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhaCungCap");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("_1_DAL.Entities.SanPham", b =>
                {
                    b.HasOne("_1_DAL.Entities.HangDT", "HangDT")
                        .WithMany("SanPhams")
                        .HasForeignKey("HangDTId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL.Entities.LoaiDT", "LoaiDT")
                        .WithMany("SanPhams")
                        .HasForeignKey("LoaiDTId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HangDT");

                    b.Navigation("LoaiDT");
                });

            modelBuilder.Entity("_1_DAL.Entities.DichVu", b =>
                {
                    b.Navigation("HoaDonCTs");
                });

            modelBuilder.Entity("_1_DAL.Entities.HangDT", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("_1_DAL.Entities.HoaDon", b =>
                {
                    b.Navigation("HoaDonCTs");
                });

            modelBuilder.Entity("_1_DAL.Entities.KhachHang", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1_DAL.Entities.KhuyenMai", b =>
                {
                    b.Navigation("HoaDonCTs");
                });

            modelBuilder.Entity("_1_DAL.Entities.LoaiDT", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("_1_DAL.Entities.NhaCungCap", b =>
                {
                    b.Navigation("NhaCungCapCTs");
                });

            modelBuilder.Entity("_1_DAL.Entities.NhanVien", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1_DAL.Entities.SanPham", b =>
                {
                    b.Navigation("HoaDonCTs");

                    b.Navigation("NhaCungCapCTs");
                });
#pragma warning restore 612, 618
        }
    }
}
