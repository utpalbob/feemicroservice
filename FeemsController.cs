using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace feems
{
	[Route("api/[controller]")]
	public class FeemsController : Controller
	{

		private IFeemsRepository feemsRepository;


		public FeemsController(IFeemsRepository feemsRepository)
		{
			this.feemsRepository = feemsRepository;
		}

		[HttpGet]
		public virtual IActionResult Get()
		{
			return this.Ok(feemsRepository.All());
		}

		[HttpGet("{id}")]
		public virtual IActionResult Get(int id)
		{
			return this.Ok(feemsRepository.Get(id));
		}

	}
}
