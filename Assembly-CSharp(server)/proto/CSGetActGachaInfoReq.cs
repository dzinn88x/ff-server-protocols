using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000864 RID: 2148
	[Token(Token = "0x2000864")]
	[ProtoContract]
	public class CSGetActGachaInfoReq
	{
		// Token: 0x06002572 RID: 9586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002572")]
		[Address(RVA = "0x21B1860", Offset = "0x21B1860", VA = "0x7BBC9B1860")]
		public CSGetActGachaInfoReq()
		{
		}

		// Token: 0x04002820 RID: 10272
		[Token(Token = "0x4002820")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112778", Offset = "0x1112778")]
		public uint chest_id;

		// Token: 0x04002821 RID: 10273
		[Token(Token = "0x4002821")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111278C", Offset = "0x111278C")]
		public uint chest_sub_id;
	}
}
