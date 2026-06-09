using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A87 RID: 2695
	[Token(Token = "0x2000A87")]
	[ProtoContract]
	public class UnlockRewardsDesc
	{
		// Token: 0x06002791 RID: 10129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002791")]
		[Address(RVA = "0x24A1438", Offset = "0x24A1438", VA = "0x7BBCCA1438")]
		public UnlockRewardsDesc()
		{
		}

		// Token: 0x0400318E RID: 12686
		[Token(Token = "0x400318E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122FC4", Offset = "0x1122FC4")]
		public uint ep_event_id;

		// Token: 0x0400318F RID: 12687
		[Token(Token = "0x400318F")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122FD8", Offset = "0x1122FD8")]
		public uint unlock_id;

		// Token: 0x04003190 RID: 12688
		[Token(Token = "0x4003190")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122FEC", Offset = "0x1122FEC")]
		public uint require_item;

		// Token: 0x04003191 RID: 12689
		[Token(Token = "0x4003191")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123000", Offset = "0x1123000")]
		public uint require_num;

		// Token: 0x04003192 RID: 12690
		[Token(Token = "0x4003192")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123014", Offset = "0x1123014")]
		public EInventory.AwardType fp_award_type;

		// Token: 0x04003193 RID: 12691
		[Token(Token = "0x4003193")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123028", Offset = "0x1123028")]
		public uint fp_award_id;

		// Token: 0x04003194 RID: 12692
		[Token(Token = "0x4003194")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112303C", Offset = "0x112303C")]
		public uint fp_award_num;

		// Token: 0x04003195 RID: 12693
		[Token(Token = "0x4003195")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123050", Offset = "0x1123050")]
		public EInventory.AwardType ep_award_type;

		// Token: 0x04003196 RID: 12694
		[Token(Token = "0x4003196")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123064", Offset = "0x1123064")]
		public uint ep_award_id;

		// Token: 0x04003197 RID: 12695
		[Token(Token = "0x4003197")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123078", Offset = "0x1123078")]
		public uint ep_award_num;

		// Token: 0x04003198 RID: 12696
		[Token(Token = "0x4003198")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112308C", Offset = "0x112308C")]
		public uint fp_award_time;

		// Token: 0x04003199 RID: 12697
		[Token(Token = "0x4003199")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11230A0", Offset = "0x11230A0")]
		public uint ep_award_time;
	}
}
