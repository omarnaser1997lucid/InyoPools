//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IPPEA.EntityData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int uid { get; set; }
        public string Code { get; set; }
        public Nullable<int> ManufacturerId { get; set; }
        public Nullable<int> VendorId { get; set; }
        public Nullable<int> IsActive { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string UpSellMessage { get; set; }
        public string ImageSmallPath { get; set; }
        public string ImageLargePath { get; set; }
        public string FileName { get; set; }
        public string Cost { get; set; }
        public string Price { get; set; }
        public Nullable<int> IsOnSale { get; set; }
        public string SalePrice { get; set; }
        public Nullable<int> IsShipable { get; set; }
        public string ShipPrice { get; set; }
        public string Weight { get; set; }
        public string Length { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public Nullable<int> HasCountryTax { get; set; }
        public Nullable<int> HasStateTax { get; set; }
        public Nullable<int> HasLocalTax { get; set; }
        public string DateAdded { get; set; }
        public string DateModified { get; set; }
        public string Keywords { get; set; }
        public string DetailLink { get; set; }
        public Nullable<int> Inventory_Tracked { get; set; }
        public Nullable<int> DropShip { get; set; }
        public Nullable<int> DownloadOneTime { get; set; }
        public string DownloadExpire { get; set; }
        public Nullable<int> DealTimeIsActive { get; set; }
        public Nullable<int> MMIsActive { get; set; }
    }
}