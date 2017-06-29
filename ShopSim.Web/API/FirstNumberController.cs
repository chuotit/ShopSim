using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using ShopSim.Service;
using ShopSim.Web.Infrastructure.Core;
using ShopSim.Web.Models;

namespace ShopSim.Web.API
{
    [RoutePrefix("api/firstnumber")]
    public class FirstNumberController : ApiControllerBase
    {
        private IFirstNumberService _firstNumberService;

        public FirstNumberController(IErrorService errorService, IFirstNumberService firstNumberService)
            : base(errorService)
        {
            this._firstNumberService = firstNumberService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                var listFirstNumber = _firstNumberService.GetAll();
                var listFirstNumberVm = Mapper.Map<List<FirstNumberViewModel>>(listFirstNumber);

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listFirstNumberVm);
                return response;
            });
        }
    }
}
