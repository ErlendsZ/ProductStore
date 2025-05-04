namespace ProductStore.Models
{
    public class Product
    {
        /// <summary>
        /// Product ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Product name.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Product quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Product price.
        /// </summary>
        public decimal Price { get; set; }
    }

}
