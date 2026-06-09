using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F86 RID: 3974
	[Token(Token = "0x2000F86")]
	public class PingResult : NetDetectionResult
	{
		// Token: 0x060039E0 RID: 14816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039E0")]
		[Address(RVA = "0x2460720", Offset = "0x2460720", VA = "0x7BBCC60720")]
		public PingResult()
		{
		}

		// Token: 0x04004B74 RID: 19316
		[Token(Token = "0x4004B74")]
		[FieldOffset(Offset = "0x18")]
		public int average_delay;

		// Token: 0x04004B75 RID: 19317
		[Token(Token = "0x4004B75")]
		[FieldOffset(Offset = "0x1C")]
		public int loss_rate;
	}
}
