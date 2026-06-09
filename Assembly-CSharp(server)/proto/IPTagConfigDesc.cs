using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AAD RID: 2733
	[Token(Token = "0x2000AAD")]
	[ProtoContract]
	public class IPTagConfigDesc
	{
		// Token: 0x060027B7 RID: 10167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027B7")]
		[Address(RVA = "0x21BB478", Offset = "0x21BB478", VA = "0x7BBC9BB478")]
		public IPTagConfigDesc()
		{
		}

		// Token: 0x04003351 RID: 13137
		[Token(Token = "0x4003351")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126688", Offset = "0x1126688")]
		public uint item_id;

		// Token: 0x04003352 RID: 13138
		[Token(Token = "0x4003352")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112669C", Offset = "0x112669C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112669C", Offset = "0x112669C")]
		public string ip_tag_icon;

		// Token: 0x04003353 RID: 13139
		[Token(Token = "0x4003353")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11266EC", Offset = "0x11266EC")]
		public bool is_hide;

		// Token: 0x04003354 RID: 13140
		[Token(Token = "0x4003354")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126700", Offset = "0x1126700")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1126700", Offset = "0x1126700")]
		public string region;
	}
}
