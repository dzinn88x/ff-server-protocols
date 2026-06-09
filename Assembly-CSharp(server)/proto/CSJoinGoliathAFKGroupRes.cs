using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000987 RID: 2439
	[Token(Token = "0x2000987")]
	[ProtoContract]
	public class CSJoinGoliathAFKGroupRes
	{
		// Token: 0x06002695 RID: 9877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002695")]
		[Address(RVA = "0x21B65E8", Offset = "0x21B65E8", VA = "0x7BBC9B65E8")]
		public CSJoinGoliathAFKGroupRes()
		{
		}

		// Token: 0x04002C37 RID: 11319
		[Token(Token = "0x4002C37")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119C6C", Offset = "0x1119C6C")]
		public GoliathAFKGroupInfo group_info;
	}
}
