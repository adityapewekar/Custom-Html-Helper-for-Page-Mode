using System.ComponentModel;

namespace CustomHTMLHelperPageMode.Models
{
    public class User
    {
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Contact No")]
        public string Phone { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Address")]
        public string Address { get; set; }
    }
}