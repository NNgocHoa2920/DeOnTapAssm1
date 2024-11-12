using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WEB_ONTAP.Models;

namespace WEB_ONTAP.Configuration
{
    public class DACTConfig : IEntityTypeConfiguration<DACT>
    {
        public void Configure(EntityTypeBuilder<DACT> builder)
        {
            //builder.HasKey(X => X.Id);

            ////CẤU HÌNH 1-N 
            ////1 NHANVIEN - N DACT
            //builder.HasOne<NhanVien>(x => x.NhanVien)
            //    .WithMany(x => x.DACTs)
            //    .HasForeignKey(x => x.NhanVienID);

            ////1 dự án - N DACT
            //builder.HasOne<DuAn>(x => x.DuAn)
            //    .WithMany(x => x.DACTs)
            //    .HasForeignKey(x => x.DuAnID);
        }
    }
}
