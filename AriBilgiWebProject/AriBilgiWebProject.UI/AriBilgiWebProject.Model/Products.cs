namespace AriBilgiWebProject.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Products
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public int Stock { get; set; }

        public double UnitPrice { get; set; }

        public short? Discount { get; set; }

        public short? Rate { get; set; }

        public long? Color { get; set; }

        public long? Tags { get; set; }

        public int? CategoryId { get; set; }

        public virtual Categories Categories { get; set; }
    }
}
