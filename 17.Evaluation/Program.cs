namespace _17.evaluation
{
	internal class Program
	{
		// 1번 문제
		// 주어진 문자열 중 찾는 문자가 있는 인덱스를 구하는 함수를 작성하시오 단 없을 경우 -1을 출력하시오.

		// 입력 : "abcdef", 'd'
		// 출력 : 3

		// 입력 : "Winner winner chicken dinner", 'c'
		// 출력 : 14

		// 입력 : "Not your lucky day", 'p'
		// 출력 : -1

		public static int FindKeyIndex(string text, char key)
		{
			int index = text.IndexOf(key);
			return index;
		}

		// 2번 문제
		// 주어진 숫자가 소수인지 판별하는 함수를 작성하시오.

		// 입력 : 7
		// 출력 : true

		// 입력 : 4
		// 출력 : false

		// 입력 : 1
		// 출력 : false

		public static bool IsPrime(int numer)
		{
			bool result = true;
			if (numer % 2 == 0 || numer == 1)
			{
				result = false;
			}
			return result;
		}

		// 3번 문제
		// 주어진 숫자의 각 자리수의 합을 구하는 함수를 작성하시오.

		// 입력 : 18234
		// 출력 : 18

		// 입력 : 3849
		// 출력 : 24

		// 입력 : 12345
		// 출력 : 15

		public static int SumOfDigits(int number)
		{
			int num = 0;
			while (number != 0)
			{
				num += number % 10;
				number /= 10;
			}
			return num;
		}

		// 4번 문제 
		// 주어진 두 배열에서 공통항목을 찾는 함수를 작성하시오. 단, 중복은 허용하지 않는다.

		// 입력 : 
		// int[] array1 = {1, 5, 5, 10};
		// int[] array2 = {3, 5, 5, 10};
		// 출력 :
		// {5, 10}

		// 입력 : 
		// int[] array1 = {3, 5, 7, 9};
		// int[] array2 = {7, 6, 5, 4};
		// 출력 :
		// {5, 7}

		// 입력 : 
		// int[] array1 = {8, 7, 6, 5};
		// int[] array2 = {1, 2, 3, 4};
		// 출력 :
		// {null}

		public static int[] FindCommonItems(int[] array1, int[] array2)
		{
			int[] num = new int[0];
			int index = 0;
			for (int i = 0; i < array1.Length; i++)
			{
				bool result = false;
				for (int j = 0; j < index; j++)
				{
					if (num[j] == array1[i])
					{
						result = true;
						break;
					}
				}

				if (!result)
				{
					for (int j = 0; j < array2.Length; j++)
					{
						if (array1[i] == array2[j])
						{
							Array.Resize(ref num, num.Length + 1);
							num[num.Length - 1] = array2[j];
							index++;
							break;
						}
					}
				}
			}

			return num;
		}

		// 5번 문제
		// 주어진 배열에서 주어진 숫자와 가장 가까운 수를 구하는 함수를 작성하시오.

		// 입력 : {3, 10, 28}, 20
		// 출력 : 28

		// 입력 : {10, 11, 12}, 15
		// 출력 : 12

		// 입력 : {1, 2, 3, 4, 5}, 3
		// 출력 : 3

		public static int FindClosestNumber(int[] array, int number)
		{
			int max = int.MaxValue;
			int num = 0;
			for(int i = 0; i < array.Length; i++)
			{
				int tmp = Math.Abs(array[i] - number);
				if(max > tmp)
				{
					max = tmp;
					num = array[i];
				}
			}
			return num;
		}

		// 6번 문제
		// 주어진 배열에서 가장 자주 나오는 값인 최빈값을 구하는 함수를 작성하시오.
		// 단, 최빈값이 여러개인 경우 가장 값이 작은 값을 구한다. (조건, 0 < 배열 요소 값 < 1000)

		// 입력 : {1, 2, 3, 3, 3, 4}
		// 출력 : 3

		// 입력 : {1, 99, 99, 55, 32, 14}
		// 출력 : 99

		// 입력 : {11}
		// 출력 : 11

		public static int FindModeNumber(int[] array)
		{
			int[] frequencies = new int[1001]; 

			foreach (int num in array)
			{
				frequencies[num]++;
			}

			int maxFrequency = 0;
			int mode = int.MaxValue; 

			for (int i = 0; i < frequencies.Length; i++)
			{
				if (frequencies[i] > maxFrequency)
				{
					maxFrequency = frequencies[i];
					mode = i;
				}
			}

			return mode;
		}

		static void Main(string[] args)
		{
			// 1번 문제
			Console.WriteLine(FindKeyIndex("abcdef", 'd'));
			Console.WriteLine(FindKeyIndex("Winner winner chicken dinner", 'c'));
			Console.WriteLine(FindKeyIndex("Not your lucky day", 'p'));

			// 2번 문제
			Console.WriteLine(IsPrime(7));
			Console.WriteLine(IsPrime(4));
			Console.WriteLine(IsPrime(1));

			// 3번 문제
			Console.WriteLine(SumOfDigits(18234));
			Console.WriteLine(SumOfDigits(3849));
			Console.WriteLine(SumOfDigits(12345));

			// 4번 문제
			int[] array1 = { 1, 5, 5, 10 };
			int[] array2 = { 3, 5, 5, 10 };
			int[] num1 = FindCommonItems(array1, array2);
			foreach (int i in num1)
			{
				Console.WriteLine($"4 - 1 : {i}");
			}

			int[] array3 = { 3, 5, 7, 9 };
			int[] array4 = { 7, 6, 5, 4 };
			int[] num2 = FindCommonItems(array3, array4);
			foreach (int i in num2)
			{
				Console.WriteLine($"4 - 2 : {i}");
			}

			int[] array5 = { 8, 7, 6, 5 };
			int[] array6 = { 1, 2, 3, 4 };
			int[] num3 = FindCommonItems(array5, array6);
			foreach (int i in num3)
			{
				Console.WriteLine($"4 - 3 : {i}");
			}

			// 5번 문제
			int[] a = { 3, 10, 28 };
			int[] b = { 10, 11, 12 };
			int[] c = { 1, 2, 3, 4, 5 };

			Console.WriteLine(FindClosestNumber(a, 28));
			Console.WriteLine(FindClosestNumber(b, 15));
			Console.WriteLine(FindClosestNumber(c, 3));

			// 6번 문제
			int[] d = { 1, 2, 3, 3, 3, 4 };
			int[] e = { 1, 99, 99, 55, 32, 14};
			int[] f = { 11 };

			Console.WriteLine(FindModeNumber(d));
			Console.WriteLine(FindModeNumber(e));
			Console.WriteLine(FindModeNumber(f));
		}
	}
}
