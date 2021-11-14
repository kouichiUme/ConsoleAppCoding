using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Chapter14Sql
    {
        // private ILogger _logger;


        public static void p1()
        {

            // "select t.TenantName from Tenants t";
            // "left join AptTenants as at";
            // "on at.TenantID = t.TenantID";
            // "group by t.TenantName";
            // "having count(at.AptID) > 1";


        }


        public static void p2()
        {
            //   "select b.BuildingID ,count(r.Status) from Buildings b";
            //     "left join Apartments a";
            //     "on b.BuildingID= a.BuildingID";
            //     "left join  Requests r";
            //     "on r.AptID = a.AptID";
            //    "where r.Status = 'open'";
            //     "group by b.BuildingID";
        }

        public static void JoinImplicit()
        {


            // linq
            // from
            // 


        }


        public static void whereInLinq()
        {

        }

    }
}
