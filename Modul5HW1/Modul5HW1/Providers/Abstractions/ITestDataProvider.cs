using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5HW1.Providers.Abstractions
{
    public interface ITestDataProvider
    {
        public string ObjCreateUserJson { get; set; }
        public string ObjUpdateUserJson { get; set; }
        public string ObjRegUserHavePassJson { get; set; }
        public string ObjRegUserDontHavePassJson { get; set; }
        public string ObjLogUserHavePassJson { get; set; }
        public string ObjLogUserDontHavePassJson { get; set; }
    }
}
