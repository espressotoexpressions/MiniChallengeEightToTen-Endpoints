using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniChallengeEightToTen_Endpoints.Services;


namespace MiniChallengeEightToTen_Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuessItController : ControllerBase
    {
        private readonly GuessItServices _guessItServices;

        public GuessItController (GuessItServices guessItServices)
        {

            _guessItServices= guessItServices;
        }

        [HttpGet]
        [Route("GuessItEasy/Easy/{num}")]

        public string GuessItEasy(string num){
            return _guessItServices.GuessIt(num,1);
        }

        [HttpGet]
        [Route("GuessItEasy/Medium/{num}")]

        public string GuessItMedium(string num){
            return _guessItServices.GuessIt(num,2);
        }

        [HttpGet]
        [Route("GuessItEasy/Hard/{num}")]

        public string GuessItHard(string num){
            return _guessItServices.GuessIt(num,3);
        }
    }
}