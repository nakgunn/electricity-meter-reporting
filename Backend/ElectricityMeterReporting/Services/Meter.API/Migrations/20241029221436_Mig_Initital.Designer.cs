﻿// <auto-generated />
using System;
using Meter.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Meter.API.Migrations
{
    [DbContext(typeof(MeterDbContext))]
    [Migration("20241029221436_Mig_Initital")]
    partial class Mig_Initital
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Meter.API.Models.Entities.Meter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("LastIndex")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("LastIndexDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("MeasurementCurrent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MeasurementVoltage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Meters");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4d4e797e-16dc-4d8b-81fb-17d7ed4d96e2"),
                            LastIndex = 41.3108731490067m,
                            LastIndexDate = new DateTime(2024, 10, 30, 1, 14, 35, 899, DateTimeKind.Local).AddTicks(7807),
                            MeasurementCurrent = 5.04984144233824m,
                            MeasurementVoltage = 7.48404574730343m,
                            SerialNumber = "SN480359"
                        },
                        new
                        {
                            Id = new Guid("441eb1a4-17de-4868-9c8a-265456bac20b"),
                            LastIndex = 2.06604843651495m,
                            LastIndexDate = new DateTime(2024, 10, 30, 1, 14, 35, 899, DateTimeKind.Local).AddTicks(7826),
                            MeasurementCurrent = 6.62477750730384m,
                            MeasurementVoltage = 8.7274816753189m,
                            SerialNumber = "SN389388"
                        },
                        new
                        {
                            Id = new Guid("a04ada71-d73f-43ec-9c5a-3149562545c0"),
                            LastIndex = 12.5456883078097m,
                            LastIndexDate = new DateTime(2024, 10, 30, 1, 14, 35, 899, DateTimeKind.Local).AddTicks(7831),
                            MeasurementCurrent = 4.34623249650769m,
                            MeasurementVoltage = 2.18874399603874m,
                            SerialNumber = "SN469294"
                        },
                        new
                        {
                            Id = new Guid("70a994b6-11d8-4362-b1b3-1ff56105b82a"),
                            LastIndex = 8.16607372102124m,
                            LastIndexDate = new DateTime(2024, 10, 30, 1, 14, 35, 899, DateTimeKind.Local).AddTicks(7865),
                            MeasurementCurrent = 6.03649989569376m,
                            MeasurementVoltage = 3.45010845998231m,
                            SerialNumber = "SN500042"
                        },
                        new
                        {
                            Id = new Guid("297a745d-d73e-43b8-8d87-9e69ba9eb08d"),
                            LastIndex = 6.5880160043172m,
                            LastIndexDate = new DateTime(2024, 10, 30, 1, 14, 35, 899, DateTimeKind.Local).AddTicks(7870),
                            MeasurementCurrent = 7.4671873759133m,
                            MeasurementVoltage = 5.40369910542006m,
                            SerialNumber = "SN836354"
                        },
                        new
                        {
                            Id = new Guid("b7792b85-8eff-453e-86fa-e7b7b8d12f37"),
                            LastIndex = 34.0097600874116m,
                            LastIndexDate = new DateTime(2024, 10, 30, 1, 14, 35, 899, DateTimeKind.Local).AddTicks(7878),
                            MeasurementCurrent = 1.04471281941103m,
                            MeasurementVoltage = 6.41905284716454m,
                            SerialNumber = "SN699305"
                        },
                        new
                        {
                            Id = new Guid("0d47b8de-fdf2-4500-9f71-4c676ba44ee1"),
                            LastIndex = 4.72249286186685m,
                            LastIndexDate = new DateTime(2024, 10, 30, 1, 14, 35, 899, DateTimeKind.Local).AddTicks(7883),
                            MeasurementCurrent = 1.37182939011335m,
                            MeasurementVoltage = 1.29969700202157m,
                            SerialNumber = "SN887722"
                        },
                        new
                        {
                            Id = new Guid("2364449e-fbcd-49f3-b2d3-8f1098f031f1"),
                            LastIndex = 8.66340592418833m,
                            LastIndexDate = new DateTime(2024, 10, 30, 1, 14, 35, 899, DateTimeKind.Local).AddTicks(7888),
                            MeasurementCurrent = 3.1775551015712m,
                            MeasurementVoltage = 1.60702593746998m,
                            SerialNumber = "SN807362"
                        },
                        new
                        {
                            Id = new Guid("c15ea22a-0093-405f-aab9-f33986c48d4e"),
                            LastIndex = 5.36679776261033m,
                            LastIndexDate = new DateTime(2024, 10, 30, 1, 14, 35, 899, DateTimeKind.Local).AddTicks(7893),
                            MeasurementCurrent = 5.71476173932756m,
                            MeasurementVoltage = 2.56827631521461m,
                            SerialNumber = "SN313486"
                        },
                        new
                        {
                            Id = new Guid("85e3ee1f-e28c-4ea8-9dec-e8b38f29121f"),
                            LastIndex = 43.0376005743783m,
                            LastIndexDate = new DateTime(2024, 10, 30, 1, 14, 35, 899, DateTimeKind.Local).AddTicks(7898),
                            MeasurementCurrent = 4.25376303377939m,
                            MeasurementVoltage = 2.16610460484716m,
                            SerialNumber = "SN266653"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}