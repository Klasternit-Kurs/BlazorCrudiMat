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

		public Osobe(ILogger<Osobe> log)
		{
			_logger = log;
		}

		public void UcitajOsobe()
		{
			_logger.LogInformation("Pocinjem sa ucitavanjem podataka");
			Baza b = new Baza();
			Clients.Caller.SendAsync("EvoOsobe", b.Osobas.ToList());
			_logger.LogInformation("Poslato klijentu");
		}
	}
}
