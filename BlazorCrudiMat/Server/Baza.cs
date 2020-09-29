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

		public Baza(DbContextOptions<Baza> op) : base(op) { }

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
