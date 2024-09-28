using System.ComponentModel.DataAnnotations;

namespace ITHub.Models.Dto
{ 

    public class ChangePasswordRequestDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

    }

}
