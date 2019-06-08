﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(LearningLanguagesContext))]
    partial class LearningLanguagesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Models.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<int?>("ParentId")
                        .HasColumnName("parent_id");

                    b.Property<string>("Picture")
                        .HasColumnName("picture")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DAL.Models.CategoriesTranslations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnName("category_id");

                    b.Property<int>("LangId")
                        .HasColumnName("lang_id");

                    b.Property<string>("Translation")
                        .IsRequired()
                        .HasColumnName("translation")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("LangId");

                    b.ToTable("CategoriesTranslations");
                });

            modelBuilder.Entity("DAL.Models.LanguageTranslations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LangId")
                        .HasColumnName("lang_id");

                    b.Property<int>("NativeLangId")
                        .HasColumnName("native_lang_id");

                    b.Property<string>("Translation")
                        .IsRequired()
                        .HasColumnName("translation")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("LangId");

                    b.HasIndex("NativeLangId");

                    b.ToTable("LanguageTranslations");
                });

            modelBuilder.Entity("DAL.Models.Languages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("DAL.Models.TestResults", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnName("category_id");

                    b.Property<int>("LangId")
                        .HasColumnName("lang_id");

                    b.Property<int>("Result")
                        .HasColumnName("result");

                    b.Property<DateTime>("TestDate")
                        .HasColumnName("testDate")
                        .HasColumnType("datetime");

                    b.Property<int>("TestId")
                        .HasColumnName("test_id");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnName("user_id")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("LangId");

                    b.HasIndex("TestId");

                    b.HasIndex("UserId");

                    b.ToTable("TestResults");
                });

            modelBuilder.Entity("DAL.Models.TestTranslations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LangId")
                        .HasColumnName("lang_id");

                    b.Property<int>("TestId")
                        .HasColumnName("test_id");

                    b.Property<string>("Translation")
                        .IsRequired()
                        .HasColumnName("translation")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("LangId");

                    b.HasIndex("TestId");

                    b.ToTable("TestTranslations");
                });

            modelBuilder.Entity("DAL.Models.Tests", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnName("icon")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("DAL.Models.TotalScores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LangId")
                        .HasColumnName("lang_id");

                    b.Property<int>("Total")
                        .HasColumnName("total");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnName("user_id")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("LangId");

                    b.HasIndex("UserId");

                    b.ToTable("TotalScores");
                });

            modelBuilder.Entity("DAL.Models.Users", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("DAL.Models.WordTranslations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LangId")
                        .HasColumnName("lang_id");

                    b.Property<string>("Pronounce")
                        .IsRequired()
                        .HasColumnName("pronounce")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("Translation")
                        .IsRequired()
                        .HasColumnName("translation")
                        .HasMaxLength(100);

                    b.Property<int>("WordId")
                        .HasColumnName("word_id");

                    b.HasKey("Id");

                    b.HasIndex("LangId");

                    b.HasIndex("WordId");

                    b.ToTable("WordTranslations");
                });

            modelBuilder.Entity("DAL.Models.Words", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnName("category_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Picture")
                        .HasColumnName("picture")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("Sound")
                        .HasColumnName("sound")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Words");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DAL.Models.Categories", b =>
                {
                    b.HasOne("DAL.Models.Categories", "Parent")
                        .WithMany("InverseParent")
                        .HasForeignKey("ParentId")
                        .HasConstraintName("Categories_fk0");
                });

            modelBuilder.Entity("DAL.Models.CategoriesTranslations", b =>
                {
                    b.HasOne("DAL.Models.Categories", "Category")
                        .WithMany("CategoriesTranslations")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("CategoriesTranslations_fk0");

                    b.HasOne("DAL.Models.Languages", "Lang")
                        .WithMany("CategoriesTranslations")
                        .HasForeignKey("LangId")
                        .HasConstraintName("CategoriesTranslations_fk1");
                });

            modelBuilder.Entity("DAL.Models.LanguageTranslations", b =>
                {
                    b.HasOne("DAL.Models.Languages", "Lang")
                        .WithMany("LanguageTranslationsLang")
                        .HasForeignKey("LangId")
                        .HasConstraintName("LanguageTranslations_fk0");

                    b.HasOne("DAL.Models.Languages", "NativeLang")
                        .WithMany("LanguageTranslationsNativeLang")
                        .HasForeignKey("NativeLangId")
                        .HasConstraintName("LanguageTranslations_fk1");
                });

            modelBuilder.Entity("DAL.Models.TestResults", b =>
                {
                    b.HasOne("DAL.Models.Categories", "Category")
                        .WithMany("TestResults")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("TestResults_fk3");

                    b.HasOne("DAL.Models.Languages", "Lang")
                        .WithMany("TestResults")
                        .HasForeignKey("LangId")
                        .HasConstraintName("TestResults_fk2");

                    b.HasOne("DAL.Models.Tests", "Test")
                        .WithMany("TestResults")
                        .HasForeignKey("TestId")
                        .HasConstraintName("TestResults_fk0");

                    b.HasOne("DAL.Models.Users", "User")
                        .WithMany("TestResults")
                        .HasForeignKey("UserId")
                        .HasConstraintName("TestResults_fk1");
                });

            modelBuilder.Entity("DAL.Models.TestTranslations", b =>
                {
                    b.HasOne("DAL.Models.Languages", "Lang")
                        .WithMany("TestTranslations")
                        .HasForeignKey("LangId")
                        .HasConstraintName("TestTranslations_fk1");

                    b.HasOne("DAL.Models.Tests", "Test")
                        .WithMany("TestTranslations")
                        .HasForeignKey("TestId")
                        .HasConstraintName("TestTranslations_fk0");
                });

            modelBuilder.Entity("DAL.Models.TotalScores", b =>
                {
                    b.HasOne("DAL.Models.Languages", "Lang")
                        .WithMany("TotalScores")
                        .HasForeignKey("LangId")
                        .HasConstraintName("TotalScores_fk1");

                    b.HasOne("DAL.Models.Users", "User")
                        .WithMany("TotalScores")
                        .HasForeignKey("UserId")
                        .HasConstraintName("TotalScores_fk0");
                });

            modelBuilder.Entity("DAL.Models.WordTranslations", b =>
                {
                    b.HasOne("DAL.Models.Languages", "Lang")
                        .WithMany("WordTranslations")
                        .HasForeignKey("LangId")
                        .HasConstraintName("WordTranslations_fk1");

                    b.HasOne("DAL.Models.Words", "Word")
                        .WithMany("WordTranslations")
                        .HasForeignKey("WordId")
                        .HasConstraintName("WordTranslations_fk0");
                });

            modelBuilder.Entity("DAL.Models.Words", b =>
                {
                    b.HasOne("DAL.Models.Categories", "Category")
                        .WithMany("Words")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("Words_fk0");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DAL.Models.Users")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DAL.Models.Users")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Models.Users")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DAL.Models.Users")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
