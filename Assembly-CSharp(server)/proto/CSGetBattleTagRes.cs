using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009B8 RID: 2488
	[Token(Token = "0x20009B8")]
	[ProtoContract]
	public class CSGetBattleTagRes
	{
		// Token: 0x060026C6 RID: 9926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C6")]
		[Address(RVA = "0x21B243C", Offset = "0x21B243C", VA = "0x7BBC9B243C")]
		public CSGetBattleTagRes()
		{
		}

		// Token: 0x04002CB1 RID: 11441
		[Token(Token = "0x4002CB1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A7FC", Offset = "0x111A7FC")]
		public List<BattleTagCount> battle_tag_counts;

		// Token: 0x04002CB2 RID: 11442
		[Token(Token = "0x4002CB2")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A810", Offset = "0x111A810")]
		public uint[] show_tag_ids;
	}
}
