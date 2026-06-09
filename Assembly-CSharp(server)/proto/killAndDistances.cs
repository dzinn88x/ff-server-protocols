using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006FA RID: 1786
	[Token(Token = "0x20006FA")]
	[ProtoContract]
	public class killAndDistances
	{
		// Token: 0x06002408 RID: 9224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002408")]
		[Address(RVA = "0x24A1BE0", Offset = "0x24A1BE0", VA = "0x7BBCCA1BE0")]
		public killAndDistances()
		{
		}

		// Token: 0x040023A1 RID: 9121
		[Token(Token = "0x40023A1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B270", Offset = "0x110B270")]
		public uint wp_id;

		// Token: 0x040023A2 RID: 9122
		[Token(Token = "0x40023A2")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B284", Offset = "0x110B284")]
		public uint distance;
	}
}
