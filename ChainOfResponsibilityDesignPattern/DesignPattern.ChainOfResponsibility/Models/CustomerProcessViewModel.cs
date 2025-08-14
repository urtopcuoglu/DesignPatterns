namespace DesignPattern.ChainOfResponsibility.Models
{
    public class CustomerProcessViewModel //burası sanal bir sınıf olarak kullanılacak.
    {
        public string CustomerProcessId { get; set; }
        public string Name { get; set; }
        public string Amount { get; set; }
        public string EmployeeName { get; set; }
        public string Description { get; set; }
    }
}
