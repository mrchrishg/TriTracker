using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using TriTracker.Model;
using TriTracker.Model.ViewModel;

namespace TriTracker.Web.App_Start
{
    public class AutomapperConfig
    {
        public static void CreateMappings()
        {
            Mapper.CreateMap<Activity, ActivityViewModel>();
            Mapper.CreateMap<ActivityViewModel, Activity>();



        }
    }
}