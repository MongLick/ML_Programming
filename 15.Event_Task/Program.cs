namespace _15.Event_Task
{
	internal class Program
	{
		// 플레이어가 코인을 얻을때 발생하는 이벤트를 구현하자
		// 이벤트에 반응하는 UI, SFX, VFX 객체를 구현하자
		// 플레이어가 코인을 얻을때 발생하는 이벤트에 반응하도록 UI, SFX, VFX를 참조하자
		// 플레이어가 코인을 얻으면 UI, SFX, VFX가 반응하는지 확인하자

		public class Player
		{
			public event Action OnGetCoin;

			public void GetCoin()
			{
				Console.WriteLine("플레이어가 코인을 얻었습니다.");

				if(OnGetCoin != null)
				{
					OnGetCoin();
				}
			}
		}

		public class UI
		{
			public void UpdateUI()
			{
				Console.WriteLine("UI에 코인 수를 갱신하였습니다.");
			}
		}

		public class SFX
		{
			public void CoinSound()
			{
				Console.WriteLine("코인을 얻는 효과음을 재생시켰습니다.");
			}
		}

		public class VFX
		{
			public void CoinEffect()
			{
				Console.WriteLine("코인을 얻는 반짝거리는 효과를 보여줍니다.");
			}
		}

		static void Main(string[] args)
		{
			Player player = new Player();
			UI ui = new UI();
			SFX sfx = new SFX();
			VFX vfx = new VFX();

			player.OnGetCoin += ui.UpdateUI;
			player.OnGetCoin += sfx.CoinSound;
			player.OnGetCoin += vfx.CoinEffect;

			player.GetCoin();
		}
	}
}
