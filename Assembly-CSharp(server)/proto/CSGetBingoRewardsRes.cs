using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007CA RID: 1994
	[Token(Token = "0x20007CA")]
	[ProtoContract]
	public class CSGetBingoRewardsRes
	{
		// Token: 0x060024D9 RID: 9433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D9")]
		[Address(RVA = "0x21B26B8", Offset = "0x21B26B8", VA = "0x7BBC9B26B8")]
		public CSGetBingoRewardsRes()
		{
		}

		// Token: 0x0400261C RID: 9756
		[Token(Token = "0x400261C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F1A4", Offset = "0x110F1A4")]
		public uint id;

		// Token: 0x0400261D RID: 9757
		[Token(Token = "0x400261D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F1B8", Offset = "0x110F1B8")]
		public AwardData rewards;
	}
}
