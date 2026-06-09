using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007A1 RID: 1953
	[Token(Token = "0x20007A1")]
	[ProtoContract]
	public class CSOpenTreasureBoxRes
	{
		// Token: 0x060024B0 RID: 9392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024B0")]
		[Address(RVA = "0x21B6D18", Offset = "0x21B6D18", VA = "0x7BBC9B6D18")]
		public CSOpenTreasureBoxRes()
		{
		}

		// Token: 0x040025BB RID: 9659
		[Token(Token = "0x40025BB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E614", Offset = "0x110E614")]
		public AwardData awards;

		// Token: 0x040025BC RID: 9660
		[Token(Token = "0x40025BC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E628", Offset = "0x110E628")]
		public uint left_box_num;

		// Token: 0x040025BD RID: 9661
		[Token(Token = "0x40025BD")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E63C", Offset = "0x110E63C")]
		public List<ExchangedAward> exchangedAwards;
	}
}
