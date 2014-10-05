using QRInfoSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace QRInfoSystem.Services.Models
{
    public class SheduleViewModel
    {
        public static Expression<Func<Shedule, SheduleViewModel>> FromModel
        {
            get
            {
                return s => new SheduleViewModel
                    {
                        EndDate = s.EndDate.ToString(),
                        StartDate = s.StartDate.ToString(),
                        Room = s.Room.Model,
                        TeacherId = s.TeacherId
                    };
            }
        }

        public string Room { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public int TeacherId { get; set; }
    }
}