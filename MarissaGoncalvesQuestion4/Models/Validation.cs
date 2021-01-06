using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MarissaGoncalvesQuestion4.Models
{
    
    [MetadataType(typeof(Post_Validation))]
    public partial class Post
    {

    }

    public class Post_Validation
    {
        [Display (Name = "Message")]
        [Required(ErrorMessage = "Please enter a message for the posts list.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Please enter a message between 2-50 characters.")]
        public string message;

        [Display(Name = "Author")]
        [Required (ErrorMessage = "Please enter an author for the posts lists.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Please enter an author between 2-50 characters.")]
        public string author;
    }


}