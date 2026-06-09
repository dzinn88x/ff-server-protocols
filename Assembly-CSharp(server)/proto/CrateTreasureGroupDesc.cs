using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009F5 RID: 2549
	[Token(Token = "0x20009F5")]
	[ProtoContract]
	public class CrateTreasureGroupDesc
	{
		// Token: 0x060026FF RID: 9983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026FF")]
		[Address(RVA = "0x21B9050", Offset = "0x21B9050", VA = "0x7BBC9B9050")]
		public CrateTreasureGroupDesc()
		{
		}

		// Token: 0x04002E22 RID: 11810
		[Token(Token = "0x4002E22")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C6B0", Offset = "0x111C6B0")]
		public uint group_id;

		// Token: 0x04002E23 RID: 11811
		[Token(Token = "0x4002E23")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C6C4", Offset = "0x111C6C4")]
		public uint num_group;

		// Token: 0x04002E24 RID: 11812
		[Token(Token = "0x4002E24")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C6D8", Offset = "0x111C6D8")]
		public bool is_repeatable;

		// Token: 0x04002E25 RID: 11813
		[Token(Token = "0x4002E25")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C6EC", Offset = "0x111C6EC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111C6EC", Offset = "0x111C6EC")]
		public string icon;
	}
}
