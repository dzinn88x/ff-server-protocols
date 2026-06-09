using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A1B RID: 2587
	[Token(Token = "0x2000A1B")]
	[ProtoContract]
	public class RegionDesc
	{
		// Token: 0x06002725 RID: 10021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002725")]
		[Address(RVA = "0x249FDCC", Offset = "0x249FDCC", VA = "0x7BBCC9FDCC")]
		public RegionDesc()
		{
		}

		// Token: 0x04002F33 RID: 12083
		[Token(Token = "0x4002F33")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EC6C", Offset = "0x111EC6C")]
		public uint id;

		// Token: 0x04002F34 RID: 12084
		[Token(Token = "0x4002F34")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EC80", Offset = "0x111EC80")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111EC80", Offset = "0x111EC80")]
		public string region_server;

		// Token: 0x04002F35 RID: 12085
		[Token(Token = "0x4002F35")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111ECD0", Offset = "0x111ECD0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111ECD0", Offset = "0x111ECD0")]
		public string notification_region_server;

		// Token: 0x04002F36 RID: 12086
		[Token(Token = "0x4002F36")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111ED20", Offset = "0x111ED20")]
		public uint voice_type;

		// Token: 0x04002F37 RID: 12087
		[Token(Token = "0x4002F37")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111ED34", Offset = "0x111ED34")]
		public uint voice_server;

		// Token: 0x04002F38 RID: 12088
		[Token(Token = "0x4002F38")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111ED48", Offset = "0x111ED48")]
		public uint chat_server;

		// Token: 0x04002F39 RID: 12089
		[Token(Token = "0x4002F39")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111ED5C", Offset = "0x111ED5C")]
		public bool open;
	}
}
