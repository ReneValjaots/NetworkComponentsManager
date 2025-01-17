﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nc.Soft.Data;

#nullable disable

namespace Nc.Soft.Migrations;

[DbContext(typeof(ApplicationDbContext))]
partial class ApplicationDbContextModelSnapshot : ModelSnapshot
{
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder
            .HasAnnotation("ProductVersion", "8.0.3")
            .HasAnnotation("Relational:MaxIdentifierLength", 128);

        SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
            {
                b.Property<string>("Id")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .HasMaxLength(256)
                    .HasColumnType("nvarchar(256)");

                b.Property<string>("NormalizedName")
                    .HasMaxLength(256)
                    .HasColumnType("nvarchar(256)");

                b.HasKey("Id");

                b.HasIndex("NormalizedName")
                    .IsUnique()
                    .HasDatabaseName("RoleNameIndex")
                    .HasFilter("[NormalizedName] IS NOT NULL");

                b.ToTable("AspNetRoles", (string)null);
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("ClaimType")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ClaimValue")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("RoleId")
                    .IsRequired()
                    .HasColumnType("nvarchar(450)");

                b.HasKey("Id");

                b.HasIndex("RoleId");

                b.ToTable("AspNetRoleClaims", (string)null);
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
            {
                b.Property<string>("Id")
                    .HasColumnType("nvarchar(450)");

                b.Property<int>("AccessFailedCount")
                    .HasColumnType("int");

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Email")
                    .HasMaxLength(256)
                    .HasColumnType("nvarchar(256)");

                b.Property<bool>("EmailConfirmed")
                    .HasColumnType("bit");

                b.Property<bool>("LockoutEnabled")
                    .HasColumnType("bit");

                b.Property<DateTimeOffset?>("LockoutEnd")
                    .HasColumnType("datetimeoffset");

                b.Property<string>("NormalizedEmail")
                    .HasMaxLength(256)
                    .HasColumnType("nvarchar(256)");

                b.Property<string>("NormalizedUserName")
                    .HasMaxLength(256)
                    .HasColumnType("nvarchar(256)");

                b.Property<string>("PasswordHash")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("PhoneNumber")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("PhoneNumberConfirmed")
                    .HasColumnType("bit");

                b.Property<string>("SecurityStamp")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("TwoFactorEnabled")
                    .HasColumnType("bit");

                b.Property<string>("UserName")
                    .HasMaxLength(256)
                    .HasColumnType("nvarchar(256)");

                b.HasKey("Id");

                b.HasIndex("NormalizedEmail")
                    .HasDatabaseName("EmailIndex");

                b.HasIndex("NormalizedUserName")
                    .IsUnique()
                    .HasDatabaseName("UserNameIndex")
                    .HasFilter("[NormalizedUserName] IS NOT NULL");

                b.ToTable("AspNetUsers", (string)null);
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("ClaimType")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ClaimValue")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("UserId")
                    .IsRequired()
                    .HasColumnType("nvarchar(450)");

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.ToTable("AspNetUserClaims", (string)null);
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
            {
                b.Property<string>("LoginProvider")
                    .HasMaxLength(128)
                    .HasColumnType("nvarchar(128)");

                b.Property<string>("ProviderKey")
                    .HasMaxLength(128)
                    .HasColumnType("nvarchar(128)");

                b.Property<string>("ProviderDisplayName")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("UserId")
                    .IsRequired()
                    .HasColumnType("nvarchar(450)");

                b.HasKey("LoginProvider", "ProviderKey");

                b.HasIndex("UserId");

                b.ToTable("AspNetUserLogins", (string)null);
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
            {
                b.Property<string>("UserId")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("RoleId")
                    .HasColumnType("nvarchar(450)");

                b.HasKey("UserId", "RoleId");

                b.HasIndex("RoleId");

                b.ToTable("AspNetUserRoles", (string)null);
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
            {
                b.Property<string>("UserId")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("LoginProvider")
                    .HasMaxLength(128)
                    .HasColumnType("nvarchar(128)");

                b.Property<string>("Name")
                    .HasMaxLength(128)
                    .HasColumnType("nvarchar(128)");

                b.Property<string>("Value")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("UserId", "LoginProvider", "Name");

                b.ToTable("AspNetUserTokens", (string)null);
            });

        modelBuilder.Entity("Nc.Data.Network.ComponentType.ConnectionComponentTypeData", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Description")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Location")
                    .HasColumnType("nvarchar(max)");

                b.Property<double>("Speed")
                    .HasColumnType("float");

                b.HasKey("Id");

                b.ToTable("ConnectionComponentTypes", "NetworkComponentType");
            });

        modelBuilder.Entity("Nc.Data.Network.ComponentType.DeviceTypeData", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Description")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("HardwareVersion")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Model")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("DeviceTypes", "NetworkComponentType");
            });

        modelBuilder.Entity("Nc.Data.Network.ComponentType.ServerTypeData", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Description")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Hostname")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Memory")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("NetworkServerTypes", "NetworkComponentType");
            });

        modelBuilder.Entity("Nc.Data.Network.ComponentType.SupportStructureTypeData", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Description")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Material")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("SupportStructureTypes", "NetworkComponentType");
            });

        modelBuilder.Entity("Nc.Data.Network.Components.CableWiringData", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("ConnectorType")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("FacilityId")
                    .HasColumnType("int");

                b.Property<double>("Length")
                    .HasColumnType("float");

                b.Property<int>("NetworkServerTypeId")
                    .HasColumnType("int");

                b.Property<int>("PathwayId")
                    .HasColumnType("int");

                b.Property<string>("SerialNum")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("CableWirings", "ConnectionComponent");
            });

        modelBuilder.Entity("Nc.Data.Network.Components.CommunicationAppearanceData", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int>("FacilityId")
                    .HasColumnType("int");

                b.Property<int>("GeographicPointId")
                    .HasColumnType("int");

                b.Property<string>("IpAddress")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("NetworkServerTypeId")
                    .HasColumnType("int");

                b.Property<string>("SerialNum")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Type")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("CommunicationAppearances", "NetworkServer");
            });

        modelBuilder.Entity("Nc.Data.Network.Components.FiberWiringData", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("ConnectorType")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("FacilityId")
                    .HasColumnType("int");

                b.Property<double>("Length")
                    .HasColumnType("float");

                b.Property<int>("NetworkServerTypeId")
                    .HasColumnType("int");

                b.Property<int>("PathwayId")
                    .HasColumnType("int");

                b.Property<string>("SerialNum")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("FiberWirings", "ConnectionComponent");
            });

        modelBuilder.Entity("Nc.Data.Network.Components.MicrowaveComponentData", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int>("FacilityId")
                    .HasColumnType("int");

                b.Property<double>("Frequency")
                    .HasColumnType("float");

                b.Property<int>("NetworkServerTypeId")
                    .HasColumnType("int");

                b.Property<int>("PathwayId")
                    .HasColumnType("int");

                b.Property<double>("PowerOutput")
                    .HasColumnType("float");

                b.Property<string>("SerialNum")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("MicrowaveComponents", "ConnectionComponent");
            });

        modelBuilder.Entity("Nc.Data.Network.Components.RouterData", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int>("FacilityId")
                    .HasColumnType("int");

                b.Property<int>("GeographicPointId")
                    .HasColumnType("int");

                b.Property<string>("IpAddress")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Model")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("NetworkServerTypeId")
                    .HasColumnType("int");

                b.Property<string>("SerialNum")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Routers", "NetworkServer");
            });

        modelBuilder.Entity("Nc.Data.Network.Components.SupportStructureData", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int>("FacilityId")
                    .HasColumnType("int");

                b.Property<int>("GeographicPointId")
                    .HasColumnType("int");

                b.Property<DateTime?>("InstallationDate")
                    .HasColumnType("datetime2");

                b.Property<bool?>("IsMaintenanceValid")
                    .HasColumnType("bit");

                b.Property<string>("Location")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("NetworkServerTypeId")
                    .HasColumnType("int");

                b.Property<string>("SerialNum")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("SupportStructures", "SupportStructure");
            });

        modelBuilder.Entity("Nc.Data.Network.Components.SwitchData", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int>("FacilityId")
                    .HasColumnType("int");

                b.Property<int>("GeographicPointId")
                    .HasColumnType("int");

                b.Property<int>("NetworkServerTypeId")
                    .HasColumnType("int");

                b.Property<int>("NumberOfPorts")
                    .HasColumnType("int");

                b.Property<string>("SerialNum")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Switches", "NetworkServer");
            });

        modelBuilder.Entity("Nc.Data.Network.Facility.FacilityData", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int>("FacilityTypeId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("FacilityEntities", "Facility");
            });

        modelBuilder.Entity("Nc.Data.Network.Facility.FacilityTypeData", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("FacilityTypes", "Facility");
            });

        modelBuilder.Entity("Nc.Data.Network.Location.GeographicBoundaryData", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Description")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("GeographicBoundaries", "Location");
            });

        modelBuilder.Entity("Nc.Data.Network.Location.GeographicPointData", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Description")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Latitude")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Longitude")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("GeographicPoints", "Location");
            });

        modelBuilder.Entity("Nc.Data.Network.Location.PathwayData", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Description")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<double>("TotalDistance")
                    .HasColumnType("float");

                b.HasKey("Id");

                b.ToTable("Pathways", "Location");
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
            {
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
            {
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
            {
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
            {
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
            {
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });
#pragma warning restore 612, 618
    }
}
