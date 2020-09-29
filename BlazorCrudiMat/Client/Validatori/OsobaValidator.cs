using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorCrudiMat.Shared;
using FluentValidation;

namespace BlazorCrudiMat.Client.Validatori
{
	public class OsobaValidator : AbstractValidator<Osoba>
	{
		public OsobaValidator()
		{
			RuleFor(o => o.Ime).NotEmpty().WithMessage("Mora ime!");
			RuleFor(o => o.Prezime).NotEmpty().WithMessage("Mora prezime!");
			RuleFor(o => o.PObox).NotEmpty().WithMessage("Ne prazno!")
				                 .Must(po => NekaProvera(po)).WithMessage("Jok!");
		}

		public bool NekaProvera(string s)
		{
			if (string.IsNullOrEmpty(s))
				return false;
			return	s.Length == 5 ? true : false;
		}
		
	}
}
