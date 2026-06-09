using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000786 RID: 1926
	[Token(Token = "0x2000786")]
	[ProtoContract]
	public class AccountWallet
	{
		// Token: 0x06002495 RID: 9365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002495")]
		[Address(RVA = "0x21AE854", Offset = "0x21AE854", VA = "0x7BBC9AE854")]
		public AccountWallet()
		{
		}

		// Token: 0x04002580 RID: 9600
		[Token(Token = "0x4002580")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E0B0", Offset = "0x110E0B0")]
		public uint coins;

		// Token: 0x04002581 RID: 9601
		[Token(Token = "0x4002581")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E0C4", Offset = "0x110E0C4")]
		public int gems;

		// Token: 0x04002582 RID: 9602
		[Token(Token = "0x4002582")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E0D8", Offset = "0x110E0D8")]
		public uint gop_gems;

		// Token: 0x04002583 RID: 9603
		[Token(Token = "0x4002583")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E0EC", Offset = "0x110E0EC")]
		public ulong total_topup;

		// Token: 0x04002584 RID: 9604
		[Token(Token = "0x4002584")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E100", Offset = "0x110E100")]
		public long last_topup_time;
	}
}
