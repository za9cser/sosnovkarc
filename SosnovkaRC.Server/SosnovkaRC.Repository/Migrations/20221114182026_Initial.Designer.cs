﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SosnovkaRC.Repository;

#nullable disable

namespace SosnovkaRC.Repository.Migrations
{
    [DbContext(typeof(SosnovkaContext))]
    [Migration("20221114182026_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("SosnovkaRC.Domain.Models.Athletes.Athlete", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Bio")
                        .HasColumnType("text");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime>("JoiningDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime?>("LeavingDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Athletes");
                });

            modelBuilder.Entity("SosnovkaRC.Domain.Models.Athletes.AthleteIdentifier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int>("AthleteId")
                        .HasColumnType("integer");

                    b.Property<string>("Identifier")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PlatformId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AthleteId");

                    b.HasIndex("PlatformId");

                    b.ToTable("AthleteIdentifiers");
                });

            modelBuilder.Entity("SosnovkaRC.Domain.Models.Platforms.Platform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Platforms");
                });

            modelBuilder.Entity("SosnovkaRC.Domain.Models.Races.Competition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("CityId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Competitions");
                });

            modelBuilder.Entity("SosnovkaRC.Domain.Models.Races.Race", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int>("CompetitionId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.HasIndex("CompetitionId");

                    b.ToTable("Races");
                });

            modelBuilder.Entity("SosnovkaRC.Domain.Models.Races.Result", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int?>("AthleteId")
                        .HasColumnType("integer");

                    b.Property<double>("FinishDistance")
                        .HasColumnType("double precision");

                    b.Property<TimeSpan>("FinishTime")
                        .HasColumnType("interval");

                    b.Property<int>("RunId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AthleteId");

                    b.HasIndex("RunId");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("SosnovkaRC.Domain.Models.Races.Run", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<double>("Distance")
                        .HasColumnType("double precision");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("interval");

                    b.Property<double?>("FactDistance")
                        .HasColumnType("double precision");

                    b.Property<bool>("IsDistanceRun")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsOutdoor")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("RaceId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RaceId");

                    b.ToTable("Runs");
                });

            modelBuilder.Entity("SosnovkaRC.Domain.Models.Races.Split", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int>("ResultId")
                        .HasColumnType("integer");

                    b.Property<double>("SplitDistance")
                        .HasColumnType("double precision");

                    b.Property<TimeSpan>("SplitTime")
                        .HasColumnType("interval");

                    b.HasKey("Id");

                    b.HasIndex("ResultId");

                    b.ToTable("Splits");
                });

            modelBuilder.Entity("SosnovkaRC.Domain.Models.Athletes.AthleteIdentifier", b =>
                {
                    b.HasOne("SosnovkaRC.Domain.Models.Athletes.Athlete", "Athlete")
                        .WithMany("Identifiers")
                        .HasForeignKey("AthleteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SosnovkaRC.Domain.Models.Platforms.Platform", "Platform")
                        .WithMany()
                        .HasForeignKey("PlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Athlete");

                    b.Navigation("Platform");
                });

            modelBuilder.Entity("SosnovkaRC.Domain.Models.Races.Race", b =>
                {
                    b.HasOne("SosnovkaRC.Domain.Models.Races.Competition", "Competition")
                        .WithMany("Races")
                        .HasForeignKey("CompetitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Competition");
                });

            modelBuilder.Entity("SosnovkaRC.Domain.Models.Races.Result", b =>
                {
                    b.HasOne("SosnovkaRC.Domain.Models.Athletes.Athlete", null)
                        .WithMany("Results")
                        .HasForeignKey("AthleteId");

                    b.HasOne("SosnovkaRC.Domain.Models.Races.Run", "Run")
                        .WithMany("Results")
                        .HasForeignKey("RunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Run");
                });

            modelBuilder.Entity("SosnovkaRC.Domain.Models.Races.Run", b =>
                {
                    b.HasOne("SosnovkaRC.Domain.Models.Races.Race", "Race")
                        .WithMany("Runs")
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Race");
                });

            modelBuilder.Entity("SosnovkaRC.Domain.Models.Races.Split", b =>
                {
                    b.HasOne("SosnovkaRC.Domain.Models.Races.Result", "Result")
                        .WithMany("Splits")
                        .HasForeignKey("ResultId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Result");
                });

            modelBuilder.Entity("SosnovkaRC.Domain.Models.Athletes.Athlete", b =>
                {
                    b.Navigation("Identifiers");

                    b.Navigation("Results");
                });

            modelBuilder.Entity("SosnovkaRC.Domain.Models.Races.Competition", b =>
                {
                    b.Navigation("Races");
                });

            modelBuilder.Entity("SosnovkaRC.Domain.Models.Races.Race", b =>
                {
                    b.Navigation("Runs");
                });

            modelBuilder.Entity("SosnovkaRC.Domain.Models.Races.Result", b =>
                {
                    b.Navigation("Splits");
                });

            modelBuilder.Entity("SosnovkaRC.Domain.Models.Races.Run", b =>
                {
                    b.Navigation("Results");
                });
#pragma warning restore 612, 618
        }
    }
}
