using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007C9 RID: 1993
	[Token(Token = "0x20007C9")]
	[ProtoContract]
	public class CSGetBingoRewardsReq
	{
		// Token: 0x060024D8 RID: 9432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D8")]
		[Address(RVA = "0x21B26B0", Offset = "0x21B26B0", VA = "0x7BBC9B26B0")]
		public CSGetBingoRewardsReq()
		{
		}

		// Token: 0x0400261B RID: 9755
		[Token(Token = "0x400261B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F190", Offset = "0x110F190")]
		public uint id;
	}
}
