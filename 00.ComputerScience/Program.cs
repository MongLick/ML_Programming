﻿namespace _00.ComputerScience
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			 * <int 2의 보수>
			 * 
			 * int가 32bit이니 총 42억이 표현이 가능한데 맨 앞에 숫자를 부호로 사용한다. 0이면 + , 1이면 -로 판정한다. 그래서 31bit이니 21억 까지 표현이 가능한 것 이다.
			 * -1은 10000000 00000000 00000000 00000001 로 표현하고 1은 00000000 00000000 00000000 00000001로 표현한다.
			 * 컴퓨터는 빼기보다 더하기가 훨씬 빠르다.
			 * 0010 + 0001 은 0011로 바로 나오는데 예를 들어 11000000 - 00000001을 하면 맨 앞에서 부터 계속 당겨와야하기 때문에
			 * +는 바로 앞에만 영향을 주지만 -는 앞이 0이라면 계속 앞으로 가서 1을 찾아야 하기 때문이다.
			 * 3-2 나 3+(-2)나 똑같다.
			 * 그래서 더 빠르게 하기 위해서 2의 보수를 사용한다.
			 * + 숫자에 1을 0으로 0을 1로 바꾸자 이렇게 뒤집은걸 1의 보수라고 한다.
			 * 여기에 +1를 해주면 2의 보수라고 한다.
			 * 예를 들어 1010을 뒤집으면 0101을 1의 보수라고 하고 0110을 2의 보수라고 한다.
			 * 예를 들어 8 - 1이면 1000 - 0001 인데 0001을 1의 보수로 변경하면 1110 2의 보수로 변경하면 1111이다.
			 * 그래서 1000 + 1111을 하면 10111이다. 4개 자리로만 계산을 했으니 5번째 자리인 1을 버리면 0111이다. 이는 곧 7이다.
			 * 이렇게 2의 보수를 하면
			 * 1. 컴퓨터는 더하기가 훨씬 빠르고 빼기는 느리다.
			 * 2. 빼기 대신에 (-)를 더하는 경우가 더 빠르다.
			 * 3. 2의 보수를 사용하면 동일한 결과가 나온다.
			 */


			/*
			 * < 언더플로우 & 오버플로우 >
			 * 
			 * int 최대값 2147483647 에 +1을 하면 2147483648가 나와야 하지만 
			 * 오버플로우가 발생되어 -2147483648이 나오고
			 * int 최소값 -2147483648 에 -1을 하면 -2147483649가 나와야 하지만
			 * 언더플로우가 발생되어 2147483647이 나온다.
			 * 
			 * 최대값보다 커지면 오버플로우
			 * 최소값보다 작으면 언더플로우
			 * 
			 * 01111111 11111111 11111111 11111111 => 2147483647
			 * 여기에 +1을 해주면
			 * 10000000 00000000 00000000 00000000 => -2147483648
			 * 변경되면서 맨 앞에 부호가 바뀌어 버린다.
			 * 
			 * 10000000 00000000 00000000 00000000 => -2147483648
			 * 여기에 -1을 해주면
			 * 10000000 00000000 00000000 00000001 => -1인데 -1 대신 +1로 계산을 하면
			 * 00000000 00000000 00000000 00000001 => 1로 계산
			 * 1의 보수로 변경해주면
			 * 11111111 11111111 11111111 11111110로 변경된다.
			 * 2의 보수로 변경해주면
			 * 11111111 11111111 11111111 11111111로 변경된다.
			 * 
			 * 10000000 00000000 00000000 00000000 + 11111111 11111111 11111111 11111111 을 하게 되면
			 * 101111111 11111111 11111111 11111111로 변경된다.
			 * 맨 앞에 1을 버리게 되면
			 * 01111111 11111111 11111111 11111111 => 2147483647로 변경된다.
			 */

			int max = 2147483647;
			int result = max + 1;
			Console.WriteLine(result);

			int min = -2147483648;
			int result2 = min - 1;
			Console.WriteLine(result2);

			/*
			 * <float 부동소수점>
			 * 
			 * 고정소수점 : 점이 고정 되어 있는 것
			 * 맨 앞 부호를 빼면 앞에는 15자리 뒤에는 16자리
			 * (부호) 15. 16 .위치가 15번째 자리인 것
			 * 예를 들어 7.625이면
			 * 00000000 00000111 . 10100000 00000000
			 * 이렇기 때문에 -3 ~ 3 까지만 표현이 가능하다.
			 * 그래서 32bit나 쓰는데 표현할 수 있는 숫자가 너무 작다.
			 * 
			 * 부동소수점 : 점이 고정 되어 있지 않은 것
			 * 인간은 10진수로 숫자 * 10의 몇승인지로 표현하는 것
			 * 1 * 10 0승 이면 1
			 * 1 * 10 -1승 이면 0.1
			 * 1 * 10 -2승 이면 0.01
			 * 1 * 10 -3승 이면 0.001
			 * 1 * 10 +3승 이면 1.000
			 * 앞에 숫자를 지수(1) 몇승인지가 가수(-3승)이다.
			 * 컴퓨터는 2진수로만 표현하기 때문에 2의 몇승인지로 표현한다.
			 * 1bit는 부호로 사용하고 지수는 8bit 가수는 23bit를 사용한다.
			 * 부동소수점 쓰는 이유는 적은 용량으로 더 많은 수를 표현할 수 있기 때문이다.
			 * 1.1 + 0.1 이 1.2가 아닌 이유는
			 * 0.1을 2진수로 표현하면
			 * 2의 -1 승 = 0.5 2의 -2승 0.25 2의 -3승 0.125 2의 -4승 0.0625 2의 -5승 0.03125
			 * 2의 -4승 + 2의 -5승 ... 계속 하기 때문에
			 * 컴퓨터는 0.1 즉 1/10을 표현할 수 있는 방법이 없다.
			 * 예를 들어 1/3 은 0.3333333 이다 1/3 + 1/3+ 1/3 은 1이지만 컴퓨터는 0.9999999로 이해하기 때문에 1 != 0.9999999로 되기 때문에
			 * 1.1 + 0.1 == 1.2가 틀리다는 말이다. 2진법으로 0.1은 무한 소수이다.
			 * 
			 * 결론 : 컴퓨터는 소수점이 근사치이다 똑같니? 라고 물어보는게 아니라 오차가 0.0001보다 작니? 라는 식으로 물어봐야한다.
			 */




			/*
			 * <논리 연산자 및 비교 연산자 같이 해보기>
			 * bool result = 1 <= level <= 18;   // 프로그래밍 문법상 오류
			 * 왜 안 되는지
			 * 어떻게 소스를 구성해야 위에 의도를 구현할 수 있는지
			 */

			int level = 15;

			bool result3 = (1 <= level) && (level <= 18);
			if (result3)
			{
				Console.WriteLine("1보다 크고 18렙 보다 작습니다.");
			}
			else
			{
				Console.WriteLine("1보다 작거나 18렙 보다 큽니다.");
			}

			/*
			 * <비트 마스크 공부하기>
			 * 비트마스크(Bitmask)는 컴퓨터 과학에서 사용되는 기술로, 이진수를 활용하여 정보를 저장하고 처리하는 방법입니다.
			 * 비트마스크는 특히 플래그(flag)를 표현하거나 다수의 상태를 표현하고 관리하는 데 사용됩니다.
			 * 
			 * 비트마스크를 이해하는 데 핵심적인 개념은 이진수(binary)를 사용하여 데이터를 표현하는 것입니다. 
			 * 각 비트(bit)는 특정한 상태를 나타냅니다. 예를 들어, 4비트를 사용하여 상태를 나타낼 수 있는 경우, 0000부터 1111까지 총 16가지의 상태를 표현할 수 있습니다.
			 * C#에서 비트마스크는 일반적으로 비트 연산자를 사용하여 처리됩니다. 
			 * 주요 비트 연산자로는 AND(&), OR(|), XOR(^), NOT(~) 등이 있습니다. 
			 * 이러한 비트 연산자를 사용하여 특정 비트를 설정하거나 검사하고 상태를 변경합니다.
			 * 
			 * 비트마스크는 다음과 같은 장점을 갖습니다
			 * 공간 효율성: 비트 단위로 상태를 저장하기 때문에 메모리 사용이 효율적입니다.
			 * 속도: 비트 연산은 일반적으로 다른 연산에 비해 빠릅니다.
			 * 간결성: 여러 개의 상태를 하나의 변수에 저장하고 관리할 수 있어 코드가 간결해집니다.
			 * 
			 * 비트마스크는 주로 상태를 표현하고 다루는 경우에 유용하게 사용됩니다. 예를 들어, 특정 기능이 활성화되었는지 여부를 추적하거나 여러 가지 설정을 관리하는 데 사용될 수 있습니다.
			 */
		}
	}
}
