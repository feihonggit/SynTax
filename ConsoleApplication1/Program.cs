using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1、typeof()与GetType()的区别
            if (false)
            {
                string name = "lxf";
                string str1 = name.GetType().Name; // String
                int a = 123;
                string str2 = typeof(int).Name; //Int32
                string str3 = a.GetType().Name; //Int32
            }
            #endregion

            #region 2、DataTable的select参数 string filterExpression熟悉
            if (false)
            {
                DataTable dt = new DataTable("Student");
                DataColumn dc1 = new DataColumn("ID", typeof(int));
                DataColumn dc2 = new DataColumn("Name", typeof(string));
                DataColumn dc3 = new DataColumn("Birthday", typeof(DateTime));
                dt.Columns.Add(dc1);
                dt.Columns.Add(dc2);
                dt.Columns.Add(dc3);

                DataRow dr1 = dt.NewRow();
                dr1["ID"] = 12;
                dr1["Name"] = "lxf";
                dr1["Birthday"] = new DateTime(1991, 11, 17);

                DataRow dr2 = dt.NewRow();
                dr2["ID"] = 5;
                dr2["Name"] = "zhangsan";
                dr2["Birthday"] = new DateTime(1990, 05, 17);
                dt.Rows.Add(dr1);
                dt.Rows.Add(dr2);

                DataRow[] drs = dt.Select("Birthday='1990.05.17'");
                foreach (var item in drs)
                {
                    Console.WriteLine("姓名：" + item["Name"] + "年龄：" + item["Birthday"]);
                }

            }
            #endregion

            #region  3、字典和集合值的获取  键|索引
            if (false)
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic["name"] = "lxf";    // 字典只能根据键获取值  不能根据索引获取值 业务它是无需的
                dic["sex"] = "male";
                foreach (var item in dic)
                {
                    Console.WriteLine(item);
                }
                List<string> list = new List<string>(); // 只能通过索引访问集合元素，访问前必须先赋值，不然会报超出索引范围异常
                list.Add("李小飞");
                list.Add("马云");
                list[0] = "ls"; // 
                list[1] = "my";
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }

            // DataRow对象既可以用索引访问列值  也可用列名访问列值

            #endregion

            #region StringBuilder测试
            StringBuilder sb = new StringBuilder();
            sb.Append("acadf{0}kljl");  //不会当做占位符
            sb.AppendFormat("1243{0}23452", "中国"); //acadf{0}kljl1243中国23452
            Console.WriteLine(sb.ToString());
            Console.WriteLine("===============");
            string str = sb.ToString();
            sb.AppendFormat(str, "哈哈");
            Console.WriteLine(sb.ToString()); //acadf{0}kljl1243中国23452acadf哈哈kljl1243中国23452

            #endregion

            Console.ReadKey();
        }
    }
}
