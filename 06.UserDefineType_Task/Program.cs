namespace _06.UserDefineType_Task
{
	internal class Program
	{
		enum Rsp { Scissors = 1, Rock, Paper }

		static void Main(string[] args)
		{
			int playerWin = 0;
			int computerWin = 0;
			Console.WriteLine("가위 바위 보 게임을 시작합니다.\n");
			do
			{
				Rsp playerChoice = Player();
				Rsp computerChoice = Computer();
				int Result = Battle(playerChoice, computerChoice);
				if (Result == 0)
				{
					computerWin++;
				}
				else if (Result == 1)
				{
					playerWin++;
				}
				Console.WriteLine($"플레이어 승리 수 : {playerWin}, 컴퓨터 승리 수 : {computerWin}\n");
			} while (playerWin != 3 && computerWin != 3);
		}

		static Rsp Player()
		{
			ConsoleKeyInfo keyInfo;
			bool keyTrue = false;
			Rsp rsp = new Rsp();
			do
			{
				keyTrue = false;
				Console.WriteLine("가위는 1번, 바위는 2번, 보는 3번 중에 하나를 입력해주세요");
				keyInfo = Console.ReadKey();

				if (keyInfo.Key == ConsoleKey.NumPad1)
				{
					Console.WriteLine("\n플레이어는 가위를 냈습니다.");
					rsp = Rsp.Scissors;
				}
				else if (keyInfo.Key == ConsoleKey.NumPad2)
				{
					Console.WriteLine("\n플레이어는 바위를 냈습니다.");
					rsp = Rsp.Rock;
				}
				else if (keyInfo.Key == ConsoleKey.NumPad3)
				{
					Console.WriteLine("\n플레이어는 보를 냈습니다.");
					rsp = Rsp.Paper;
				}
				else
				{
					Console.WriteLine("\n잘못 입력하였습니다. 다시 입력해주세요.\n");
					keyTrue = true;
				}
			} while (keyTrue == true);

			return rsp;
		}

		static Rsp Computer()
		{
			Random random = new Random();
			Rsp rsp = new Rsp();
			int computer = random.Next(1, 4);

			switch (computer)
			{
				case 1:
					Console.WriteLine("컴퓨터는 가위를 냈습니다.");
					rsp = Rsp.Scissors;
					break;
				case 2:
					Console.WriteLine("컴퓨터는 바위를 냈습니다.");
					rsp = Rsp.Rock;
					break;
				case 3:
					Console.WriteLine("컴퓨터는 보를 냈습니다.");
					rsp = Rsp.Paper;
					break;
			}
			return rsp;
		}

		static int Battle(Rsp playerChoice, Rsp computerChoice)
		{
			int playerWin = 0;
			if(playerChoice == computerChoice)
			{
				Console.WriteLine("플레이어와 컴퓨터가 비겼습니다.");
				playerWin = 2;
			}
			else if(playerChoice == Rsp.Scissors && computerChoice == Rsp.Rock)
			{
				Console.WriteLine("컴퓨터가 승리했습니다.");
			}
			else if(playerChoice == Rsp.Scissors && computerChoice == Rsp.Paper)
			{
				Console.WriteLine("플레이어가 승리했습니다.");
				playerWin++;
			}
			else if(playerChoice == Rsp.Rock && computerChoice == Rsp.Scissors)
			{
				Console.WriteLine("플레이어가 승리했습니다.");
				playerWin++;
			}
			else if(playerChoice == Rsp.Rock && computerChoice == Rsp.Paper)
			{
				Console.WriteLine("컴퓨터가 승리했습니다.");
			}
			else if (playerChoice == Rsp.Paper && computerChoice == Rsp.Scissors)
			{
				Console.WriteLine("컴퓨터가 승리했습니다.");
			}
			else
			{
				Console.WriteLine("플레이어가 승리했습니다.");
				playerWin++;
			}
			return playerWin;
		}
	}
}
