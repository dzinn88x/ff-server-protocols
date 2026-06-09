using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AEC RID: 2796
	[Token(Token = "0x2000AEC")]
	[ProtoContract]
	public class MShopPurchaseItemsDesc
	{
		// Token: 0x060027F4 RID: 10228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F4")]
		[Address(RVA = "0x21BC0E0", Offset = "0x21BC0E0", VA = "0x7BBC9BC0E0")]
		public MShopPurchaseItemsDesc()
		{
		}

		// Token: 0x040034B3 RID: 13491
		[Token(Token = "0x40034B3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11290A4", Offset = "0x11290A4")]
		public uint item_id;
	}
}
