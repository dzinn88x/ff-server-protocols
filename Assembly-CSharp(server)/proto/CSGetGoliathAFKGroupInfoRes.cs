using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000984 RID: 2436
	[Token(Token = "0x2000984")]
	[ProtoContract]
	public class CSGetGoliathAFKGroupInfoRes
	{
		// Token: 0x06002692 RID: 9874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002692")]
		[Address(RVA = "0x21B40D8", Offset = "0x21B40D8", VA = "0x7BBC9B40D8")]
		public CSGetGoliathAFKGroupInfoRes()
		{
		}

		// Token: 0x04002C33 RID: 11315
		[Token(Token = "0x4002C33")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119C1C", Offset = "0x1119C1C")]
		public GoliathAFKGroupInfo group_info;
	}
}
