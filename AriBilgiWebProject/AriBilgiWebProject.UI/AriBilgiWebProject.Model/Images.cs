namespace AriBilgiWebProject.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Images
    {
        public int Id { get; set; }

        [Required]
        public string TableName { get; set; }

        public int TableReference { get; set; }

        [Required]
        public string PicUrl { get; set; }
    }
}
