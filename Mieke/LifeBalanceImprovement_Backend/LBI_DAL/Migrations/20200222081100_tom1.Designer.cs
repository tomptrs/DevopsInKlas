﻿// <auto-generated />
using System;
using LBI_DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LBI_DAL.Migrations
{
    [DbContext(typeof(LBIContext))]
    [Migration("20200222081100_tom1")]
    partial class tom1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LBI_DAL.Models.Agenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AgendaDb");
                });

            modelBuilder.Entity("LBI_DAL.Models.AgendaItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AgendaId");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("UserCategoryId");

                    b.HasKey("Id");

                    b.HasIndex("AgendaId");

                    b.HasIndex("UserCategoryId");

                    b.ToTable("AgendaItemDb");
                });

            modelBuilder.Entity("LBI_DAL.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("CategoryDb");
                });

            modelBuilder.Entity("LBI_DAL.Models.EigenNetwerk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Nummer");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("EigenNetwerkDb");
                });

            modelBuilder.Entity("LBI_DAL.Models.Externe_bron", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Chat");

                    b.Property<string>("ChatLink");

                    b.Property<string>("Description");

                    b.Property<string>("Forum");

                    b.Property<string>("Icone");

                    b.Property<bool>("IsMail");

                    b.Property<string>("Mail");

                    b.Property<string>("Phone");

                    b.Property<string>("Site");

                    b.Property<string>("SmallDescription");

                    b.HasKey("Id");

                    b.ToTable("Externe_bronDb");
                });

            modelBuilder.Entity("LBI_DAL.Models.Goals", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<DateTime>("BeginTime");

                    b.Property<DateTime>("EndTime");

                    b.Property<string>("Goal");

                    b.Property<double>("Percentage");

                    b.Property<int>("Progress");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("GoalsDb");
                });

            modelBuilder.Entity("LBI_DAL.Models.Happiness", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("SmallDescription");

                    b.HasKey("Id");

                    b.ToTable("HappinessDb");
                });

            modelBuilder.Entity("LBI_DAL.Models.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Duration");

                    b.Property<int?>("StatId");

                    b.Property<int>("UserCategoryId");

                    b.HasKey("Id");

                    b.HasIndex("StatId");

                    b.HasIndex("UserCategoryId");

                    b.ToTable("LogDb");
                });

            modelBuilder.Entity("LBI_DAL.Models.Mindfulness", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("MindfulnessDb");
                });

            modelBuilder.Entity("LBI_DAL.Models.MomentKader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Emotie");

                    b.Property<string>("Gedachte");

                    b.Property<string>("Lichaam");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("MomentKaderDb");
                });

            modelBuilder.Entity("LBI_DAL.Models.Quotes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("quote");

                    b.Property<string>("tip");

                    b.HasKey("id");

                    b.ToTable("QuotesDb");
                });

            modelBuilder.Entity("LBI_DAL.Models.Stats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Bad");

                    b.Property<bool>("Good");

                    b.Property<int>("UserId");

                    b.Property<int>("Week");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Statsdb");
                });

            modelBuilder.Entity("LBI_DAL.Models.UserCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Color");

                    b.Property<double>("IdealValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("UserCategoryDb");
                });

            modelBuilder.Entity("LBI_DAL.Models.UserHappiness", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HappinessId");

                    b.Property<bool>("Status");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("HappinessId");

                    b.HasIndex("UserId");

                    b.ToTable("UserHappinessDb");
                });

            modelBuilder.Entity("LBI_DAL.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<bool>("FirstLoginStats");

                    b.Property<string>("GUID");

                    b.Property<string>("Name");

                    b.Property<string>("Note");

                    b.HasKey("Id");

                    b.ToTable("UsersDb");
                });

            modelBuilder.Entity("LBI_DAL.Models.Agenda", b =>
                {
                    b.HasOne("LBI_DAL.Models.Users", "User")
                        .WithMany("Agendas")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LBI_DAL.Models.AgendaItem", b =>
                {
                    b.HasOne("LBI_DAL.Models.Agenda", "Agenda")
                        .WithMany("AgendaItems")
                        .HasForeignKey("AgendaId");

                    b.HasOne("LBI_DAL.Models.UserCategory", "UserCategory")
                        .WithMany("AgendaItems")
                        .HasForeignKey("UserCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LBI_DAL.Models.EigenNetwerk", b =>
                {
                    b.HasOne("LBI_DAL.Models.Users", "User")
                        .WithMany("EigenNetwerken")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LBI_DAL.Models.Goals", b =>
                {
                    b.HasOne("LBI_DAL.Models.Users", "User")
                        .WithMany("Goals")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LBI_DAL.Models.Log", b =>
                {
                    b.HasOne("LBI_DAL.Models.Stats", "Stat")
                        .WithMany("Logs")
                        .HasForeignKey("StatId");

                    b.HasOne("LBI_DAL.Models.UserCategory", "UserCategory")
                        .WithMany("Logs")
                        .HasForeignKey("UserCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LBI_DAL.Models.MomentKader", b =>
                {
                    b.HasOne("LBI_DAL.Models.Users", "User")
                        .WithMany("MomentKaders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LBI_DAL.Models.Stats", b =>
                {
                    b.HasOne("LBI_DAL.Models.Users", "User")
                        .WithMany("Stats")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LBI_DAL.Models.UserCategory", b =>
                {
                    b.HasOne("LBI_DAL.Models.Category", "Category")
                        .WithMany("UserCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LBI_DAL.Models.Users", "User")
                        .WithMany("UserCategories")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LBI_DAL.Models.UserHappiness", b =>
                {
                    b.HasOne("LBI_DAL.Models.Happiness", "Happiness")
                        .WithMany("UserHapinesses")
                        .HasForeignKey("HappinessId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LBI_DAL.Models.Users", "User")
                        .WithMany("UserHappiness")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
