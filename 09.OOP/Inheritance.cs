using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP
{
	internal class Inheritance
	{
		/**********************************************************************************
         * 상속 (Inheritance)
         *
         * 부모클래스의 모든 기능을 가지는 자식클래스를 설계하는 방법
         * is-a 관계 : 부모클래스가 자식클래스를 포함하는 상위개념일 경우 상속관계가 적합함
         **********************************************************************************/

		// <상속>
		// 부모클래스를 상속하는 자식클래스에게 부모클래스의 모든 기능을 부여
		// class 자식클래스 : 부모클래스
		// 만약 몬스터 이름을 상속받지 않게 하면 모든 몬스터에 이름을 계속 선언해줘야한다.
		// 아래와 같이 몇 줄 안 되더라도 몬스터가 5천 종류가 있다면 밑에 코드를 5천개 복붙해야하기에 
		// 그럴 경우 상속을 하는게 낫다. 몬스터는 움직일 수 있나? 당연하지 등을 코드를 써주면 된다.

		class Monster
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
				Console.WriteLine($"{name} 이/가 {damage} 를 받아 체력이 {hp} 이 되었습니다.");
			}
		}

		class Dragon : Monster
		{
			public int damage2;

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

		class DragonRed : Dragon
		{
			public DragonRed()
			{
				damage2 = 100;
				name = "드래곤레드";
			}
		}

		// 이렇게 하면 드래곤, 몬스터를 둘 다 상속 받아서 사용할 수 있다.

		class Slime : Monster
		{
			public Slime()
			{
				name = "슬라임";
				hp = 5;
			}

			public void Split()
			{
				Console.WriteLine($"{name} 이/가 분열합니다.");
			}
		}

		class Hero
		{
			int damage = 3;

			public void Attack(Monster monster)
			{
				monster.TakeHit(damage);
			}

			// 만약에 몬스터라는 상속 구조를 하지 않았다면 드래곤 때리기 슬라임 때리기를 전부 구현했어야한다.

			public void Attack2(Dragon dragon)
			{
				// 위에처럼 안 했으면 이런식으로 모든 몬스터를 넣었어야 한다.
			}
		}

		void Main1()
		{
			Dragon dragon = new Dragon();
			Slime slime = new Slime();

			// 부모클래스 Monster를 상속한 자식클래스는 모두 부모클래스의 기능을 가지고 있음
			dragon.Move();
			slime.Move();

			// 자식클래스는 부모클래스의 기능에 자식만의 기능을 더욱 추가하여 구현 가능
			dragon.Breath();
			slime.Split();

			// 업캐스팅 : 자식클래스는 부모클래스 자료형으로 묵시적 형변환 가능
			Hero hero = new Hero();
			hero.Attack(dragon);
			hero.Attack(slime);

			// 밑에 있는 것이 업 캐스팅
			Monster monster = new Dragon();
			hero.Attack(monster);

			// 다운캐스팅 : 부모클래스는 자식클래스 자료형으로 명시적 형변환 가능 (단, 가능할 경우)
			Dragon d = (Dragon)monster;				// 100% 경우(명시적) 아래와 같이 실수 안 한다는 조건하에
			// Slime s = (Slime)monster;            // error : 인스턴스가 Slime이 아니기 때문에 변환시 오류
			// 여기에 몬스터는 new Dragon();으로 했기에 슬라임이 아님

			if (monster is Dragon)                  // 형변환이 가능한지 확인 몬스터가 드래곤이니? 물어보는 것
			{
				Dragon isDraong = (Dragon)monster;
			}

			Dragon asDragon = monster as Dragon;    // 형변환이 가능하다면 형변환 드래곤 이면 바꿔주고 아니면 null을 반환한다.
		}

		// 개구리 클래스가 있는데 육지생물, 해양생물 이라는 2개 클래스를 가질 수는 없다.
		// 상속은 1개 클래스만 받을 수 있다.
		// 대신 몬스터를 상속받은 드래곤 드래곤을 상속받은 레드드래곤 이런 식으로는 레드드래곤이 몬스터도 상속 받은거기에 이렇게 사용은 가능하다.

		// <상속 사용의미 1>
		// 상속을 진행하는 경우 부모클래스의 소스가 자식클래스에서 모두 적용됨
		// 부모클래스와 자식클래스의 상속관계가 적합한 경우 부모클래스에서의 기능 구현이 자식클래스에서도 어울림
		class Building
		{
			// 부모클래스에서 기능을 구현할 경우 모든 부모를 상속하는 자식클래스에 기능을 구현하는 효과
		}

		class Home : Building
		{
			// 자식클래스에서 자식클래스만의 기능을 구현
		}

		class School : Building
		{
			// 자식클래스에서 자식클래스만의 기능을 구현
		}


		// <상속 사용의미 2>
		// 업캐스팅을 통해 자식클래스는 부모클래스로 형변환이 가능함
		// 자식클래스는 부모클래스를 요구하는 곳에서 동일한 기능을 수행할 수 있음
		class Parent
		{
			public void Func() { }
		}
		class Child1 : Parent { }
		class Child2 : Parent { }
		class Child3 : Parent { }

		void UseParent(Parent parent)
		{
			parent.Func(); 
		}
		void Main2()
		{
			Child1 child1 = new Child1();
			Child2 child2 = new Child2();
			Child3 child3 = new Child3();

			UseParent(child1);
			UseParent(child2);
			UseParent(child3);
		}
	}
}
