using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200079F RID: 1951
	[Token(Token = "0x200079F")]
	[ProtoContract]
	public class CSClaimPayLevelRewardReq
	{
		// Token: 0x060024AE RID: 9390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024AE")]
		[Address(RVA = "0x21B0924", Offset = "0x21B0924", VA = "0x7BBC9B0924")]
		public CSClaimPayLevelRewardReq()
		{
		}

		// Token: 0x040025B2 RID: 9650
		[Token(Token = "0x40025B2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E560", Offset = "0x110E560")]
		public uint id;

		// Token: 0x040025B3 RID: 9651
		[Token(Token = "0x40025B3")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E574", Offset = "0x110E574")]
		public uint level;
	}
}
