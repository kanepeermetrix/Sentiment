using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sentiment.Clients;
using Sentiment.Models;

namespace Sentiment.Controllers
{
    [Route("api/sentiment")]
    [ApiController]
    public class SentimentController : ControllerBase
    {
        private readonly SentimentService _sentimentService;
        private readonly ILineWriter _lineWriter;

        public SentimentController(SentimentService sentimentService, ILineWriter lineWriter)
        {
            _sentimentService = sentimentService;
            _lineWriter = lineWriter;

        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DocumentList documentList)
        {
            var response = await _sentimentService.SendToAzure(documentList);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = _lineWriter.GetGhost();
            return Ok(response);
        }
    }
}
