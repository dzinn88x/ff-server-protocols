using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000798 RID: 1944
	[Token(Token = "0x2000798")]
	[ProtoContract]
	public class CSGetRebateSubscriptionBonusStatusRes
	{
		// Token: 0x060024A7 RID: 9383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A7")]
		[Address(RVA = "0x21B58A0", Offset = "0x21B58A0", VA = "0x7BBC9B58A0")]
		public CSGetRebateSubscriptionBonusStatusRes()
		{
		}

		// Token: 0x040025A8 RID: 9640
		[Token(Token = "0x40025A8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E498", Offset = "0x110E498")]
		public bool is_got;
	}
}
