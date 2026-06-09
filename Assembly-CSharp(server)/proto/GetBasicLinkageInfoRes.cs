using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000696 RID: 1686
	[Token(Token = "0x2000696")]
	[ProtoContract]
	public class GetBasicLinkageInfoRes
	{
		// Token: 0x060023D3 RID: 9171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D3")]
		[Address(RVA = "0x21BAA50", Offset = "0x21BAA50", VA = "0x7BBC9BAA50")]
		public GetBasicLinkageInfoRes()
		{
		}

		// Token: 0x0400211F RID: 8479
		[Token(Token = "0x400211F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108F98", Offset = "0x1108F98")]
		public uint activity_id;

		// Token: 0x04002120 RID: 8480
		[Token(Token = "0x4002120")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108FAC", Offset = "0x1108FAC")]
		public uint activity_type;

		// Token: 0x04002121 RID: 8481
		[Token(Token = "0x4002121")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108FC0", Offset = "0x1108FC0")]
		public uint today_data;

		// Token: 0x04002122 RID: 8482
		[Token(Token = "0x4002122")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108FD4", Offset = "0x1108FD4")]
		public uint day;
	}
}
