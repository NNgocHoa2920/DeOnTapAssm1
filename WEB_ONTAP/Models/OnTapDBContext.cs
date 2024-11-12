using Microsoft.EntityFrameworkCore;
using System;

namespace WEB_ONTAP.Models
{
    //đại diện cho csdl
    public class OnTapDBContext : DbContext
    {
        public OnTapDBContext()
        {
            
        }

        public OnTapDBContext(DbContextOptions options) : base(options)
        {
        }

        //TẠO CÁC DBSET
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<DuAn> DuAns { get; set; }
        public DbSet<DACT> DACTs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NGUYEN_NGOC_HOA\\HOANN; Database=OnTapASM1;Trusted_Connection= True;" +
"TrustServerCertificate=True");
        }
        //có thể config fulent api ở đây bằng cách

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NhanVien>().HasKey(x => x.Id);
           
            modelBuilder.Entity<DuAn>().HasKey(x => x.MaDA);
            
            modelBuilder.Entity<DACT>().HasKey(x => x.Id);
            //modelBuilder.Entity<DACT>()
            //    .HasKey(x => new { x.NhanVienID, x.DuAnID });
                
            modelBuilder.Entity<DACT>()
                .HasOne<NhanVien>(x => x.NhanVien)
                .WithMany(x => x.DACTs)
                .HasForeignKey(x=>x.NhanVienID);

            modelBuilder.Entity<DACT>()
               .HasOne<DuAn>(x => x.DuAn)
               .WithMany(x => x.DACTs)
               .HasForeignKey(x=>x.DuAnID);



        }




    }
}
