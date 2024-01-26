using System.Text;

namespace RealEstateCLI
{
    internal class Ad
    {
        public int ID { get; set; }
        public int Area { get; set; }
        public Category Category { get; set; }
        public DateTime CreateAt { get; set; }
        public string Description { get; set; }
        public int Floors { get; set; }
        public bool FreeOfCharge { get; set; }
        public string ImageURL { get; set; }
        public (double Lat, double Long) Coords { get; set; }
        public int Rooms { get; set; }
        public Seller Seller { get; set; }

        public override string ToString() =>
            $"\telado neve:      {Seller.Name}\n" +
            $"\telado telefonja: {Seller.Phone}\n" +
            $"\talapterulet:     {Area}\n" +
            $"\tszobak szama:    {Rooms}";

        public double DistanceTo((double Lat, double Long) origin) =>
            Math.Sqrt(
                Math.Pow(origin.Lat - Coords.Lat, 2) +
                Math.Pow(origin.Long - Coords.Long, 2));

        public static List<Ad> LoadFromCSV(string filename)
        {
            List<Ad> ads = new();
            using StreamReader sr = new($@"..\..\..\src\{filename}", Encoding.UTF8);
            _ = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                var v = sr.ReadLine().Split(';');
                var latlong = v[2].Split(',');

                ads.Add(new()
                {
                    ID = int.Parse(v[0]),
                    Rooms = int.Parse(v[1]),
                    Coords = (
                        Lat: double.Parse(latlong[0].Replace('.', ',')),
                        Long: double.Parse(latlong[1].Replace('.', ','))),
                    Floors = int.Parse(v[3]),
                    Area = int.Parse(v[4]),
                    Description = v[5],
                    FreeOfCharge = v[6] == "1",
                    ImageURL = v[7],
                    CreateAt = DateTime.Parse(v[8]),
                    Seller = new()
                    {
                        ID = int.Parse(v[9]),
                        Name = v[10],
                        Phone = v[11],
                    },
                    Category = new()
                    {
                        ID = int.Parse(v[12]),
                        Name = v[13],
                    },
                });
            }
            return ads;
        }
    }
}
