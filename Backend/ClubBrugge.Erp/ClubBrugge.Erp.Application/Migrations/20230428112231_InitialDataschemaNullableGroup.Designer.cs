﻿// <auto-generated />
using System;
using ClubBrugge.Erp.Application;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClubBrugge.Erp.Application.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230428112231_InitialDataschemaNullableGroup")]
    partial class InitialDataschemaNullableGroup
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ClubBrugge.Erp.Domain.Entities.AwayTeam", b =>
                {
                    b.Property<int>("AwayTeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AwayTeamId"), 1L, 1);

                    b.Property<string>("AwayTeamGender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AwayTeamGroup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AwayTeamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AwayTeamYouth")
                        .HasColumnType("bit");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.HasKey("AwayTeamId");

                    b.HasIndex("CountryId");

                    b.ToTable("AwayTeams");
                });

            modelBuilder.Entity("ClubBrugge.Erp.Domain.Entities.Competition", b =>
                {
                    b.Property<int>("CompetitionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompetitionId"), 1L, 1);

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompetitionId");

                    b.HasIndex("CountryId");

                    b.ToTable("Competitions");
                });

            modelBuilder.Entity("ClubBrugge.Erp.Domain.Entities.CompetitionStage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CompetitionStages");
                });

            modelBuilder.Entity("ClubBrugge.Erp.Domain.Entities.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("ClubBrugge.Erp.Domain.Entities.HomeTeam", b =>
                {
                    b.Property<int>("HomeTeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HomeTeamId"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("HomeTeamGender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeTeamGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeTeamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HomeTeamYouth")
                        .HasColumnType("bit");

                    b.HasKey("HomeTeamId");

                    b.HasIndex("CountryId");

                    b.ToTable("HomeTeams");
                });

            modelBuilder.Entity("ClubBrugge.Erp.Domain.Entities.Manager", b =>
                {
                    b.Property<int>("ManagerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ManagerId"), 1L, 1);

                    b.Property<int?>("AwayTeamId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HomeTeamId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ManagerId");

                    b.HasIndex("AwayTeamId");

                    b.HasIndex("CountryId");

                    b.HasIndex("HomeTeamId");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("ClubBrugge.Erp.Domain.Entities.Match", b =>
                {
                    b.Property<int>("MatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MatchId"), 1L, 1);

                    b.Property<int?>("Attendance")
                        .HasColumnType("int");

                    b.Property<int>("AwayScore")
                        .HasColumnType("int");

                    b.Property<int>("AwayTeamId")
                        .HasColumnType("int");

                    b.Property<bool>("BehindClosedDoors")
                        .HasColumnType("bit");

                    b.Property<int>("CompetitionId")
                        .HasColumnType("int");

                    b.Property<int>("CompetitionStageId")
                        .HasColumnType("int");

                    b.Property<int>("HomeScore")
                        .HasColumnType("int");

                    b.Property<int>("HomeTeamId")
                        .HasColumnType("int");

                    b.Property<string>("KickOff")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastUpdated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastUpdated360")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatchDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatchStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatchStatus360")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("NeutralGround")
                        .HasColumnType("bit");

                    b.Property<string>("PlayStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RefereeId")
                        .HasColumnType("int");

                    b.Property<int>("SeasonId")
                        .HasColumnType("int");

                    b.Property<int>("StadiumId")
                        .HasColumnType("int");

                    b.HasKey("MatchId");

                    b.HasIndex("AwayTeamId");

                    b.HasIndex("CompetitionId");

                    b.HasIndex("CompetitionStageId");

                    b.HasIndex("HomeTeamId");

                    b.HasIndex("RefereeId");

                    b.HasIndex("SeasonId");

                    b.HasIndex("StadiumId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("ClubBrugge.Erp.Domain.Entities.Referee", b =>
                {
                    b.Property<int>("RefereeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RefereeId"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RefereeId");

                    b.HasIndex("CountryId");

                    b.ToTable("Referees");
                });

            modelBuilder.Entity("ClubBrugge.Erp.Domain.Entities.Season", b =>
                {
                    b.Property<int>("SeasonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SeasonId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SeasonId");

                    b.ToTable("Seasons");
                });

            modelBuilder.Entity("ClubBrugge.Erp.Domain.Entities.Stadium", b =>
                {
                    b.Property<int>("StadiumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StadiumId"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StadiumId");

                    b.HasIndex("CountryId");

                    b.ToTable("Stadiums");
                });

            modelBuilder.Entity("ClubBrugge.Erp.Domain.Entities.AwayTeam", b =>
                {
                    b.HasOne("ClubBrugge.Erp.Domain.Entities.Country", "Country")
                        .WithMany("AwayTeams")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("ClubBrugge.Erp.Domain.Entities.Competition", b =>
                {
                    b.HasOne("ClubBrugge.Erp.Domain.Entities.Country", null)
                        .WithMany("Competitions")
                        .HasForeignKey("CountryId");
                });

            modelBuilder.Entity("ClubBrugge.Erp.Domain.Entities.HomeTeam", b =>
                {
                    b.HasOne("ClubBrugge.Erp.Domain.Entities.Country", "Country")
                        .WithMany("HomeTeams")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("ClubBrugge.Erp.Domain.Entities.Manager", b =>
                {
                    b.HasOne("ClubBrugge.Erp.Domain.Entities.AwayTeam", null)
                        .WithMany("AwayTeamManagers")
                        .HasForeignKey("AwayTeamId");

                    b.HasOne("ClubBrugge.Erp.Domain.Entities.Country", "Country")
                        .WithMany("Managers")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClubBrugge.Erp.Domain.Entities.HomeTeam", null)
                        .WithMany("HomeTeamManagers")
                        .HasForeignKey("HomeTeamId");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("ClubBrugge.Erp.Domain.Entities.Match", b =>
                {
                    b.HasOne("ClubBrugge.Erp.Domain.Entities.AwayTeam", "AwayTeam")
                        .WithMany("AwayMatches")
                        .HasForeignKey("AwayTeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ClubBrugge.Erp.Domain.Entities.Competition", "Competition")
                        .WithMany("Matches")
                        .HasForeignKey("CompetitionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ClubBrugge.Erp.Domain.Entities.CompetitionStage", "CompetitionStage")
                        .WithMany("Matches")
                        .HasForeignKey("CompetitionStageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClubBrugge.Erp.Domain.Entities.HomeTeam", "HomeTeam")
                        .WithMany("HomeMatches")
                        .HasForeignKey("HomeTeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ClubBrugge.Erp.Domain.Entities.Referee", "Referee")
                        .WithMany("Matches")
                        .HasForeignKey("RefereeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClubBrugge.Erp.Domain.Entities.Season", "Season")
                        .WithMany("Matches")
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClubBrugge.Erp.Domain.Entities.Stadium", "Stadium")
                        .WithMany("Matches")
                        .HasForeignKey("StadiumId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AwayTeam");

                    b.Navigation("Competition");

                    b.Navigation("CompetitionStage");

                    b.Navigation("HomeTeam");

                    b.Navigation("Referee");

                    b.Navigation("Season");

                    b.Navigation("Stadium");
                });

            modelBuilder.Entity("ClubBrugge.Erp.Domain.Entities.Referee", b =>
                {
                    b.HasOne("ClubBrugge.Erp.Domain.Entities.Country", "Country")
                        .WithMany("Referees")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("ClubBrugge.Erp.Domain.Entities.Stadium", b =>
                {
                    b.HasOne("ClubBrugge.Erp.Domain.Entities.Country", "Country")
                        .WithMany("Stadiums")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("ClubBrugge.Erp.Domain.Entities.AwayTeam", b =>
                {
                    b.Navigation("AwayMatches");

                    b.Navigation("AwayTeamManagers");
                });

            modelBuilder.Entity("ClubBrugge.Erp.Domain.Entities.Competition", b =>
                {
                    b.Navigation("Matches");
                });

            modelBuilder.Entity("ClubBrugge.Erp.Domain.Entities.CompetitionStage", b =>
                {
                    b.Navigation("Matches");
                });

            modelBuilder.Entity("ClubBrugge.Erp.Domain.Entities.Country", b =>
                {
                    b.Navigation("AwayTeams");

                    b.Navigation("Competitions");

                    b.Navigation("HomeTeams");

                    b.Navigation("Managers");

                    b.Navigation("Referees");

                    b.Navigation("Stadiums");
                });

            modelBuilder.Entity("ClubBrugge.Erp.Domain.Entities.HomeTeam", b =>
                {
                    b.Navigation("HomeMatches");

                    b.Navigation("HomeTeamManagers");
                });

            modelBuilder.Entity("ClubBrugge.Erp.Domain.Entities.Referee", b =>
                {
                    b.Navigation("Matches");
                });

            modelBuilder.Entity("ClubBrugge.Erp.Domain.Entities.Season", b =>
                {
                    b.Navigation("Matches");
                });

            modelBuilder.Entity("ClubBrugge.Erp.Domain.Entities.Stadium", b =>
                {
                    b.Navigation("Matches");
                });
#pragma warning restore 612, 618
        }
    }
}
