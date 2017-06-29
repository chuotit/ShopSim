using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using ShopSim.Model.Models;
using ShopSim.Service;
using ShopSim.Web.Infrastructure.Core;
using ShopSim.Web.Models;
using ShopSim.Web.Infrastructure.Extensions;

namespace ShopSim.Web.API
{
    [RoutePrefix("api/simnetwork")]
    public class SimNetworkController : ApiControllerBase
    {
        private ISimNetworkService _simNetworkService;

        public SimNetworkController(IErrorService errorService, ISimNetworkService simNetworkService)
            : base(errorService)
        {
            this._simNetworkService = simNetworkService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                var listSimNetwork = _simNetworkService.GetAll();
                var listSimNetworkVm = Mapper.Map<List<SimNetworkViewModel>>(listSimNetwork);

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listSimNetworkVm);
                return response;
            });
        }

        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage request, SimNetworkViewModel simNetworkVm)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    SimNetwork newSimNetwork = new SimNetwork();
                    newSimNetwork.UpdateSimNetwork(simNetworkVm);
                    var simNetworkReturn = _simNetworkService.Add(newSimNetwork);
                    _simNetworkService.SaveChanges();
                    response = request.CreateResponse(HttpStatusCode.Created, simNetworkReturn);
                }
                return response;
            });
        }

        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage request, SimNetworkViewModel simNetworkVm)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var postSimNetworkDb = _simNetworkService.GetById(simNetworkVm.ID);
                    postSimNetworkDb.UpdateSimNetwork(simNetworkVm);
                    _simNetworkService.Update(postSimNetworkDb);
                    _simNetworkService.SaveChanges();
                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }

        [Route("delete")]
        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _simNetworkService.Delete(id);
                    _simNetworkService.SaveChanges();
                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }
    }
}