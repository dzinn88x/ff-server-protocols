using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A7C RID: 2684
	[Token(Token = "0x2000A7C")]
	[ProtoContract]
	public class ChallengeDesc
	{
		// Token: 0x06002786 RID: 10118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002786")]
		[Address(RVA = "0x21B7EC0", Offset = "0x21B7EC0", VA = "0x7BBC9B7EC0")]
		public ChallengeDesc()
		{
		}

		// Token: 0x0400313B RID: 12603
		[Token(Token = "0x400313B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11227E0", Offset = "0x11227E0")]
		public uint ep_event_id;

		// Token: 0x0400313C RID: 12604
		[Token(Token = "0x400313C")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11227F4", Offset = "0x11227F4")]
		public uint challenge_id;

		// Token: 0x0400313D RID: 12605
		[Token(Token = "0x400313D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122808", Offset = "0x1122808")]
		public uint challenge_type;

		// Token: 0x0400313E RID: 12606
		[Token(Token = "0x400313E")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112281C", Offset = "0x112281C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112281C", Offset = "0x112281C")]
		public string challenge_desc;

		// Token: 0x0400313F RID: 12607
		[Token(Token = "0x400313F")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112286C", Offset = "0x112286C")]
		public uint if_reset;

		// Token: 0x04003140 RID: 12608
		[Token(Token = "0x4003140")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122880", Offset = "0x1122880")]
		public EInventory.AwardType award_type;

		// Token: 0x04003141 RID: 12609
		[Token(Token = "0x4003141")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122894", Offset = "0x1122894")]
		public uint award_id;

		// Token: 0x04003142 RID: 12610
		[Token(Token = "0x4003142")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11228A8", Offset = "0x11228A8")]
		public uint award_num;

		// Token: 0x04003143 RID: 12611
		[Token(Token = "0x4003143")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11228BC", Offset = "0x11228BC")]
		public uint count_type;

		// Token: 0x04003144 RID: 12612
		[Token(Token = "0x4003144")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11228D0", Offset = "0x11228D0")]
		public uint game_mode;

		// Token: 0x04003145 RID: 12613
		[Token(Token = "0x4003145")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11228E4", Offset = "0x11228E4")]
		public uint[] role_condition;

		// Token: 0x04003146 RID: 12614
		[Token(Token = "0x4003146")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122920", Offset = "0x1122920")]
		public uint player_count;

		// Token: 0x04003147 RID: 12615
		[Token(Token = "0x4003147")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122934", Offset = "0x1122934")]
		public List<ChallengeCondition> conditions;

		// Token: 0x04003148 RID: 12616
		[Token(Token = "0x4003148")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122948", Offset = "0x1122948")]
		public uint match_mode;

		// Token: 0x04003149 RID: 12617
		[Token(Token = "0x4003149")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112295C", Offset = "0x112295C")]
		public uint date;

		// Token: 0x0400314A RID: 12618
		[Token(Token = "0x400314A")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122970", Offset = "0x1122970")]
		public uint special_challenge;

		// Token: 0x0400314B RID: 12619
		[Token(Token = "0x400314B")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122984", Offset = "0x1122984")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1122984", Offset = "0x1122984")]
		public string start_time;

		// Token: 0x0400314C RID: 12620
		[Token(Token = "0x400314C")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11229D4", Offset = "0x11229D4")]
		public EInventory.AwardType award_type2;

		// Token: 0x0400314D RID: 12621
		[Token(Token = "0x400314D")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11229E8", Offset = "0x11229E8")]
		public uint award_id2;

		// Token: 0x0400314E RID: 12622
		[Token(Token = "0x400314E")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11229FC", Offset = "0x11229FC")]
		public uint award_num2;

		// Token: 0x0400314F RID: 12623
		[Token(Token = "0x400314F")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122A10", Offset = "0x1122A10")]
		public EInventory.AwardType award_type3;

		// Token: 0x04003150 RID: 12624
		[Token(Token = "0x4003150")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122A24", Offset = "0x1122A24")]
		public uint award_id3;

		// Token: 0x04003151 RID: 12625
		[Token(Token = "0x4003151")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122A38", Offset = "0x1122A38")]
		public uint award_num3;

		// Token: 0x04003152 RID: 12626
		[Token(Token = "0x4003152")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122A4C", Offset = "0x1122A4C")]
		public uint award_time;

		// Token: 0x04003153 RID: 12627
		[Token(Token = "0x4003153")]
		[FieldOffset(Offset = "0x8C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122A60", Offset = "0x1122A60")]
		public uint award_time2;

		// Token: 0x04003154 RID: 12628
		[Token(Token = "0x4003154")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122A74", Offset = "0x1122A74")]
		public uint award_time3;

		// Token: 0x04003155 RID: 12629
		[Token(Token = "0x4003155")]
		[FieldOffset(Offset = "0x94")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122A88", Offset = "0x1122A88")]
		public bool is_ep_only;

		// Token: 0x04003156 RID: 12630
		[Token(Token = "0x4003156")]
		[FieldOffset(Offset = "0x95")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122A9C", Offset = "0x1122A9C")]
		public bool is_team_share;

		// Token: 0x04003157 RID: 12631
		[Token(Token = "0x4003157")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122AB0", Offset = "0x1122AB0")]
		public uint challenge_group;
	}
}
