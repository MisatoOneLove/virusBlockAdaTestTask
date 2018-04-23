using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace virusBlockadaTestTask.ViewModels
{
    public class UserViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public UserViewModel()
        {
            
        }

        public UserViewModel(string username, string password)
        {
            Username = username;
            Password = password;
        }

    }
}