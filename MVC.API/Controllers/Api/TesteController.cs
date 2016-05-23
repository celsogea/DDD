﻿using Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC.API.Controllers.Api
{
    public class TesteController : ApiController
    {

        private readonly IUserAppService _userAppService;

        public TesteController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }


        // GET: api/Teste
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Teste/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Teste
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Teste/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Teste/5
        public void Delete(int id)
        {
        }
    }
}
