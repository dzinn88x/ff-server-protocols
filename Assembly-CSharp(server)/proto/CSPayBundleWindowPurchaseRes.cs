using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008BA RID: 2234
	[Token(Token = "0x20008BA")]
	[ProtoContract]
	public class CSPayBundleWindowPurchaseRes
	{
		// Token: 0x060025C8 RID: 9672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C8")]
		[Address(RVA = "0x21B6DE8", Offset = "0x21B6DE8", VA = "0x7BBC9B6DE8")]
		public CSPayBundleWindowPurchaseRes()
		{
		}

		// Token: 0x04002A07 RID: 10759
		[Token(Token = "0x4002A07")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11164CC", Offset = "0x11164CC")]
		public List<AwardDesc> awards;

		// Token: 0x04002A08 RID: 10760
		[Token(Token = "0x4002A08")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11164E0", Offset = "0x11164E0")]
		public uint purchase_times;

		// Token: 0x04002A09 RID: 10761
		[Token(Token = "0x4002A09")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11164F4", Offset = "0x11164F4")]
		public EStore.RebateCardBillStatus status;

		// Token: 0x04002A0A RID: 10762
		[Token(Token = "0x4002A0A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116508", Offset = "0x1116508")]
		public uint id;
	}
}
