using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007A5 RID: 1957
	[Token(Token = "0x20007A5")]
	[ProtoContract]
	public class TreasureBoxShow
	{
		// Token: 0x060024B4 RID: 9396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024B4")]
		[Address(RVA = "0x24A1120", Offset = "0x24A1120", VA = "0x7BBCCA1120")]
		public TreasureBoxShow()
		{
		}

		// Token: 0x040025C3 RID: 9667
		[Token(Token = "0x40025C3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E6B4", Offset = "0x110E6B4")]
		public uint id;

		// Token: 0x040025C4 RID: 9668
		[Token(Token = "0x40025C4")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E6C8", Offset = "0x110E6C8")]
		public List<TreasureBoxShowData> treasure_boxes;
	}
}
