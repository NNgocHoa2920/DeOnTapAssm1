using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WEB_ONTAP.Models;

namespace WEB_ONTAP.Configuration
{
    public class NhanVienConfig : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            //KHÓA CHÍNH
           // builder.HasKey(x => x.Id);
        }
    }
}
