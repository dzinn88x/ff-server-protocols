using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000921 RID: 2337
	[Token(Token = "0x2000921")]
	[ProtoContract]
	public class CSGetEPSubscriptionBonusStatusRes
	{
		// Token: 0x0600262F RID: 9775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600262F")]
		[Address(RVA = "0x21B32D4", Offset = "0x21B32D4", VA = "0x7BBC9B32D4")]
		public CSGetEPSubscriptionBonusStatusRes()
		{
		}

		// Token: 0x04002B56 RID: 11094
		[Token(Token = "0x4002B56")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11187A4", Offset = "0x11187A4")]
		public bool is_got;
	}
}
