﻿namespace _02.Operator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool bValue = false;
			int iValue = 0;
			float fValue = 0.0f;

			/********************************************************************
             * 연산자 (Operator)
             *
             * 프로그래밍 언어에서는 일반적인 수학 연산과 유사한 연산자들이 지원됨
             * C#는 여러 연산자를 제공하며 기본 연산을 수행할 수 있음
             *********************************************************************/

			/**************************************************************
             * 산술 연산자
             **************************************************************/

			// <이진 연산자> // 2개 가지고 숫자 계산하는 것
			iValue = 1 + 2;     // +(더하기)
			iValue = 3 - 1;     // -(빼기)
			iValue = 4 * 2;     // *(곱하기)
			fValue = 5f / 3f;   // /(나누기) : 주의! 5 / 3 과 같이 int의 나눗셈은 소수점을 버림
			iValue = 13 % 3;    // %(나머지)

			// <단항 연산자>
			iValue = +iValue;   // + 단항연산자(양수)  : 값을 반환
			iValue = -iValue;   // - 단항연산자(음수)  : 값의 마이너스를 반환
			++iValue;           // ++ 전위증가연산자   : 값을 1 증가
			iValue++;           // ++ 후위증가연산자   : 값을 1 증가
			--iValue;           // -- 전위감소연산자   : 값을 1 감소
			iValue--;           // -- 후위감소연산자   : 값을 1 감소

			// <전위연산자와 후위연산자>
			// 전위연산자 : 값을 반환하기 전에 연산
			iValue = 0;
			Console.WriteLine(iValue);   // output : 0
			Console.WriteLine(++iValue); // output : 1
			Console.WriteLine(iValue);   // output : 1
										 // 후위연산자 : 값을 반환한 후에 연산
			iValue = 0;
			Console.WriteLine(iValue);   // output : 0
			Console.WriteLine(iValue++); // output : 0
			Console.WriteLine(iValue);   // output : 1

			/**************************************************************
             * 대입 연산자
             **************************************************************/

			// <대입 연산자>
			iValue = 10;        // = : 오른쪽의 값을 왼쪽 변수에 대입

			// <복합 대입 연산자>
			// 이진 연산자(op)의 경우
			// x op= y 는 x = x op y 와 동일
			iValue += 5;        // iValue = iValue + 5; 와 동일

			/****************************************************************
             * 비교 연산자
             ****************************************************************/

			// <비교 연산자>
			bValue = 3 > 1;     // >  : 왼쪽 피연산자가 더 클 경우 true
			bValue = 3 < 1;     // <  : 왼쪽 피연산자가 더 작을 경우 true
			bValue = 3 >= 1;    // >= : 왼쪽 피연산자가 더 크거나 같은 경우 true
			bValue = 3 <= 1;    // <= : 왼쪽 피연산자가 더 작거나 같은 경우 true
			bValue = 3 == 1;    // == : 두 피연산자가 같은 경우 true
			bValue = 3 != 1;    // != : 두 피연산자가 다를 경우 true

			/****************************************************************
             * 논리 연산자
             ****************************************************************/

			// <논리 연산자>
			bValue = !false;            // !(Not)  : 피연산자의 논리 부정을 반환
			bValue = true && false;     // &&(And) : 두 피연산자가 모두 true 일 경우 true
			bValue = true || false;     // ||(Or)  : 두 피연산자가 모두 false 일 경우 false
			bValue = true ^ false;      // ^(Xor)  : 두 피연산자가 다를 경우 true

			// <조건부 논리 연산자>
			// 조건부 논리 And 연산자 &&
			// 빠른 계산을 위해 false && x(논리자료형) 의 경우 어떠한 논리자료형이 있어도
			// 결과는 항상 false이기 때문에 false && x 에서 x는 무시하게 됨
			iValue = 10;
			bValue = false && (++iValue > 5);
			Console.WriteLine(iValue);  // output : 10

			// 조건부 논리 Or 연산자 ||
			// 빠른 계산을 위해 true || x(논리자료형) 의 경우 어떠한 논리자료형이 있어도
			// 결과는 항상 true이기 때문에 true || x 에서 x는 무시하게 됨
			iValue = 10;
			bValue = true || (++iValue > 5);
			Console.WriteLine(iValue);  // output : 10

			// 논리 연산자 안에서 산술은 안 한다.
			// 산술을 하고 싶으면 논리 연산자 만나기 전이나 후에 해주자.

			/****************************************************************
             * 비트 연산자
             ****************************************************************/

			// <단항 연산자>
			iValue = ~0x35;         // ~(비트 보수) : 데이터를 비트단위로 보수 연산 (보수 : 0->1, 1->0)
			// 예를 들어서 1001을 바꿔주면 0110으로 바꿔준다라는 말이다.

			// <이진 연산자>
			iValue = 0x11 & 0x83;   // &(And) : 데이터를 비트단위로 And 연산
			iValue = 0x11 | 0x83;   // |(Or)  : 데이터를 비트단위로 Or 연산
			iValue = 0x11 ^ 0x83;   // ^(Xor) : 데이터를 비트단위로 Xor 연산

			// <비트 쉬프트 연산자> // 다른 연산보다 훨씬 빠르다
			iValue = 0x20 << 1;     // << : 왼쪽의 피연산자의 비트를 오른쪽 피연산자만큼 왼쪽으로 이동
			Console.WriteLine($"쉬프트 << 비트 연산자 : {iValue}"); // 32 * 2
			iValue = 0x20 >> 1;     // >> : 왼쪽의 피연산자의 비트를 오른쪽 피연산자만큼 오른쪽으로 이동
			Console.WriteLine($"쉬프트 >> 비트 연산자 : {iValue}"); // 32 / 2
			// 0x가 16진수이다. 곧 20은 32라는 뜻

			// 그냥 *2 해주것보다 << 1을 해주는 것이 훨씬 빠르다
			// << 1 은 *2 << 2 은 *4 << 3은 *8 이다 2의 x승 이라고 이라고 보면 된다. << 3이면 2의 3승 == 8이다.
			// 곱하기가 나누기 보다 훨씬 빠르다 100 / 2 보다 100 * 0.5가 훨씬 빠르다 이것보다 100 >> 1이 훨씬 빠르다
			// << 2를 하면  * 4 >> 2를 하면 /4가 된다.

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
		}
	}
}
