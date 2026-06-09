using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007C8 RID: 1992
	[Token(Token = "0x20007C8")]
	[ProtoContract]
	public class CSFlipBingoRes
	{
		// Token: 0x060024D7 RID: 9431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D7")]
		[Address(RVA = "0x21B151C", Offset = "0x21B151C", VA = "0x7BBC9B151C")]
		public CSFlipBingoRes()
		{
		}

		// Token: 0x04002619 RID: 9753
		[Token(Token = "0x4002619")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F168", Offset = "0x110F168")]
		public uint activity_id;

		// Token: 0x0400261A RID: 9754
		[Token(Token = "0x400261A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F17C", Offset = "0x110F17C")]
		public List<ActivityBingoRewardsInfo> rewards;
	}
}
