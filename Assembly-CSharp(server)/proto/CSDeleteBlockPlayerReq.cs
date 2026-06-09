using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200082F RID: 2095
	[Token(Token = "0x200082F")]
	[ProtoContract]
	public class CSDeleteBlockPlayerReq
	{
		// Token: 0x06002544 RID: 9540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002544")]
		[Address(RVA = "0x21B0F40", Offset = "0x21B0F40", VA = "0x7BBC9B0F40")]
		public CSDeleteBlockPlayerReq()
		{
		}

		// Token: 0x04002751 RID: 10065
		[Token(Token = "0x4002751")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111133C", Offset = "0x111133C")]
		public ulong blocked_id;
	}
}
