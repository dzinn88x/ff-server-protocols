using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000985 RID: 2437
	[Token(Token = "0x2000985")]
	[ProtoContract]
	public class CSCreateGoliathAFKGroupRes
	{
		// Token: 0x06002693 RID: 9875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002693")]
		[Address(RVA = "0x21B0D54", Offset = "0x21B0D54", VA = "0x7BBC9B0D54")]
		public CSCreateGoliathAFKGroupRes()
		{
		}

		// Token: 0x04002C34 RID: 11316
		[Token(Token = "0x4002C34")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119C30", Offset = "0x1119C30")]
		public GoliathAFKGroupInfo group_info;
	}
}
