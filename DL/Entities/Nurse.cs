namespace DL.Entities
{
    public class Nurse  
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nurse() { }
        public Nurse(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
