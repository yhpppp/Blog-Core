using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Core.Repository.sugar
{
    class BaseDBConfig
    {
        //配置文件的形式
        //public static string ConnectionString = File.ReadAllText(@"D:\my-file\dbCountPsw1.txt").Trim();

        //正常格式是

        public static string ConnectionString = "server=.;uid=sa;pwd=123456;database=BlogDB";

    }
}
