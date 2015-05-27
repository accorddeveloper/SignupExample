using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DanielGrahamHomeEx.Models
{
    public class SignupViewModel
    {
        public Guid? Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Required]
        
        [StringLength(200)]
        public string LastName { get; set; }

        [Required]
        [StringLength(1)]
        public string Gender { get; set; }

        [Required]
        [StringLength(25)]
        public string Phone { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        [Required]
        [StringLength(100)]
        public string City { get; set; }

        [Required]
        [StringLength(2)]
        public string State { get; set; }

        [Required]
        [StringLength(10)]
        public string Zip { get; set; }

        public void SaveModel()
        {
            if(this.Id == null || this.Id == Guid.Empty)
            {
                this.Id = Guid.NewGuid();
                HttpContext.Current.Session[this.Id.Value.ToString()] = this;
            }
        }

        public static SignupViewModel GetModel(Guid id)
        {
            var model = HttpContext.Current.Session[id.ToString()] as SignupViewModel;
            return model;
        }
    }
}