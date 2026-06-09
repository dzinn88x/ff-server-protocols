using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A7B RID: 2683
	[Token(Token = "0x2000A7B")]
	[ProtoContract]
	public class BadgePriceDesc
	{
		// Token: 0x06002785 RID: 10117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002785")]
		[Address(RVA = "0x21AF6C8", Offset = "0x21AF6C8", VA = "0x7BBC9AF6C8")]
		public BadgePriceDesc()
		{
		}

		// Token: 0x04003134 RID: 12596
		[Token(Token = "0x4003134")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122718", Offset = "0x1122718")]
		public uint ep_event_id;

		// Token: 0x04003135 RID: 12597
		[Token(Token = "0x4003135")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112272C", Offset = "0x112272C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112272C", Offset = "0x112272C")]
		public string region;

		// Token: 0x04003136 RID: 12598
		[Token(Token = "0x4003136")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112277C", Offset = "0x112277C")]
		public EInventory.CurrencyType cost_type;

		// Token: 0x04003137 RID: 12599
		[Token(Token = "0x4003137")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122790", Offset = "0x1122790")]
		public uint cost_value;

		// Token: 0x04003138 RID: 12600
		[Token(Token = "0x4003138")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11227A4", Offset = "0x11227A4")]
		public uint discount_value1;

		// Token: 0x04003139 RID: 12601
		[Token(Token = "0x4003139")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11227B8", Offset = "0x11227B8")]
		public uint discount_value2;

		// Token: 0x0400313A RID: 12602
		[Token(Token = "0x400313A")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11227CC", Offset = "0x11227CC")]
		public uint discount_value3;
	}
}
