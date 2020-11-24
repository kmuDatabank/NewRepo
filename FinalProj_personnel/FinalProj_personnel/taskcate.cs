using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class taskcate
    {
        public taskcate(string task)
        {
            this.cate = cate;

        }

        public taskcate()
        { 
        }

        private static taskcate instance = new taskcate();
        public static taskcate GetInstance() { return instance; }
        string strConn = "Server = 49.50.174.201;database=databank;Uid=databank;Pwd=dbdb;Charset=utf8";
      
        public string cate { get; set; }

        public void Insert(string query)
        {
        }
        
    }
}
