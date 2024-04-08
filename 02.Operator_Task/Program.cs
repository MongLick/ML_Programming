namespace _02.Operator_Task
{
	internal class Program
	{
		//제목 : 제드

		//변수와 상수를 이용해서 캐릭터의 스탯을 관리해주자.
		//스킬들은 모두 1레벨 스킬로 가정하자.
		//레벨을 입력 받아준다.
		//Q스킬에 대한 수치를 계산한 결과출력
		//W스킬에 대한 수치를 계산한 결과출력
		//E스킬에 대한 수치를 계산한 결과출력
		//R스킬에 대한 수치를 계산한 결과출력

		//최종수치 = 기본수치 + 계수 * 스탯

		static void Main(string[] args)
		{
			int level;
			float ad = 63;
			float levelad =3.4f;
			float qDamage;
			float eDamage;
			float rDamage;

			Console.Write("제드의 레벨을 입력해주세요 : ");
			level = int.Parse(Console.ReadLine());

			qDamage = 70 + (levelad * level) * 1.1f;
			eDamage = 65 + (levelad * level) * 0.65f;
			rDamage = ad + (levelad * level);

			Console.WriteLine($"제드의 Q스킬 데미지 : {qDamage}");
			Console.WriteLine($"제드의 E스킬 데미지 : {eDamage}");
			Console.WriteLine($"제드의 R스킬 데미지 : {rDamage}");
		}
	}
}
