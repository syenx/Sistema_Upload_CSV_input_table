using System.Data.Entity.ModelConfiguration;
using OP.PortalOncoprod.Infra.CrossCutting.Logging.Model;

namespace OP.PortalOncoprod.Infra.CrossCutting.Logging.Data
{
    public class AuditoriaConfig : EntityTypeConfiguration<Auditoria>
    {
        public AuditoriaConfig()
        {
            HasKey(a => a.LogId);

            Property(a => a.Sistema)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(150);

            Property(a => a.Acao)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(1000);

            Property(a => a.IP)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(20);

            Property(a => a.UserId)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(150);

            ToTable("LogAuditoria");
        }
    }
}