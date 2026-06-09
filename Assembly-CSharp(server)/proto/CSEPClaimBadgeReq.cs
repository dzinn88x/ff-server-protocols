using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000883 RID: 2179
	[Token(Token = "0x2000883")]
	[ProtoContract]
	public class CSEPClaimBadgeReq
	{
		// Token: 0x06002591 RID: 9617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002591")]
		[Address(RVA = "0x21B0FEC", Offset = "0x21B0FEC", VA = "0x7BBC9B0FEC")]
		public CSEPClaimBadgeReq()
		{
		}

		// Token: 0x040028C0 RID: 10432
		[Token(Token = "0x40028C0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11138A8", Offset = "0x11138A8")]
		public uint[] challenge_ids;
	}
}
