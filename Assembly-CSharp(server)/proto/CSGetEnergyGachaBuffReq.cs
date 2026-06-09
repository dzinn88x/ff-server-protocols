using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009AB RID: 2475
	[Token(Token = "0x20009AB")]
	[ProtoContract]
	public class CSGetEnergyGachaBuffReq
	{
		// Token: 0x060026B9 RID: 9913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B9")]
		[Address(RVA = "0x21B32E4", Offset = "0x21B32E4", VA = "0x7BBC9B32E4")]
		public CSGetEnergyGachaBuffReq()
		{
		}

		// Token: 0x04002C99 RID: 11417
		[Token(Token = "0x4002C99")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A540", Offset = "0x111A540")]
		public uint lottery_id;

		// Token: 0x04002C9A RID: 11418
		[Token(Token = "0x4002C9A")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A554", Offset = "0x111A554")]
		public uint lottery_sub_id;
	}
}
