//------------------------------------------------------------------------------
// <copyright file="WebDataService.svc.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;

namespace NorthwindService
{
    public class Northwind : DataService<NorthwindEntities >
    {
        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(DataServiceConfiguration config)
        {
            // TODO: set rules to indicate which entity sets and service operations are visible, updatable, etc.
            // Examples:
            // config.SetEntitySetAccessRule("MyEntityset", EntitySetRights.AllRead);
            // config.SetServiceOperationAccessRule("MyServiceOperation", ServiceOperationRights.All);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;

            config.SetEntitySetAccessRule("Orders", EntitySetRights.AllRead
     | EntitySetRights.WriteMerge
     | EntitySetRights.WriteReplace);
            config.SetEntitySetAccessRule("Order_Details", EntitySetRights.AllRead
                | EntitySetRights.AllWrite);
            config.SetEntitySetAccessRule("Customers", EntitySetRights.AllRead);
            config.SetEntitySetAccessRule("Products", EntitySetRights.AllRead
                | EntitySetRights.WriteReplace);
            config.SetEntitySetAccessRule("Categories", EntitySetRights.AllRead
                | EntitySetRights.WriteReplace);
        }
    }
}
