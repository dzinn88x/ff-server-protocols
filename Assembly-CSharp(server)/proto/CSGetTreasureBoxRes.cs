using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007A2 RID: 1954
	[Token(Token = "0x20007A2")]
	[ProtoContract]
	public class CSGetTreasureBoxRes
	{
		// Token: 0x060024B1 RID: 9393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024B1")]
		[Address(RVA = "0x21B6004", Offset = "0x21B6004", VA = "0x7BBC9B6004")]
		public CSGetTreasureBoxRes()
		{
		}

		// Token: 0x040025BE RID: 9662
		[Token(Token = "0x40025BE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E650", Offset = "0x110E650")]
		public List<TreasureBoxShow> boxes;

		// Token: 0x040025BF RID: 9663
		[Token(Token = "0x40025BF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E664", Offset = "0x110E664")]
		public List<CrateDescs> crates;
	}
}
