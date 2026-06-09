using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005ED RID: 1517
	[Token(Token = "0x20005ED")]
	[ProtoContract]
	public class MailSenderInfo
	{
		// Token: 0x0600236D RID: 9069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600236D")]
		[Address(RVA = "0x21BC2E0", Offset = "0x21BC2E0", VA = "0x7BBC9BC2E0")]
		public MailSenderInfo()
		{
		}

		// Token: 0x04001E48 RID: 7752
		[Token(Token = "0x4001E48")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11065E0", Offset = "0x11065E0")]
		public ulong sender_id;

		// Token: 0x04001E49 RID: 7753
		[Token(Token = "0x4001E49")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11065F4", Offset = "0x11065F4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11065F4", Offset = "0x11065F4")]
		public string sender_nick;

		// Token: 0x04001E4A RID: 7754
		[Token(Token = "0x4001E4A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106644", Offset = "0x1106644")]
		public ulong clan_id;

		// Token: 0x04001E4B RID: 7755
		[Token(Token = "0x4001E4B")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106658", Offset = "0x1106658")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1106658", Offset = "0x1106658")]
		public string clan_name;

		// Token: 0x04001E4C RID: 7756
		[Token(Token = "0x4001E4C")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11066A8", Offset = "0x11066A8")]
		public ulong clan_captain_id;

		// Token: 0x04001E4D RID: 7757
		[Token(Token = "0x4001E4D")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11066BC", Offset = "0x11066BC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11066BC", Offset = "0x11066BC")]
		public string clan_captain_nick;

		// Token: 0x04001E4E RID: 7758
		[Token(Token = "0x4001E4E")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110670C", Offset = "0x110670C")]
		public uint season_id;

		// Token: 0x04001E4F RID: 7759
		[Token(Token = "0x4001E4F")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106720", Offset = "0x1106720")]
		public uint season_rank;

		// Token: 0x04001E50 RID: 7760
		[Token(Token = "0x4001E50")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106734", Offset = "0x1106734")]
		public uint ep_unlock_id;

		// Token: 0x04001E51 RID: 7761
		[Token(Token = "0x4001E51")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106748", Offset = "0x1106748")]
		public uint ep_challenge_id;

		// Token: 0x04001E52 RID: 7762
		[Token(Token = "0x4001E52")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110675C", Offset = "0x110675C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110675C", Offset = "0x110675C")]
		public string gift_message;

		// Token: 0x04001E53 RID: 7763
		[Token(Token = "0x4001E53")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11067AC", Offset = "0x11067AC")]
		public MailGlobalDropInfo global_drop;

		// Token: 0x04001E54 RID: 7764
		[Token(Token = "0x4001E54")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11067C0", Offset = "0x11067C0")]
		public uint honor_delta;

		// Token: 0x04001E55 RID: 7765
		[Token(Token = "0x4001E55")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11067D4", Offset = "0x11067D4")]
		public uint subscription_ep_id;

		// Token: 0x04001E56 RID: 7766
		[Token(Token = "0x4001E56")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11067E8", Offset = "0x11067E8")]
		public ulong championship_team_id;

		// Token: 0x04001E57 RID: 7767
		[Token(Token = "0x4001E57")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11067FC", Offset = "0x11067FC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11067FC", Offset = "0x11067FC")]
		public string championship_team_name;

		// Token: 0x04001E58 RID: 7768
		[Token(Token = "0x4001E58")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110684C", Offset = "0x110684C")]
		public uint championship_type;

		// Token: 0x04001E59 RID: 7769
		[Token(Token = "0x4001E59")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106860", Offset = "0x1106860")]
		public uint championship_id;

		// Token: 0x04001E5A RID: 7770
		[Token(Token = "0x4001E5A")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106874", Offset = "0x1106874")]
		public uint championship_trial_pos;

		// Token: 0x04001E5B RID: 7771
		[Token(Token = "0x4001E5B")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106888", Offset = "0x1106888")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1106888", Offset = "0x1106888")]
		public string region;

		// Token: 0x04001E5C RID: 7772
		[Token(Token = "0x4001E5C")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11068D8", Offset = "0x11068D8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11068D8", Offset = "0x11068D8")]
		public string championship_name;

		// Token: 0x04001E5D RID: 7773
		[Token(Token = "0x4001E5D")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106928", Offset = "0x1106928")]
		public uint limitedevent_leaderboard_type;

		// Token: 0x04001E5E RID: 7774
		[Token(Token = "0x4001E5E")]
		[FieldOffset(Offset = "0x9C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110693C", Offset = "0x110693C")]
		public uint limitedevent_rank;
	}
}
