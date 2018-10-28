using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace FTCweb.Models
{
    public class GenreEnum
    {
        public enum Genre {

      
            [Display(Name = "Action Game")]
            Action,
            [Display(Name = "Adventure")]
            Adventure,
            [Display(Name = "3D Shooter")]
            Shooter_3D,


        }
    }

}