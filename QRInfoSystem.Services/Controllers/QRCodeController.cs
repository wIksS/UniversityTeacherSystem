using QRInfoSystem.Data;
using QRInfoSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QRInfoSystem.Services.Controllers
{
    public class QRCodeController : BaseController    
    {
        public QRCodeController(IQRInfoSystemData data)
            : base(data)
        {
        }

        [Authorize]
        [HttpPost]
        public IHttpActionResult CreateQRCode(int id)
        {
            QRCode code = new QRCode();
            code.TeacherId = id;

            data.QRCodes.Add(code);
            data.QRCodes.SaveChanges();

            return Ok(code);
        }
    }
}
