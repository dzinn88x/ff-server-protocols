using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B16 RID: 2838
	[Token(Token = "0x2000B16")]
	[ProtoContract]
	public class BooyahDaySettingDesc
	{
		// Token: 0x0600281E RID: 10270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600281E")]
		[Address(RVA = "0x21AFDB0", Offset = "0x21AFDB0", VA = "0x7BBC9AFDB0")]
		public BooyahDaySettingDesc()
		{
		}

		// Token: 0x040035D2 RID: 13778
		[Token(Token = "0x40035D2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B9D0", Offset = "0x112B9D0")]
		public uint process_start_timestamp;

		// Token: 0x040035D3 RID: 13779
		[Token(Token = "0x40035D3")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B9E4", Offset = "0x112B9E4")]
		public uint process_end_timestamp;

		// Token: 0x040035D4 RID: 13780
		[Token(Token = "0x40035D4")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B9F8", Offset = "0x112B9F8")]
		public uint web_open_timestamp;

		// Token: 0x040035D5 RID: 13781
		[Token(Token = "0x40035D5")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BA0C", Offset = "0x112BA0C")]
		public uint web_close_timestamp;

		// Token: 0x040035D6 RID: 13782
		[Token(Token = "0x40035D6")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BA20", Offset = "0x112BA20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112BA20", Offset = "0x112BA20")]
		public string web_jump;

		// Token: 0x040035D7 RID: 13783
		[Token(Token = "0x40035D7")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BA70", Offset = "0x112BA70")]
		public uint mode_jump_gopos;

		// Token: 0x040035D8 RID: 13784
		[Token(Token = "0x40035D8")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BA84", Offset = "0x112BA84")]
		public uint mode_jump_sub_gopos;

		// Token: 0x040035D9 RID: 13785
		[Token(Token = "0x40035D9")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BA98", Offset = "0x112BA98")]
		public uint chess_open_timestamp;

		// Token: 0x040035DA RID: 13786
		[Token(Token = "0x40035DA")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BAAC", Offset = "0x112BAAC")]
		public uint chess_close_timestamp;

		// Token: 0x040035DB RID: 13787
		[Token(Token = "0x40035DB")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BAC0", Offset = "0x112BAC0")]
		public uint sign_in_switch;

		// Token: 0x040035DC RID: 13788
		[Token(Token = "0x40035DC")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BAD4", Offset = "0x112BAD4")]
		public uint store_switch;

		// Token: 0x040035DD RID: 13789
		[Token(Token = "0x40035DD")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BAE8", Offset = "0x112BAE8")]
		public uint ranking_switch;

		// Token: 0x040035DE RID: 13790
		[Token(Token = "0x40035DE")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BAFC", Offset = "0x112BAFC")]
		public uint store_jump;

		// Token: 0x040035DF RID: 13791
		[Token(Token = "0x40035DF")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112BB10", Offset = "0x112BB10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BB10", Offset = "0x112BB10")]
		public string store_jump_cdn;

		// Token: 0x040035E0 RID: 13792
		[Token(Token = "0x40035E0")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BB60", Offset = "0x112BB60")]
		public uint store_start;

		// Token: 0x040035E1 RID: 13793
		[Token(Token = "0x40035E1")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BB74", Offset = "0x112BB74")]
		public uint store_end;

		// Token: 0x040035E2 RID: 13794
		[Token(Token = "0x40035E2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BB88", Offset = "0x112BB88")]
		public uint exchange_token;

		// Token: 0x040035E3 RID: 13795
		[Token(Token = "0x40035E3")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BB9C", Offset = "0x112BB9C")]
		public uint sugar_token;

		// Token: 0x040035E4 RID: 13796
		[Token(Token = "0x40035E4")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112BBB0", Offset = "0x112BBB0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BBB0", Offset = "0x112BBB0")]
		public string background_cdn;
	}
}
