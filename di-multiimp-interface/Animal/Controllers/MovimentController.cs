using AnimalMoviment.Enums;
using AnimalMoviment.Intefaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AnimalMoviment.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class MovimentController : ControllerBase
    {

        private readonly IMoviment _dogMoviment;
        private readonly IMoviment _catMoviment;
        private readonly IMoviment _humanMoviment;
        public MovimentController(Func<MovimentEnum, IMoviment> serviceResolver)
        {
            _dogMoviment = serviceResolver(MovimentEnum.Dog);
            _catMoviment = serviceResolver(MovimentEnum.Cat);
            _humanMoviment = serviceResolver(MovimentEnum.Human);
        }

        [HttpGet]
        public string GetCat()
        {
            return _catMoviment.Walk();
        }

        [HttpGet]
        public string GetDog()
        {
            return _dogMoviment.Walk();
        }

        [HttpGet]
        public string GetHuman()
        {
            return _humanMoviment.Walk();
        }

    }
}
