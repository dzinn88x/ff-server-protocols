using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A7D RID: 2685
	[Token(Token = "0x2000A7D")]
	[ProtoContract]
	public class EPQuestDesc
	{
		// Token: 0x06002787 RID: 10119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002787")]
		[Address(RVA = "0x21B992C", Offset = "0x21B992C", VA = "0x7BBC9B992C")]
		public EPQuestDesc()
		{
		}

		// Token: 0x04003158 RID: 12632
		[Token(Token = "0x4003158")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122AC4", Offset = "0x1122AC4")]
		public uint ep_event_id;

		// Token: 0x04003159 RID: 12633
		[Token(Token = "0x4003159")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122AD8", Offset = "0x1122AD8")]
		public uint quest_id;

		// Token: 0x0400315A RID: 12634
		[Token(Token = "0x400315A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122AEC", Offset = "0x1122AEC")]
		public uint daily_count;

		// Token: 0x0400315B RID: 12635
		[Token(Token = "0x400315B")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122B00", Offset = "0x1122B00")]
		public uint count_type;

		// Token: 0x0400315C RID: 12636
		[Token(Token = "0x400315C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122B14", Offset = "0x1122B14")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1122B14", Offset = "0x1122B14")]
		public string start_time;

		// Token: 0x0400315D RID: 12637
		[Token(Token = "0x400315D")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122B64", Offset = "0x1122B64")]
		public uint match_mode;

		// Token: 0x0400315E RID: 12638
		[Token(Token = "0x400315E")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122B78", Offset = "0x1122B78")]
		public uint game_mode;

		// Token: 0x0400315F RID: 12639
		[Token(Token = "0x400315F")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122B8C", Offset = "0x1122B8C")]
		public uint[] role_condition;

		// Token: 0x04003160 RID: 12640
		[Token(Token = "0x4003160")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122BC8", Offset = "0x1122BC8")]
		public uint player_count;

		// Token: 0x04003161 RID: 12641
		[Token(Token = "0x4003161")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122BDC", Offset = "0x1122BDC")]
		public List<ChallengeCondition> conditions;

		// Token: 0x04003162 RID: 12642
		[Token(Token = "0x4003162")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122BF0", Offset = "0x1122BF0")]
		public EInventory.AwardType award_type;

		// Token: 0x04003163 RID: 12643
		[Token(Token = "0x4003163")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122C04", Offset = "0x1122C04")]
		public uint award_id;

		// Token: 0x04003164 RID: 12644
		[Token(Token = "0x4003164")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122C18", Offset = "0x1122C18")]
		public uint award_num;

		// Token: 0x04003165 RID: 12645
		[Token(Token = "0x4003165")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122C2C", Offset = "0x1122C2C")]
		public EInventory.AwardType award_type2;

		// Token: 0x04003166 RID: 12646
		[Token(Token = "0x4003166")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122C40", Offset = "0x1122C40")]
		public uint award_id2;

		// Token: 0x04003167 RID: 12647
		[Token(Token = "0x4003167")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122C54", Offset = "0x1122C54")]
		public uint award_num2;

		// Token: 0x04003168 RID: 12648
		[Token(Token = "0x4003168")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122C68", Offset = "0x1122C68")]
		public EInventory.AwardType award_type3;

		// Token: 0x04003169 RID: 12649
		[Token(Token = "0x4003169")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122C7C", Offset = "0x1122C7C")]
		public uint award_id3;

		// Token: 0x0400316A RID: 12650
		[Token(Token = "0x400316A")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122C90", Offset = "0x1122C90")]
		public uint award_num3;

		// Token: 0x0400316B RID: 12651
		[Token(Token = "0x400316B")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122CA4", Offset = "0x1122CA4")]
		public uint award_time;

		// Token: 0x0400316C RID: 12652
		[Token(Token = "0x400316C")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122CB8", Offset = "0x1122CB8")]
		public uint award_time2;

		// Token: 0x0400316D RID: 12653
		[Token(Token = "0x400316D")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122CCC", Offset = "0x1122CCC")]
		public uint award_time3;
	}
}
