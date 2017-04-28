using System;
using System.Linq;
using System.Collections.Generic;


namespace feems{

	public class FeemsRepository : IFeemsRepository
	{

		public static ICollection<Feems> feemsCol;

		public FeemsRepository()
		{
			if(feemsCol == null){
				feemsCol = new List<Feems>(){

					new Feems(){id=1, Fee="Paid"},
					new Feems(){id=2, Fee="Unpaid"},
					new Feems(){id=3, Fee="Paid"},
					new Feems(){id=4, Fee="Unpaid"},
				};
			}

		}

		public Feems Update(Feems feems)
		{

			Feems oldFeems = this.Get(feems.id);
			oldFeems.Fee = feems.Fee;
			return oldFeems;
		}


		public ICollection<Feems> All()
		{
			return feemsCol;
		}

		public Feems Add(Feems feems)
		{
			feemsCol.Add(feems);
			return feems;
		}

		public Feems Get(int id)
		{

			return feemsCol.ElementAt(id);
		}


	}
}
