using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001627 RID: 5671
	[Token(Token = "0x2001627")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EFC8C", Offset = "0x10EFC8C")]
	public class UIHUDPVEHUDExitGameController : UIBaseController
	{
		// Token: 0x060065FC RID: 26108 RVA: 0x0001D1F0 File Offset: 0x0001B3F0
		[Token(Token = "0x60065FC")]
		[Address(RVA = "0x16BAC90", Offset = "0x16BAC90", VA = "0x7BBBEBAC90")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060065FD RID: 26109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065FD")]
		[Address(RVA = "0x16BACE0", Offset = "0x16BACE0", VA = "0x7BBBEBACE0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060065FE RID: 26110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065FE")]
		[Address(RVA = "0x16BADC4", Offset = "0x16BADC4", VA = "0x7BBBEBADC4")]
		public void InitData(float exitCountDown, Action countDownEndCallback)
		{
		}

		// Token: 0x060065FF RID: 26111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065FF")]
		[Address(RVA = "0x16BAE00", Offset = "0x16BAE00", VA = "0x7BBBEBAE00")]
		private void Update()
		{
		}

		// Token: 0x06006600 RID: 26112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006600")]
		[Address(RVA = "0x16BAEC8", Offset = "0x16BAEC8", VA = "0x7BBBEBAEC8")]
		private string FormatTimeToString(float duration)
		{
			return null;
		}

		// Token: 0x06006601 RID: 26113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006601")]
		[Address(RVA = "0x16BB22C", Offset = "0x16BB22C", VA = "0x7BBBEBB22C")]
		private void OnExitClick()
		{
		}

		// Token: 0x06006602 RID: 26114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006602")]
		[Address(RVA = "0x16BB288", Offset = "0x16BB288", VA = "0x7BBBEBB288")]
		public UIHUDPVEHUDExitGameController()
		{
		}

		// Token: 0x040083F9 RID: 33785
		[Token(Token = "0x40083F9")]
		[FieldOffset(Offset = "0x58")]
		private PVEHUDExitGameUIView m_View;

		// Token: 0x040083FA RID: 33786
		[Token(Token = "0x40083FA")]
		[FieldOffset(Offset = "0x60")]
		private float closeEndTime;

		// Token: 0x040083FB RID: 33787
		[Token(Token = "0x40083FB")]
		[FieldOffset(Offset = "0x68")]
		private Action m_CountDownEndCallback;

		// Token: 0x040083FC RID: 33788
		[Token(Token = "0x40083FC")]
		[FieldOffset(Offset = "0x70")]
		private bool m_IsEnd;

		// Token: 0x040083FD RID: 33789
		[Token(Token = "0x40083FD")]
		[FieldOffset(Offset = "0x78")]
		private TimeSpan m_TimeHelper;
	}
}
