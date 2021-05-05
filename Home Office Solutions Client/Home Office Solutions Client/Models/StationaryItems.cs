using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Office_Solutions_Client.Models
{
    
        public enum ProductType { Notebook, Pen, Paper, Tape, Envelope, Diary }
        public class StationaryItems
        {
            [Key]
            public int ProductID { get; set; }
            [Required(ErrorMessage = "A Name is required for this field")]
            public string Name { get; set; }
            [Required(ErrorMessage = "A Product Type is required for this field")]
            [Display(Name = "Product Type")]
            public ProductType ProductType { get; set; }
            [Required(ErrorMessage = " A product brand/manufacturer is required for this field")]
            public string Brand { get; set; }
            [Required(ErrorMessage = "Product Color is required for this field")]
            public string Color { get; set; }
            public string ProductDescription { get; set; }

            public override string ToString()
            {
                return String.Format("ProductID: {0} | Name: {1} | ProductType: {2} | Brand:{3} | Color: {4} | ProductDescription:{5}", ProductID, Name, ProductType, Brand, Color, ProductDescription);
            }


        }
    
}
