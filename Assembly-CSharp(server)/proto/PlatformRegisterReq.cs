using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000612 RID: 1554
	[Token(Token = "0x2000612")]
	[ProtoContract]
	public class PlatformRegisterReq
	{
		// Token: 0x0600238D RID: 9101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600238D")]
		[Address(RVA = "0x249F580", Offset = "0x249F580", VA = "0x7BBCC9F580")]
		public PlatformRegisterReq()
		{
		}

		// Token: 0x04001EEF RID: 7919
		[Token(Token = "0x4001EEF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110747C", Offset = "0x110747C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110747C", Offset = "0x110747C")]
		public string nickname;

		// Token: 0x04001EF0 RID: 7920
		[Token(Token = "0x4001EF0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11074CC", Offset = "0x11074CC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11074CC", Offset = "0x11074CC")]
		public string access_token;

		// Token: 0x04001EF1 RID: 7921
		[Token(Token = "0x4001EF1")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110751C", Offset = "0x110751C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110751C", Offset = "0x110751C")]
		public string open_id;

		// Token: 0x04001EF2 RID: 7922
		[Token(Token = "0x4001EF2")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110756C", Offset = "0x110756C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110756C", Offset = "0x110756C")]
		public string region;

		// Token: 0x04001EF3 RID: 7923
		[Token(Token = "0x4001EF3")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11075BC", Offset = "0x11075BC")]
		public uint avatar_id;

		// Token: 0x04001EF4 RID: 7924
		[Token(Token = "0x4001EF4")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11075D0", Offset = "0x11075D0")]
		public uint platform_type;

		// Token: 0x04001EF5 RID: 7925
		[Token(Token = "0x4001EF5")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11075E4", Offset = "0x11075E4")]
		public uint platform_sdk_id;

		// Token: 0x04001EF6 RID: 7926
		[Token(Token = "0x4001EF6")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11075F8", Offset = "0x11075F8")]
		public EAccount.DownloadType source;

		// Token: 0x04001EF7 RID: 7927
		[Token(Token = "0x4001EF7")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110760C", Offset = "0x110760C")]
		public bool use_default_nickname;

		// Token: 0x04001EF8 RID: 7928
		[Token(Token = "0x4001EF8")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107620", Offset = "0x1107620")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1107620", Offset = "0x1107620")]
		public string editor_register_key;

		// Token: 0x04001EF9 RID: 7929
		[Token(Token = "0x4001EF9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107670", Offset = "0x1107670")]
		public bool is_new_register_proc;

		// Token: 0x04001EFA RID: 7930
		[Token(Token = "0x4001EFA")]
		[FieldOffset(Offset = "0x51")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107684", Offset = "0x1107684")]
		public bool is_first_game_squad;
	}
}
