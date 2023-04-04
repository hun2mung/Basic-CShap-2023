using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs04_enums
{
    internal class Program
    {
        enum HomeTown
        {
            SEOUL = 1,
            DAEJEON,
            DAEGU,
            BUSAN,
            JEJU
        }
 
        //enum DialogResult
        //{
        //    YES,
        //    NO,
        //    CANCEL,
        //    CONFIRM,
        //    OK
        //};
        static void Main(string[] args)
        {
            //DialogResult result = DialogResult.YES;
            //Console.WriteLine(result);

            HomeTown myHomeTown;

            myHomeTown = HomeTown.BUSAN;

            if (myHomeTown == HomeTown.SEOUL)
            {
                Console.WriteLine("서울 출신이시군요!");
            }
            else if(myHomeTown == HomeTown.DAEJEON)
            {
                Console.WriteLine("충청도에유~");
            }
            else if(myHomeTown == HomeTown.DAEGU)
            {
                Console.WriteLine("대구여~");
            }
            else if (myHomeTown == HomeTown.BUSAN)
            {
                Console.WriteLine("부산이라예~~");
            }
        }
    }
}
