namespace _07._Class
{
	internal class Program
	{
		/***********************************************************************
         * 클래스 (class)
         * 
         * 데이터와 관련 기능을 캡슐화할 수 있는 참조 형식
         * 객체지향 프로그래밍에 객체를 만들기 위한 설계도
         * 클래스는 객체를 만들기 위한 설계도이며, 만들어진 객체는 인스턴스라 함
         * 참조 : 원본을 가리키고 있음 == 원본의 주소를 가지고 있음
         ***********************************************************************/

		// <클래스 구성>
		// class 클래스이름 { 클래스내용 }
		// 클래스 내용으로는 변수와 함수가 포함 가능
		class Student
		{
			public string name;
			public int math;
			public int english;
			public int science;

			public float GetAverage()
			{
				return (math + english + science) / 3f;
			}
		}

		void Main1()
		{
			Student kim = null;     // 지역변수를 생성하고 null(아무것도 없음) 참조
			kim = new Student();    // 클래스 인스턴스를 생성하고 지역변수가 인스턴스를 참조함
			kim.name = "Kim";       // 인스턴스의 변수에 접근하기 위해 참조한 변수에 . 을 붙여 사용
			kim.math = 10;
			kim.english = 20;
			kim.science = 100;

			float average = kim.GetAverage();   // 클래스내 함수에 접근하기 위해 참조한 변수에 . 을 붙여 사용
		}


		// <클래스 생성자>
		// 반환형이 없는 클래스이름의 함수를 생성자라 하며 클래스의 인스턴스를 만들 때 호출되는 역할로 사용
		// 인스턴스의 생성자는 new 키워드를 통해서 사용
		class Car
		{
			public string name;
			public string color;

			// 기본생성자는 다른 생성자를 포함하지 않은 경우에만 자동 생성됨
			/*public Car()
            {

            }*/

			public Car(string name, string color)
			{
				this.name = name;
				this.color = color;
			}
		}

		void Main2()
		{
			Car car;
			// car.name = "차";         // error : 클래스 지역변수는 인스턴스 없이 사용불가

			Car truck = new Car("트럭", "파란색");
			Console.WriteLine($"{truck.name}, {truck.color}");    // output : 트럭, 파란색

			// Car taxi = new Car();    // error : 기본생성자는 다른생성자를 포함하지 않은 경우에만 자동생성됨
		}


		// <클래스 얕은복사>
		// 클래스에 대입연산자(=)를 통해 같은 인스턴스를 참조함
		class MyClass
		{
			public int value1;
			public int value2;
		}

		void Main3()
		{
			MyClass s = new MyClass();
			s.value1 = 1;
			s.value2 = 2;

			MyClass t = s;      // 변수가 같은 인스턴스를 참조함
			t.value1 = 3;

			// 같은 인스턴스를 참조하기 때문에 복사본을 변경하는 경우 원본도 변경됨
			Console.WriteLine(s.value1);    // 3
			Console.WriteLine(s.value2);    // 2

			Console.WriteLine(t.value1);    // 3
			Console.WriteLine(t.value2);    // 2
		}

		struct Player
		{
			public int hp;
		}

		struct Monster
		{
			public int damage;

			public void Attack(Player player)
			{
				player.hp -= damage;
			}
		}

		class PlayerCalss
		{
			public int hp;
		}

		class MonsterCalss
		{
			public int damage;

			public void Attack(PlayerCalss playerCalss)
			{
				playerCalss.hp -= damage;
			}
		}

		static void Main(string[] args)
		{
			// 구조체

			Player player = new Player();
			player.hp = 100;

			Monster monster = new Monster();
			monster.damage = 40;

			monster.Attack(player);					   // 구조체로 하면 플레이어 체력 100이라는 값을 넣어준거지 실제로 플레이어의 체력을 넣어준 것이 아니다.
													   // 그래서 아무리 데미지를 넣어도 플레이어의 체력은 계속 100이다.
													   // 구조체를 복사하면 값 자체를 복사해온다.
			Console.WriteLine(player.hp);

			// 클래스

			PlayerCalss playerCalss = new PlayerCalss();
			playerCalss.hp = 100;

			MonsterCalss monsterCalss = new MonsterCalss();
			monsterCalss.damage = 40;

			monsterCalss.Attack(playerCalss);          // 클래스로 하면 실제로 플레이어가 들고 있는 체력을 가지고 온다.
													   // 그래서 데미지를 넣으면 실제로 플레이어의 체력이 깍이게 된다.
													   // 이렇게 클래스는 원본을 바꾸고 싶은 상황에서 많이 사용하게 된다.
													   // 클래스를 복사하면 주소지를 복사하기에 같은 원본을 참조하게 된다.
			Console.WriteLine(playerCalss.hp);
		}



		/*******************************************
         * 값형식, 참조형식
         * 
         * 값형식 (Value type) : 
         * 복사할 때 실제값이 복사됨 (깊은 복사)
         * 구조체는 값형식
         * 
         * 참조형식 (Reference type) : 
         * 복사할 때 객체주소가 복사됨 (얕은 복사)
         * 클래스는 참조형식
         ********************************************/

		// <값형식과 참조형식의 차이>
		// 값형식 : 데이터가 중요한 경우 사용, 값이 복사됨
		// 참조형식 : 객체가 중요한 경우 사용, 객체주소가 복사됨
		struct ValueType
		{
			public int value;
		}

		class RefType
		{
			public int value;
		}

		void Main4()
		{
			ValueType valueType1 = new ValueType() { value = 10 };
			ValueType valueType2 = valueType1;      // 값이 복사
			valueType2.value = 20;                  // 값을 대입해도 원본에는 영향 없음
			Console.WriteLine(valueType1.value);    // output : 10

			RefType refType1 = new RefType() { value = 10 };
			RefType refType2 = refType1;            // 객체주소가 복사
			refType2.value = 20;                    // 값을 대입하는 경우 원본 데이터를 변경
			Console.WriteLine(refType1.value);      // output : 20
		}


		// <값에 의한 호출, 참조에 의한 호출>
		// 값에 의한 호출 (Call by value) : 
		// 값형식의 데이터가 전달되며 데이터가 복사되어 전달됨
		// 함수의 매개변수로 전달하는 경우 복사한 값이 전달되며 원본은 유지됨
		void Swap(ValueType left, ValueType right)
		{
			int temp = left.value;
			left.value = right.value;
			right.value = temp;
		}

		// 참조에 의한 호출 (Call by reference) :
		// 참조형식의 데이터가 전달되며 주소가 복사되어 전달됨
		// 함수의 매개변수로 전달하는 경우 주소가 전달되며 주소를 통해 접근하기 때문에 원본을 전달하는 효과
		void Swap(RefType left, RefType right)
		{
			int temp = left.value;
			left.value = right.value;
			right.value = temp;
		}

		void Main5()
		{
			ValueType leftValue = new ValueType() { value = 10 };
			ValueType rightValue = new ValueType() { value = 20 };
			Swap(leftValue, rightValue);    // 데이터의 복사본이 함수로 들어가기 때문에 원본이 바뀌지 않음
			Console.WriteLine($"{leftValue.value}, {rightValue.value}");    // output : 10, 20

			RefType leftRef = new RefType() { value = 10 };
			RefType rightRef = new RefType() { value = 20 };
			Swap(leftRef, rightRef);        // 원본의 주소가 함수로 들어가기 때문에 원본이 바뀜
			Console.WriteLine($"{leftRef.value}, {rightRef.value}");        // output : 20, 10
		}


		// <클래스의 얕은복사, 깊은복사>
		// 얕은복사 (Shallow copy) : 객체를 복사할 때 주소값만을 복사하여 같은 원본을 가리키게 함
		// 깊은복사 (Deep copy) : 객체를 복사할 때 주소값 안의 원본을 복사하여 다른 객체를 가지고 가리키게 함
		void Main6()
		{
			RefType original = new RefType() { value = 1 };

			// 얕은복사
			RefType shallowCopy = original;

			// 깊은복사
			RefType deepCopy = new RefType();
			deepCopy.value = original.value;

			Console.WriteLine(original.value);      // output : 1
			Console.WriteLine(shallowCopy.value);   // output : 1
			Console.WriteLine(deepCopy.value);      // output : 1

			original.value = 2;

			Console.WriteLine(original.value);      // output : 2
			Console.WriteLine(shallowCopy.value);   // output : 2
			Console.WriteLine(deepCopy.value);      // output : 1
		}

		// 값이 필요하면 구조체를 사용하고
		// 원본(객체)가 필요하면 클래스를 만들어서 사용하면 된다.

		// 예를 들어서 몬스터가 플레이어를 따라 다녀야한다면. 몬스터가 추가 되었을 때 플레이어를 가르키면 되기에 얕은 복사로 하면 자동으로 플레이어를 따라가게 할 수 있다.
		// 타겟을 깊은 복사로 하게 되면 사실 몬스터 마다 따라가고 있는 플레이어는 다 다른 플레이어이다.

		// 예를 들어서 몬스터가 죽으면 아이템을 떨군다고 하면 몬스터 a가 죽었을 때 아이템을 플레이어가 먹으면 b 몬스터가 아이템을 가르키고 있는 것이 없기에
		// 몬스터가 각자 아이템을 들고 있어야하는 경우에는 깊은 복사를 해줘야한다.

		// 클래스는 객체를 만들 수 있는 설계도가 붕어빵(객체)의 붕어빵틀(클래스)로 많이 표현한다.
		// 사람을 만들 수 있는 클래스는 Age와 Name이라는 속성(Property)를 가지고 있고, 어떤 행동을 할 수 있는 메서드(Method)를 가지고 있습니다.
		// 이 클래스를 가지고 인스턴화를 하면 실제 객체 결과물이 곧 인스턴스입니다.
		// Player player2 = new Player(); 에서 플레이어2 라는 인스터를 하나 생성한 것 입니다.
		// player2.Age
		// player2.Name 등 속석 값을 지정하는 것 입니다.
		// player2는 new Player();를 가리키는 주소를 가지고 있고 new Player();가 실제 값을 가지고 있는 것 입니다.
		// player3 = player2를 한다면 player2, 3은 같은 new Player()를 가르키는 것.

		static void Main55(string[] args)
		{

		}
	}
}
