using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020025FD RID: 9725
	[Token(Token = "0x20025FD")]
	public class CountDownConfig
	{
		// Token: 0x0600C8C2 RID: 51394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8C2")]
		[Address(RVA = "0x1600974", Offset = "0x1600974", VA = "0x7BBBE00974")]
		public CountDownConfig()
		{
		}

		// Token: 0x0400FB19 RID: 64281
		[Token(Token = "0x400FB19")]
		[FieldOffset(Offset = "0x10")]
		public ulong m_EndTime;

		// Token: 0x0400FB1A RID: 64282
		[Token(Token = "0x400FB1A")]
		[FieldOffset(Offset = "0x18")]
		public string m_Prefix;

		// Token: 0x0400FB1B RID: 64283
		[Token(Token = "0x400FB1B")]
		[FieldOffset(Offset = "0x20")]
		public string m_Suffix;

		// Token: 0x0400FB1C RID: 64284
		[Token(Token = "0x400FB1C")]
		[FieldOffset(Offset = "0x28")]
		public bool m_Formated;

		// Token: 0x0400FB1D RID: 64285
		[Token(Token = "0x400FB1D")]
		[FieldOffset(Offset = "0x30")]
		public OnStarted m_OnStarted;

		// Token: 0x0400FB1E RID: 64286
		[Token(Token = "0x400FB1E")]
		[FieldOffset(Offset = "0x38")]
		public OnFinished m_OnFinished;

		// Token: 0x0400FB1F RID: 64287
		[Token(Token = "0x400FB1F")]
		[FieldOffset(Offset = "0x40")]
		public bool m_ShortDisplay;
	}
}
