using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000860 RID: 2144
	[Token(Token = "0x2000860")]
	[ProtoContract]
	public class CSGetLotteryProbabilityReq
	{
		// Token: 0x0600256E RID: 9582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600256E")]
		[Address(RVA = "0x21B4804", Offset = "0x21B4804", VA = "0x7BBC9B4804")]
		public CSGetLotteryProbabilityReq()
		{
		}

		// Token: 0x0400281A RID: 10266
		[Token(Token = "0x400281A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112700", Offset = "0x1112700")]
		public uint chest_id;

		// Token: 0x0400281B RID: 10267
		[Token(Token = "0x400281B")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112714", Offset = "0x1112714")]
		public uint chest_sub_id;
	}
}
