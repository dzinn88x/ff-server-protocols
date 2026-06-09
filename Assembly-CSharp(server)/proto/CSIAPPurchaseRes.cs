using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008B1 RID: 2225
	[Token(Token = "0x20008B1")]
	[ProtoContract]
	public class CSIAPPurchaseRes
	{
		// Token: 0x060025BF RID: 9663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025BF")]
		[Address(RVA = "0x21B64B8", Offset = "0x21B64B8", VA = "0x7BBC9B64B8")]
		public CSIAPPurchaseRes()
		{
		}

		// Token: 0x040029EC RID: 10732
		[Token(Token = "0x40029EC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11161C0", Offset = "0x11161C0")]
		public List<AwardDesc> awards;

		// Token: 0x040029ED RID: 10733
		[Token(Token = "0x40029ED")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11161D4", Offset = "0x11161D4")]
		public EStore.RebateCardBillStatus status;
	}
}
