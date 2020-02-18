﻿
namespace PetStore.Data.Models
{
    using static DataValidation;
    using static DataValidation.User;
    using System.Collections.Generic;

    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(EmailMaxLength)]        
        public string Email { get; set; }
        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();

    }
}