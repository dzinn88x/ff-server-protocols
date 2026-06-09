using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005D7 RID: 1495
	[Token(Token = "0x20005D7")]
	[ProtoContract]
	public class ExchangedAward
	{
		// Token: 0x06002357 RID: 9047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002357")]
		[Address(RVA = "0x21B9FA4", Offset = "0x21B9FA4", VA = "0x7BBC9B9FA4")]
		public ExchangedAward()
		{
		}

		// Token: 0x04001DA6 RID: 7590
		[Token(Token = "0x4001DA6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11051E0", Offset = "0x11051E0")]
		public EInventory.AwardType origin_award_type;

		// Token: 0x04001DA7 RID: 7591
		[Token(Token = "0x4001DA7")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11051F4", Offset = "0x11051F4")]
		public uint origin_award_id;

		// Token: 0x04001DA8 RID: 7592
		[Token(Token = "0x4001DA8")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105208", Offset = "0x1105208")]
		public uint origin_award_num;

		// Token: 0x04001DA9 RID: 7593
		[Token(Token = "0x4001DA9")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110521C", Offset = "0x110521C")]
		public EInventory.AwardType dest_award_type;

		// Token: 0x04001DAA RID: 7594
		[Token(Token = "0x4001DAA")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105230", Offset = "0x1105230")]
		public uint dest_award_id;

		// Token: 0x04001DAB RID: 7595
		[Token(Token = "0x4001DAB")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105244", Offset = "0x1105244")]
		public uint dest_award_num;

		// Token: 0x04001DAC RID: 7596
		[Token(Token = "0x4001DAC")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105258", Offset = "0x1105258")]
		public uint origin_award_time;
	}
}
