using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A86 RID: 2694
	[Token(Token = "0x2000A86")]
	[ProtoContract]
	public class TicketPriceDesc
	{
		// Token: 0x06002790 RID: 10128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002790")]
		[Address(RVA = "0x24A10B4", Offset = "0x24A10B4", VA = "0x7BBCCA10B4")]
		public TicketPriceDesc()
		{
		}

		// Token: 0x04003185 RID: 12677
		[Token(Token = "0x4003185")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122ED4", Offset = "0x1122ED4")]
		public uint ep_event_id;

		// Token: 0x04003186 RID: 12678
		[Token(Token = "0x4003186")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122EE8", Offset = "0x1122EE8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1122EE8", Offset = "0x1122EE8")]
		public string region;

		// Token: 0x04003187 RID: 12679
		[Token(Token = "0x4003187")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122F38", Offset = "0x1122F38")]
		public EInventory.CurrencyType cost_type;

		// Token: 0x04003188 RID: 12680
		[Token(Token = "0x4003188")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122F4C", Offset = "0x1122F4C")]
		public uint cost_value;

		// Token: 0x04003189 RID: 12681
		[Token(Token = "0x4003189")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122F60", Offset = "0x1122F60")]
		public uint bundle_value;

		// Token: 0x0400318A RID: 12682
		[Token(Token = "0x400318A")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122F74", Offset = "0x1122F74")]
		public uint bundle_badge;

		// Token: 0x0400318B RID: 12683
		[Token(Token = "0x400318B")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122F88", Offset = "0x1122F88")]
		public uint bundle_reward_item1;

		// Token: 0x0400318C RID: 12684
		[Token(Token = "0x400318C")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122F9C", Offset = "0x1122F9C")]
		public uint bundle_reward_num1;

		// Token: 0x0400318D RID: 12685
		[Token(Token = "0x400318D")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122FB0", Offset = "0x1122FB0")]
		public uint bundle_reward_time1;
	}
}
