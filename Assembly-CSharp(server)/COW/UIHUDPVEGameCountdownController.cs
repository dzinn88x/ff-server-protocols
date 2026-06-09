using System;
using System.Text;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001624 RID: 5668
	[Token(Token = "0x2001624")]
	public class UIHUDPVEGameCountdownController : UIBaseController
	{
		// Token: 0x060065E8 RID: 26088 RVA: 0x0001D1A8 File Offset: 0x0001B3A8
		[Token(Token = "0x60065E8")]
		[Address(RVA = "0x16B9F48", Offset = "0x16B9F48", VA = "0x7BBBEB9F48")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060065E9 RID: 26089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065E9")]
		[Address(RVA = "0x16B9F98", Offset = "0x16B9F98", VA = "0x7BBBEB9F98", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060065EA RID: 26090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065EA")]
		[Address(RVA = "0x16BA09C", Offset = "0x16BA09C", VA = "0x7BBBEBA09C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060065EB RID: 26091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065EB")]
		[Address(RVA = "0x16BA168", Offset = "0x16BA168", VA = "0x7BBBEBA168")]
		private void OnEndTimeCome(object[] data)
		{
		}

		// Token: 0x060065EC RID: 26092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065EC")]
		[Address(RVA = "0x16BA204", Offset = "0x16BA204", VA = "0x7BBBEBA204")]
		private void Update()
		{
		}

		// Token: 0x060065ED RID: 26093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065ED")]
		[Address(RVA = "0x16BA44C", Offset = "0x16BA44C", VA = "0x7BBBEBA44C")]
		public UIHUDPVEGameCountdownController()
		{
		}

		// Token: 0x040083EF RID: 33775
		[Token(Token = "0x40083EF")]
		[FieldOffset(Offset = "0x58")]
		private UIHUDPVEGameCountdownView m_View;

		// Token: 0x040083F0 RID: 33776
		[Token(Token = "0x40083F0")]
		[FieldOffset(Offset = "0x60")]
		private uint m_GameEndTimeMS;

		// Token: 0x040083F1 RID: 33777
		[Token(Token = "0x40083F1")]
		[FieldOffset(Offset = "0x64")]
		private bool m_IsEndTimeCome;

		// Token: 0x040083F2 RID: 33778
		[Token(Token = "0x40083F2")]
		[FieldOffset(Offset = "0x68")]
		private uint mSeconds;

		// Token: 0x040083F3 RID: 33779
		[Token(Token = "0x40083F3")]
		[FieldOffset(Offset = "0x70")]
		private StringBuilder m_Timer;
	}
}
