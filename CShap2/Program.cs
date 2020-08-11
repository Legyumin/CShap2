using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShap2
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";
            //문자열 변형
            WriteLine(greeting + "\n");
            WriteLine(greeting.IndexOf("o"));
            WriteLine(greeting.LastIndexOf("o"));

            WriteLine(greeting.Contains("Evening"));
            WriteLine(greeting.Contains("Morning")); 

            WriteLine(greeting.Replace("Morning", "Evening")); //greeting에서 "Morning"을 찾아 "Evening"으로 교체

            WriteLine(greeting.ToLower()); //모두 소문자
            WriteLine(greeting.ToUpper()); //모두 대문자
            WriteLine(greeting.Insert(4, " Sunday"));
            WriteLine(greeting.Remove(4,8));
            WriteLine("   Hello World     ".Trim()); //앞뒤 공백을 삭제

            //문자열 분할
            WriteLine(greeting.Substring(0, 5)); //0번지 이상 5번지 미만
            WriteLine(greeting.Substring(5)); //5번지 이상 전부

            string[] arr=greeting.Split(new string[] { " " },System.StringSplitOptions.None);
            foreach (string element in arr)
                WriteLine(element);
        }
    }
}
