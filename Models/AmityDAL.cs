using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcIEnumerable.Models
{
    public class AmityDAL
    {
        public IEnumerable<Amity> getStudent()
        {
            List<Amity> stu = new List<Amity>();
            stu.Add(new Amity
            {
                sId = 1,
                sEnroll = 101,
                sName = "Shiv Chandar"
            });
            stu.Add(new Amity
            {
                sId = 2,
                sEnroll = 102,
                sName = "Pushpa Kumari"
            });
            stu.Add(new Amity
            {
                sId = 3,
                sEnroll = 103,
                sName = "Alok Jha"
            });
            stu.Add(new Amity
            {
                sId = 4,
                sEnroll = 104,
                sName = "Suraj Kumar"
            });
            return stu;
        }
    }
}