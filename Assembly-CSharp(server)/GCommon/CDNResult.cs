using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F87 RID: 3975
	[Token(Token = "0x2000F87")]
	public class CDNResult : NetDetectionResult
	{
		// Token: 0x060039E1 RID: 14817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039E1")]
		[Address(RVA = "0x25E6E28", Offset = "0x25E6E28", VA = "0x7BBCDE6E28")]
		public CDNResult()
		{
		}

		// Token: 0x04004B76 RID: 19318
		[Token(Token = "0x4004B76")]
		[FieldOffset(Offset = "0x18")]
		public float req_time;

		// Token: 0x04004B77 RID: 19319
		[Token(Token = "0x4004B77")]
		[FieldOffset(Offset = "0x20")]
		public long reponse_code;
	}
}
