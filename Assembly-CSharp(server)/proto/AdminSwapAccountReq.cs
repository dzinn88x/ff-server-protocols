using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005E5 RID: 1509
	[Token(Token = "0x20005E5")]
	[ProtoContract]
	public class AdminSwapAccountReq
	{
		// Token: 0x06002365 RID: 9061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002365")]
		[Address(RVA = "0x21AEEF4", Offset = "0x21AEEF4", VA = "0x7BBC9AEEF4")]
		public AdminSwapAccountReq()
		{
		}

		// Token: 0x04001DDA RID: 7642
		[Token(Token = "0x4001DDA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11058AC", Offset = "0x11058AC")]
		public ulong account_id_a;

		// Token: 0x04001DDB RID: 7643
		[Token(Token = "0x4001DDB")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11058C0", Offset = "0x11058C0")]
		public ulong account_id_b;

		// Token: 0x04001DDC RID: 7644
		[Token(Token = "0x4001DDC")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11058D4", Offset = "0x11058D4")]
		public bool is_transfer_gems;
	}
}
