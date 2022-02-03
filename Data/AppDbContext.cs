using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using rainha_rodeio.Models;

#nullable disable

namespace rainha_rodeio.Data
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cidade> Cidades { get; set; }
        public virtual DbSet<Escolaridade> Escolaridades { get; set; }
        public virtual DbSet<Fase> Fases { get; set; }
        public virtual DbSet<FaseJurado> FaseJurados { get; set; }
        public virtual DbSet<Modelo> Modelos { get; set; }
        public virtual DbSet<ModeloArquivo> ModeloArquivos { get; set; }
        public virtual DbSet<ModeloCaracteristica> ModeloCaracteristicas { get; set; }
        public virtual DbSet<ModeloFase> ModeloFases { get; set; }
        public virtual DbSet<ModeloStatus> ModeloStatuses { get; set; }
        public virtual DbSet<Perfil> Perfils { get; set; }
        public virtual DbSet<TipoArquivo> TipoArquivos { get; set; }
        public virtual DbSet<TipoCabelo> TipoCabelos { get; set; }
        public virtual DbSet<TipoComprimentoCabelo> TipoComprimentoCabelos { get; set; }
        public virtual DbSet<TipoCorCabelo> TipoCorCabelos { get; set; }
        public virtual DbSet<TipoCorOlho> TipoCorOlhos { get; set; }
        public virtual DbSet<TipoCorPele> TipoCorPeles { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<VwModelo> VwModelos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=172.16.0.4;DataBase=AmberCute;Uid=ambercute;Pwd=#CXk8nsw@r;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Cidade>(entity =>
            {
                entity.ToTable("Cidade");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Escolaridade>(entity =>
            {
                entity.ToTable("Escolaridade");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Fase>(entity =>
            {
                entity.ToTable("Fase");

                entity.Property(e => e.DataFim).HasColumnType("date");

                entity.Property(e => e.DataInclusao).HasColumnType("datetime");

                entity.Property(e => e.DataInicio).HasColumnType("date");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Observacao).HasMaxLength(2000);
            });

            modelBuilder.Entity<FaseJurado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FaseJurado");

                entity.Property(e => e.DataInclusao).HasColumnType("datetime");
            });

            modelBuilder.Entity<Modelo>(entity =>
            {
                entity.ToTable("Modelo");

                entity.Property(e => e.Bairro).HasMaxLength(100);

                entity.Property(e => e.CaminhoFoto).HasMaxLength(1000);

                entity.Property(e => e.Cpf).HasMaxLength(11);

                entity.Property(e => e.DataInclusao).HasColumnType("datetime");

                entity.Property(e => e.DataNascimento).HasColumnType("date");

                entity.Property(e => e.DataUltimaAlteracao).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.Endereco).HasMaxLength(500);

                entity.Property(e => e.EnderecoNumero).HasMaxLength(10);

                entity.Property(e => e.Foto).HasColumnType("image");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Observacao).HasMaxLength(2000);

                entity.Property(e => e.Rg).HasMaxLength(20);

                entity.HasOne(d => d.IdCidadeNavigation)
                    .WithMany(p => p.Modelos)
                    .HasForeignKey(d => d.IdCidade)
                    .HasConstraintName("FK_Modelo_Cidade");

                entity.HasOne(d => d.IdEscolaridadeNavigation)
                    .WithMany(p => p.Modelos)
                    .HasForeignKey(d => d.IdEscolaridade)
                    .HasConstraintName("FK_Modelo_Escolaridade");
            });

            modelBuilder.Entity<ModeloArquivo>(entity =>
            {
                entity.ToTable("ModeloArquivo");

                entity.Property(e => e.DataInclusao).HasColumnType("datetime");

                entity.HasOne(d => d.IdTipoArquivoNavigation)
                    .WithMany(p => p.ModeloArquivos)
                    .HasForeignKey(d => d.IdTipoArquivo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ModeloArquivo_TipoArquivo");
            });

            modelBuilder.Entity<ModeloCaracteristica>(entity =>
            {
                entity.ToTable("ModeloCaracteristica");

                entity.Property(e => e.Altura).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.MedidaBusto).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.MedidaCintura).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.MedidaQuadril).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.Peso).HasColumnType("numeric(4, 2)");

                entity.HasOne(d => d.IdModeloNavigation)
                    .WithMany(p => p.ModeloCaracteristicas)
                    .HasForeignKey(d => d.IdModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ModeloCaracteristica_Modelo");

                entity.HasOne(d => d.IdTipoCabeloNavigation)
                    .WithMany(p => p.ModeloCaracteristicas)
                    .HasForeignKey(d => d.IdTipoCabelo)
                    .HasConstraintName("FK_ModeloCaracteristica_TipoCabelo");

                entity.HasOne(d => d.IdTipoComprimentoCabeloNavigation)
                    .WithMany(p => p.ModeloCaracteristicas)
                    .HasForeignKey(d => d.IdTipoComprimentoCabelo)
                    .HasConstraintName("FK_ModeloCaracteristica_TipoComprimentoCabelo");

                entity.HasOne(d => d.IdTipoCorCabeloNavigation)
                    .WithMany(p => p.ModeloCaracteristicas)
                    .HasForeignKey(d => d.IdTipoCorCabelo)
                    .HasConstraintName("FK_ModeloCaracteristica_TipoCorCabelo");

                entity.HasOne(d => d.IdTipoCorOlhoNavigation)
                    .WithMany(p => p.ModeloCaracteristicas)
                    .HasForeignKey(d => d.IdTipoCorOlho)
                    .HasConstraintName("FK_ModeloCaracteristica_ModeloCaracteristica");

                entity.HasOne(d => d.IdTipoCorPeleNavigation)
                    .WithMany(p => p.ModeloCaracteristicas)
                    .HasForeignKey(d => d.IdTipoCorPele)
                    .HasConstraintName("FK_ModeloCaracteristica_TipoCorPele");
            });

            modelBuilder.Entity<ModeloFase>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ModeloFase");

                entity.Property(e => e.DataInclusado).HasColumnType("datetime");

                entity.HasOne(d => d.IdFaseNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdFase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ModeloFase_Fase");

                entity.HasOne(d => d.IdModeloNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ModeloFase_Modelo");

                entity.HasOne(d => d.IdModeloStatusNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdModeloStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ModeloFase_ModeloStatus");
            });

            modelBuilder.Entity<ModeloStatus>(entity =>
            {
                entity.ToTable("ModeloStatus");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Perfil>(entity =>
            {
                entity.ToTable("Perfil");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TipoArquivo>(entity =>
            {
                entity.ToTable("TipoArquivo");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TipoCabelo>(entity =>
            {
                entity.ToTable("TipoCabelo");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TipoComprimentoCabelo>(entity =>
            {
                entity.ToTable("TipoComprimentoCabelo");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TipoCorCabelo>(entity =>
            {
                entity.ToTable("TipoCorCabelo");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TipoCorOlho>(entity =>
            {
                entity.ToTable("TipoCorOlho");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TipoCorPele>(entity =>
            {
                entity.ToTable("TipoCorPele");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("Usuario");

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasMaxLength(11);

                entity.Property(e => e.DataInclusao).HasColumnType("datetime");

                entity.Property(e => e.DataUltimaAlteracao).HasColumnType("datetime");

                entity.Property(e => e.DataUltimoLogin).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Foto).HasColumnType("image");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuario_Perfil");
            });

            modelBuilder.Entity<VwModelo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwModelo");

                entity.Property(e => e.Altura).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.Bairro).HasMaxLength(100);

                entity.Property(e => e.CaminhoFoto).HasMaxLength(1000);

                entity.Property(e => e.Cpf).HasMaxLength(11);

                entity.Property(e => e.DataInclusao).HasColumnType("datetime");

                entity.Property(e => e.DataNascimento).HasColumnType("date");

                entity.Property(e => e.DataUltimaAlteracao).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.Endereco).HasMaxLength(500);

                entity.Property(e => e.EnderecoNumero).HasMaxLength(10);

                entity.Property(e => e.Foto).HasColumnType("image");

                entity.Property(e => e.MedidaBusto).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.MedidaCintura).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.MedidaQuadril).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.NomeCidade).HasMaxLength(50);

                entity.Property(e => e.NomeEscolaridade).HasMaxLength(100);

                entity.Property(e => e.NomeTipoCabelo).HasMaxLength(50);

                entity.Property(e => e.NomeTipoComprimentoCabelo).HasMaxLength(50);

                entity.Property(e => e.NomeTipoCorCabelo).HasMaxLength(50);

                entity.Property(e => e.NomeTipoCorOlho).HasMaxLength(50);

                entity.Property(e => e.NomeTipoCorPele).HasMaxLength(50);

                entity.Property(e => e.Observacao).HasMaxLength(2000);

                entity.Property(e => e.Peso).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.Rg).HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
