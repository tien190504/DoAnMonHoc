using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DO_AN_LT_WIN.Entities
{
    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }

        public virtual DbSet<Bai_Thi> Bai_Thi { get; set; }
        public virtual DbSet<Cau_Hoi> Cau_Hoi { get; set; }
        public virtual DbSet<Chuong> Chuongs { get; set; }
        public virtual DbSet<CT_Bai_Thi> CT_Bai_Thi { get; set; }
        public virtual DbSet<CT_Giang_Day> CT_Giang_Day { get; set; }
        public virtual DbSet<CT_Mon_Hoc> CT_Mon_Hoc { get; set; }
        public virtual DbSet<Danh_Gia_Cua_Sinh_Vien> Danh_Gia_Cua_Sinh_Vien { get; set; }
        public virtual DbSet<Giang_Vien> Giang_Vien { get; set; }
        public virtual DbSet<Ket_Qua_Thi> Ket_Qua_Thi { get; set; }
        public virtual DbSet<Ky_Thi> Ky_Thi { get; set; }
        public virtual DbSet<Mon_Hoc> Mon_Hoc { get; set; }
        public virtual DbSet<Phuong_An_Chon> Phuong_An_Chon { get; set; }
        public virtual DbSet<Sinh_Vien> Sinh_Vien { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bai_Thi>()
                .Property(e => e.Ma_Bai_Thi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Bai_Thi>()
                .Property(e => e.Ma_Sinh_Vien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Bai_Thi>()
                .Property(e => e.Ma_Ky_Thi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Bai_Thi>()
                .Property(e => e.Ma_Mon_Hoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Bai_Thi>()
                .HasMany(e => e.CT_Bai_Thi)
                .WithRequired(e => e.Bai_Thi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Bai_Thi>()
                .HasMany(e => e.Ket_Qua_Thi)
                .WithRequired(e => e.Bai_Thi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cau_Hoi>()
                .Property(e => e.Ma_Cau_Hoi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cau_Hoi>()
                .Property(e => e.Ma_Chuong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cau_Hoi>()
                .Property(e => e.Phuong_An_Dung)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cau_Hoi>()
                .HasMany(e => e.CT_Bai_Thi)
                .WithRequired(e => e.Cau_Hoi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cau_Hoi>()
                .HasMany(e => e.Phuong_An_Chon)
                .WithRequired(e => e.Cau_Hoi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Chuong>()
                .Property(e => e.Ma_Chuong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Chuong>()
                .Property(e => e.Ma_Mon_Hoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Chuong>()
                .HasMany(e => e.Cau_Hoi)
                .WithRequired(e => e.Chuong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CT_Bai_Thi>()
                .Property(e => e.Ma_Bai_Thi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_Bai_Thi>()
                .Property(e => e.Ma_Cau_Hoi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_Bai_Thi>()
                .Property(e => e.SV_Chon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_Giang_Day>()
                .Property(e => e.Ma_Giang_Vien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_Giang_Day>()
                .Property(e => e.Ma_Mon_Hoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_Mon_Hoc>()
                .Property(e => e.Ma_Ky_Thi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_Mon_Hoc>()
                .Property(e => e.Ma_Mon_Hoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_Mon_Hoc>()
                .HasMany(e => e.Bai_Thi)
                .WithRequired(e => e.CT_Mon_Hoc)
                .HasForeignKey(e => new { e.Ma_Ky_Thi, e.Ma_Mon_Hoc })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Danh_Gia_Cua_Sinh_Vien>()
                .Property(e => e.Ma_Danh_Gia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Danh_Gia_Cua_Sinh_Vien>()
                .Property(e => e.Ma_Ket_Qua)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Giang_Vien>()
                .Property(e => e.Ma_Giang_Vien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Giang_Vien>()
                .HasMany(e => e.CT_Giang_Day)
                .WithRequired(e => e.Giang_Vien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ket_Qua_Thi>()
                .Property(e => e.Ma_Ket_Qua)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Ket_Qua_Thi>()
                .Property(e => e.Ma_Bai_Thi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Ket_Qua_Thi>()
                .HasMany(e => e.Danh_Gia_Cua_Sinh_Vien)
                .WithRequired(e => e.Ket_Qua_Thi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ky_Thi>()
                .Property(e => e.Ma_Ky_Thi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Ky_Thi>()
                .HasMany(e => e.CT_Mon_Hoc)
                .WithRequired(e => e.Ky_Thi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mon_Hoc>()
                .Property(e => e.Ma_Mon_Hoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mon_Hoc>()
                .HasMany(e => e.Chuongs)
                .WithRequired(e => e.Mon_Hoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mon_Hoc>()
                .HasMany(e => e.CT_Giang_Day)
                .WithRequired(e => e.Mon_Hoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mon_Hoc>()
                .HasMany(e => e.CT_Mon_Hoc)
                .WithRequired(e => e.Mon_Hoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phuong_An_Chon>()
                .Property(e => e.Ma_Cau_Hoi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Phuong_An_Chon>()
                .Property(e => e.Phuong_An_Chon1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sinh_Vien>()
                .Property(e => e.Ma_Sinh_Vien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sinh_Vien>()
                .HasMany(e => e.Bai_Thi)
                .WithRequired(e => e.Sinh_Vien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Ma_Sinh_Vien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Ma_Giang_Vien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.So_Dien_Thoai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
