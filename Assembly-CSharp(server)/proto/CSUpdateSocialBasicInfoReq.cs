using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009B1 RID: 2481
	[Token(Token = "0x20009B1")]
	[ProtoContract]
	public class CSUpdateSocialBasicInfoReq
	{
		// Token: 0x060026BF RID: 9919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026BF")]
		[Address(RVA = "0x21B7BE4", Offset = "0x21B7BE4", VA = "0x7BBC9B7BE4")]
		public CSUpdateSocialBasicInfoReq()
		{
		}

		// Token: 0x04002CA1 RID: 11425
		[Token(Token = "0x4002CA1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A5E0", Offset = "0x111A5E0")]
		public ESocial.Gender gender;

		// Token: 0x04002CA2 RID: 11426
		[Token(Token = "0x4002CA2")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A5F4", Offset = "0x111A5F4")]
		public ESocial.Language language;

		// Token: 0x04002CA3 RID: 11427
		[Token(Token = "0x4002CA3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A608", Offset = "0x111A608")]
		public ESocial.TimeOnline time_online;

		// Token: 0x04002CA4 RID: 11428
		[Token(Token = "0x4002CA4")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A61C", Offset = "0x111A61C")]
		public ESocial.TimeActive time_active;

		// Token: 0x04002CA5 RID: 11429
		[Token(Token = "0x4002CA5")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A630", Offset = "0x111A630")]
		public List<ESocial.PlayerBattleTagID> battle_tag;

		// Token: 0x04002CA6 RID: 11430
		[Token(Token = "0x4002CA6")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A66C", Offset = "0x111A66C")]
		public List<ESocial.SocialTag> social_tag;

		// Token: 0x04002CA7 RID: 11431
		[Token(Token = "0x4002CA7")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A6A8", Offset = "0x111A6A8")]
		public ESocial.ModePrefer mode_prefer;

		// Token: 0x04002CA8 RID: 11432
		[Token(Token = "0x4002CA8")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A6BC", Offset = "0x111A6BC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111A6BC", Offset = "0x111A6BC")]
		public string signature;

		// Token: 0x04002CA9 RID: 11433
		[Token(Token = "0x4002CA9")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A70C", Offset = "0x111A70C")]
		public ESocial.RankShow rank_show;
	}
}
