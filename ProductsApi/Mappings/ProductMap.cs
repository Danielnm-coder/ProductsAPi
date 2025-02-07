using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductsApi.Entities;

namespace ProductsApi.Mappings
{
    /// <summary>
    /// Classe de mapeamento para entidade produto
    /// </summary>
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("PRODUCTS");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("ID")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            builder.Property(p => p.Name)
                .HasColumnName("NAME")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.Price)
                .HasColumnName("PRICE")
                .HasColumnType("decimal(10,2)")
                .IsRequired();

            builder.Property(p => p.Quantiity)
                .HasColumnName("QUANTITY")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.CategoryId)
                .HasColumnName("CATEGORY_ID")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            builder.HasOne(p => p.Category)//Produto tem 1 categoria
                .WithMany(c => c.Product)//Categoria TEM MUITOS produtos
                .HasForeignKey(p => p.CategoryId);//Chave estrangeira

        }
    }
}
