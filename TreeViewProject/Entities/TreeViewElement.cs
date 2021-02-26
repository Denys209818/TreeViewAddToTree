using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TreeViewProject.Models
{ 
    [Table("tblTreeViewCategories")]
    public class TreeViewElement
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        [Required, StringLength(255)]
        public string UrlSlug { get; set; }
        [ForeignKey("Parent.Id")]
        public int? ParentId { get; set; }
        public TreeViewElement Parent { get; set; }
    }
}
