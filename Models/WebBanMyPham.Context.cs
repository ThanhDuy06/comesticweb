﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanMyPham.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WebBanMyPhamEntities : DbContext
    {
        public WebBanMyPhamEntities()
            : base("name=WebBanMyPhamEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<menu> menus { get; set; }
        public virtual DbSet<news> news { get; set; }
        public virtual DbSet<menu_sanpham> menu_sanpham { get; set; }
        public virtual DbSet<menu_footer> menu_footer { get; set; }
        public virtual DbSet<footer_htkh> footer_htkh { get; set; }
        public virtual DbSet<footer_lienhe> footer_lienhe { get; set; }
        public virtual DbSet<footer_lienhe2> footer_lienhe2 { get; set; }
        public virtual DbSet<banner> banners { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<block> blocks { get; set; }
        public virtual DbSet<category_product> category_product { get; set; }
        public virtual DbSet<pruduct_trangdiem> pruduct_trangdiem { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
