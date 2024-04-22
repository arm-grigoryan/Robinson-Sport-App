﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RobinsonSportApp.Data;

#nullable disable

namespace RobinsonSportApp.Data.Migrations
{
    [DbContext(typeof(RobinsonSportAppDbContext))]
    [Migration("20240422124558_AssociationsAndContacts")]
    partial class AssociationsAndContacts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RobinsonSportApp.Data.Entities.Association", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Emails")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("PhoneNumbers")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("PresidentFirstName")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("PresidentLastName")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("WebsiteUrl")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.ToTable("Associations");
                });

            modelBuilder.Entity("RobinsonSportApp.Data.Entities.AssociationContact", b =>
                {
                    b.Property<int>("AssociationId")
                        .HasColumnType("int");

                    b.Property<int>("ContactPersonId")
                        .HasColumnType("int");

                    b.HasKey("AssociationId", "ContactPersonId");

                    b.HasIndex("ContactPersonId");

                    b.ToTable("AssociationContact");
                });

            modelBuilder.Entity("RobinsonSportApp.Data.Entities.ContactPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("LastName")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("RobinsonSportApp.Data.Entities.AssociationContact", b =>
                {
                    b.HasOne("RobinsonSportApp.Data.Entities.Association", "Association")
                        .WithMany("AssociationContacts")
                        .HasForeignKey("AssociationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RobinsonSportApp.Data.Entities.ContactPerson", "ContactPerson")
                        .WithMany("AssociationContacts")
                        .HasForeignKey("ContactPersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Association");

                    b.Navigation("ContactPerson");
                });

            modelBuilder.Entity("RobinsonSportApp.Data.Entities.Association", b =>
                {
                    b.Navigation("AssociationContacts");
                });

            modelBuilder.Entity("RobinsonSportApp.Data.Entities.ContactPerson", b =>
                {
                    b.Navigation("AssociationContacts");
                });
#pragma warning restore 612, 618
        }
    }
}
