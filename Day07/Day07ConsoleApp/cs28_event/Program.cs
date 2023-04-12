using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs28_event
{
    // 1. 이벤트 사용 대리자 생성
    delegate void EventHandler(string message);

    class CustomNotifier
    {
        // 2. 이벤트 준비
        public event EventHandler SomethingChanged;

        public void DoSomething(int num)
        {
            int temp = num % 10;
            if(temp != 0 && temp % 3 == 0)  // 3. 이벤트 발생 상황 수행
            {
                SomethingChanged(string.Format("{0} : odd", num));
            } 
        }
    }
    internal class Program
    {
        // 4. 이벤트가 대신 호출할 메소드
        static void CustomHandler(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            CustomNotifier notifier = new CustomNotifier();
            notifier.SomethingChanged += new EventHandler(CustomHandler);

            for(int i = 0; i <= 30; i++)
            {
                notifier.DoSomething(i);
            }
        }
    }
}
