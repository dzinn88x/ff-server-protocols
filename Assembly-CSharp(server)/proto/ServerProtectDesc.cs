using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B3B RID: 2875
	[Token(Token = "0x2000B3B")]
	[ProtoContract]
	public class ServerProtectDesc
	{
		// Token: 0x06002843 RID: 10307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002843")]
		[Address(RVA = "0x24A058C", Offset = "0x24A058C", VA = "0x7BBCCA058C")]
		public ServerProtectDesc()
		{
		}

		// Token: 0x04003697 RID: 13975
		[Token(Token = "0x4003697")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CFC4", Offset = "0x112CFC4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112CFC4", Offset = "0x112CFC4")]
		public string region;

		// Token: 0x04003698 RID: 13976
		[Token(Token = "0x4003698")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D014", Offset = "0x112D014")]
		public bool is_open;

		// Token: 0x04003699 RID: 13977
		[Token(Token = "0x4003699")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D028", Offset = "0x112D028")]
		public uint allow_percent;
	}
}
