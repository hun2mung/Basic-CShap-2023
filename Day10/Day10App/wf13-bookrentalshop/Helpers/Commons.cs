using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf13_bookrentalshop.Helpers
{
    internal class Commons
    {
        // 모든 프로그램상에서 전부 사용 가능. static을 통해 메모리로 올라감. readonly로 고치기 불가!
        public static readonly string connString = "Server=localhost;" +
                                                   "Port=3306;" +
                                                   "Database=bookrentalshop;" +
                                                   "Uid=root;" +
                                                   "Pwd=12345;";
        
        // 로그인 사용자 아이디 저장변수 // 프로그램 전체에서 데이터 공유
        public static string LoginID = string.Empty;

    }
}
