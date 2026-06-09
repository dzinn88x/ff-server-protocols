using System;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x02001338 RID: 4920
	[Token(Token = "0x2001338")]
	public class AutoTaskRateGame : AutoPopupTask
	{
		// Token: 0x06004E01 RID: 19969 RVA: 0x00017B50 File Offset: 0x00015D50
		[Token(Token = "0x6004E01")]
		[Address(RVA = "0x155ADC0", Offset = "0x155ADC0", VA = "0x7BBBD5ADC0", Slot = "5")]
		public override bool Do()
		{
			return default(bool);
		}

		// Token: 0x06004E02 RID: 19970 RVA: 0x00017B68 File Offset: 0x00015D68
		[Token(Token = "0x6004E02")]
		[Address(RVA = "0x155B020", Offset = "0x155B020", VA = "0x7BBBD5B020", Slot = "6")]
		public override bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06004E03 RID: 19971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E03")]
		[Address(RVA = "0x155B0C0", Offset = "0x155B0C0", VA = "0x7BBBD5B0C0", Slot = "4")]
		public override ServiceMessageTypeHTTP[] NeedHttpRequests()
		{
			return null;
		}

		// Token: 0x06004E04 RID: 19972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E04")]
		[Address(RVA = "0x155B0C8", Offset = "0x155B0C8", VA = "0x7BBBD5B0C8")]
		public AutoTaskRateGame()
		{
		}

		// Token: 0x0400754D RID: 30029
		[Token(Token = "0x400754D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string SHOW_RATEGAME_KEY;

		// Token: 0x0400754E RID: 30030
		[Token(Token = "0x400754E")]
		[FieldOffset(Offset = "0x10")]
		private UIRateGamePopupWindowController m_RateWindow;
	}
}
