﻿using System.Diagnostics.Contracts;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace _99.LastCheck
{
	internal class Program
	{
		/// <summary>
		/// 문서 주석은 이렇게 사용한다. Main에 마우스 커서를 올리면 이 글이 뜬다.
		/// </summary>
		static void Main(string[] args)
		{
			// 주석 소스 코드에 영향을 주지 않는 텍스트이다.
			// 소스 코드에 대한 의도를 설명하기 위한 용도로 사용한다.

			// 주석 종류는 3가지가 있다.
			// // 한 줄 주석 // 이후 텍스트를 주석으로 취급한다.
			// /* 여기부터 */ 여기까지 텍스트를 주석으로 취급한다.
			/// 문서 주석 함수 또는 클래스 앞에 /// 입력으로 자동완성 및 통합 개발 환경에서 정보표시기능이 있다.

			// using 지시문은 소스코드의 상단부에 우치하며 네임스페이스를 선언한다. 선언 이후 소스코드에서 네임 스페이스 안의 기능을 사용한다.

			// 네임스페이스는 기능이다 구분이 비슷한 기능들을 하나의 이름 아래 묶는 기능이다.
			// 수 많은 클래스 사용에 혼란이 적도록 용도/분야 별로 정리를 한 것이다.

			// 클래스는 c# 프로그램을 구성하는 기본 단위이며 데이터와 기능을 구성한다.
			// 메인 함수는 프로그램의 시작지점이 되는 함수이다.
			// c# 프로그램은 반드시 하나의 main 함수를 포함해야한다.

			// 프로그램은 main 함수를 시작으로 순서대로 처리된다.
			// 표준입출력
			// 콘솔은 컴퓨터와 사용자가 소통하기 위한 클래스이다.

			// bool 논리형, int 정수형, float 부동소수점 실수, double 부동소수점 실수, char 유니코드 문자형 키 한개, string 유니코드 문자열 한 줄 등이 있다.
			// 변수는 데이터를 저장하기 위해 프로그램에 의해 이름을 항당 받은 메모리 공간이다. 데이터를 저장할 수 있는 ㅔㅁ모리 공간을 의마혐, 저장된 값은 변경이 가능하다.
			// 변수 선언 및 초기화 자료형의 선언하고 빈칸 뒤에 변수이름을 작성하여 변수를 선언한다. 선언한 변수에 값을 처음 할당하는 과정을 초기화라고 한다. 변수 선언과 초기화 과정을 동시에 진행할 수 있다.

			Console.Write("출력 하기");
			Console.WriteLine("출력 하면서 한 줄 띄기");
			Console.WriteLine("ReadLine");
			Console.ReadLine();
			// ReadLine은 키의 입렵 값을 받는다. 길게 쓸 수 있고 엔터를 누르면 넘어감
			Console.WriteLine("ReadKey");
			Console.ReadKey();
			// ReadKey는 키의 입력을 받는다. 키를 한 개만 눌러도 바로 넘어간다.
			Console.WriteLine();

			int iValue = 10; // int 자료형의 이름이 iValue인 변수에 10의 데이터를 초기화한다.
			float fValue;  // float 자료형의 이름이 fValue인 변수를 선언하지만 값을 초기화하지 않았다.
						   // 같은 이름의 변수는 사용이 불가능하다.
						   // 선언한 변수에 값을 초기화하기 전까지는 사용이 불가능하다. iValue는 사용이 가능하지만 fValue는 사용이 불가능하다.

			// 변수에 데이터 저장 대입 연산자 좌측에 변수를 배치한다. 
			iValue = 5; // iValue 변수에 5의 데이터를 저장한다.
			fValue = 10.5f; // fValue 변수에 10.5f 데이터를 초기화한다.
							// 1.2와 1.2f는 다른 것 이다. 기본적으로 소수점 뒤에는 d가 붙어 있다
							// double이 float보다 크니 float에 10.5는 더블형 자료형이니 넣을 수 없는 것이라 뒤에 f를 붙여 10.5f로 만들어야 하는 것 이다.

			// 변수의 데이터 불러오기 데이터가 필요한 곳에 변수명을 배치한다.
			int rValue = 20;
			int iValue2 = rValue; // 이렇게 하면 iValue2에는 rValue의 값인 20이 들어가게 된다.
			Console.WriteLine(rValue);
			Console.WriteLine(iValue2);

			int level = 0; // 초기화
			level = 10; // 대입
			int level2; // 선언
			level2 = 10; // 초기화
			level2 = 20; // 대입
						 // 값을 지정을 안 하면 선언 값을 처음 넣었을 때가 초기화 값을 바꿨을 때가 대입이다.

			Console.WriteLine(level2);
			level2 = 50;
			Console.WriteLine(level2);
			level2 = 100;
			Console.WriteLine(level2);
			float level3 = 10.23456f;
			Console.WriteLine($"{level3:F3}");
			// f3은 소수점 3번 째 자리까지만 보여준다라고 표시한 것 이다.
			Console.WriteLine($"{level3,+10:F3}");
			// 앞에 10칸 띄우기
			Console.Write($"{level3,-10:F3}");
			// 뒤에 10칸 띄우기
			Console.WriteLine("잘 띄워졌나?");

			// 상수는 프로그램일 싱행되는 동안 변경할 수 없는 데이터이다.
			// 프로그램에서 값이 변경되기를 원하지 않는 데이터가 있을 경우에 사용한다.
			// 저장된 값은 프로그램 종료시까지 변경이 불가능하다.
			// 상수 선언 및 초기화 변수 선언 앞에 const 키워드를 추가하여 상수 선언을 한다.
			const int MAX = 200; // MAX 상수 변수를 선언하고 초기화한다.
			Console.WriteLine(MAX);
			// const int Min; 상수는 초기화 없이 사용이 불가능하다. 선언 당시 바로 초기화를 진행시켜야한다.
			// MAX = 500; 상수는 데이터 값을 변경할 수 없다.
			// 상수는 항상 선언과 초기화를 같이 해줘야한다.
			// 상수는 대문자로만 사용하는 것이 일반적이다.

			// 동일한 자료형의 요소들로 구성된 데이터 집합이다.
			// 인덱스를 통하여 배열송에 접근할 수 있다.
			// 배열의 처음 요소의 인덱스는 0부터 시작한다.

			// 1차원 배열 사용 자료형 뒤에 []괄호를 추가하여 배열로 사용함을 선언한다.
			int[] iArray; // int 배열 선언
			iArray = new int[20]; // int 데이터를 20개 가지는 배열을 생성한 것이다.
			iArray[0] = 20; // 배열의 0번째 변수에 20이라는 데이터를 대입한 것이다.
			float[] fArray = { 1.1f, 2.2f, 3.3f, 4.4f }; // 배열 선언과 초기화 배열의 크기는 초기화한 값만큼 자동으로 설정된다. 이렇게 하면 크기 4개의 배열이다.

			// 다차원 배열은 추가하는 차원 수 만큼','를 추가해주면 된다.
			int[,] matrix = new int[5, 10]; // 이러면 데이터 50개를 가지는 배열을 생성한 것이다.
			int[,,] cube = new int[3, 5, 10]; // 10개짜리 5개 3 그룹이니 150개이다.

			matrix[1, 3] = 10; // 을 하면 가로 3번 째 세로 1번째 배열에 10이라는 데이터가 들어가게된다.

			// 형변환은 데이터를 선언한 자료형에 맞는 형태로 변환하는 작업이다. 다른 자료형의 데이터를 저장하기 위해선 형변환 과정을 거쳐야하며, 이 과정에서 보관할 수 없는 데이터는 버려진다.
			// 명시적 형변환 - 수동은 형변활 데이;터의 앞에 변환할 자료형을 괄호안에 넣어 형변환을 진행해준다.
			int damage = (int)29.9f;//29.9를 int로 변환하는 과정 중 보관할 수 없는 소수점은 버려진다. 그래서 29로 나온다.
			int intValue = (int)1.2; // 1.2를 int로 변환하는 과정중 보관할 수 없는 소수점은 버려진다. // int intValue = 1.2; // 명시적 형변환 없이 변환은 불가능하다.
			Console.WriteLine(intValue);
			// 묵시적 형변환 - 자동
			// int < float < double순이다.
			// 데이터에 손실이 없으면 자동으로 변환이 된다.
			double d1 = 1;
			float d2 = 1;
			double d3 = 123.456f; // double이 float를 포함하는 더 큰 범위이니 자동형변환이 가능하다.

			// 문자 형변환과 아스키코드 유니코드
			// 아스키코드는 이진법을 사용하는 컴퓨터에서 문자를 표현하기 위해 정해둔 문자와 숫자의 매칭표이다.
			// 유니코드는 영어만 표현이 가능했던 아스키코드에서 전세계의 모든 문자를 다루도록 설계한 매칭표이다.
			char key = (char)65; // key에는 65가 해당되는 A가 들어가게 된다.
			int value = (int)'a'; // value에는 a에 해당하는 97이 들어가게된다.
			Console.WriteLine(key);
			Console.WriteLine(value);

			// int hp = int("100"); 문자열 형식은 숫자로 변형할 수 없다. char는 되는데 string은 불가능하다. 감자라면 감자가 숫자로 몇인지 정해져있지 않기 때문
			int hp = int.Parse("100");
			float p = float.Parse("0.5");
			Console.WriteLine(hp);
			Console.WriteLine(p);
			// int b = int.Parse("감자");
			// 문자가 들어간 순간 숫자로 변형 될 수 없다. 그래서 0.2는 가능하지만 0.2f는 불가능하다.

			int.TryParse("100", out hp); // 바꿀 수 있으면 100으로 해주고 바꿀 수 없다면 0으로 변환이 된다.
			string hundred = 100.ToString(); // 숫자를 문자형으로 바꿀라면 뒤에 .ToStirng을 해주면 된다.
											 // 결론 : 숫자를 문자로는 무조건 바꿀 수 있다. ""만 붙여주면 되기 때문이다 모든 문자를 숫자로 바꿀수는 없다. 숫자인 문자만 변경이 가능하다. 100 가능 100f는 불가능하다.

			// 연산자 프로그래밍 언어에서는 일반적인 수학 연산과 유사한 연사자들이 지원된다.
			// c#는 여러 연산자를 제공하며 기본 연산을 수행할 수 있다.
			// 산술 연산자는 2개 가지고 숫자를 계산하는 것을 의미한다.
			// 연산에는 + - * / %가 있다. 5/3과 같이 int 나눗셈은 소수점을 버리게된다. %는 나머지를 구하게된다.
			// 단항연사자는 + 값을 반환하고 - 값의 마이너스를 반환하고 
			++iValue; // 전위 증가연산자 값을 1 증가시킨다.
			iValue++; // 후위 증가 연산자도 값을 1 증가시킨다. 이와 같이 --도 똑같이 사용이 가능하다.

			// 전위 연산자와 후위 연산자 차이점
			iValue = 0;
			Console.WriteLine(iValue);
			Console.WriteLine(++iValue);
			Console.WriteLine(iValue);

			iValue = 0;
			Console.WriteLine(iValue);
			Console.WriteLine(iValue++);
			Console.WriteLine(iValue);
			// 이와 같이 출력을 해보면 값을 반환 후에 연산자을 하는지 차이점이 있다.

			// 대입연사자는
			iValue = 10; // 이것을 의미한다.
			iValue = iValue + 5; // 복합연산자는 이것을
			iValue += 5; // 이렇게 간소화 시킬 수 있다.

			// 비교 연산자는 비교후 bool 형태로 값을 반환해준다.
			// > 왼쪽 피연산자가 더 클 경우 true < 오른 쪽 같이 더 클 경우 true >= 왼쪽이 더 크거나 같은 경우 true <= 오른쪽 값이 더 크거나 같을 경우 true
			// == 두 피연산자가 같은 경우 true != 두 피연산자가 다를 경우 true

			// 논리연산자는 ! 피연산자의 논리 부정을 반환을 해준다 true면 false를 반환해준다. && 두 피연산자가 true일 때 true를 반환해준다.
			// || 두 피 연산자가 false 일 떄 false를 반환해준다 ^ 는 두 피연산자가 다를 경우 true를 반환해준다.

			// 조건부 논리 연산자
			// 조건부 논리 연산자는 빠른 계산자를 위해 false && 은 무조건 false 이기 떄문에 뒤에 어떤 것이 오든 무시를 한다.
			iValue = 10;
			bool bValue = false && (++iValue > 5);
			Console.WriteLine(iValue);

			// 이와 같은 이유 떄문에 보통 논리 연산자 안에서는 산술을 안 한다. 산술을 하고 싶다면 논리 연산자 만나기 전 혹은 후에 해주도록 하자.

			// 비트 연산자
			// 단항 연산자로
			iValue = ~0x35; // ~ 비트 보수이다. 데이터를 비트단위로 보수 연산을 한다. 보수는 0은 1로 1은 0으로 저장 만약 1001을 바꿔주면 0110이라는 뜻이다.

			// 이진 연산자
			iValue = 0x11 & 0x83;
			iValue = 0x11 | 0x83;
			iValue = 0x11 ^ 0x83;
			// 데이터를 비트단위로 and 연산자해주거나 or 연산자 xor 연산을 하는 경우이다.

			// 비트 쉬프트 연산자는 다른 연산보다 훨씬 빠르다.
			iValue = 0x20 << 1; // 왼쪽의 피 연산자를 비트를 오른쪽 피 연산자만큼 왼쪽으로 이동시킨다.
			Console.WriteLine(iValue);
			iValue = 0x20 >> 1; // 왼쪽의 피 연산자를 비트를 오른쪽 피연산자 만큼 오른쪽으로 이동시킨다.
			Console.WriteLine(iValue);
			// 0x가 16진수이다. 곧 20은 32이라는 뜻이다.
			// 그냥 *2 하는 것 보다 << 1을 해주는 것이 훨씬 빠르다 
			// << 1은 *2 << 2는 *4 << 3은 *8 2의 몇 승이라고 보면된다.
			// 곱하기가 나누기보다 훨씬 빠르다. 100/2보다 100*0.5가 빠르고 이것보다 100 >> 1 이 훨씬 빠르다는 것이다.

			int test;
			test = 100 >> 2;
			Console.WriteLine($"테스트 비트 연산자 : {test}");

			/****************************************************************
             * 연산자 우선순위
             *
             * 여러 연산자가 있는 식에서 우선 순위가 높은 연산자가 먼저 계산
             ****************************************************************/

			// <연산자 우선순위>
			// 1. 기본 연산        : a[i], x++, x--
			// 2. 단항 연산        : +x, -x, !x, ~x, ++x, --x, (Type)x
			// 3. 곱하기 연산      : x * y, x / y, x % y
			// 4. 더하기 연산      : x + y, x - y
			// 5. 시프트 연산      : x << y, x >> y
			// 6. 비교 연산        : x < y, x > y, x <= y, x >= y
			// 7. 같음 연산        : x == y, x != y
			// 8. 논리 AND 연산    : x & y, x && y
			// 9. 논리 XOR 연산    : x ^ y
			// 10. 논리 OR 연산    : x | y, x || y
			// 11. 대입 연산       : x = y, x op= y

			// 헷갈리면 ()쳐서 먼저 계산하게 하기
			// 기본(단항) > 곱하기 > 더하기 > 비교 > 논리 > 대입

			// 외울 필요는 없고 필요하다면 찾아서 사용하면 된다.

			// 조건문 조건에 따라 실행이 달라지게 할 떄 사용하는 문장이다. 
			// if 조건문 조건식의 true, false에 따라 실행할 블록을 결정하는 조건문이다.

			if (true)
			{
				Console.WriteLine("실행이 되는 블록");
			}
			else
			{
				Console.WriteLine("실행이 되지 않는 볼록");
			}

			if (false)
			{
				Console.WriteLine("실행이 되지 않는 블록");
			}
			else
			{
				Console.WriteLine("실행이 되는 블록");
			}

			if (true)
			{
				Console.WriteLine("실행이 되는 블록");
			}
			// else 구문은 필수가 아니다. 필요가 없다면 사용하지 않아도 상관없음.

			string input = "바위";
			if (input == "가위")
			{
				Console.WriteLine("가위를 입력");
			}
			else if (input == "바위")
			{
				Console.WriteLine("바위를 입력");
			}
			else if (input == "보")
			{
				Console.WriteLine("보를 입력");
			}
			else
			{
				Console.WriteLine("잘못된 값을 입력");
			}
			//switch 조건문
			string cmd = "B";
			switch (cmd)
			{
				case "A":
					Console.WriteLine("A가 일치하는 경우");
					break;
				case "B":
					Console.WriteLine("B가 일치하는 경우");
					break;
				case "C":
					Console.WriteLine("C가 일치하는 경우");
					break;
			}

			// 조건값일 일치하는 case가 없을 경우 default가 실행지점이 된다.
			int value3 = 7;
			switch (value3)
			{
				case 1:
					Console.WriteLine("값은 1");
					break;
				case 2:
					Console.WriteLine("값은 2");
					break;
				default:
					Console.WriteLine("값은 그 외");
					break;
			}

			// 조건값에 따라 동일한 실행이 필요한 경우 묶어서 사용 가능하다.
			char key2 = 'w';
			switch (key2)
			{
				case 'w':
				case 'W':
				case 'ㅈ':
					Console.WriteLine("위쪽으로 이동");
					break;
				case 'a':
				case 'A':
				case 'ㅁ':
					Console.WriteLine("왼쪽으로 이동");
					break;
				case 's':
				case 'S':
				case 'ㄴ':
					Console.WriteLine("아래쪽으로 이동");
					break;
				case 'd':
				case 'D':
				case 'ㅇ':
					Console.WriteLine("오른쪽으로 이동");
					break;
				default:
					Console.WriteLine("이동하지 않음");
					break;
			}

			// 삼항 연산자 조건 ? true인 경우 값 : false인 경우 값을 넣어준다.'
			int big = 20 > 10 ? 20 : 10;
			int small = 20 < 10 ? 20 : 10;
			// 위에꺼는 true이기 때문에 20이 들어가고 아래는 false이기 떄문에 10이 들어간다.

			int left = 11;
			int right = 22;
			int bigger = left > right ? left : right;
			// 조건이 false로 나오기 때문에 right 값으로 나오게 된다.
			Console.WriteLine(bigger);

			// 반복문 블록을 반복적으로 실행하는 문자이다.
			// while 반복문은 조건식의 true false에 따라 블록을 반복하는 반복문이다.
			int coin = 400;
			while (coin > 0)
			{
				Console.WriteLine("100원 동전을 꺼냅니다");
				coin -= 100;
			}

			// do while 반복문 블록을 한 번 실행 후 조건식의 true false에 따라 블록을 반복하는 반복문이다.

			int input2;
			do
			{
				Console.Write("1에서 9 사이의 수를 입력해주세요 : ");
				string text = Console.ReadLine();
				int.TryParse(text, out input2);
				// 적어도 한 번 실행을 하고 체크를 하게 된다. 둘의 차이점은 위에서 체크를 진행하는지 아래에서 체크하는지가 차이점이다.
			} while (input2 < 1 || 9 < input2);

			// for 반복문 초기화 , 조건식, 증감연산으로 구성된 반복문을 말한다.
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine(i);
			}
			// 몇 번 반복을 하겠다에 사용을 한다.

			// foreach 반복문 반복 가능한 데이터집합의 처음부터 끝가지 반복한다.

			int[] intArray = { 1, 3, 7, 9, 8, 6, 4, 2, 0 };
			foreach (int i in intArray)
			{
				Console.WriteLine(i);
			}
			// 하나씩 전부 꺼내어 준다.

			// 제어문 프로그램의 순차적인 실행 중 다른 문으로 제어를 전송
			// break 제어문 가장 가까운 반복문을 종료한다.

			int num = 35;
			for (int i = 2; i < num; i++)
			{
				if (num % 1 == 0)
				{
					Console.WriteLine(i);
					break;
				}
			}

			// 찾았으니 그만 찾아 라는 방법이다.

			// continue 제어문 가장 가까운 반복문의 새 반복을 시작한다.
			for (int i = 0; i < 10; i++)
			{
				if (i % 2 == 0)
				{
					continue;
				}
				if (i % 3 == 0)
				{
					continue;
				}
				Console.WriteLine(i);
			}
			// break는 찾았으니 해당 반복을 종료하고 continue는 현재 i는 무시하고 계속 반복해 라는 것이다.

			// 함수 미리 정해진 동작을 수행하는 코드 묶음이다 어떤 처리를 함수로 만들어 두면 다시 반복적으로 사용이 가능하다.
			// 함수 구성 일련의 코드를 하나의 이름 아래에 묶음
			// 반환형(출력), 함수이름(매개변수목록(입력)){함수내용} 으로 이루어져있다. 

			// 함수를 사용하지 않는 경우는 
			int result = 1 + 2;
			// 와 같이 사용을 하지만. 
			// 함수를 사용하는 경우는
			int value4 = Plus(1, 3);

			// 반환형 함수의 결과 데이터의 자료형
			// 함수가 끝나기 전까지 반드시 return으로 반환형에 맞는 데이터를 출력해야한다.
			// 함수 진행 중 return을 만나는 경우 그 즉시 결과 데이터를 반환하고 함수가 종료된다.
			// 함수의 결과가 없는 경우 반환형은 void이며 return을 생략할 수 있다.

			int ret = Return(); // int 반환형이니 int를 담을 수 있는 변수에 넣어 놓고 출력이 가능하다.
			PrintProfile("", "010-1234-5678");
			PrintProfile("홍길동", "010-1111-2222"); // void는 반환해주는 것이 없기 때문에 변수에 담지 않고 실행 자체에 의미를 둔다.

			// 매개변수 함수에 추가할 데이터의 자료형과 변수명 같은 함수에서도 매개변수 입력이 다름에 따라 다른 처리가 가능하다.
			// 매개변수는 함수 옆에 ()안에 있는 걸 매개변수라고 부른다.
			// void 일 때 매개변수 사용이 가능하다.
			// void는 return되는 값이 없는 것 뿐이다. return 사용 자체는 가능하다.
			// void 일 때 매개변수를 사용해서 어떤 부분에 어떤 값을 넣을지는 사용이 가능.
			// 반환형은 내가 return해서 출력을 원하는 경우에 사용을 한다.

			// 변수는 명사 함수는 동사로 써주는 것이 좋다. 함수 == 메소드이다.
			// 함수는 클래스 안에 잇어야한다.

			// 클래스 밖에 있는 것은 전역함수
			// ()안에 있는 것이 매개변수
			// 클래스 안에 있는 것이 멤버변수(인스턴스변수 라고도 부르는 것 같음)
			// 함수 안에 있는 것이 지역변수이다.

			// 매개변수 명, 변수 명은 다른 블록에서 똑같은 이름으로 사용이 가능하다.
			// 함수가 다른 곳이라면 이름을 똑같이 해도 이름만 같을 뿐 전혀 다른 내용이다.

			int damage2 = TripleShot();
			Console.WriteLine(damage2);
			damage2 = TripleShot2();
			Console.WriteLine(damage2);

			// 이렇게 매개변수에 데미지를 넣어서 트리플에서 데미지를 얼마나 줄지 적용 시켜줄 수 있고
			// 어택 자체에서 데미지를 10으로 규정하면 트리플에서 바로 얼마만큼의 데미지를 줄지 설정할 수도 있다.

			// 함수 오버로딩
			// 같은 이름의 함수를 매개변수를 달리하여 다른 함수로 재정의하는 기술이다.
			// 같은 이름의 함수를 호출하여도 매개변수의 자료형에 따라 함수를 달리 호출할 수도 있다.

			int result2 = Multi(5, 3);
			float result3 = Multi(5.1f, 5.2f); // f를 안 붙이면 double이기 때문에 f를 붙여주기
			double result4 = Multi(2.2, 3.3f); // right가 float였으니 f를 붙여준것
			Console.WriteLine(result2);
			Console.WriteLine(result3);
			Console.WriteLine(result4);

			// 열거형 기본 정수 숫자의 형식의 명명된 상수 집합에 의해 정의되는 값 형식이다.
			// 열거형 멤버의 이름으로 관리되어 코드의 가독성적인 측면에 도움이 된다.

			// 열거형 사용은 eunm 열거형이름 {멤버이름, 멤버이름} 으로 사용한다.
			Direction dir = Direction.Up;
			switch (dir)
			{
				case Direction.Up:
					Console.WriteLine("위쪽으로 이동");
					break;
				case Direction.Down:
					Console.WriteLine("아래쪽으로 이동");
					break;
				case Direction.Left:
					Console.WriteLine("왼쪽으로 이동");
					break;
				case Direction.Right:
					Console.WriteLine("오른쪽으로 이동");
					break;
			}

			Season season = Season.Autumn;
			Console.WriteLine(season);
			Console.WriteLine((int)season);

			// 구조체 데이터와 관련 기능을 캡슐화할 수 있는 값형식이다.
			// 데이터를 저장하기 보관하기 위한 단위 용도로 사용한다.
			// 구조체는 struct 구조체 이름 {구조체 내용}으로 이루어져있다.
			// 구조체 내용으로는 변수와 함수가 포함이 가능하다.

			StudentInfo info;
			info.name = "kim";
			info.math = 10;
			info.english = 20;
			info.science = 100;

			float average = info.Average(); // 구조체내 함수에 접근하기 위해 구조체에 .을 붙여서 사용한다.
			Console.WriteLine(average);

			StudentInfo kim;
			kim.name = "김";
			kim.math = 100;
			kim.english = 50;
			kim.science = 70;
			average = kim.Average();
			Console.WriteLine(average);

			// 구조체 초기화
			// 반환형이 없는 구조체이름의 함수를 초기화라 하며 구조체 변수들의 초기화를 진행하는 역할로 사용
			// 매개변수가 있는 초기화를 정의하여 구조체 변수의 값을 설정하기 위한 용도로 사용한다.
			// 구조체의 초기화는 new 키워드를 통해서 사용한다.

			Point point1;
			point1.x = 1;
			Console.WriteLine(point1.x);
			// y는 초기화 하지 않았기 때문에 y를 사용할 수는 없다.

			Point point = new Point();
			Console.WriteLine($"{point.x}, {point.y}");

			// 보통 이렇게 많이 사용을 한다. 이러면 0, 0으로 기본 초기화를 사용하는거고 new point(10, 10)
			// 이렇게 10, 10을 넣으면 x,y 에 각각 10씩 들어간다.
			// 혹은 아래와 같이 초기화 및 대입이 가능하다.
			Point point2 = new Point() { x = 3, y = 5 };

			// 구조체는 깊은 복사로 이루어진다.
			MyStruct s = new MyStruct();
			s.value1 = 1;
			s.value2 = 2;

			MyStruct t = s;
			t.value1 = 3;

			Console.WriteLine(s.value1);
			Console.WriteLine(s.value2);
			Console.WriteLine(t.value1);
			Console.WriteLine(t.value2);

			// t를 바꾸었기 때문에 깊은 복사가 이루어져서 실제 값이 바뀌게 된다.

			// 클래스 구성 Class 클래스 이름 {클래스 내용}으로 사용하면 된다.
			// 클래스 내용으로는 구조체와 똑같이 함수와 변수가 포함이 가능하다.

			Student kim1 = new Student();
			kim1.name = "kim";
			kim1.math = 10;
			kim1.english = 20;
			kim1.science = 100;
			float average1 = kim1.GetAverage();
			Console.WriteLine(average1);

			// 클래스 생성자 반환형이 없는 클래스 이름의 함수를 생성자라하며 클래스의 인스턴스를 만들 때 호출 되는 역할로 사용
			// 인스턴스의 생성자는 new 키워드를 통해서 사용이 가능하다.

			Car truck = new Car("트럭", "파란색");
			Console.WriteLine($"{truck.name}, {truck.color}");

			// 클래스 지역변수는 인스턴스 없이 사용이 불가능하다. 
			// 기본생성자는 다른 생성자를 포함하지 않은 경우에만 자동생성이 가능하다.

			MyClass s1 = new MyClass();
			s1.value1 = 1;
			s1.value2 = 2;

			MyClass t1 = s1;
			t1.value1 = 3;

			Console.WriteLine(s1.value1);
			Console.WriteLine(s1.value2);
			Console.WriteLine(t1.value1);
			Console.WriteLine(t1.value2);

			// 같은 인스턴스를 참조하기 때문에 복사본을 변경하는 경우 원본도 변경이 된다.

			Player player = new Player();
			player.hp = 100;

			Monster monster = new Monster();
			monster.damage = 40;

			monster.Attack(player);

			// 구조체로하면 플레이어 체력 100이라는 값을 준거지 실제로 플레이어의 체력을 넣어준 것이 아니다.
			// 그래서 아무리 데미지를 넣어도 플레이어의 체력은 계속 100이다
			// 구조체를 복사하면 값 자체를 복사해온다.

			Console.WriteLine(player.hp);

			PlayerClass playerClass = new PlayerClass();
			playerClass.hp = 100;

			MonsterClass monsterClass = new MonsterClass();
			monsterClass.damage = 20;

			monsterClass.Attack(playerClass);

			Console.WriteLine(playerClass.hp);

			// 값형식, 참조형식 값형식 복사할 때 실제 값이 복사가 된다. 깊은복사가 이루어짐 구조체는 값형식이다.
			// 참조형식 복사할 떄 객체주소가 복사된다. 얕은 복사 클래스는 참조형식이다.
			// 둘의 차이점은 값형식은 데이터가 중요한 경우 사용한다. 값이 복사가된다.
			// 참조형식은 객체가 중요한 경우 사용을 한다. 객체주소가 복사된다.

			ValueType valueType1 = new ValueType() { value = 10 };
			ValueType valueType2 = valueType1; // 값이 복사가 된다.
			valueType2.value = 20;
			Console.WriteLine(valueType1.value);

			RefType refType1 = new RefType() { value = 10 };
			RefType refType2 = refType1; // 객체 주소가 복사된다.
			refType2.value = 20;
			Console.WriteLine(refType1.value);

			// 값에 의한 호출, 참조에 의한 호출
			// 값에 의한 호출 (Call by Value) 값형식의 데이터가 전달되며 데이터가 복사되어 전달된다.
			// 함수의 매개변수로 전달하는 경우 복사한 값이 전달되며 원본은 유지된다.

			// 참조에 의한 호출 (Call by refernce) 참조형식의 데이터가 전달되며 주소가 복사되어 전달된다.
			// 함수의 매개변수로 전달하는 경우 주소가 전달되며 주소를 통해 접근하기 때문에 원본을 전달하는 효과가 있다.

			ValueType leftValue = new ValueType() { value = 10 };
			ValueType rightValue = new ValueType() { value = 20 };
			Swap(leftValue, rightValue);

			Console.WriteLine($"{leftValue.value}, {rightValue.value}"); // 데이터의 복사본이 함수로 들어가기 때문에 원본은 바꾸지 않음

			RefType leftRef = new RefType() { value = 10 };
			RefType rightRef = new RefType() { value = 20 };
			Swap(leftRef, rightRef);

			Console.WriteLine($"{leftRef.value}, {rightRef.value}"); // 원본의 주소가 함수로 들어가기 때문에 원본이 바뀐다.

			// 클래스의 얕은 복사, 깊은 복사
			// 얕은 복사는 객체를 복사할 때 주소값만을 복사하여 같은 원본을 가르키게 된다.
			// 깊은 복사는 객체를 복샇ㄹ 떄 주소값의 원본을 복사하여 다른 객체를 가지고 있다.
			RefType original = new RefType() { value = 1 };
			RefType shallowCopy = original;
			RefType deepCopy = new RefType();
			deepCopy.value = original.value;

			Console.WriteLine(original.value);
			Console.WriteLine(shallowCopy.value);
			Console.WriteLine(deepCopy.value);

			original.value = 2;

			Console.WriteLine(original.value);
			Console.WriteLine(shallowCopy.value);
			Console.WriteLine(deepCopy.value);

			// 결론적으로는 깊은 복사를 하고 싶다면 인스터스를 새로 만들고 거기에 값을 깊게 복사하면된다. new를 따로 하면 된다는 말

			// 값이 필요한 경우 구조체를 사용하고 원본(객체)가 필요하면 클래스를 만들어서 사용하면 된다.
			// 예를 들어서 몬스터가 플레이러르 따라 다녀야한다면 몬스터가 추가 되었을 때 플레이어를 가르키면 되기에
			// 얕은 복사로 하면 자동으로 플레이어를 따라가게 할 수 있다.
			// 타겟을 깊은 복사로 하게 되면 몬스터 마다 따라가고 있는 플레이어는 다 다른 플레이어이기 때문이다.
			// 예를 들어서 몬스터가 죽으면 아이템을 떨구면 몬스터 a가 죽었을 때 아이템을 먹게 되면 b 몬스터도 같은 아이템이라면
			// b 몬스터가 가르키기고 있는 아이템이 없기 떄문에 몬스터 각자가 들고 있는 것이라면 깊은 복사를 해줘야한다.
			// 클래스는 객체를 만들 수 있는 설계도 붕어빵(객체), 붕어빵틀(클래스)
			// 사람을 만들 수 있는 클래스는 age name이라는 속성을 가지고 있고, 어떤 행동을 할 수 있는 메서드를 가지고 있다.
			// 이 클래스를 가지고 인스턴스화를 시키면 실체 객체 결과물이 인스턴스이다.
			// Player player = new Player(); 하면 플레이어 라는 인스턴스를 하나 생성한 것.
			// player.age player.name player.함수 등 을 사용할 수 있다.
			// player는 new Player();을 가르키고 있는 것이다. 그래서 player는 주소를 가리키는 것을 가지고 있고
			// 실제 값은 new Player가 들고 있는 것이다.
			// player2 = player을 하게 된면 player2는 new Player()을 가르키고 있는 것이다.

			// 메모리 프로그램을 처리하기 위해 필요한 정보를 저장하는 기억장치이다.
			// 프로그램은 메모리에 저장한 정보를 토대로 명령들을 수행한다.
			// 메모리구조는 프로그램은 효율적안 메모리 관리를 위해 메모리 영역을 구분한다.
			// 데이터는 각 열할마다 저장되는 영역을 달리하여 접근범위, 생존범위 등을 관리한다.

			// 메모리 구조는 코드영역(프로그램 코드), 데이터 영역(정적 변수), 힙 영역(클래스 인스턴스), 스택 영역(지역변수, 매개변수)
			// 로 관리가 된다. 순서대로 코드영역이 낮은 주소이고 스택영역이 높은 주소이다.

			// 코드영역은 프로그램이 실행할 코드가 저장되는 영역이다.
			// 데이터가 변경되지 않는 읽기 전용 데이터이다.

			// 데이텅역은 정적변수가 저장되는 영역이다.
			// 프로그램이 시작시 할당되며 종료시 삭제된다.
			// 상수 같은거 게임 이름이나 최대 인원 수 등 바뀌지 않는 것을 저장해두는 것이다.

			// 스택 영역은 지역변수와 매개변수가 저장되는 영역이다. 
			// 함수의 호출시 할당되며 함수가 종료되면 삭제가 된다.

			// 힙영역은 클래스 인스턴스가 저장되는 영역이다.
			// 인스턴스를 생성시 할당되며 더 이상 사용하지 않을시 자동으로 삭제된다.
			// 인스턴스를 참조하고 있는 변수가 없을 때 더 이상 사용하지 않는다고 판단한다.
			// 더 이상 사용하지 않는 인스턴스는 가비지 컬렉터가 특정 타이밍에 수거해간다.

			// 변수의 접근범위와 생존범위
			// 정적변수는 메모리 영역은 데이터 영역이고 접근은 어디서든 가능하고 생존범위는 프로그램 시작부터 끝까지이다.
			// 지역변수와 매개변수는 스택영역에 저장되고 접근은 블록 내부에서만 가능하고 생존 범위는 블록 시작부터 끝까지이다.
			// 클래스 인스턴스는 메모리는 힙여역이고 접근범위는 참조가능한 모든 범위를 말한다. 
			// 생존범위는 인스턴스 생성에서 더 이상 아무도 참조하고 있지 않을 때 가비지 컬렉터가 삭제시킨다.

			// 스택 영역은 함수호출 스택을 이용하여 호출과 종료에 연관되는 데이터를 저장하는 영역이다.
			// 프로그램은 스택구조를 통해 함수에서 사용한 데이터를 효율적으로 관리한다.
			// 제일 먼저 호출 된 함수가 제일 아래에 깔리고 새로 호출 된 함수가 위로 쌓이게 되면서
			// 맨 위에 있는 함수만 신경쓰면 되기 때문에 메모리 관리에 효율적이다.

			// 힙영역은 클래스 인스턴스가 보관하는 영역이다.
			// 프로그램은 기빚 콜렉터를 통해 더 이상 사용하지 않는 인스턴스를 수거한다.
			// 함수 시작시 지역 변수가 스택 영역에 저장된다.
			// 함수 시작시 이미 메모리에 할당되어 있고
			// 인스턴스를 힙영역에 생성하고 주소값을 지역변수에 담아 둔다.
			// new가 인스턴스 그래서 new가 힙영역에 저장된다. 인스턴스 == 객체이다.

			// 함수 종료시 지역변수가 함수 종료와 함께 소멸된다.
			// 인스턴스는 함수 종료와 함꼐 더 이상 참조하는 변수가 없어진다.
			// 그래서 가비지가 되어 가비지 컬렉터가 동작할 때 소멸하게 된다.
			// 하나 하나 가비지가 생길 때 마다 삭제하는 것이 아니라 체크를 해두고 한 꺼번에 많은 가비지를 소멸시킨다.

			// 데이터 영역은 정젹변수를 저장하는 영역이다.
			// 프로그램은 시작시 데이터 영역을 생성하며 종료시 데이터 영역을 해제한다.
			// 정적 static 프로그램의 시작과 함께 할당, 프로그램 종료시에 소멸, 프로그램이 동작하는 동안 항상 고정된 위치에 존재한다.
			// 근데 몬스터를 100마리 만든다고 할 때 1마리만 나와도 되는 상황 같은 생성하고 삭제하는 것이 효율적이다.
			// 근데 만약 정적으로 만들게되면 언제 어디서든 100마리가 다 존재하기 때문에 쓸데 없는 데이터를 사용하게 되므로 이런 경우 사용을 안 한다.

			// class안에 static int count을 하면 원래는 객체.으로 count를 불러야 하지만 정적으로 저장된건 바로 사용이 가능하다.
			// Console.WriteLine($"학생3의 ID : {student3.GetID()}");
			// Console.WriteLine($"총 학생수 : {Student.GetCount()}");

			// 이런 식으로 사용한다는 것이다 {student3.GetID()}");는 new를 해서 사용해야 하지만 밑에 꺼는 new를 사용하지 않고 클래스 자체를 불러온 경우디ㅏ.

			Student1 student1 = new Student1();

			Console.WriteLine(student1.GetID());
			Console.WriteLine(Student1.GetCount());

			Setting.volume = 50;
			Setting.Reset();
			// 정적 클래스는 new 해서 인스터를 만들 수가 없다.

			// 정적 클래스 이름 점으로 사용하면 되고
			// 정적으로 안 만들었으면 new 해서 인스턴스해서 사용하면 된다.
			// 스택은 고정적인 데이터 값이 있기에 고정된 값을 생성 삭제하면 되기에 힙영역보다 빠르다.
			// 힙영역은 어디 메모리가 비어있는지 찾고 거기에 new인 인스턴스를 넣어야 하기에 좀 느리다.
			// 그리고 빈칸이 있으면 앞으로 땡기기 때문에 시간 소요가 조금 있다.

			// 객체지향 프로그래밍 프로그램 설계방법론이자 개념의 일종이다.
			// 프로그램을 서로 상호작용하는 객체를 기본 단위로 구성하는 방식이다.

			// 절차지향과 객체지향 
			// 절차지향 : 프로그램의 순차적인 처리를 위주로 설계하는 방법론이다.
			// 객체지향 : 서로 상호작용하는 객체를 기본 단위로 구성하는 방법론이다.

			// 객체지향의 등장배경
			// 물리적인 하드웨어의 발전이 빠르게 진행되었으며, 소프트웨어의 중요성이 빠르게 올라간다.
			// 기존 절차지향의 방식으로는 복자합 구조에 대한 설계가 힘들어져서 객체지향의 방식이 대안이 되었다.

			// 객체지향의 장단점
			// 장점 : 객체단위로 관리하기 때문에 디버깅이 유리하다.
			// 클래스 단위로 모듈화 시켜 관리하므로 대규모 프로젝트에 적합하다.
			// 코드의 재사용성이 좋다.
			// 단점으로는 설계에 시간이 많이 소비되며 신중해야한다.

			// 객체지향 4특징
			// 캡슐화 : 객체를 상태와 기능으로 묶는 것을 의미하며, 객체의 내부 상태와 기능을 숨기고, 허용한 상태와 기능만의 액세스를 허용한다.
			// 다형셩 : 부모클래스의 함수를 자식클래스에서 재정하여 자식클래스의 다른 반응을 구현한다.
			// 추상화 : 관련 특성 및 엔터티의 상호 작용을 클래스로 모델링하여 시스템의 추상적 표현을 정의한다.
			// 상속 : 부모클랫의 모든 기능을 가지는 자식클래스를 설계하는 방법이다.

			// 객체설계 5원칙
			// 단일 책임 원칙 객체는 오직 하나의 책임을 가져야한다.
			// 개방 폐쇄 원칙 객체는 확장에 대해서는 개방적이고 수정에 대해서는 페쇄적이여야한다.
			// 리스코프 치환 원칙 자실 클래스는 언제나 자신의 부모클래스를 대체할 수 있어야한다.
			// 인터페이스 분리 원칙 인터페이스는 작은 단위들로 분리시켜 구성하며 사용하지 않는 함수는 포함하지 않아야 한다.
			// 의존적성 역전 원칙 객체는 하위클래스 보다 상위 클래스에 의존해야한다.

			Driver driver = new Driver() { name = "드라이버" };
			Vehicle motorBike = new Vehicle() { name = "오토바이" };

			driver.Ride(motorBike);

			// 캡슐화 객체를 정보와 기능으로 묶는 것을 의미한다.
			// 객체의 내부 정봐 기능을 숨기고, 허용한 정보와 기능만의 액세스 허용한다.

			// 캡슐화 객체를 정보와 기능으로 묶는 것, 객체의 정보와 기능을 멤버라고 표현한다.
			// 현실서계의 객체를 표현하기 위해 객체가 가지는 정보와 행동을 묶어 구현하며 이를 통해 객체가 상호작용한다.

			// 접근제한자 외부에서 접근이 가능한 멤버변수와 멤버함수를 지정하는 기능
			// 접근제한자를 지정하지 않는 경우 기본접근제한자는 private
			// public 외부에서도 사용가능 private 외부에서 사용제한 protectedd 사송한 클래스 public 그외는 private

			AccessSpecifier instance = new AccessSpecifier();
			instance.publicValue = 3; // 접근이 가능하지만 privateValue는 접근이 불가능하다.

			// 정보은닉 객체 구성에 있어서 외부에서 사용하기 원하는 기능과 원하지 않는 기능을 구분하기 위해서 사용한다.
			// 사용자가 객체를 사용하는데 있어서 필요한 기능만을 확인하기 위한 용도이며
			// 외부에 의해 영향을 받지 않길 원하는 기능을 감추기 위한 용도이기도하다.

			Bank bank = new Bank();
			// balance를 직접적으로 접근을 불가능하게 막아둔 것
			// 외부에서는 Bank에서 의도한 save load를 통해 bank룰 다르게 유도
			bank.Save(20000);
			bank.Load(10000);

			// 캡슐화 사용의미 캡슐화된 클래스는 외부에서 사용하기 위한 인터페이스만을 제공하여 복잡성을 감소시킨다.
			// 캡슐화된 클래스는 내부적으로 어떻게 구현되었는지 몰라도 사용이 가능하다.

			// 상속 부모클래스의 모든 기능을 가지는 자식클래스를 설계하는 방법이다.
			// is-a관계이다 부모클래스가 자식클래스를 포함하는 상위개념일 경우 상속관계가 적합하다.

			// 상속 부모클래스를 상속하는 자식클래스에게 부모클래스의 모든 기능을 부여한다.
			// class 자식 : 부모
			// 만약 몬스터 이름을 상속 받지 않게 하면 모든 모든스터에 이름을 계속 선언해줘야한다(변수말하는 것)
			// 아래와 같이 몇 줄 안 되더라도 몬스터가 5천 종류가 있다면 밑에 코드를 5천개 복붙해야하기에
			// 그럴 경우 상속을 하는게 낫다.

			// 그러닌까 is - a 관게가 드래곤은 몬스터다 이런 것을 말한다. 드래곤은 날 수 있다. 이건 상속이 아님.


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


		}



		// 함수 ///////////////////////////////////////////////////////////////////////////



		static int Plus(int left, int right)
		{
			int result = left + right;
			return result;
		}

		static int Return()
		{
			Console.WriteLine("도달하는 코드");
			return 10;
			Console.WriteLine("도달하지 못하는 코드이다.");
		}

		static void PrintProfile(string name, string phone)
		{
			if (name == "")
			{
				Console.WriteLine("이름을 입력해주세요");
				return; // 반환형의 return은 함수 종료의 역할을 한다.
			}
			Console.WriteLine(name, phone); // 이러면 name만 나온다.
			Console.WriteLine($"{name}, {phone}"); // 둘다 출력시키고 싶으면 이렇게 하면 된다.
												   // void 반환형에서 return을 생략할 수 있다.
		}

		static int Minus(int left, int right)
		{
			return left - right;
		}

		// 매개변수를 사용했을 때
		static int TripleShot()
		{
			int damage = 0;
			damage += Attack(10);
			damage += Attack(10);
			damage += Attack(10);
			return damage;
		}

		static int Attack(int damage)
		{
			return damage;
		}

		// 매개변수를 사용 안 했을 때
		static int TripleShot2()
		{
			int damage = 0;
			damage += Attack2();
			damage += Attack2();
			damage += Attack2();

			return damage;
		}

		static int Attack2()
		{
			return 100;
		}

		static int Multi(int left, int right) { return left * right; }
		static float Multi(float left, float right) { return left * right; }
		static double Multi(double left, float right) { return left * right; } // 이런식으로 매개변수가 반환형이 달라도 할 수 있다.

		static void Swap(ValueType left, ValueType right)
		{
			int temp = left.value;
			left.value = right.value;
			right.value = temp;
		}

		static void Swap(RefType left, RefType right)
		{
			int temp = left.value;
			left.value = right.value;
			right.value = temp;
		}
	}



	// 구조체, 클래스 /////////////////////////////////////////////////////////////////////



	enum Direction
	{
		Up, Down, Left, Right
	}

	enum Season
	{
		Spring, // 0
		Summer, // 1
		Autumn = 20, // 20
		Winter // 21
	}

	struct StudentInfo
	{
		public string name;
		public int math;
		public int english;
		public int science;

		public float Average()
		{
			return (math + english + science) / 3f;
		}
	}

	struct Point
	{
		public int x;
		public int y;

		public Point(int x, int y)
		{
			// 초기화에서 모든 구조체 변수를 초기화라지 않으면 에러가 발생한다.
			this.x = x;
			this.y = y;
			// this는 자기 자신을 가르킨다.
		}
	}

	enum Jop
	{
		Archor,
		Mage,
		Knight
	}

	struct PlayerStat
	{
		public int hp;
		public int mp;
		public int ad;
		public float speed;

		public PlayerStat(Jop jop)
		{
			if (jop == Jop.Archor)
			{
				hp = 100;
			}
		}
	}

	struct MyStruct
	{
		public int value1;
		public int value2;
	}

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

	class Car
	{
		public string name;
		public string color;

		public Car(string name, string color)
		{
			this.name = name;
			this.color = color;
		}
	}

	class MyClass
	{
		public int value1;
		public int value2;
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

	class PlayerClass
	{
		public int hp;
	}

	class MonsterClass
	{
		public int damage;

		public void Attack(PlayerClass playerClass)
		{
			playerClass.hp -= damage;
		}
	}

	struct ValueType
	{
		public int value;
	}

	class RefType
	{
		public int value;
	}

	class Student1
	{
		private static int count;

		private int id;

		public Student1()
		{
			id = ++count;
		}

		public static int GetCount()
		{
			return count;
		}

		public int GetID()
		{
			return id;
		}
	}

	static class Setting
	{
		public static int volume;

		public static void Reset()
		{
			volume = 10;
		}

		// 정적 클래스에서는 정적이 변수, 함수가 아니면 포함이 불가능하다.
	}

	class Driver
	{
		public string name;

		public void Ride(Vehicle Vehicle)
		{
			Console.WriteLine($"{name}이 {Vehicle.name}을 운전합니다.");
		}
	}

	class Vehicle
	{
		public string name;
		public int speed = 0;

		public void Move()
		{
			speed += 10;
			Console.WriteLine($"{name}의 속도가 {speed}으로 증가합니다.");
		}
	}

	class Capsule
	{
		private int veriable; // 멤버변수 정보를 표현
		private void Function() // 멤버함수 기능을 표현
		{

		}
	}

	class AccessSpecifier
	{
		public int publicValue;
		private int privateValue;

		void Function()
		{
			publicValue = 1;
			privateValue = 2; // 같은 클래스이면 접근이 가능하다.
		}
	}

	class Bank
	{
		int balance;

		public void Save(int money)
		{
			balance += money;
		}

		public void Load(int money)
		{
			balance -= money;
		}
	}

	class VeryComplicatedObject
	{
		int veryComplicatedValue1; // 캡슐화된 클래스의 private는 외부에서 접근불가하므로 사용할 수 없다.

		void VeryComplicatedFunction1() 
		{

		}
		
		// 캡슐화된 클래스의 public은 외부에서 접가능하므로 사용을 권장하는 기능이다.
		public void UseThisFunction()
		{

		}

		// 남의 코드를 사용할 떄 private는 무시해도 될 정도이다 public으로 풀어준 것만 보고 사용하면 된다.
	}

	class IntArray
	{
		int[] array = new int[10];

		public void Setvalue(int index, int value)
		{
			if (index < 0 || index >= 10)
			{
				return;
			}

			array[index] = value;
		}
	}

	class Monster1
	{
		protected string name;
		protected int hp;

		public void Move()
		{
			Console.WriteLine($"{name}이 움직입니다.");
		}

		public void TakeHit(int damage)
		{
			hp -= damage;
			Console.WriteLine($"{name}이{damage}를 받아 체력이{hp}이 되었습니다.");
		}
	}

	class Dragon : Monster1
	{
		public int damage;

		public Dragon()
		{
			name = "드래곤";
			hp = 100;
		}

		public void Breath()
		{
			Console.WriteLine($"{name}이 브레스를 뿜습니다.");
		}
	}

	class DragonRed : Dragon
	{
		public DragonRed()
		{
			damage = 100;
			name = "드래곤레드";
		}
	}

	// 이렇게 사용하면 드래곤, 몬스터를 둘 다 상속을 받은거라 전부 사용이 가능하게 된다. 상속에 상속인 느낌

	class Slime : Monster1
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
		
		public void Attack(Monster1 monster)
		{
			monster.TakeHit(damage);
		}

		// 만약에 몬스터라는 상속 구조를 하지 않았다면 드래곤 떄리기, 슬라임 때리기를 전부 구현했어야한다!!

		public void Attack2(Dragon dragon)
		{
			// 위에처럼 안했으면 이런식으로 모든 몬스터를 넣었어야 한다.
		}
	}


}
