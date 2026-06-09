using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200079B RID: 1947
	[Token(Token = "0x200079B")]
	[ProtoContract]
	public class PayLevelConfig
	{
		// Token: 0x060024AA RID: 9386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024AA")]
		[Address(RVA = "0x249F044", Offset = "0x249F044", VA = "0x7BBCC9F044")]
		public PayLevelConfig()
		{
		}

		// Token: 0x040025AB RID: 9643
		[Token(Token = "0x40025AB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E4D4", Offset = "0x110E4D4")]
		public PayLevelPoolDesc pool;

		// Token: 0x040025AC RID: 9644
		[Token(Token = "0x40025AC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E4E8", Offset = "0x110E4E8")]
		public List<PayLevelRewardDesc> rewards;
	}
}
