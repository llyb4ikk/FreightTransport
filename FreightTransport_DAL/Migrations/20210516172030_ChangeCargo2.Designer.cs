// <auto-generated />
using System;
using FreightTransport_DAL.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FreightTransport_DAL.Migrations
{
    [DbContext(typeof(FreightTransportDBContext))]
    [Migration("20210516172030_ChangeCargo2")]
    partial class ChangeCargo2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FreightTransport_DAL.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarType")
                        .HasColumnType("int");

                    b.Property<int>("CarryingCapacity")
                        .HasColumnType("int");

                    b.Property<float>("FuelConsumption")
                        .HasColumnType("real");

                    b.Property<float?>("Height")
                        .HasColumnType("real");

                    b.Property<float?>("Length")
                        .HasColumnType("real");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<float?>("Widthf")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("FreightTransport_DAL.Entities.CarDriver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CarDrivers");
                });

            modelBuilder.Entity("FreightTransport_DAL.Entities.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("Height")
                        .HasColumnType("real");

                    b.Property<float?>("Length")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int?>("TransportationId")
                        .HasColumnType("int");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.Property<float?>("Width")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("TransportationId");

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("FreightTransport_DAL.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Latitude")
                        .HasColumnType("real");

                    b.Property<float>("Longitude")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Region")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("FreightTransport_DAL.Entities.DriverSalary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarDriverId")
                        .HasColumnType("int");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<int>("TransportationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarDriverId");

                    b.HasIndex("TransportationId");

                    b.ToTable("DiverSalaries");
                });

            modelBuilder.Entity("FreightTransport_DAL.Entities.Transportation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<int>("DestinationCityId")
                        .HasColumnType("int");

                    b.Property<double>("Distance")
                        .HasColumnType("float");

                    b.Property<int>("StartCityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("DestinationCityId");

                    b.HasIndex("StartCityId");

                    b.ToTable("Transportations");
                });

            modelBuilder.Entity("FreightTransport_DAL.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountOfOrders")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FreightTransport_DAL.Entities.Cargo", b =>
                {
                    b.HasOne("FreightTransport_DAL.Entities.User", "Owner")
                        .WithMany("Cargos")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FreightTransport_DAL.Entities.Transportation", "Transportation")
                        .WithMany("Cargos")
                        .HasForeignKey("TransportationId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Owner");

                    b.Navigation("Transportation");
                });

            modelBuilder.Entity("FreightTransport_DAL.Entities.DriverSalary", b =>
                {
                    b.HasOne("FreightTransport_DAL.Entities.CarDriver", "CarDriver")
                        .WithMany("Salaries")
                        .HasForeignKey("CarDriverId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FreightTransport_DAL.Entities.Transportation", "Transportation")
                        .WithMany("DriverSalaries")
                        .HasForeignKey("TransportationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CarDriver");

                    b.Navigation("Transportation");
                });

            modelBuilder.Entity("FreightTransport_DAL.Entities.Transportation", b =>
                {
                    b.HasOne("FreightTransport_DAL.Entities.Car", "Car")
                        .WithMany("Transportations")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FreightTransport_DAL.Entities.City", "DestinationCity")
                        .WithMany("DestinationRoutes")
                        .HasForeignKey("DestinationCityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FreightTransport_DAL.Entities.City", "StartCity")
                        .WithMany("StartRoutes")
                        .HasForeignKey("StartCityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("DestinationCity");

                    b.Navigation("StartCity");
                });

            modelBuilder.Entity("FreightTransport_DAL.Entities.Car", b =>
                {
                    b.Navigation("Transportations");
                });

            modelBuilder.Entity("FreightTransport_DAL.Entities.CarDriver", b =>
                {
                    b.Navigation("Salaries");
                });

            modelBuilder.Entity("FreightTransport_DAL.Entities.City", b =>
                {
                    b.Navigation("DestinationRoutes");

                    b.Navigation("StartRoutes");
                });

            modelBuilder.Entity("FreightTransport_DAL.Entities.Transportation", b =>
                {
                    b.Navigation("Cargos");

                    b.Navigation("DriverSalaries");
                });

            modelBuilder.Entity("FreightTransport_DAL.Entities.User", b =>
                {
                    b.Navigation("Cargos");
                });
#pragma warning restore 612, 618
        }
    }
}
