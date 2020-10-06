using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManager.Domain.Entities;

namespace TaskManager.Infra.Mappings
{
    public class TaskMapping : IEntityTypeConfiguration<Tasks>
    {
        public void Configure(EntityTypeBuilder<Tasks> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnType("int");
            builder.Property(e => e.Title).HasColumnType("varchar(20)").IsRequired();
            builder.Property(e => e.Description).HasColumnType("varchar(30)").IsRequired();
            builder.Property<bool>(e => e.Status).IsRequired();
        }
    }
}
