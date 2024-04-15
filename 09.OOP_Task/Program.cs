using System.Security.Cryptography.X509Certificates;

namespace _09.OOP_Task
{
	internal class Program
	{
		class Driver
		{
			public string name;

			public void Ride(Vehicle vehicle)
			{
				Console.WriteLine($"{this.name} 이/가 {vehicle.name} 을 운전합니다.");
			}

			public void SpeedControlUp(Vehicle vehicle)
			{
				vehicle.SpeedUp();
			}

			public void SpeedControlDown(Vehicle vehicle)
			{
				vehicle.SpeedDown();
			}
		}

		class Vehicle
		{
			public string name;
			public int speed = 0;

			public void SpeedUp()
			{
				speed += 10;
				Console.WriteLine($"{name}의 속도가 {speed} 으로 증가합니다.");
			}

			public void SpeedDown()
			{
				if(speed <= 0)
				{
					Console.WriteLine("현재 속도는 0입니다. 더 느리게 달릴 수 없습니다.");
					return;
				}
				speed -= 10;
				Console.WriteLine($"{name}의 속도가 {speed} 으로 감소합니다.");
			}
		}
		class Monster
		{
			public void Setting(string name, int hp, int damage)
			{
				Console.WriteLine($"{name}는 {hp}의 체력을 가지고 있고 {damage}의 데미지를 가지고 있습니다.");
			}
		}

		class Monster2
		{
			protected string name;
			protected int hp;

			public void Move()
			{
				Console.WriteLine($"{name} 이/가 움직입니다.");
			}

			public void TakeHit(int damage)
			{
				hp -= damage;
				Console.WriteLine($"{name} 이/가 {damage}를 받아 체력이 {hp} 이 되었습니다.");
			}
		}

		class Dragon : Monster2
		{
			public Dragon()
			{
				name = "드래곤";
				hp = 100;
			}

			public void Breath()
			{
				Console.WriteLine($"{name} 이/가 브레스를 뿜습니다.");
			}
		}

		class Slime : Monster2
		{
			public Slime()
			{
				name = "슬라임";
				hp = 30;
			}

			public void Split()
			{
				Console.WriteLine($"{name} 이/가 분열합니다.");
			}
		}

		class Orc : Monster2
		{
			public Orc()
			{
				name = "오크";
				hp = 50;
			}

			public void Anger()
			{
				Console.WriteLine($"{name} 이/가 분노합니다.");
			}
		}

		class OrcKing : Orc
		{
			public OrcKing()
			{
				name = "오크왕";
				hp = 150;
			}

			public void Shout()
			{
				Console.WriteLine($"{name} 이/가 큰 소리를 치며 플레이어의 방어력을 저하시킵니다.");
			}
		}

		class Skill
		{
			public virtual void Execute()
			{
				Console.WriteLine("스킬 재사용 대기시간을 진행시킴.");
			}
		}

		class FireBall : Skill
		{
			public override void Execute()
			{
				base.Execute();
				Console.WriteLine("전방에 화염구를 날림");
			}
		}

		class Heal : Skill
		{
			public override void Execute()
			{
				base.Execute();
				Console.WriteLine("아군을 치유시킴");
			}
		}

		class Player
		{
			Skill skill;

			public void SetSkill(Skill skill)
			{
				this.skill = skill;
			}

			public void UseSkill()
			{
				skill.Execute();
			}
		}

		abstract class Item
		{
			public abstract void Use();
		}

		class Potion : Item
		{
			public override void Use() 
			{
				Console.WriteLine("포션을 사용하여 체력을 회복합니다.");
			}
		}

		class Herb : Item
		{
			public override void Use()
			{
				Console.WriteLine("해독초를 사용하여 독을 해제합니다.");
			}
		}

		class Player2
		{
			public void PotionUse(Potion potion)
			{
				potion.Use();
			}

			public void HerbUse(Herb herb)
			{
				herb.Use();
			}
		}

		static void Main(string[] args)
		{
			// 1번 문제
			Driver dirver = new Driver() { name = "드라이버"};
			Vehicle vehicle = new Vehicle() { name = "오토바이"};

			dirver.Ride(vehicle);

			int key;
			do
			{
				Console.WriteLine("속도를 높이려면 1번키를 속도를 줄이려면 2번 키를 눌러주세요 종료하면 3번을 눌러주세요");
				key = int.Parse(Console.ReadLine());

				if (key == 1)
				{
					dirver.SpeedControlUp(vehicle);
				}
				else if (key == 2)
				{
					dirver.SpeedControlDown(vehicle);
				}
				else if(key == 3)
				{
					Console.WriteLine("운전을 종료합니다.");
				}
				else
				{
					Console.WriteLine("다시 입력해주세요");
				}
			}while (key != 3);

			// 2번 문제
			Console.WriteLine("몬스터에 이름을 설정해주세요");
			string name = Console.ReadLine();
			Console.WriteLine("몬스터에 체력을 설정해주세요");
			int hp = int.Parse(Console.ReadLine());
			Console.WriteLine("몬스터에 데미지를 설정해주세요");
			int damage = int.Parse(Console.ReadLine());
			Monster monster = new Monster();
			monster.Setting(name, hp, damage);

			//3번 문제
			Dragon dragon = new Dragon();
			Slime slime = new Slime();
			Orc orc = new Orc();
			OrcKing orcKing = new OrcKing();

			dragon.Move();
			slime.Move();
			orc.Move();
			orcKing.Move();

			dragon.TakeHit(10);
			slime.TakeHit(10);
			orc.TakeHit(10);
			orcKing.TakeHit(10);

			dragon.Breath();
			slime.Split();
			orc.Anger();
			orcKing.Anger();
			orcKing.Shout();

			// 4번 문제
			Skill qSkill = new FireBall();
			Skill wSkill = new Heal();
			Player player = new Player();

			player.SetSkill(qSkill);
			player.UseSkill();
			player.SetSkill(wSkill);
			player.UseSkill();

			// 5번 문제
			Player2 player2 = new Player2();
			Potion potion = new Potion();
			Herb herb = new Herb();
			player2.PotionUse(potion);
			player2.HerbUse(herb);
		}
	}
}
