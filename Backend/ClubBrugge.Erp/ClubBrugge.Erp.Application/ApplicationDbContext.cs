using ClubBrugge.Erp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubBrugge.Erp.Application
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .EnableSensitiveDataLogging()
                .UseSqlServer("Server=LAPTOP-0TJPAPHV;Database=JupilerProLeagueDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AwayTeam>()
                .HasKey(a => a.Id);

            modelBuilder.Entity<AwayTeam>()
                .HasOne(a => a.Country)
                .WithMany(c => c.AwayTeams)
                .HasForeignKey(a => a.CountryId);

            modelBuilder.Entity<Competition>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<CompetitionStage>()
                .HasKey(cs => cs.Id);

            modelBuilder.Entity<CompetitionStage>()
                .HasMany(cs => cs.Matches)
                .WithOne(m => m.CompetitionStage)
                .HasForeignKey(m => m.CompetitionStageId);

            modelBuilder.Entity<Country>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<HomeTeam>()
                .HasKey(h => h.Id);

            modelBuilder.Entity<HomeTeam>()
                .HasOne(h => h.Country)
                .WithMany(c => c.HomeTeams)
                .HasForeignKey(h => h.CountryId);

            modelBuilder.Entity<Manager>()
                .HasKey(m => m.Id);

            modelBuilder.Entity<Manager>()
                .HasOne(m => m.Country)
                .WithMany(c => c.Managers)
                .HasForeignKey(m => m.CountryId);

            modelBuilder.Entity<Match>()
                .HasKey(m => m.Id);

            modelBuilder.Entity<Match>()
                .HasOne(m => m.Competition)
                .WithMany(c => c.Matches)
                .HasForeignKey(m => m.CompetitionId)
                    .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Match>()
                .HasOne(m => m.Season)
                .WithMany(s => s.Matches)
                .HasForeignKey(m => m.SeasonId);

            modelBuilder.Entity<Match>()
                .HasOne(m => m.HomeTeam)
                .WithMany(h => h.HomeMatches)
                .HasForeignKey(m => m.HomeTeamId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Match>()
                .HasOne(m => m.AwayTeam)
                .WithMany(a => a.AwayMatches)
                .HasForeignKey(m => m.AwayTeamId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Match>()
                .HasOne(m => m.CompetitionStage)
                .WithMany(cs => cs.Matches)
                .HasForeignKey(m => m.CompetitionStageId);

            modelBuilder.Entity<Match>()
                .HasOne(m => m.Stadium)
                .WithMany(s => s.Matches)
                .HasForeignKey(m => m.StadiumId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Match>()
                .HasOne(m => m.Referee)
                .WithMany(r => r.Matches)
                .HasForeignKey(m => m.RefereeId);

            modelBuilder.Entity<Referee>()
                .HasKey(r => r.Id);

            modelBuilder.Entity<Referee>()
                .HasOne(r => r.Country)
                .WithMany(c => c.Referees)
                .HasForeignKey(r => r.CountryId);

            modelBuilder.Entity<Season>()
                .HasKey(s => s.Id);

            modelBuilder.Entity<Stadium>()
                .HasKey(s => s.Id);

            modelBuilder.Entity<Stadium>()
                .HasOne(s => s.Country)
                .WithMany(c => c.Stadiums)
                .HasForeignKey(s => s.CountryId);

            modelBuilder.Entity<MatchPlayerStats>()
              .HasKey(s => s.Id);
        }

        public DbSet<Match> Matches { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Manager> Managers { get; set; }

        public DbSet<AwayTeam> AwayTeams { get; set; }
        public DbSet<HomeTeam> HomeTeams { get; set; }

        public DbSet<Country> Countries { get; set; }
        public DbSet<CompetitionStage> CompetitionStages { get; set; }
        public DbSet<Stadium> Stadiums { get; set; }
        public DbSet<Referee> Referees { get; set; }
        public DbSet<MatchPlayerStats> MatchPlayerStats { get; set; }
    }
}