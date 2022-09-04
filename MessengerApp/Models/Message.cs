using System.ComponentModel.DataAnnotations;

namespace MessengerApp.Models
{
    //імплементація many to many relationship
    public class Message
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string MessageText { get; set; }
        public DateTime DateOfSending { get; set; }
        public string UserID { get; set; }
        public virtual User Sender { get; set; }

}
}
