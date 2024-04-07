namespace _01.Variable_Task
{
	internal class Program
	{
		//캐릭터 선택창을 만들어보자
		//이름, 직업, 레벨, 체력을 입력받고 입력받은 내용을 변수에 저장.
		//모든 입력이 완료 되었을 때 입력한 데이터들을 출력해주자.
		//단, 이름 / 직업 문자열, 레벨 / 체력 정수형 으로 사용하자.

		static void Main(string[] args)
		{
			string name;
			string job;
			int level;
			int hp;

			Console.Write("플레이어의 이름을 입력해주세요 : ");
			name = Console.ReadLine();
			Console.WriteLine($"플레이어의 이름은 {name}입니다\n");

			Console.Write("플레이어의 직업을 입력해주세요 : ");
			job = Console.ReadLine();
			Console.WriteLine($"플레이어의 직업은 {job}입니다\n");

			Console.Write("플레이어의 레벨을 입력해주세요 : ");
			level = int.Parse(Console.ReadLine());
			Console.WriteLine($"플레이어의 레벨은 {level}입니다\n");

			Console.Write("플레이어의 체력을 입력해주세요 : ");
			hp = int.Parse(Console.ReadLine());
			Console.WriteLine($"플레이어의 체력은 {hp}입니다");
		}
	}
}
