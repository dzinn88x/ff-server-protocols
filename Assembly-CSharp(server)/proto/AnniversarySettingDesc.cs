using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B15 RID: 2837
	[Token(Token = "0x2000B15")]
	[ProtoContract]
	public class AnniversarySettingDesc
	{
		// Token: 0x0600281D RID: 10269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600281D")]
		[Address(RVA = "0x21AF03C", Offset = "0x21AF03C", VA = "0x7BBC9AF03C")]
		public AnniversarySettingDesc()
		{
		}

		// Token: 0x040035CE RID: 13774
		[Token(Token = "0x40035CE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B944", Offset = "0x112B944")]
		public uint process_start_timestamp;

		// Token: 0x040035CF RID: 13775
		[Token(Token = "0x40035CF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B958", Offset = "0x112B958")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112B958", Offset = "0x112B958")]
		public string web_link;

		// Token: 0x040035D0 RID: 13776
		[Token(Token = "0x40035D0")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B9A8", Offset = "0x112B9A8")]
		public uint web_open_timestamp;

		// Token: 0x040035D1 RID: 13777
		[Token(Token = "0x40035D1")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B9BC", Offset = "0x112B9BC")]
		public uint web_close_timestamp;
	}
}
