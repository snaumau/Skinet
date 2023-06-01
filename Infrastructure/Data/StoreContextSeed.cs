using Core.Entities;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace Infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext storeContext, ILoggerFactory loggerFactory)
        {
			try
			{
				if (!storeContext.ProductBrands.Any())
				{
					var brandsData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/brands.json");
					var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);

					if (brands is not null)
					{
                        foreach (var item in brands)
                        {
                            storeContext.ProductBrands.Add(item);
                        }

						await storeContext.SaveChangesAsync();
                    }
				}

                if (!storeContext.ProductTypes.Any())
                {
                    var typesData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/types.json");
                    var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);

                    if (types is not null)
                    {
                        foreach (var item in types)
                        {
                            storeContext.ProductTypes.Add(item);
                        }

                        await storeContext.SaveChangesAsync();
                    }
                }

                if (!storeContext.Products.Any())
                {
                    var productsData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/products.json");
                    var products = JsonSerializer.Deserialize<List<Product>>(productsData);

                    if (products is not null)
                    {
                        foreach (var item in products)
                        {
                            storeContext.Products.Add(item);
                        }

                        await storeContext.SaveChangesAsync();
                    }
                }
            }
			catch (Exception ex)
			{
                var logger = loggerFactory.CreateLogger<StoreContextSeed>();
                logger.LogError(ex.Message);
			}
        }
    }
}
