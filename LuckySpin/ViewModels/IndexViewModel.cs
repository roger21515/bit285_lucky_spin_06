using System.ComponentModel.DataAnnotations;

namespace LuckySpin.ViewModels
{ //FirstName, Luck, Starting Balance
    public class IndexViewModel
    {

        [Required(ErrorMessage = "Please enter your first name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please choose a lucky number")]
        public int Luck { get; set; }

        public decimal StartingBalance { get; set; }
    }
}
