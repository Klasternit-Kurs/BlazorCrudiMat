using BlazorCrudiMat.Shared;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrudiMat.Server
{
	public class Osobe : Hub
	{
		private readonly ILogger<Osobe> _logger;
		private readonly Baza _db;

		public Osobe(ILogger<Osobe> log, Baza db)
		{
			_logger = log;
			_db = db;
		}

		public void UcitajOsobe()
		{
			_logger.LogInformation("Pocinjem sa ucitavanjem podataka");
			Clients.Caller.SendAsync("EvoOsobe", _db.Osobas.ToList());
			_logger.LogInformation("Poslato klijentu");
		}

		public void ObrisiOsobu(Osoba o)
		{
			_logger.LogInformation("Pocinjem brisanje");
			_db.Osobas.Remove(o);
			_db.SaveChanges();
			Clients.Caller.SendAsync("EvoOsobe", _db.Osobas.ToList());
		}

		public void UrediOsobu(Osoba o)
		{
			_logger.LogInformation("Krecem sa uredjivanjem");
			if (o.ID == 0)
			{
				_logger.LogInformation("Nova je osoba, unosim...");
				_db.Osobas.Add(o);
				_db.SaveChanges();
				_logger.LogInformation("Gotov sa dodavanjem.");
			} else
			{
				_db.Osobas.Update(o);
				_db.SaveChanges();

			}
			Clients.Caller.SendAsync("EvoOsobe", _db.Osobas.ToList());
		}
	}
}
