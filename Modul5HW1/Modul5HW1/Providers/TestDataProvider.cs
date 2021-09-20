using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Modul5HW1.Providers
{
    public class TestDataProvider
    {
        public TestDataProvider()
        {
            SetData();
        }

        public string ObjCreateUserJson { get; set; }
        public string ObjUpdateUserJson { get; set; }

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

            var serObj3 = JsonConvert.SerializeObject(
                new
                {
                    email = "eve.holt@reqres.in",
                    password = "pistol"
                });

            var serObj4 = JsonConvert.SerializeObject(
                 new
                 {
                     email = "eve.holt@reqres.in",
                 });

            var serObj5 = JsonConvert.SerializeObject(
                new
                {
                    email = "eve.holt@reqres.in",
                    password = "cityslicka"
                });
        }
    }
}
