using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000597 RID: 1431
	[Token(Token = "0x2000597")]
	[ProtoContract]
	public class EGameServer
	{
		// Token: 0x06002347 RID: 9031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002347")]
		[Address(RVA = "0x21B9810", Offset = "0x21B9810", VA = "0x7BBC9B9810")]
		public EGameServer()
		{
		}

		// Token: 0x02000598 RID: 1432
		[Token(Token = "0x2000598")]
		[ProtoContract]
		public enum ServerStatus
		{
			// Token: 0x04001C6E RID: 7278
			[Token(Token = "0x4001C6E")]
			ServerStatus_NONE,
			// Token: 0x04001C6F RID: 7279
			[Token(Token = "0x4001C6F")]
			ServerStatus_RUNNING,
			// Token: 0x04001C70 RID: 7280
			[Token(Token = "0x4001C70")]
			ServerStatus_SOFTCLOSED,
			// Token: 0x04001C71 RID: 7281
			[Token(Token = "0x4001C71")]
			ServerStatus_DOWN
		}
	}
}
