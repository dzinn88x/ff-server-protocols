using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000677 RID: 1655
	[Token(Token = "0x2000677")]
	[ProtoContract]
	public class TeamIDSlice
	{
		// Token: 0x060023C0 RID: 9152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C0")]
		[Address(RVA = "0x24A0D9C", Offset = "0x24A0D9C", VA = "0x7BBCCA0D9C")]
		public TeamIDSlice()
		{
		}

		// Token: 0x04002093 RID: 8339
		[Token(Token = "0x4002093")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108764", Offset = "0x1108764")]
		public ulong[] team_ids;
	}
}
