//Pedro Castaneda
//10-27-2022
//Magic 8 Ball - Endpoint
//Create an endpoint that will give a random answer to a users question
//Peer Review by; Andrea Burr ; i like the game i think it runs well overall very short and clean code !
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using castanedaPMagic8BallEndpoint.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace castanedaPMagic8BallEndpoint.Controllers
{
    [Route("[controller]")]
    public class Magic8BallController : Controller
    {
        Random r = new Random();
        string[] magicBallAnswers = {"It is cerain.", "It is decidedly so.", "Without a doubt.", "Yes definitely.", "You may rely on it", "As I see it, yes.", "Most likely.", "Outlook good.", "Yes.", "Signs point to yes.", "Reply hazy, try again", "Ask again later.", "Better not tell you now.", "Cannot predict now.", "Concentrate and ask again.", "Don't count on it.", "My reply is no.", "My sources say no.", "Outlook not so good.", "Very doubtful."};
        [HttpGet("Magic8Ball")]
        public string MagicAnswer(MagicModel user)
        {
            int randomAnswer = r.Next(0, magicBallAnswers.Length);
            return $"{magicBallAnswers[randomAnswer]}";
        }
    }
}