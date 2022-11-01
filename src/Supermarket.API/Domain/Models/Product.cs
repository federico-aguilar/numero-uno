namespace Supermarket.API.Domain.Models
{
    public class Product
    {
        private int id; //backing field
        public int Id { get; set; } //property
        
        //get and set are accessors (some say set is a mutator): 
        // able to access data and info in private fields. Do so from 
        // public properties
        // https://stackoverflow.com/a/29422973/14077628
        // {
        //      get => id;
        //      set => id = value
        // }
        
        public string Name { get; set; } 
        public short QuantityInPackage { get; set; }
        public EUnitOfMeasurement UnitOfMeasurement { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}