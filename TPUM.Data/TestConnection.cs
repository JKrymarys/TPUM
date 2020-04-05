using System;

namespace TPUM.Data
{
    public class TestConnection
    {

        public int generateRandomNumber () {

            Random r = new Random();
            return r.Next(1,100);
        }
    }
}
