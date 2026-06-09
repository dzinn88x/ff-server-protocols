using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007A4 RID: 1956
	[Token(Token = "0x20007A4")]
	[ProtoContract]
	public class CSGetTreasureBoxPRRes
	{
		// Token: 0x060024B3 RID: 9395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024B3")]
		[Address(RVA = "0x21B5F90", Offset = "0x21B5F90", VA = "0x7BBC9B5F90")]
		public CSGetTreasureBoxPRRes()
		{
		}

		// Token: 0x040025C2 RID: 9666
		[Token(Token = "0x40025C2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E6A0", Offset = "0x110E6A0")]
		public List<RareProbability> rare_pr;
	}
}
