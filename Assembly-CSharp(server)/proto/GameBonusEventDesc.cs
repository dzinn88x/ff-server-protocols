using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A6F RID: 2671
	[Token(Token = "0x2000A6F")]
	[ProtoContract]
	public class GameBonusEventDesc
	{
		// Token: 0x06002779 RID: 10105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002779")]
		[Address(RVA = "0x21BA658", Offset = "0x21BA658", VA = "0x7BBC9BA658")]
		public GameBonusEventDesc()
		{
		}

		// Token: 0x040030E4 RID: 12516
		[Token(Token = "0x40030E4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1121E08", Offset = "0x1121E08")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121E08", Offset = "0x1121E08")]
		public string region;

		// Token: 0x040030E5 RID: 12517
		[Token(Token = "0x40030E5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121E58", Offset = "0x1121E58")]
		public uint id;

		// Token: 0x040030E6 RID: 12518
		[Token(Token = "0x40030E6")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121E6C", Offset = "0x1121E6C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1121E6C", Offset = "0x1121E6C")]
		public string start_day;

		// Token: 0x040030E7 RID: 12519
		[Token(Token = "0x40030E7")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1121EBC", Offset = "0x1121EBC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121EBC", Offset = "0x1121EBC")]
		public string end_day;

		// Token: 0x040030E8 RID: 12520
		[Token(Token = "0x40030E8")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1121F0C", Offset = "0x1121F0C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121F0C", Offset = "0x1121F0C")]
		public string daily_start_time;

		// Token: 0x040030E9 RID: 12521
		[Token(Token = "0x40030E9")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121F5C", Offset = "0x1121F5C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1121F5C", Offset = "0x1121F5C")]
		public string daily_end_time;

		// Token: 0x040030EA RID: 12522
		[Token(Token = "0x40030EA")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121FAC", Offset = "0x1121FAC")]
		public uint match_mode;

		// Token: 0x040030EB RID: 12523
		[Token(Token = "0x40030EB")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121FC0", Offset = "0x1121FC0")]
		public uint game_mode;

		// Token: 0x040030EC RID: 12524
		[Token(Token = "0x40030EC")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121FD4", Offset = "0x1121FD4")]
		public uint map_id;

		// Token: 0x040030ED RID: 12525
		[Token(Token = "0x40030ED")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121FE8", Offset = "0x1121FE8")]
		public int group_mode;

		// Token: 0x040030EE RID: 12526
		[Token(Token = "0x40030EE")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121FFC", Offset = "0x1121FFC")]
		public uint exp_bonus;

		// Token: 0x040030EF RID: 12527
		[Token(Token = "0x40030EF")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122010", Offset = "0x1122010")]
		public uint gold_bonus;

		// Token: 0x040030F0 RID: 12528
		[Token(Token = "0x40030F0")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122024", Offset = "0x1122024")]
		public uint gold_limit;

		// Token: 0x040030F1 RID: 12529
		[Token(Token = "0x40030F1")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122038", Offset = "0x1122038")]
		public uint debris_limit;

		// Token: 0x040030F2 RID: 12530
		[Token(Token = "0x40030F2")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112204C", Offset = "0x112204C")]
		public long today_start_timestamp;

		// Token: 0x040030F3 RID: 12531
		[Token(Token = "0x40030F3")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122060", Offset = "0x1122060")]
		public long today_end_timestamp;

		// Token: 0x040030F4 RID: 12532
		[Token(Token = "0x40030F4")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122074", Offset = "0x1122074")]
		public long tomorrow_start_timestamp;

		// Token: 0x040030F5 RID: 12533
		[Token(Token = "0x40030F5")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122088", Offset = "0x1122088")]
		public long tomorrow_end_timestamp;
	}
}
