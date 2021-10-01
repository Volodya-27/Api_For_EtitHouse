namespace WebApplication21.Models
{
    public class NullHouse : IHouse
    {
        public int Id { get; set; }
        public string Desc { get; set; }
        public string Img { get; set; }


        private NullHouse()
        {
            this.Id = 0;
            this.Desc = "null";
            this.Img = "null";
        }
        static public NullHouse Create() => new NullHouse();

    }
}
