﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VidlieDbContextModel;

namespace vidlie.Migrations
{
    [DbContext(typeof(VidlieDbContext))]
    [Migration("20200918121700_startingfromscratch2")]
    partial class startingfromscratch2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("vidlie.Models.Customer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<bool>("HasSubscription")
                        .HasColumnType("INTEGER");

                    b.Property<double>("SubscriptionId")
                        .HasColumnType("REAL");

                    b.Property<string>("SubscriptionId1")
                        .HasColumnType("TEXT");

                    b.Property<string>("age")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SubscriptionId1");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("vidlie.Models.Subscription", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<double>("Discount")
                        .HasColumnType("REAL");

                    b.Property<double>("Duration")
                        .HasColumnType("REAL");

                    b.Property<string>("SubscriptionType")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("vidlie.Models.Customer", b =>
                {
                    b.HasOne("vidlie.Models.Subscription", "Subscription")
                        .WithMany()
                        .HasForeignKey("SubscriptionId1");
                });
#pragma warning restore 612, 618
        }
    }
}
