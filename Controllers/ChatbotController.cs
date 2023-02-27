using System;
using Microsoft.AspNetCore.Mvc;
using webapi.Models;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatbotController : ControllerBase
    {
        [HttpGet]
        //[ValidateAntiForgeryToken]
        public string Get([FromQuery] string Message)
        {

            return Message;
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ResponseModel Post([FromBody] RequestModel item)
        {
            return new ResponseModel { UserId = Utils.generateID(), Question = item.Message, Answer = item.Message, CSRF_TOKEN = item.__RequestVerificationToken };
        }
    }
}

