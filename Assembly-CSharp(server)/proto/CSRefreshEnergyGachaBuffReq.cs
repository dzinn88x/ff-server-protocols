using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009A9 RID: 2473
	[Token(Token = "0x20009A9")]
	[ProtoContract]
	public class CSRefreshEnergyGachaBuffReq
	{
		// Token: 0x060026B7 RID: 9911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B7")]
		[Address(RVA = "0x21B72E8", Offset = "0x21B72E8", VA = "0x7BBC9B72E8")]
		public CSRefreshEnergyGachaBuffReq()
		{
		}

		// Token: 0x04002C95 RID: 11413
		[Token(Token = "0x4002C95")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A4F0", Offset = "0x111A4F0")]
		public uint lottery_id;

		// Token: 0x04002C96 RID: 11414
		[Token(Token = "0x4002C96")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A504", Offset = "0x111A504")]
		public uint lottery_sub_id;
	}
}
