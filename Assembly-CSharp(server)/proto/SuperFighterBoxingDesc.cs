using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B29 RID: 2857
	[Token(Token = "0x2000B29")]
	[ProtoContract]
	public class SuperFighterBoxingDesc
	{
		// Token: 0x06002831 RID: 10289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002831")]
		[Address(RVA = "0x24A0AA4", Offset = "0x24A0AA4", VA = "0x7BBCCA0AA4")]
		public SuperFighterBoxingDesc()
		{
		}

		// Token: 0x04003632 RID: 13874
		[Token(Token = "0x4003632")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C45C", Offset = "0x112C45C")]
		public ELimitedEvent.SuperFighterManner manner_id;

		// Token: 0x04003633 RID: 13875
		[Token(Token = "0x4003633")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C470", Offset = "0x112C470")]
		public uint consume_token_id;

		// Token: 0x04003634 RID: 13876
		[Token(Token = "0x4003634")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C484", Offset = "0x112C484")]
		public uint consume_token_num;

		// Token: 0x04003635 RID: 13877
		[Token(Token = "0x4003635")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C498", Offset = "0x112C498")]
		public uint damage_lower;

		// Token: 0x04003636 RID: 13878
		[Token(Token = "0x4003636")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C4AC", Offset = "0x112C4AC")]
		public uint damage_upper;
	}
}
