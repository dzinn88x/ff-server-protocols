using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B2B RID: 2859
	[Token(Token = "0x2000B2B")]
	[ProtoContract]
	public class SupercarSettingDesc
	{
		// Token: 0x06002833 RID: 10291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002833")]
		[Address(RVA = "0x24A0BE8", Offset = "0x24A0BE8", VA = "0x7BBCCA0BE8")]
		public SupercarSettingDesc()
		{
		}

		// Token: 0x0400363E RID: 13886
		[Token(Token = "0x400363E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C54C", Offset = "0x112C54C")]
		public uint length;

		// Token: 0x0400363F RID: 13887
		[Token(Token = "0x400363F")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C560", Offset = "0x112C560")]
		public uint second_level_speed;

		// Token: 0x04003640 RID: 13888
		[Token(Token = "0x4003640")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C574", Offset = "0x112C574")]
		public uint third_level_speed;

		// Token: 0x04003641 RID: 13889
		[Token(Token = "0x4003641")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C588", Offset = "0x112C588")]
		public uint max_speed;

		// Token: 0x04003642 RID: 13890
		[Token(Token = "0x4003642")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C59C", Offset = "0x112C59C")]
		public uint token_id;

		// Token: 0x04003643 RID: 13891
		[Token(Token = "0x4003643")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C5B0", Offset = "0x112C5B0")]
		public uint speed_per_token;

		// Token: 0x04003644 RID: 13892
		[Token(Token = "0x4003644")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C5C4", Offset = "0x112C5C4")]
		public uint speed_per_help;

		// Token: 0x04003645 RID: 13893
		[Token(Token = "0x4003645")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C5D8", Offset = "0x112C5D8")]
		public uint tokens_feed_back_help;

		// Token: 0x04003646 RID: 13894
		[Token(Token = "0x4003646")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C5EC", Offset = "0x112C5EC")]
		public AwardDesc helper_award;

		// Token: 0x04003647 RID: 13895
		[Token(Token = "0x4003647")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C600", Offset = "0x112C600")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112C600", Offset = "0x112C600")]
		public string web_event_url;

		// Token: 0x04003648 RID: 13896
		[Token(Token = "0x4003648")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C650", Offset = "0x112C650")]
		public uint web_event_start_timestamp;

		// Token: 0x04003649 RID: 13897
		[Token(Token = "0x4003649")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C664", Offset = "0x112C664")]
		public uint web_event_end_timestamp;

		// Token: 0x0400364A RID: 13898
		[Token(Token = "0x400364A")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112C678", Offset = "0x112C678")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C678", Offset = "0x112C678")]
		public string share_web_page_url;
	}
}
