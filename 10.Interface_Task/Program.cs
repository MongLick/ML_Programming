namespace _10.Interface_Task
{
	internal class Program
	{
		// 플레이어 : 물체를 여는 기능, 들어가는 기능
		// 상자, 문, 마을
		// 문, 마을 : 들어갈 수 있어야 함
		// 상자, 문 : 열수 있어야 함
		// 상자를 열면 : 아이템 나오게
		// 문 들어갔을 때 : 건물안으로 들어간다.
		// 마을 들어갔을 때 : 마을 맵을 진입한다.
		// 문을 열면 : 진입할 수 있도록 설명한다.
		// 탑승물 : 열수 있다. 여는 경우 탈수 있다. 

		public interface IEnterable
		{
			void Enter();
		}

		public interface IOpenable
		{
			void Open();
		}

		class Player
		{
			public void Enter(IEnterable enterable)
			{
				Console.WriteLine("플레이어가 대상에 들어가기 시도합니다.");
				enterable.Enter();
			}

			public void Open(IOpenable openable)
			{
				Console.WriteLine("플레이어가 대상을 열기 시도합니다.");
				openable.Open();
			}
		}

		class Box : IOpenable
		{
			public void Open()
			{
				Console.WriteLine("박스를 오픈합니다.");
				Console.WriteLine("아이템이 나왔습니다.");
			}
		}

		class Door : IOpenable, IEnterable
		{
			public void Open()
			{
				Console.WriteLine("문을 엽니다. 문에 들어갈 수 있습니다.");
			}

			public void Enter()
			{
				Console.WriteLine("문에 들어갑니다.");
			}
		}

		class Town : IEnterable
		{
			public void Enter()
			{
				Console.WriteLine("마을에 진입합니다.");
			}
		}

		class Car : IOpenable, IEnterable
		{
			bool a = false;

			public void Open()
			{
				Console.WriteLine("자동차 문이 열립니다.");
				a = true;
			}

			public void Enter()
			{
				if (a == false)
				{
					Console.WriteLine("자동차 문이 잠겨있어 자동차 안으로 들어갈 수 없습니다.");
					return;
				}

				Console.WriteLine("자동차 안으로 들어갑니다.");
			}
		}

		static void Main(string[] args)
		{
			Player player = new Player();
			Box box = new Box();
			Door door = new Door();
			Town town = new Town();
			Car car = new Car();

			player.Open(box);
			player.Open(door);

			player.Enter(door);
			player.Enter(town);

			player.Enter(car);
			player.Enter(car);
			player.Open(car);
			player.Enter(car);
		}
	}
}
