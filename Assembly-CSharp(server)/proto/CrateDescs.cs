using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009F6 RID: 2550
	[Token(Token = "0x20009F6")]
	[ProtoContract]
	public class CrateDescs
	{
		// Token: 0x06002700 RID: 9984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002700")]
		[Address(RVA = "0x21B8FDC", Offset = "0x21B8FDC", VA = "0x7BBC9B8FDC")]
		public CrateDescs()
		{
		}

		// Token: 0x04002E26 RID: 11814
		[Token(Token = "0x4002E26")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C73C", Offset = "0x111C73C")]
		public uint crate_id;

		// Token: 0x04002E27 RID: 11815
		[Token(Token = "0x4002E27")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C750", Offset = "0x111C750")]
		public List<CrateTreasureGroupDesc> treasure_group;
	}
}
