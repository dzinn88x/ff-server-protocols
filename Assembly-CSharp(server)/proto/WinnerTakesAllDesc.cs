using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A70 RID: 2672
	[Token(Token = "0x2000A70")]
	[ProtoContract]
	public class WinnerTakesAllDesc
	{
		// Token: 0x0600277A RID: 10106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600277A")]
		[Address(RVA = "0x24A1AF8", Offset = "0x24A1AF8", VA = "0x7BBCCA1AF8")]
		public WinnerTakesAllDesc()
		{
		}

		// Token: 0x040030F6 RID: 12534
		[Token(Token = "0x40030F6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112209C", Offset = "0x112209C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112209C", Offset = "0x112209C")]
		public string region;

		// Token: 0x040030F7 RID: 12535
		[Token(Token = "0x40030F7")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11220EC", Offset = "0x11220EC")]
		public uint chip_cost;

		// Token: 0x040030F8 RID: 12536
		[Token(Token = "0x40030F8")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122100", Offset = "0x1122100")]
		public uint diamond_cost;
	}
}
