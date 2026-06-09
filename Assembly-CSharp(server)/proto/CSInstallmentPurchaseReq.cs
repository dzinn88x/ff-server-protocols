using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008C6 RID: 2246
	[Token(Token = "0x20008C6")]
	[ProtoContract]
	public class CSInstallmentPurchaseReq
	{
		// Token: 0x060025D4 RID: 9684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D4")]
		[Address(RVA = "0x21B65A8", Offset = "0x21B65A8", VA = "0x7BBC9B65A8")]
		public CSInstallmentPurchaseReq()
		{
		}

		// Token: 0x04002A2F RID: 10799
		[Token(Token = "0x4002A2F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11168DC", Offset = "0x11168DC")]
		public uint item_id;

		// Token: 0x04002A30 RID: 10800
		[Token(Token = "0x4002A30")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11168F0", Offset = "0x11168F0")]
		public uint price;

		// Token: 0x04002A31 RID: 10801
		[Token(Token = "0x4002A31")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116904", Offset = "0x1116904")]
		public bool is_one_time_payment;
	}
}
