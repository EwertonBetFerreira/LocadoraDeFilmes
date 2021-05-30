using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoLocadora.Domain.Features.Filmes;
using VideoLocadora.Domain.Features.Generos;
using VideoLocadora.Domain.Features.Locacoes;

namespace VideoLocadoraRepository.Features.Filmes
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Locacao> Locacoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Definicoes das regras de criacao do banco de dados
            modelBuilder.Entity<Filme>()
                .Property(p => p.Nome)
                .HasMaxLength(200).IsRequired();

            //modelBuilder.Entity<Filme>()
            //    .HasKey(p => new { p.Id });

            modelBuilder.Entity<Genero>()
                .Property(p => p.Nome)
                .HasMaxLength(100).IsRequired();

            modelBuilder.Entity<Locacao>()
                .Property(p => p.ListaFilmes)
                .IsRequired();

            modelBuilder.Entity<Locacao>()
                .Property(p => p.CPFCliente)
                .HasMaxLength(14).IsRequired();

            modelBuilder.Entity<Locacao>()
                .Property(p => p.DataLocacao)
                .IsRequired();

            modelBuilder.Entity<Filme>()
                .HasData(
                    new Filme { Id = 1, Nome = "Filme1", DataCriacao = DateTime.Now, Ativo = 1, Genero = "Terror" },
                    new Filme { Id = 2, Nome = "Filme2", DataCriacao = DateTime.Now, Ativo = 1, Genero = "Comedia" },
                    new Filme { Id = 3, Nome = "Filme3", DataCriacao = DateTime.Now, Ativo = 0, Genero = "Aventura"},
                    new Filme { Id = 4, Nome = "Filme4", DataCriacao = DateTime.Now, Ativo = 0, Genero = "Ficcao"},
                    new Filme { Id = 5, Nome = "Filme5", DataCriacao = DateTime.Now, Ativo = 1, Genero = "Romance"});

            modelBuilder.Entity<Genero>()
                .HasData(
                    new Genero { Id = 1, Nome = "Terror", DataCriacao = DateTime.Now, Ativo = 1},
                    new Genero { Id = 2, Nome = "Comedia", DataCriacao = DateTime.Now, Ativo = 1},
                    new Genero { Id = 3, Nome = "Aventura", DataCriacao = DateTime.Now, Ativo = 0},
                    new Genero { Id = 4, Nome = "Ficcao", DataCriacao = DateTime.Now, Ativo = 0},
                    new Genero { Id = 5, Nome = "Romance", DataCriacao = DateTime.Now, Ativo = 1});

            modelBuilder.Entity<Locacao>()
                .HasData(
                    new Locacao { Id = 1, ListaFilmes = "Filme 1, Filme 2, Filme 3", CPFCliente = "69874521830", DataLocacao = DateTime.Now },
                    new Locacao { Id = 2, ListaFilmes = "Filme 1", CPFCliente = "12457865420", DataLocacao = DateTime.Now },
                    new Locacao { Id = 3, ListaFilmes = "Filme 2, Filme 3", CPFCliente = "98563258741", DataLocacao = DateTime.Now },
                    new Locacao { Id = 4, ListaFilmes = "Filme 3", CPFCliente = "98633365792", DataLocacao = DateTime.Now },
                    new Locacao { Id = 5, ListaFilmes = "Filme 5, Filme 6", CPFCliente = "11478569831", DataLocacao = DateTime.Now });
        }
    }
}
