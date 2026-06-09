using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200057E RID: 1406
	[Token(Token = "0x200057E")]
	[ProtoContract]
	public class EAbTest
	{
		// Token: 0x0600233E RID: 9022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600233E")]
		[Address(RVA = "0x21B97A8", Offset = "0x21B97A8", VA = "0x7BBC9B97A8")]
		public EAbTest()
		{
		}

		// Token: 0x0200057F RID: 1407
		[Token(Token = "0x200057F")]
		[ProtoContract]
		public enum Type
		{
			// Token: 0x04001B83 RID: 7043
			[Token(Token = "0x4001B83")]
			Type_NONE,
			// Token: 0x04001B84 RID: 7044
			[Token(Token = "0x4001B84")]
			Type_NEWBIECHOICE
		}
	}
}
