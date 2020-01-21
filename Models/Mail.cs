using System.ComponentModel.DataAnnotations;

namespace ProgettoFinaleBack
{
    public class Mail
    {
        [Key]
        public string ProtId { get; set; }
        public string StartDate { get; set; }
        public string ReceiveDate { get; set; }
        public Tipo Type { get; set; }
        public string Sender { get; set; }
        public string Subject { get; set; }
        public string Object { get; set; }
        public string Attachment { get; set; }
    }

    public enum Tipo{
        Entrata = 1,
        Uscita = 2,
        Interna = 3
    }
}