using QRInfoSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace QRInfoSystem.Services.Models
{
    public class SheduleOutputModel
    {
        public static Expression<Func<Shedule, SheduleOutputModel>> FromModel
        {
            get
            {
                return s => new SheduleOutputModel
                {
                    end = s.EndDate,
                    start = s.StartDate,
                    title = "Room : " + s.Room.Model,
                };
            }
        }

        public string title { get; set; }

        public DateTime start { get; set; }

        public DateTime end { get; set; }
    }
}