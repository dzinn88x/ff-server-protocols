using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A41 RID: 2625
	[Token(Token = "0x2000A41")]
	[ProtoContract]
	public class ClanRaceRewardsDesc
	{
		// Token: 0x0600274B RID: 10059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600274B")]
		[Address(RVA = "0x21B8AA0", Offset = "0x21B8AA0", VA = "0x7BBC9B8AA0")]
		public ClanRaceRewardsDesc()
		{
		}

		// Token: 0x04002FDE RID: 12254
		[Token(Token = "0x4002FDE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120274", Offset = "0x1120274")]
		public uint stage_id;

		// Token: 0x04002FDF RID: 12255
		[Token(Token = "0x4002FDF")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120288", Offset = "0x1120288")]
		public uint min_race_point;

		// Token: 0x04002FE0 RID: 12256
		[Token(Token = "0x4002FE0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112029C", Offset = "0x112029C")]
		public uint race_point_cost;

		// Token: 0x04002FE1 RID: 12257
		[Token(Token = "0x4002FE1")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11202B0", Offset = "0x11202B0")]
		public uint reward_honor;

		// Token: 0x04002FE2 RID: 12258
		[Token(Token = "0x4002FE2")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11202C4", Offset = "0x11202C4")]
		public AwardDesc all_member_award;

		// Token: 0x04002FE3 RID: 12259
		[Token(Token = "0x4002FE3")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11202D8", Offset = "0x11202D8")]
		public AwardDesc unlock_award;
	}
}
