using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000697 RID: 1687
	[Token(Token = "0x2000697")]
	[ProtoContract]
	public class LinkageInfo
	{
		// Token: 0x060023D4 RID: 9172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D4")]
		[Address(RVA = "0x21BBC28", Offset = "0x21BBC28", VA = "0x7BBC9BBC28")]
		public LinkageInfo()
		{
		}

		// Token: 0x04002123 RID: 8483
		[Token(Token = "0x4002123")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108FE8", Offset = "0x1108FE8")]
		public uint type;

		// Token: 0x04002124 RID: 8484
		[Token(Token = "0x4002124")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108FFC", Offset = "0x1108FFC")]
		public uint link_activity_map_token_id;
	}
}
