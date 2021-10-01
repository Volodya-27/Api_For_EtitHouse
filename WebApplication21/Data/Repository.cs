using System.Collections.Generic;
using System.Linq;
using WebApplication21.Models;

namespace WebApplication21.Data
{
    public class Repository
    {
        static List<IHouse> data;
        static Repository()
        {
            data = new List<IHouse>()
            {
                new House (){ Id = 1, Desc = "Elit House 4", Img="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQRkzDcZ4C6K8cwMtuGH7m25JFfhAma8wZBqw&usqp=CAU"},
                new House (){ Id = 2, Desc = "Elit House 44", Img="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQRkzDcZ4C6K8cwMtuGH7m25JFfhAma8wZBqw&usqp=CAU"},
                new House (){ Id = 3, Desc = "Elit House 43", Img="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQRkzDcZ4C6K8cwMtuGH7m25JFfhAma8wZBqw&usqp=CAU"},
                new House (){ Id = 5, Desc = "Elit House 42", Img="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQRkzDcZ4C6K8cwMtuGH7m25JFfhAma8wZBqw&usqp=CAU"},

            };
        }

        public static void AddHouse(IHouse house)
        {
            house.Id = data.Count;
            data.Add(house);
        }
        public static IEnumerable<IHouse> GetHouse() => data;

        public static IHouse GetHouseById(int Id) => Id >= 0 && Id < data.Count ? data[Id] : NullHouse.Create();
        public static IEnumerable<IHouse> GetHouseRange(int pos, int count)
            => data.Where(car => car.Id >= pos && car.Id < pos + count);
    }
}
