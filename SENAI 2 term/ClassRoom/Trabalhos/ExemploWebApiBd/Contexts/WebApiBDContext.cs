using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ExemploWebApiBd.Domains;

namespace ExemploWebApiBd.Contexts
{
    public partial class WebApiBDContext : DbContext
    {
        public WebApiBDContext()
        {
        }

        public WebApiBDContext(DbContextOptions<WebApiBDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Jogador> Jogador { get; set; }
        public virtual DbSet<Selecao> Selecao { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=WebApiBD; Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jogador>(entity =>
            {
                entity.Property(e => e.Foto).HasColumnType("image");

                entity.Property(e => e.Informacoes)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Nascimento).HasColumnType("datetime");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Posicao)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.QtdecartoesAmarelo).HasColumnName("QTDECartoesAmarelo");

                entity.Property(e => e.QtdecartoesVermelho).HasColumnName("QTDECartoesVermelho");

                entity.Property(e => e.Qtdefaltas).HasColumnName("QTDEFaltas");

                entity.Property(e => e.SelecaoId).HasColumnName("SelecaoID");

                entity.HasOne(d => d.Selecao)
                    .WithMany(p => p.Jogador)
                    .HasForeignKey(d => d.SelecaoId)
                    .HasConstraintName("FK__Jogador__Selecao__29572725");
            });

            modelBuilder.Entity<Selecao>(entity =>
            {
                entity.Property(e => e.Bandeira).HasColumnType("image");

                entity.Property(e => e.Escalacao)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Uniforme).HasColumnType("image");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
