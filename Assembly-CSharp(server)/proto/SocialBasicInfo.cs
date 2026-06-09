using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006D0 RID: 1744
	[Token(Token = "0x20006D0")]
	[ProtoContract]
	public class SocialBasicInfo
	{
		// Token: 0x060023E1 RID: 9185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E1")]
		[Address(RVA = "0x24A05F8", Offset = "0x24A05F8", VA = "0x7BBCCA05F8")]
		public SocialBasicInfo()
		{
		}

		// Token: 0x04002261 RID: 8801
		[Token(Token = "0x4002261")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11092A4", Offset = "0x11092A4")]
		public ulong account_id;

		// Token: 0x04002262 RID: 8802
		[Token(Token = "0x4002262")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11092B8", Offset = "0x11092B8")]
		public ESocial.Gender gender;

		// Token: 0x04002263 RID: 8803
		[Token(Token = "0x4002263")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11092CC", Offset = "0x11092CC")]
		public ESocial.Language language;

		// Token: 0x04002264 RID: 8804
		[Token(Token = "0x4002264")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11092E0", Offset = "0x11092E0")]
		public ESocial.TimeOnline time_online;

		// Token: 0x04002265 RID: 8805
		[Token(Token = "0x4002265")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11092F4", Offset = "0x11092F4")]
		public ESocial.TimeActive time_active;

		// Token: 0x04002266 RID: 8806
		[Token(Token = "0x4002266")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109308", Offset = "0x1109308")]
		public List<ESocial.PlayerBattleTagID> battle_tag;

		// Token: 0x04002267 RID: 8807
		[Token(Token = "0x4002267")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109344", Offset = "0x1109344")]
		public List<ESocial.SocialTag> social_tag;

		// Token: 0x04002268 RID: 8808
		[Token(Token = "0x4002268")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109380", Offset = "0x1109380")]
		public ESocial.ModePrefer mode_prefer;

		// Token: 0x04002269 RID: 8809
		[Token(Token = "0x4002269")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109394", Offset = "0x1109394")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1109394", Offset = "0x1109394")]
		public string signature;

		// Token: 0x0400226A RID: 8810
		[Token(Token = "0x400226A")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11093E4", Offset = "0x11093E4")]
		public ESocial.RankShow rank_show;
	}
}
