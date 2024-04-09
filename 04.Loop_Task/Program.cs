namespace _04.Loop_Task
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("숫자를 입력하세요 : ");
			int star = int.Parse(Console.ReadLine());

			for (int i = 0; i < star; i++)
			{
				Console.Write("*");
			}

			Console.WriteLine();
			Console.WriteLine();

			for (int i = 0; i < star; i++)
			{
				for (int j = 0; j < star; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}

			Console.WriteLine();
			Console.WriteLine();

			for (int i = 1; i < star + 1; i++)
			{
				for (int j = 0; j < i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}

			Console.WriteLine();
			Console.WriteLine();

			for (int i = 0; i < star; i++)
			{
				for (int j = star; j > i; j--)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}

			Console.WriteLine();
			Console.WriteLine();

			for (int i = 1; i < star + 1; i++)
			{
				for (int j = star; j > i; j--)
				{
					Console.Write(" ");
				}
				for (int k = 0; k < (i * 2) - 1; k++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			for (int i = 1; i < star + 1; i++)
			{
				for (int j = 0; j < i; j++)
				{
					Console.Write(" ");
				}
				for (int k = star * 2 - i; k > i + 1; k--)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}

			

			int playerInput;
			int playerWin = 0;
			int computerWin = 0;

			Console.WriteLine("가위바위보를 시작합니다.");

			do
			{
				do
				{
					Console.WriteLine("플레이어는 가위는 1번, 바위는 2번, 보는 3번 중에 하나를 입력해주세요");
					playerInput = int.Parse(Console.ReadLine());
				} while (playerInput != 1 && playerInput != 2 && playerInput != 3);

				switch (playerInput)
				{
					case 1:
						Console.WriteLine("플레이어는 가위를 냈습니다.");
						break;
					case 2:
						Console.WriteLine("플레이어는 바위를 냈습니다.");
						break;
					case 3:
						Console.WriteLine("플레이어는 보를 냈습니다.");
						break;
				}

				Random raddom = new Random();
				int computerInput = raddom.Next(1, 4);

				switch (computerInput)
				{
					case 1:
						Console.WriteLine("컴퓨터는 가위를 냈습니다.");
						break;
					case 2:
						Console.WriteLine("컴퓨터는 바위를 냈습니다.");
						break;
					case 3:
						Console.WriteLine("컴퓨터는 보를 냈습니다.");
						break;
				}

				if (playerInput == 1 && computerInput == 2)
				{
					computerWin++;
					Console.WriteLine("컴퓨터가 승리하였습니다.");
				}
				else if (playerInput == 1 && computerInput == 3)
				{
					playerWin++;
					Console.WriteLine("플레이어가 승리하였습니다.");
				}
				else if (playerInput == 2 && computerInput == 1)
				{
					playerWin++;
					Console.WriteLine("플레이어가 승리하였습니다.");
				}
				else if (playerInput == 2 && computerInput == 3)
				{
					computerWin++;
					Console.WriteLine("컴퓨터가 승리하였습니다.");
				}
				else if (playerInput == 3 && computerInput == 1)
				{
					computerWin++;
					Console.WriteLine("컴퓨터가 승리하였습니다.");
				}
				else if (playerInput == 3 && computerInput == 2)
				{
					playerWin++;
					Console.WriteLine("플레이어가 승리하였습니다.");
				}
				else
				{
					Console.WriteLine("플레이어와 컴퓨터가 비겼습니다.");
				}
				Console.WriteLine($"현재 플레이어 승리 : {playerWin} 컴퓨터 승리 : {computerWin}\n");
			} while (playerWin != 3 && computerWin != 3);

			if (playerWin == 3)
			{
				Console.WriteLine("플레이어가 승리하였습니다.");
			}
			else
			{
				Console.WriteLine("컴퓨터가 승리하였습니다.");
			}

			Console.WriteLine("게임이 종료되었습니다.");
		}
	}
}
