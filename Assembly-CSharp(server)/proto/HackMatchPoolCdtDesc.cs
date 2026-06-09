using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A12 RID: 2578
	[Token(Token = "0x2000A12")]
	[ProtoContract]
	public class HackMatchPoolCdtDesc
	{
		// Token: 0x0600271C RID: 10012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271C")]
		[Address(RVA = "0x21BB164", Offset = "0x21BB164", VA = "0x7BBC9BB164")]
		public HackMatchPoolCdtDesc()
		{
		}

		// Token: 0x04002F0E RID: 12046
		[Token(Token = "0x4002F0E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E80C", Offset = "0x111E80C")]
		public uint cdt_id;

		// Token: 0x04002F0F RID: 12047
		[Token(Token = "0x4002F0F")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E820", Offset = "0x111E820")]
		public bool @switch;

		// Token: 0x04002F10 RID: 12048
		[Token(Token = "0x4002F10")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E834", Offset = "0x111E834")]
		public List<HackerPoolCdt> hacker_cdt;
	}
}
