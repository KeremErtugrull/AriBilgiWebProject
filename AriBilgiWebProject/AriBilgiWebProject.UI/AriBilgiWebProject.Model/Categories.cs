namespace AriBilgiWebProject.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Categories
    {
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        [StringLength(100)]
        public string Icon { get; set; }

        public int? ParentId { get; set; }

        public long? tags { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
