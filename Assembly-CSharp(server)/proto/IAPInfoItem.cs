using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008AE RID: 2222
	[Token(Token = "0x20008AE")]
	[ProtoContract]
	public class IAPInfoItem
	{
		// Token: 0x060025BC RID: 9660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025BC")]
		[Address(RVA = "0x21BB2B0", Offset = "0x21BB2B0", VA = "0x7BBC9BB2B0")]
		public IAPInfoItem()
		{
		}

		// Token: 0x040029DC RID: 10716
		[Token(Token = "0x40029DC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115FCC", Offset = "0x1115FCC")]
		public uint pool_id;

		// Token: 0x040029DD RID: 10717
		[Token(Token = "0x40029DD")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115FE0", Offset = "0x1115FE0")]
		public uint store_id;

		// Token: 0x040029DE RID: 10718
		[Token(Token = "0x40029DE")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115FF4", Offset = "0x1115FF4")]
		public uint create_time;

		// Token: 0x040029DF RID: 10719
		[Token(Token = "0x40029DF")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116008", Offset = "0x1116008")]
		public uint end_time;

		// Token: 0x040029E0 RID: 10720
		[Token(Token = "0x40029E0")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111601C", Offset = "0x111601C")]
		public EStore.IapType iap_type;

		// Token: 0x040029E1 RID: 10721
		[Token(Token = "0x40029E1")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116030", Offset = "0x1116030")]
		public EStore.RebateCardBillStatus status;

		// Token: 0x040029E2 RID: 10722
		[Token(Token = "0x40029E2")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116044", Offset = "0x1116044")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1116044", Offset = "0x1116044")]
		public string title;
	}
}
