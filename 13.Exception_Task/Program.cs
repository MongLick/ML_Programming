namespace _13.Exception_Task
{
	internal class Program
	{
		// 두 수를 입력받고 숫자1 / 숫자2 의 결과를 출력하도록 하자. 단, 숫자2가 0인 경우 예외처리를 통해 0으로 나눌 수 없다고 출력하도록 하자.
		static void Main(string[] args)
		{
			bool check = false;
			Console.WriteLine("첫 번째 수를 입력해주세요");
			float first = float.Parse(Console.ReadLine());
			do
			{
				Console.WriteLine("두 번째 수를 입력해주세요");
				float second = float.Parse(Console.ReadLine());
				if (second != 0)
				{
					float result = first / second;
					Console.WriteLine($"첫 번째 수 / 두 번째 수의 값은 {result}입니다");	
				}
				else
				{
					Console.WriteLine("숫자 0을 입력하였습니다 다시 입력해주세요");
					check = true;
				}
			}while (check == true);
		}
	}
}
