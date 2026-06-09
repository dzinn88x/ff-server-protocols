using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009D5 RID: 2517
	[Token(Token = "0x20009D5")]
	[ProtoContract]
	public class SkateDesc
	{
		// Token: 0x060026DF RID: 9951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DF")]
		[Address(RVA = "0x24A05E8", Offset = "0x24A05E8", VA = "0x7BBCCA05E8")]
		public SkateDesc()
		{
		}

		// Token: 0x04002D84 RID: 11652
		[Token(Token = "0x4002D84")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B6AC", Offset = "0x111B6AC")]
		public uint item_id;
	}
}
