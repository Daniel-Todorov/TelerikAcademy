﻿//using BullsAndCows.Data;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.Serialization;
//using System.ServiceModel;
//using System.Text;

//namespace BullsAndCows.Wcf
//{
//    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProjectService" in code, svc and config file together.
//    // NOTE: In order to launch WCF Test Client for testing this service, please select ProjectService.svc or ProjectService.svc.cs at the Solution Explorer and start debugging.
//    public class ProjectService : IProjectService
//    {
//        private BullsAndCowsData data;

//        public ProjectService()
//        {
//            this.data = new BullsAndCowsData(BullsAndCowsContext.Create());
//        }

//        public int GetData()
//        {

//            return this.data.Articles.All().Count(); ;
//        }
//    }
//}