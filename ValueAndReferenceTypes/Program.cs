namespace ValueAndReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id = 1;
            IdGuncelle(id);
            Console.WriteLine(id);

            Ogrenci ogrenci = new Ogrenci() // Referans tip
            {
                Id = 1
            };
            IdGuncelle(ogrenci);
            
                Console.WriteLine(ogrenci.Id);
            
        }

        static void IdGuncelle(int id)
        {
            id = 7;
        }
        static void IdGuncelle(Ogrenci ogrenci)
        {
            ogrenci.Id = 7;
        }
    }
    class Ogrenci
    {
        public int Id { get; set; }
    }
}