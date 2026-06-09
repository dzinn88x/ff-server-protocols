using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000841 RID: 2113
	[Token(Token = "0x2000841")]
	[ProtoContract]
	public class IntimacyRankAwardInfo
	{
		// Token: 0x06002556 RID: 9558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002556")]
		[Address(RVA = "0x21BB5B8", Offset = "0x21BB5B8", VA = "0x7BBC9BB5B8")]
		public IntimacyRankAwardInfo()
		{
		}

		// Token: 0x04002774 RID: 10100
		[Token(Token = "0x4002774")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111620", Offset = "0x1111620")]
		public uint rank;

		// Token: 0x04002775 RID: 10101
		[Token(Token = "0x4002775")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111634", Offset = "0x1111634")]
		public EFriend.IntimacyRankAwardStatus status;
	}
}
