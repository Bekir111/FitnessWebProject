
namespace FitnessApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    
    using FitnessApp.Data.Models;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System.Reflection.Emit;

    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .Property(p => p.Price)
                .HasColumnType("decimal(18,4)");

            builder
                .Property(p => p.IsAvailable)
                .HasDefaultValue(true);

            builder.HasData(this.GenerateProducts());
        }


        private Product[] GenerateProducts()
        {
            ICollection<Product> products = new HashSet<Product>();

            Product product;

            product = new Product()
            {
                Name = "Vital Protein Powder.Chocolate flavor",
                PictureUrl = "https://cdn10.bigcommerce.com/s-quxuy/products/133/images/504/Main-Image-Whey__17399.1590994371.1280.1280.jpg?c=2",
                Price = 139.99M,
                Description = "Elevate Your Performance. High-quality protein powder for muscle recovery and growth. Packed with essential nutrients and amino acids. Enjoy the delicious taste and smooth texture. Unleash your potential with Vital Protein, the key to maximizing your performance and vitality."
            };
            products.Add(product);

            product = new Product()
            {
                Name = "Vital Creatine Monohydrate",
                PictureUrl = "https://cdn10.bigcommerce.com/s-quxuy/products/150/images/563/Creatine-main-image-450__28099.1603079104.1280.1280.jpg?c=2",
                Price = 59.99M,
                Description = "Unleash Your Power. Pure and potent creatine monohydrate supplement. Enhances strength, power, and muscular endurance. Supports explosive workouts and accelerated muscle recovery. Unleash your true potential with Vital Creatine, the ultimate tool for maximizing your athletic performance."
            };
            products.Add(product);

            product = new Product()
            {
                Name = "Vital Pre-Workout",
                PictureUrl = "https://cdn10.bigcommerce.com/s-quxuy/products/229/images/525/225g-Pre-Workour-Main__55780.1633392104.386.513.jpg?c=2",
                Price = 54.99M,
                Description = "Ignite Your Workouts. Boosts energy, focus, and endurance. Enhances strength and intensity during training. Experience heightened performance with Vital Pre-Workout, your secret weapon for crushing your workouts and surpassing your limits."
            };
            products.Add(product);

            product = new Product()
            {
                Name = "Vital Multivitamin",
                PictureUrl = "https://cdn01.pharmeasy.in/dam/products_otc/R08152/musclexp-men-daily-vital-fitness-60-tablets-pack-of-3-7-1671744190.jpg",
                Price = 16.99M,
                Description = "Nourish Your Well-being. Provides essential nutrients for optimal health and vitality. Supports immune function, energy levels, and overall well-being. Prioritize your health with Vital Multivitamin, your daily source of essential nutrients for a vibrant life."
            };
            products.Add(product);

            return products.ToArray();
        }
    }
}
