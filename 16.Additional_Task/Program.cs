namespace _16.Additional_Task
{
	internal static class Program
	{
		// <확장메서드>
		// int 또는 string 자료형에 확장메서드로 추가기능을 붙여보자
		// int value = 3; string str = “abc def ghi”;
		// bool isEven = value.IsEven(); 또는 int wordCount = str.WordCount();

		public static int WordCount(this string str)
		{
			return str.Split(' ').Length;
		}

		public static int WordCount2(this int num)
		{
			return num.ToString().Length;
		}

		public static bool IsEven(this int num)
		{
			return (num % 2 == 0);
		}

		// <매개변수 ref>
		// public static void Swap<일반화>(left, right) 함수
		// 어떤 자료형이 들어오더라도 두 매개변수 원본을 교체하는 함수 구현

		public static void Swap<T>(ref T left, ref T right)
		{
			T temp = left;
			left = right;
			right = temp;
		}

		// <Property 속성>
		// class Player 를 만들어주고
		// 체력이 라고 하는 변수를 외부에서 읽을 수는 있지만, 변경할 수 없도록
		// 체력관련 프로퍼티(Hp) 구현

		public class Player
		{
			public Action<int> OnChangeHp;

			private int hp = 100;
			public int HP { get { return hp; } set { hp = value;} }

			public void TakeDamage(int damage)
			{
				hp -= damage;
				Console.WriteLine($"플레이어가 데미지를 받아 {hp} 체력이 되었습니다.");
				if(OnChangeHp != null)
				{
					OnChangeHp(hp);
				}
			}
		}

		public class UI
		{
			public void SetHpBar(int hp)
			{
				Console.WriteLine($"UI 체력바를 {hp}으로 설정합니다.");
			}
		}

		static void Main(string[] args)
		{
			// 1번 문제
			int value = 3;
			string str = "abc def ghi";

			int wordCount = str.WordCount();
			int wordCount2 = value.WordCount2();

			bool isEven = value.IsEven();

			Console.WriteLine(WordCount(str));      
			Console.WriteLine(str.WordCount());     
			Console.WriteLine(wordCount);

			Console.WriteLine(WordCount2(value));   
			Console.WriteLine(value.WordCount2());  
			Console.WriteLine(wordCount2);

			Console.WriteLine(isEven);

			// 2번 문제
			int left = 10;
			int right = 20;
			Swap(ref left, ref right);
			Console.WriteLine($"{left}, {right}");

			string left1 = "야";
			string right2 = "호";
			Swap(ref left1, ref right2);
			Console.WriteLine($"{left1}, {right2}");

			// 3번 문제
			Player player = new Player();
			Console.WriteLine(player.HP);

			UI ui = new UI();

			player.OnChangeHp += ui.SetHpBar;

			player.TakeDamage(10);
		}

		// c# 단위평가한 날
	}
}
