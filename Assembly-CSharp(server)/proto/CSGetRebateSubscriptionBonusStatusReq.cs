using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000797 RID: 1943
	[Token(Token = "0x2000797")]
	[ProtoContract]
	public class CSGetRebateSubscriptionBonusStatusReq
	{
		// Token: 0x060024A6 RID: 9382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A6")]
		[Address(RVA = "0x21B5898", Offset = "0x21B5898", VA = "0x7BBC9B5898")]
		public CSGetRebateSubscriptionBonusStatusReq()
		{
		}

		// Token: 0x040025A7 RID: 9639
		[Token(Token = "0x40025A7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E484", Offset = "0x110E484")]
		public uint rebate_id;
	}
}
