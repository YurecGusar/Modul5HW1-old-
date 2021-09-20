using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul5HW1.Providers.Abstractions;
using Newtonsoft.Json;

namespace Modul5HW1.Providers
{
    public class TestDataProvider : ITestDataProvider
    {
        public TestDataProvider()
        {
            SetData();
        }

        public string ObjCreateUserJson { get; set; }
        public string ObjUpdateUserJson { get; set; }
        public string ObjRegUserHavePassJson { get; set; }
        public string ObjRegUserDontHavePassJson { get; set; }
        public string ObjLogUserHavePassJson { get; set; }
        public string ObjLogUserDontHavePassJson { get; set; }

        private void SetData()
        {
            ObjCreateUserJson = JsonConvert.SerializeObject(
                new
                {
                    name = "morpheus",
                    job = "leader"
                });

            ObjUpdateUserJson = JsonConvert.SerializeObject(
                new
                {
                    name = "morpheus",
                    job = "zion resident"
                });

            ObjRegUserHavePassJson = JsonConvert.SerializeObject(
                new
                {
                    email = "eve.holt@reqres.in",
                    password = "pistol"
                });

            ObjRegUserDontHavePassJson = JsonConvert.SerializeObject(
                 new
                 {
                     email = "eve.holt@reqres.in",
                 });

            ObjLogUserHavePassJson = JsonConvert.SerializeObject(
                new
                {
                    email = "eve.holt@reqres.in",
                    password = "cityslicka"
                });

            ObjLogUserDontHavePassJson = JsonConvert.SerializeObject(
                new
                {
                    email = "eve.holt@reqres.in"
                });
        }
    }
}
