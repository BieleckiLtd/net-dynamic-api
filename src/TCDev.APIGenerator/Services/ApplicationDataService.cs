﻿using Microsoft.AspNetCore.Http;
using TCDev.APIGenerator.Hooks;
using TCDev.APIGenerator.Schema.Interfaces;

namespace TCDev.APIGenerator.Data
{
    public class ApplicationDataService : IApplicationDataService<GenericDbContext, AuthDbContext>
    {
        public GenericDbContext GenericData {get;set;}
        public AuthDbContext AuthData { get; set; }
        public HttpContext Context { get; set; }


        public ApplicationDataService(GenericDbContext genericData, AuthDbContext authData, IHttpContextAccessor contextAccessor)
        {
            GenericData = genericData;
            AuthData = authData;
            Context = contextAccessor.HttpContext;
        }
    }
}
