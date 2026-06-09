using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000936 RID: 2358
	[Token(Token = "0x2000936")]
	[ProtoContract]
	public class CSSetAntiAddictionAgeStateReq
	{
		// Token: 0x06002644 RID: 9796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002644")]
		[Address(RVA = "0x21B766C", Offset = "0x21B766C", VA = "0x7BBC9B766C")]
		public CSSetAntiAddictionAgeStateReq()
		{
		}

		// Token: 0x04002B8C RID: 11148
		[Token(Token = "0x4002B8C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118C7C", Offset = "0x1118C7C")]
		public uint age_state;
	}
}
