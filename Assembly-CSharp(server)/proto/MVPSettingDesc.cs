using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B42 RID: 2882
	[Token(Token = "0x2000B42")]
	[ProtoContract]
	public class MVPSettingDesc
	{
		// Token: 0x0600284A RID: 10314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284A")]
		[Address(RVA = "0x21BC15C", Offset = "0x21BC15C", VA = "0x7BBC9BC15C")]
		public MVPSettingDesc()
		{
		}

		// Token: 0x040036AE RID: 13998
		[Token(Token = "0x40036AE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D334", Offset = "0x112D334")]
		public uint web_open;

		// Token: 0x040036AF RID: 13999
		[Token(Token = "0x40036AF")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D348", Offset = "0x112D348")]
		public uint web_close;

		// Token: 0x040036B0 RID: 14000
		[Token(Token = "0x40036B0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D35C", Offset = "0x112D35C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112D35C", Offset = "0x112D35C")]
		public string web_jump;

		// Token: 0x040036B1 RID: 14001
		[Token(Token = "0x40036B1")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D3AC", Offset = "0x112D3AC")]
		public uint chess_open;

		// Token: 0x040036B2 RID: 14002
		[Token(Token = "0x40036B2")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D3C0", Offset = "0x112D3C0")]
		public uint chess_close;

		// Token: 0x040036B3 RID: 14003
		[Token(Token = "0x40036B3")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D3D4", Offset = "0x112D3D4")]
		public uint sign_in_open;

		// Token: 0x040036B4 RID: 14004
		[Token(Token = "0x40036B4")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D3E8", Offset = "0x112D3E8")]
		public uint sign_in_close;

		// Token: 0x040036B5 RID: 14005
		[Token(Token = "0x40036B5")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D3FC", Offset = "0x112D3FC")]
		public uint exchange_store_open;

		// Token: 0x040036B6 RID: 14006
		[Token(Token = "0x40036B6")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D410", Offset = "0x112D410")]
		public uint exchange_store_close;

		// Token: 0x040036B7 RID: 14007
		[Token(Token = "0x40036B7")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D424", Offset = "0x112D424")]
		public uint gacha_jump;

		// Token: 0x040036B8 RID: 14008
		[Token(Token = "0x40036B8")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D438", Offset = "0x112D438")]
		public uint gacha_jump_start;

		// Token: 0x040036B9 RID: 14009
		[Token(Token = "0x40036B9")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D44C", Offset = "0x112D44C")]
		public uint gacha_jump_end;

		// Token: 0x040036BA RID: 14010
		[Token(Token = "0x40036BA")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D460", Offset = "0x112D460")]
		public uint exchange_token;

		// Token: 0x040036BB RID: 14011
		[Token(Token = "0x40036BB")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D474", Offset = "0x112D474")]
		public uint sugar_token;

		// Token: 0x040036BC RID: 14012
		[Token(Token = "0x40036BC")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112D488", Offset = "0x112D488")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D488", Offset = "0x112D488")]
		public string background_cdn;
	}
}
