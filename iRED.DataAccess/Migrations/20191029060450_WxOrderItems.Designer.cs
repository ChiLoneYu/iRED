﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using iRED.DataAccess;

namespace iRED.DataAccess.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191029060450_WxOrderItems")]
    partial class WxOrderItems
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WalkingTec.Mvvm.Core.ActionLog", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ActionName")
                        .HasMaxLength(50);

                    b.Property<DateTime>("ActionTime");

                    b.Property<string>("ActionUrl")
                        .HasMaxLength(250);

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("CreateTime");

                    b.Property<double>("Duration");

                    b.Property<string>("IP")
                        .HasMaxLength(50);

                    b.Property<string>("ITCode")
                        .HasMaxLength(50);

                    b.Property<int>("LogType");

                    b.Property<string>("ModuleName")
                        .HasMaxLength(50);

                    b.Property<string>("Remark");

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdateTime");

                    b.HasKey("ID");

                    b.ToTable("ActionLogs");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.DataPrivilege", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("CreateTime");

                    b.Property<Guid?>("DomainId");

                    b.Property<Guid?>("GroupId");

                    b.Property<string>("RelateId");

                    b.Property<string>("TableName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<Guid?>("UserId");

                    b.HasKey("ID");

                    b.HasIndex("DomainId");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("DataPrivileges");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FileAttachment", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("CreateTime");

                    b.Property<byte[]>("FileData");

                    b.Property<string>("FileExt")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("FileName")
                        .IsRequired();

                    b.Property<string>("GroupName")
                        .HasMaxLength(50);

                    b.Property<bool>("IsTemprory");

                    b.Property<long>("Length");

                    b.Property<string>("Path");

                    b.Property<int?>("SaveFileMode");

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<DateTime>("UploadTime");

                    b.HasKey("ID");

                    b.ToTable("FileAttachments");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FrameworkAction", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ActionName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("CreateTime");

                    b.Property<string>("MethodName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid?>("ModuleId");

                    b.Property<string>("Parameter")
                        .HasMaxLength(50);

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdateTime");

                    b.HasKey("ID");

                    b.HasIndex("ModuleId");

                    b.ToTable("FrameworkActions");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FrameworkArea", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AreaName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("CreateTime");

                    b.Property<string>("Prefix")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdateTime");

                    b.HasKey("ID");

                    b.ToTable("FrameworkAreas");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FrameworkDomain", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("CreateTime");

                    b.Property<string>("DomainAddress")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("DomainName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("DomainPort");

                    b.Property<string>("EntryUrl");

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdateTime");

                    b.HasKey("ID");

                    b.ToTable("FrameworkDomains");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FrameworkGroup", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("CreateTime");

                    b.Property<string>("GroupCode")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("GroupRemark");

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdateTime");

                    b.HasKey("ID");

                    b.ToTable("FrameworkGroups");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FrameworkMenu", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ActionName");

                    b.Property<string>("ClassName");

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("CreateTime");

                    b.Property<int?>("DisplayOrder")
                        .IsRequired();

                    b.Property<Guid?>("DomainId");

                    b.Property<bool>("FolderOnly");

                    b.Property<string>("ICon")
                        .HasMaxLength(50);

                    b.Property<bool>("IsInherit");

                    b.Property<bool?>("IsInside")
                        .IsRequired();

                    b.Property<bool>("IsPublic");

                    b.Property<string>("MethodName");

                    b.Property<string>("ModuleName");

                    b.Property<string>("PageName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid?>("ParentId");

                    b.Property<bool>("ShowOnMenu");

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<string>("Url");

                    b.HasKey("ID");

                    b.HasIndex("DomainId");

                    b.HasIndex("ParentId");

                    b.ToTable("FrameworkMenus");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FrameworkModule", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AreaId");

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("CreateTime");

                    b.Property<string>("ModuleName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("NameSpace");

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdateTime");

                    b.HasKey("ID");

                    b.HasIndex("AreaId");

                    b.ToTable("FrameworkModules");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FrameworkRole", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("CreateTime");

                    b.Property<string>("RoleCode")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("RoleRemark");

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdateTime");

                    b.HasKey("ID");

                    b.ToTable("FrameworkRoles");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FrameworkUserBase", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(200);

                    b.Property<string>("CellPhone");

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("CreateTime");

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<string>("HomePhone")
                        .HasMaxLength(30);

                    b.Property<string>("ITCode")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("IsValid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<Guid?>("PhotoId");

                    b.Property<int?>("Sex");

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<string>("ZipCode");

                    b.HasKey("ID");

                    b.HasIndex("PhotoId");

                    b.ToTable("FrameworkUsers");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FrameworkUserGroup", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("CreateTime");

                    b.Property<Guid>("GroupId");

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<Guid>("UserId");

                    b.HasKey("ID");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("FrameworkUserGroup");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FrameworkUserRole", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("CreateTime");

                    b.Property<Guid>("RoleId");

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<Guid>("UserId");

                    b.HasKey("ID");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("FrameworkUserRole");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FunctionPrivilege", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("Allowed")
                        .IsRequired();

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("CreateTime");

                    b.Property<Guid>("MenuItemId");

                    b.Property<Guid?>("RoleId");

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<Guid?>("UserId");

                    b.HasKey("ID");

                    b.HasIndex("MenuItemId");

                    b.ToTable("FunctionPrivileges");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.SearchCondition", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Condition");

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("CreateTime");

                    b.Property<string>("Name");

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<Guid>("UserId");

                    b.Property<string>("VMName");

                    b.HasKey("ID");

                    b.HasIndex("UserId");

                    b.ToTable("SearchConditions");
                });

            modelBuilder.Entity("iRED.Model.WxActivity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("BeginTime")
                        .IsRequired();

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("CreateTime");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<DateTime?>("EndTime")
                        .IsRequired();

                    b.Property<bool>("IsValid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid?>("PictureId");

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdateTime");

                    b.HasKey("ID");

                    b.HasIndex("PictureId");

                    b.ToTable("WxActivitys");
                });

            modelBuilder.Entity("iRED.Model.WxOrder", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("GoodsStatus");

                    b.Property<string>("OrderNumber");

                    b.Property<int>("OrderStatus");

                    b.Property<decimal>("OrderTotal");

                    b.Property<int>("PayStatus");

                    b.Property<string>("UserAddress");

                    b.Property<int>("UserId");

                    b.Property<string>("UserPhone");

                    b.HasKey("ID");

                    b.HasIndex("UserId");

                    b.ToTable("WxOrders");
                });

            modelBuilder.Entity("iRED.Model.WxOrderItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId");

                    b.Property<decimal>("UnitPrice");

                    b.Property<int>("Units");

                    b.HasKey("ID");

                    b.HasIndex("ProductId");

                    b.ToTable("WxOrderItems");
                });

            modelBuilder.Entity("iRED.Model.WxOrderMiddle", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId");

                    b.Property<int>("OrderItemId");

                    b.HasKey("ID");

                    b.HasIndex("OrderId");

                    b.HasIndex("OrderItemId")
                        .IsUnique();

                    b.ToTable("WxOrderMiddle");
                });

            modelBuilder.Entity("iRED.Model.WxProduct", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AvailableStock")
                        .IsRequired();

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("CreateTime");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<bool>("IsValid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid?>("PictureId");

                    b.Property<decimal?>("Price")
                        .IsRequired();

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<int?>("VenueId")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("PictureId");

                    b.HasIndex("VenueId");

                    b.ToTable("WxProducts");
                });

            modelBuilder.Entity("iRED.Model.WxUser", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AvatarUrl");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("Gender");

                    b.Property<string>("Language");

                    b.Property<string>("NickName");

                    b.Property<string>("OpenId");

                    b.Property<string>("Province");

                    b.HasKey("ID");

                    b.ToTable("WxUsers");
                });

            modelBuilder.Entity("iRED.Model.WxVenue", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("CreateTime");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<bool>("IsValid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid?>("PictureId");

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdateTime");

                    b.HasKey("ID");

                    b.HasIndex("PictureId");

                    b.ToTable("WxVenues");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.DataPrivilege", b =>
                {
                    b.HasOne("WalkingTec.Mvvm.Core.FrameworkDomain", "Domain")
                        .WithMany()
                        .HasForeignKey("DomainId");

                    b.HasOne("WalkingTec.Mvvm.Core.FrameworkGroup", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId");

                    b.HasOne("WalkingTec.Mvvm.Core.FrameworkUserBase", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FrameworkAction", b =>
                {
                    b.HasOne("WalkingTec.Mvvm.Core.FrameworkModule", "Module")
                        .WithMany("Actions")
                        .HasForeignKey("ModuleId");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FrameworkMenu", b =>
                {
                    b.HasOne("WalkingTec.Mvvm.Core.FrameworkDomain", "Domain")
                        .WithMany()
                        .HasForeignKey("DomainId");

                    b.HasOne("WalkingTec.Mvvm.Core.FrameworkMenu", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FrameworkModule", b =>
                {
                    b.HasOne("WalkingTec.Mvvm.Core.FrameworkArea", "Area")
                        .WithMany("Modules")
                        .HasForeignKey("AreaId");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FrameworkUserBase", b =>
                {
                    b.HasOne("WalkingTec.Mvvm.Core.FileAttachment", "Photo")
                        .WithMany()
                        .HasForeignKey("PhotoId");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FrameworkUserGroup", b =>
                {
                    b.HasOne("WalkingTec.Mvvm.Core.FrameworkGroup", "Group")
                        .WithMany("UserGroups")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WalkingTec.Mvvm.Core.FrameworkUserBase", "User")
                        .WithMany("UserGroups")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FrameworkUserRole", b =>
                {
                    b.HasOne("WalkingTec.Mvvm.Core.FrameworkRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WalkingTec.Mvvm.Core.FrameworkUserBase", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FunctionPrivilege", b =>
                {
                    b.HasOne("WalkingTec.Mvvm.Core.FrameworkMenu", "MenuItem")
                        .WithMany("Privileges")
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.SearchCondition", b =>
                {
                    b.HasOne("WalkingTec.Mvvm.Core.FrameworkUserBase", "User")
                        .WithMany("SearchConditions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("iRED.Model.WxActivity", b =>
                {
                    b.HasOne("WalkingTec.Mvvm.Core.FileAttachment", "Picture")
                        .WithMany()
                        .HasForeignKey("PictureId");
                });

            modelBuilder.Entity("iRED.Model.WxOrder", b =>
                {
                    b.HasOne("iRED.Model.WxUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("iRED.Model.WxOrderItem", b =>
                {
                    b.HasOne("iRED.Model.WxProduct", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("iRED.Model.WxOrderMiddle", b =>
                {
                    b.HasOne("iRED.Model.WxOrder", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("iRED.Model.WxOrderItem", "OrderItem")
                        .WithOne("Order")
                        .HasForeignKey("iRED.Model.WxOrderMiddle", "OrderItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("iRED.Model.WxProduct", b =>
                {
                    b.HasOne("WalkingTec.Mvvm.Core.FileAttachment", "Picture")
                        .WithMany()
                        .HasForeignKey("PictureId");

                    b.HasOne("iRED.Model.WxVenue", "Venue")
                        .WithMany()
                        .HasForeignKey("VenueId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("iRED.Model.WxVenue", b =>
                {
                    b.HasOne("WalkingTec.Mvvm.Core.FileAttachment", "Picture")
                        .WithMany()
                        .HasForeignKey("PictureId");
                });
#pragma warning restore 612, 618
        }
    }
}
