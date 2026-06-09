using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007A6 RID: 1958
	[Token(Token = "0x20007A6")]
	[ProtoContract]
	public class TreasureBoxShowData
	{
		// Token: 0x060024B5 RID: 9397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024B5")]
		[Address(RVA = "0x24A1194", Offset = "0x24A1194", VA = "0x7BBCCA1194")]
		public TreasureBoxShowData()
		{
		}

		// Token: 0x040025C5 RID: 9669
		[Token(Token = "0x40025C5")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E6DC", Offset = "0x110E6DC")]
		public uint award_id;

		// Token: 0x040025C6 RID: 9670
		[Token(Token = "0x40025C6")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E6F0", Offset = "0x110E6F0")]
		public bool is_preview;

		// Token: 0x040025C7 RID: 9671
		[Token(Token = "0x40025C7")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E704", Offset = "0x110E704")]
		public uint preview_avatar;

		// Token: 0x040025C8 RID: 9672
		[Token(Token = "0x40025C8")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E718", Offset = "0x110E718")]
		public bool is_big_reward;

		// Token: 0x040025C9 RID: 9673
		[Token(Token = "0x40025C9")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E72C", Offset = "0x110E72C")]
		public uint award_num;

		// Token: 0x040025CA RID: 9674
		[Token(Token = "0x40025CA")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E740", Offset = "0x110E740")]
		public EInventory.AwardType award_type;

		// Token: 0x040025CB RID: 9675
		[Token(Token = "0x40025CB")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E754", Offset = "0x110E754")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110E754", Offset = "0x110E754")]
		public string icon;

		// Token: 0x040025CC RID: 9676
		[Token(Token = "0x40025CC")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E7A4", Offset = "0x110E7A4")]
		public uint reward_level;

		// Token: 0x040025CD RID: 9677
		[Token(Token = "0x40025CD")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E7B8", Offset = "0x110E7B8")]
		public bool compose_icon;

		// Token: 0x040025CE RID: 9678
		[Token(Token = "0x40025CE")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E7CC", Offset = "0x110E7CC")]
		public uint award_time;
	}
}
