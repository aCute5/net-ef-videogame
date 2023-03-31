// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using net_ef_videogame;

Console.WriteLine("Ciao! Benvenuto nel database dei videogame?");


using(VideoGameContext db = new VideoGameContext())
{

    SoftwareHouse nuovasoftwareHouse = new SoftwareHouse
    {
        Name = "Ciao",
        IVA = 456023,
        City = "Torino",
        Country = "Italia",
        Videogames = new List<Videogame>
    {
        new Videogame { Name = "Videogioco1", Overview = "Descrizione1", ReleaseDate = DateTime.Now },
        new Videogame { Name = "Videogioco2", Overview = "Descrizione2", ReleaseDate = DateTime.Now }
    }

    };
    db.Add(nuovasoftwareHouse);
    db.SaveChanges();
}