﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TencentYoutuYun.SDK.Csharp;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 设置为你自己的密钥对
            string appid = "1006935";
            string secretId = "AKIDmtnfLVH3DoWpn5yOIdu5jG5alHacadvt";
            string secretKey = "lmHyGzfLibqK5NAZSQ7dcIYNN72dEOtF";
            string userid = "380549494";



            Conf.Instance().setAppInfo(appid, secretId, secretKey, userid, Conf.Instance().YOUTU_END_POINT);

            string path = System.IO.Directory.GetCurrentDirectory() + "\\test.jpg";
            string path2 = System.IO.Directory.GetCurrentDirectory() + "\\test.jpg";
            string result = string.Empty;

            result = Youtu.facecompare(path,path2);
            Console.WriteLine(result);
            Console.ReadKey();

            //// 人脸定位 调用demo
            result = Youtu.faceshape(path);
            Console.WriteLine(result);
            Console.ReadKey();

           result = Youtu.getpersonids("group");
           Console.WriteLine(result);
           Console.ReadKey();
        }
    }
}
