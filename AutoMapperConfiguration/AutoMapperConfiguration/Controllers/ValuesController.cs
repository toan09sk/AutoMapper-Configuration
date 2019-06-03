using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using AutoMapper;
using AutoMapperConfiguration.DTO;

namespace AutoMapperConfiguration.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        private readonly IMapper _mapper;
        public ValuesController(IMapper mapper)
        {
            _mapper = mapper;
        }

        // GET api/values
        public IEnumerable<FileViewModel> Get()
        {
            var info = new DirectoryInfo(@"C:\uploadFiles");
            var files = info.GetFiles("*.*", SearchOption.AllDirectories).           
            OrderBy(p => p.CreationTime).ToArray();
            var filesDisplay = _mapper.Map<FileInfo[], IEnumerable<FileViewModel>>(files);
            return filesDisplay;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
