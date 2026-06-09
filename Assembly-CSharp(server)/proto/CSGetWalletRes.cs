using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200077B RID: 1915
	[Token(Token = "0x200077B")]
	[ProtoContract]
	public class CSGetWalletRes
	{
		// Token: 0x06002488 RID: 9352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002488")]
		[Address(RVA = "0x21B62EC", Offset = "0x21B62EC", VA = "0x7BBC9B62EC")]
		public CSGetWalletRes()
		{
		}

		// Token: 0x0400254A RID: 9546
		[Token(Token = "0x400254A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DB60", Offset = "0x110DB60")]
		public ulong account_id;

		// Token: 0x0400254B RID: 9547
		[Token(Token = "0x400254B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DB74", Offset = "0x110DB74")]
		public AccountWallet wallet;
	}
}
