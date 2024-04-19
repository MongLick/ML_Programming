namespace _14.Delegate_Task
{
	internal class Program
	{
		// 일반화를 이용하여 어떤 자료형의 배열이더라도 복사가능한 함수를 구현
		// void ArrayCopy(배열원본, 복사할배열);

		public static void ArrayCopy<T>(T[] source, T[] output)
		{
			for (int i = 0; i < source.Length; i++)
			{
				output[i] = source[i];
			}
		}

		// 계산금지, 조건문 쓰기 금지

		public class Calculator
		{
			double left;
			double right;
			Func<double, double, double> func;

			public double Add(double x, double y)
			{
				return x + y;
			}

			public void SetCommand(double left, char oper, double right)
			{
				func = Add;
				this.left = left;
				this.right = right;
			}

			public double Equal()
			{
				return func(left, right);
			}
		}

		// 콜백함수를 이용하여 플레이어를 조작하는 UI 버튼을 만들어보자.
		// 점프를 하는 버튼, 대시를 하는 버튼

		public class Button
		{
			public Action callback;

			public void Click()
			{
				if(callback != null)
				{
					callback();
				}
			}
		}

		public class File
		{
			public void Jump()
			{
				Console.WriteLine("점프");
			}

			public void Dash()
			{
				Console.WriteLine("대쉬");
			}
		}


		static void Main(string[] args)
		{
			int[] iSrc = { 1, 2, 3, 4, 5 };
			float[] fSrc = { 1f, 2f, 3f, 4f, 5f };
			double[] dSrc = { 1d, 2d, 3d, 4d, 5d };
			char[] cSrc = { 'a', 'b', 'c' };

			int[] iDst = new int[iSrc.Length];
			float[] fDst = new float[fSrc.Length];
			double[] dDst = new double[dSrc.Length];
			char[] cDst = new char[cSrc.Length];

			ArrayCopy(iSrc, iDst);

			foreach (int i in iDst)
			{
				Console.WriteLine($"{i}");
			}

			Calculator cal = new Calculator();
			cal.SetCommand(2.5, '+', 3.2);
			double result = cal.Equal();
			// 결과가 5.7이 나오도록 구현
			Console.WriteLine(result);

			File file = new File();
			Button jumpButton = new Button();
			Button dashButton = new Button();

			jumpButton.callback = file.Jump;
			dashButton.callback = file.Dash;

			jumpButton.Click();
			dashButton.Click();
		}
	}
}
