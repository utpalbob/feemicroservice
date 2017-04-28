using System;
using System.Collections.Generic;

namespace feems {

	public interface IFeemsRepository{

		Feems Update(Feems feems);
		Feems Add(Feems feems);
		Feems Get(int id);
		ICollection<Feems> All();

	}
}
