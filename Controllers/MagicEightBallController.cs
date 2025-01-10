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
    public class MagicEightBallController : ControllerBase
    {
        private readonly MagicEightBallServices _magicEightBallServices;

        public MagicEightBallController(MagicEightBallServices magicEightBallServices)
        {
            _magicEightBallServices =magicEightBallServices;
        }
        
        [HttpGet]
        [Route("GetAnswer/{question}")]

        public string GetAnswer(string question)
        {
            return _magicEightBallServices.GetAnswer(question);
        }


    }
}