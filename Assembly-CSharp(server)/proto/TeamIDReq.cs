using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000676 RID: 1654
	[Token(Token = "0x2000676")]
	[ProtoContract]
	public class TeamIDReq
	{
		// Token: 0x060023BF RID: 9151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023BF")]
		[Address(RVA = "0x24A0D94", Offset = "0x24A0D94", VA = "0x7BBCCA0D94")]
		public TeamIDReq()
		{
		}

		// Token: 0x04002092 RID: 8338
		[Token(Token = "0x4002092")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108750", Offset = "0x1108750")]
		public ulong team_id;
	}
}
