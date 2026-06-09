using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A97 RID: 2711
	[Token(Token = "0x2000A97")]
	[ProtoContract]
	public class ExtraRewardDesc
	{
		// Token: 0x060027A1 RID: 10145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A1")]
		[Address(RVA = "0x21BA028", Offset = "0x21BA028", VA = "0x7BBC9BA028")]
		public ExtraRewardDesc()
		{
		}

		// Token: 0x0400326F RID: 12911
		[Token(Token = "0x400326F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112493C", Offset = "0x112493C")]
		public uint chest_id;

		// Token: 0x04003270 RID: 12912
		[Token(Token = "0x4003270")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124950", Offset = "0x1124950")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1124950", Offset = "0x1124950")]
		public string icon;

		// Token: 0x04003271 RID: 12913
		[Token(Token = "0x4003271")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11249A0", Offset = "0x11249A0")]
		public uint cdt_type;

		// Token: 0x04003272 RID: 12914
		[Token(Token = "0x4003272")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11249B4", Offset = "0x11249B4")]
		public uint cdt_value;

		// Token: 0x04003273 RID: 12915
		[Token(Token = "0x4003273")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11249C8", Offset = "0x11249C8")]
		public List<ExchangedAward> reward_list;

		// Token: 0x04003274 RID: 12916
		[Token(Token = "0x4003274")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11249DC", Offset = "0x11249DC")]
		public uint chest_sub_id;

		// Token: 0x04003275 RID: 12917
		[Token(Token = "0x4003275")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11249F0", Offset = "0x11249F0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11249F0", Offset = "0x11249F0")]
		public string special_reward;

		// Token: 0x04003276 RID: 12918
		[Token(Token = "0x4003276")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124A40", Offset = "0x1124A40")]
		public uint token_id;

		// Token: 0x04003277 RID: 12919
		[Token(Token = "0x4003277")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124A54", Offset = "0x1124A54")]
		public uint token_num;

		// Token: 0x04003278 RID: 12920
		[Token(Token = "0x4003278")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1124A68", Offset = "0x1124A68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124A68", Offset = "0x1124A68")]
		public string reward_icon;

		// Token: 0x04003279 RID: 12921
		[Token(Token = "0x4003279")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124AB8", Offset = "0x1124AB8")]
		public uint rare_reward;
	}
}
