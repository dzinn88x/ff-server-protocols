using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B13 RID: 2835
	[Token(Token = "0x2000B13")]
	[ProtoContract]
	public class RampageSettingDesc
	{
		// Token: 0x0600281B RID: 10267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600281B")]
		[Address(RVA = "0x249F834", Offset = "0x249F834", VA = "0x7BBCC9F834")]
		public RampageSettingDesc()
		{
		}

		// Token: 0x040035BB RID: 13755
		[Token(Token = "0x40035BB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B4F8", Offset = "0x112B4F8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112B4F8", Offset = "0x112B4F8")]
		public string main_cdn;

		// Token: 0x040035BC RID: 13756
		[Token(Token = "0x40035BC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B548", Offset = "0x112B548")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112B548", Offset = "0x112B548")]
		public string b_character_cdn;

		// Token: 0x040035BD RID: 13757
		[Token(Token = "0x40035BD")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B598", Offset = "0x112B598")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112B598", Offset = "0x112B598")]
		public string l_character_cdn;

		// Token: 0x040035BE RID: 13758
		[Token(Token = "0x40035BE")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112B5E8", Offset = "0x112B5E8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B5E8", Offset = "0x112B5E8")]
		public string b_store_cdn;

		// Token: 0x040035BF RID: 13759
		[Token(Token = "0x40035BF")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112B638", Offset = "0x112B638")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B638", Offset = "0x112B638")]
		public string l_store_cdn;

		// Token: 0x040035C0 RID: 13760
		[Token(Token = "0x40035C0")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B688", Offset = "0x112B688")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112B688", Offset = "0x112B688")]
		public string b_signup_cdn;

		// Token: 0x040035C1 RID: 13761
		[Token(Token = "0x40035C1")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B6D8", Offset = "0x112B6D8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112B6D8", Offset = "0x112B6D8")]
		public string l_signup_cdn;

		// Token: 0x040035C2 RID: 13762
		[Token(Token = "0x40035C2")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B728", Offset = "0x112B728")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112B728", Offset = "0x112B728")]
		public string web_link;

		// Token: 0x040035C3 RID: 13763
		[Token(Token = "0x40035C3")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B778", Offset = "0x112B778")]
		public uint mode_id;

		// Token: 0x040035C4 RID: 13764
		[Token(Token = "0x40035C4")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B78C", Offset = "0x112B78C")]
		public uint points_id;

		// Token: 0x040035C5 RID: 13765
		[Token(Token = "0x40035C5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B7A0", Offset = "0x112B7A0")]
		public uint token_id;

		// Token: 0x040035C6 RID: 13766
		[Token(Token = "0x40035C6")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112B7B4", Offset = "0x112B7B4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B7B4", Offset = "0x112B7B4")]
		public string b_reward;

		// Token: 0x040035C7 RID: 13767
		[Token(Token = "0x40035C7")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B804", Offset = "0x112B804")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112B804", Offset = "0x112B804")]
		public string l_reward;

		// Token: 0x040035C8 RID: 13768
		[Token(Token = "0x40035C8")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B854", Offset = "0x112B854")]
		public uint pp_start_timestamp;

		// Token: 0x040035C9 RID: 13769
		[Token(Token = "0x40035C9")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B868", Offset = "0x112B868")]
		public uint peak_day_reward_id;

		// Token: 0x040035CA RID: 13770
		[Token(Token = "0x40035CA")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B87C", Offset = "0x112B87C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112B87C", Offset = "0x112B87C")]
		public string winner_reward_cdn;
	}
}
