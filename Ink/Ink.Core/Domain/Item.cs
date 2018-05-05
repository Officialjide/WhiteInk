using System;

namespace Ink.Core.Domain
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public int? LocaltoCenter { get; set; }
        public string MainUnit { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
    }
    /*public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
   public void Configure(EntityTypeBuilder<Product> builder)
   {
      builder.HasKey(x => x.ProductID);
      builder.HasOne(e => e.Details).WithOne( o=> o.Product).HasForeignKey<ProductDetail>(e => e.ProductID);
      builder.Property(x => x.Cost).HasColumnName("StandardCost");
      builder.HasQueryFilter(o => o.Cost > 0);
      builder.ToTable("Product");
   }
}*/
}
