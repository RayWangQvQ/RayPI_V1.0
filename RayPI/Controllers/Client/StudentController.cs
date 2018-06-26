using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RayPI.Controllers.Client
{
    /// <summary>
    /// 学生模块
    /// </summary>
    [Produces("application/json")]
    [Route("api/client/[controller]")]
    public class StudentController : Controller
    {
        /*
        /// <summary>
        /// 根据姓名获取学生
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetByName")]
        public JsonResult Test()
        {
            return Json("");
        }
        */
    }
}