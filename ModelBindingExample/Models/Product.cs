using System.ComponentModel.DataAnnotations;

namespace ModelBindingExample.Models
{
    /// <summary>
    /// Represent a single salable product
    /// for Newegg.com
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The user facing full name of the product
        /// </summary>
        [MaxLength(200)]
        [RegularExpression(@"^[a-zA-Z0-9]*$", ErrorMessage = "Only alphanumeric characters are allowed.")]
        public required string ProductName { get; set; }

        /// <summary>
        /// Retail price of the item. Does
        /// not include tax
        /// </summary>
        [Range(0, 100_000)]
        public double Price { get; set; }

        /// <summary>
        /// Percent the item is on sale, number
        /// must be between 0 and 100 (0 - 100%)
        /// </summary>
        [Range(0, 100)]
        public int SalePercentage { get; set; }

        /// <summary>
        /// User facing description of the product
        /// </summary>
        public required string ProductDescription { get; set; } = "No description given";

        /// <summary>
        /// The company that is selling the product
        /// </summary>
        public string SoldBy { get; set; }
    }
}
