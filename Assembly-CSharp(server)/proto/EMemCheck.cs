using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006D6 RID: 1750
	[Token(Token = "0x20006D6")]
	[ProtoContract]
	public class EMemCheck
	{
		// Token: 0x060023E5 RID: 9189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E5")]
		[Address(RVA = "0x21B9870", Offset = "0x21B9870", VA = "0x7BBC9B9870")]
		public EMemCheck()
		{
		}

		// Token: 0x020006D7 RID: 1751
		[Token(Token = "0x20006D7")]
		[ProtoContract]
		public enum MemCheckType
		{
			// Token: 0x0400227E RID: 8830
			[Token(Token = "0x400227E")]
			MemCheckType_NONE,
			// Token: 0x0400227F RID: 8831
			[Token(Token = "0x400227F")]
			MemCheckType_GROUP,
			// Token: 0x04002280 RID: 8832
			[Token(Token = "0x4002280")]
			MemCheckType_MATCHMAKING
		}
	}
}
