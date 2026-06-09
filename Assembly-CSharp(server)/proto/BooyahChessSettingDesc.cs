using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B33 RID: 2867
	[Token(Token = "0x2000B33")]
	[ProtoContract]
	public class BooyahChessSettingDesc
	{
		// Token: 0x0600283B RID: 10299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283B")]
		[Address(RVA = "0x21AFBE4", Offset = "0x21AFBE4", VA = "0x7BBC9AFBE4")]
		public BooyahChessSettingDesc()
		{
		}

		// Token: 0x04003663 RID: 13923
		[Token(Token = "0x4003663")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C920", Offset = "0x112C920")]
		public uint ticket_id;

		// Token: 0x04003664 RID: 13924
		[Token(Token = "0x4003664")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C934", Offset = "0x112C934")]
		public uint ticket;

		// Token: 0x04003665 RID: 13925
		[Token(Token = "0x4003665")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C948", Offset = "0x112C948")]
		public uint max_step;

		// Token: 0x04003666 RID: 13926
		[Token(Token = "0x4003666")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C95C", Offset = "0x112C95C")]
		public uint reward_id;

		// Token: 0x04003667 RID: 13927
		[Token(Token = "0x4003667")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C970", Offset = "0x112C970")]
		public uint enemy_reward_lower;

		// Token: 0x04003668 RID: 13928
		[Token(Token = "0x4003668")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C984", Offset = "0x112C984")]
		public uint enemy_reward_upper;

		// Token: 0x04003669 RID: 13929
		[Token(Token = "0x4003669")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C998", Offset = "0x112C998")]
		public uint enemy_cnt;

		// Token: 0x0400366A RID: 13930
		[Token(Token = "0x400366A")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C9AC", Offset = "0x112C9AC")]
		public uint chest_reward;

		// Token: 0x0400366B RID: 13931
		[Token(Token = "0x400366B")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C9C0", Offset = "0x112C9C0")]
		public uint chest_cnt;

		// Token: 0x0400366C RID: 13932
		[Token(Token = "0x400366C")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C9D4", Offset = "0x112C9D4")]
		public uint booyah_reward;

		// Token: 0x0400366D RID: 13933
		[Token(Token = "0x400366D")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C9E8", Offset = "0x112C9E8")]
		public uint ticket_increment;

		// Token: 0x0400366E RID: 13934
		[Token(Token = "0x400366E")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C9FC", Offset = "0x112C9FC")]
		public uint ticket_max;
	}
}
