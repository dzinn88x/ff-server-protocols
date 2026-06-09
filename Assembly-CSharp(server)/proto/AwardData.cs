using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005D9 RID: 1497
	[Token(Token = "0x20005D9")]
	[ProtoContract]
	public class AwardData
	{
		// Token: 0x06002359 RID: 9049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002359")]
		[Address(RVA = "0x21AF644", Offset = "0x21AF644", VA = "0x7BBC9AF644")]
		public AwardData()
		{
		}

		// Token: 0x04001DBA RID: 7610
		[Token(Token = "0x4001DBA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105370", Offset = "0x1105370")]
		public List<Item> items;

		// Token: 0x04001DBB RID: 7611
		[Token(Token = "0x4001DBB")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105384", Offset = "0x1105384")]
		public uint coins;

		// Token: 0x04001DBC RID: 7612
		[Token(Token = "0x4001DBC")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105398", Offset = "0x1105398")]
		public uint gems;

		// Token: 0x04001DBD RID: 7613
		[Token(Token = "0x4001DBD")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11053AC", Offset = "0x11053AC")]
		public uint exps;

		// Token: 0x04001DBE RID: 7614
		[Token(Token = "0x4001DBE")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11053C0", Offset = "0x11053C0")]
		public uint activeness;

		// Token: 0x04001DBF RID: 7615
		[Token(Token = "0x4001DBF")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11053D4", Offset = "0x11053D4")]
		public uint accelerators;
	}
}
