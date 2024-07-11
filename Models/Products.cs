using System.ComponentModel.DataAnnotations;

namespace ModelBiding.Models
{
    public class Products
    {
        /// <summary>
        /// The title of the product
        /// </summary>
        [Required(ErrorMessage = "Need to input the title !!!")] //  the error message when the title is empty
        [Display(Name = "Product Name")] // Change the display name for the label of title
        public string Title { get; set; }

        /// <summary>
        /// The selling price of product
        /// </summary>
        //[Required(ErrorMessage = "Price is not valid!!!")]
        [Range(0,double.MaxValue,ErrorMessage ="Please input the valid price !!!")]
        [DataType(DataType.Currency )]
        public double Price { get; set; }

        /// <summary>
        /// The number of unit in stock
        /// </summary>
        [Range(0,double.MaxValue)]
        [Display(Name="Qty")]
        public int Quantity { get; set; }
    }
}
