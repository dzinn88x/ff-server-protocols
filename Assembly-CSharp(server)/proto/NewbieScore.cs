using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A59 RID: 2649
	[Token(Token = "0x2000A59")]
	[ProtoContract]
	public class NewbieScore
	{
		// Token: 0x06002763 RID: 10083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002763")]
		[Address(RVA = "0x249EC10", Offset = "0x249EC10", VA = "0x7BBCC9EC10")]
		public NewbieScore()
		{
		}

		// Token: 0x04003070 RID: 12400
		[Token(Token = "0x4003070")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11210AC", Offset = "0x11210AC")]
		public uint min_score;

		// Token: 0x04003071 RID: 12401
		[Token(Token = "0x4003071")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11210C0", Offset = "0x11210C0")]
		public uint max_score;

		// Token: 0x04003072 RID: 12402
		[Token(Token = "0x4003072")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11210D4", Offset = "0x11210D4")]
		public int newbie_score;

		// Token: 0x04003073 RID: 12403
		[Token(Token = "0x4003073")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11210E8", Offset = "0x11210E8")]
		public int first_win_score;
	}
}
