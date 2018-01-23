using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class PlayerModel
    {
        [Required]
        public string UserName { get; set; }

        public string UserID { get; set; }

    }
}