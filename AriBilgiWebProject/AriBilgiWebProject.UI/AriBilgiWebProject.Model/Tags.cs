namespace AriBilgiWebProject.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Tags
    {
        public int Id { get; set; }

        [Required]
        public string TagName { get; set; }

        public long TagCode { get; set; }
    }
}
