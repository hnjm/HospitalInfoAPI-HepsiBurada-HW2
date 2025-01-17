﻿// <auto-generated />
using System;
using Homework_2_BurcuMantar.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Homework_2_BurcuMantar.Data.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    partial class ProjectDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Homework_2_BurcuMantar.Entities.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Clinic")
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("HospitalId")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("HospitalId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Clinic = "Genel Cerrahi",
                            Gender = "M",
                            HospitalId = 1,
                            LastName = "Ak",
                            Name = "Ali"
                        },
                        new
                        {
                            Id = 2,
                            Clinic = "Göz Hastaliklari",
                            Gender = "M",
                            HospitalId = 3,
                            LastName = "Aka",
                            Name = "Can"
                        },
                        new
                        {
                            Id = 3,
                            Clinic = "Dahiliye",
                            Gender = "M",
                            HospitalId = 2,
                            LastName = "Akar",
                            Name = "Cem"
                        },
                        new
                        {
                            Id = 4,
                            Clinic = "Pediatri",
                            Gender = "M",
                            HospitalId = 1,
                            LastName = "Gök",
                            Name = "Han"
                        },
                        new
                        {
                            Id = 5,
                            Clinic = "Göz Hastaliklari",
                            Gender = "F",
                            HospitalId = 3,
                            LastName = "Karlı",
                            Name = "Naz"
                        },
                        new
                        {
                            Id = 6,
                            Clinic = "Cildiye",
                            Gender = "F",
                            HospitalId = 2,
                            LastName = "Sucu",
                            Name = "Gaye"
                        });
                });

            modelBuilder.Entity("Homework_2_BurcuMantar.Entities.DoctorPatient", b =>
                {
                    b.Property<int>("DoctorId")
                        .HasColumnType("integer");

                    b.Property<int>("PatientId")
                        .HasColumnType("integer");

                    b.HasKey("DoctorId", "PatientId");

                    b.HasIndex("PatientId");

                    b.ToTable("DoctorPatients");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            PatientId = 3
                        },
                        new
                        {
                            DoctorId = 1,
                            PatientId = 1
                        },
                        new
                        {
                            DoctorId = 3,
                            PatientId = 2
                        },
                        new
                        {
                            DoctorId = 3,
                            PatientId = 1
                        },
                        new
                        {
                            DoctorId = 5,
                            PatientId = 3
                        },
                        new
                        {
                            DoctorId = 4,
                            PatientId = 2
                        });
                });

            modelBuilder.Entity("Homework_2_BurcuMantar.Entities.Hospital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string[]>("Clinics")
                        .HasColumnType("text[]");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Hospitals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Ankara",
                            Clinics = new[] { "Genel Cerrahi", "Dahiliye", "Göz Hastaliklari", "Pediatri", "Cildiye", "Üroloji", "Endokrinoloji", "Acil" },
                            Name = "A"
                        },
                        new
                        {
                            Id = 2,
                            Address = "İstanbul",
                            Clinics = new[] { "Genel Cerrahi", "Dahiliye", "Göz Hastaliklari", "Pediatri", "Cildiye", "Üroloji", "Endokrinoloji", "Acil" },
                            Name = "B"
                        },
                        new
                        {
                            Id = 3,
                            Address = "İzmir",
                            Clinics = new[] { "Genel Cerrahi", "Dahiliye", "Göz Hastaliklari", "Pediatri", "Cildiye", "Üroloji", "Endokrinoloji", "Acil" },
                            Name = "C"
                        });
                });

            modelBuilder.Entity("Homework_2_BurcuMantar.Entities.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("FileNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FileNumber = 1122334455L,
                            Gender = "M",
                            LastName = "Ak",
                            Name = "Veli"
                        },
                        new
                        {
                            Id = 2,
                            FileNumber = 1528745889L,
                            Gender = "F",
                            LastName = "Aka",
                            Name = "Ece"
                        },
                        new
                        {
                            Id = 3,
                            FileNumber = 9988776655L,
                            Gender = "M",
                            LastName = "Akar",
                            Name = "Ege"
                        });
                });

            modelBuilder.Entity("Homework_2_BurcuMantar.Entities.Doctor", b =>
                {
                    b.HasOne("Homework_2_BurcuMantar.Entities.Hospital", "Hospital")
                        .WithMany("Doctors")
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hospital");
                });

            modelBuilder.Entity("Homework_2_BurcuMantar.Entities.DoctorPatient", b =>
                {
                    b.HasOne("Homework_2_BurcuMantar.Entities.Doctor", "Doctor")
                        .WithMany("DoctorPatients")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Homework_2_BurcuMantar.Entities.Patient", "Patient")
                        .WithMany("DoctorPatients")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Homework_2_BurcuMantar.Entities.Doctor", b =>
                {
                    b.Navigation("DoctorPatients");
                });

            modelBuilder.Entity("Homework_2_BurcuMantar.Entities.Hospital", b =>
                {
                    b.Navigation("Doctors");
                });

            modelBuilder.Entity("Homework_2_BurcuMantar.Entities.Patient", b =>
                {
                    b.Navigation("DoctorPatients");
                });
#pragma warning restore 612, 618
        }
    }
}
