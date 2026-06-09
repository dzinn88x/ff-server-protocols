using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000890 RID: 2192
	[Token(Token = "0x2000890")]
	[ProtoContract]
	public class unlock
	{
		// Token: 0x0600259E RID: 9630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600259E")]
		[Address(RVA = "0x24A1C6C", Offset = "0x24A1C6C", VA = "0x7BBCCA1C6C")]
		public unlock()
		{
		}

		// Token: 0x040028E1 RID: 10465
		[Token(Token = "0x40028E1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113C04", Offset = "0x1113C04")]
		public uint id;

		// Token: 0x040028E2 RID: 10466
		[Token(Token = "0x40028E2")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113C18", Offset = "0x1113C18")]
		public uint is_ep;
	}
}
