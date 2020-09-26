using BlazorCrudiMat.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrudiMat.Server
{
	public class Baza : DbContext
	{
		public DbSet<Osoba> Osobas { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-75VO5EN\TESTSERVER;Initial Catalog=BazaOsobe;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Osoba>().HasKey(o => o.ID);

			modelBuilder.Entity<Osoba>().HasData(
				new Osoba
				{
					ID = -1,
					Grad = "asd",
					Ime = "Pera",
					Prezime = "Peric",
					PObox = "234",
					Ulica = "zklj",
					Broj = "356"
				},
				new Osoba
				{
					ID = -2,
					Grad = "zxc",
					Ime = "Neko",
					Prezime = "Nekic",
					PObox = "567",
					Ulica = "kjhg",
					Broj = "87"
				},
				new Osoba
				{
					ID = -3,
					Grad = "aefesf",
					Ime = "Zkljjj",
					Prezime = "Blabla",
					PObox = "233000",
					Ulica = "Neka tamo",
					Broj = "Neki tamo"
				});
		}
	}
}
