using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A6C RID: 2668
	[Token(Token = "0x2000A6C")]
	[ProtoContract]
	public class GameDropInfo
	{
		// Token: 0x06002776 RID: 10102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002776")]
		[Address(RVA = "0x21BA6C4", Offset = "0x21BA6C4", VA = "0x7BBC9BA6C4")]
		public GameDropInfo()
		{
		}

		// Token: 0x040030C8 RID: 12488
		[Token(Token = "0x40030C8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121B24", Offset = "0x1121B24")]
		public uint drop_id;

		// Token: 0x040030C9 RID: 12489
		[Token(Token = "0x40030C9")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121B38", Offset = "0x1121B38")]
		public uint item_id;

		// Token: 0x040030CA RID: 12490
		[Token(Token = "0x40030CA")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121B4C", Offset = "0x1121B4C")]
		public uint start_time;

		// Token: 0x040030CB RID: 12491
		[Token(Token = "0x40030CB")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121B60", Offset = "0x1121B60")]
		public uint end_time;

		// Token: 0x040030CC RID: 12492
		[Token(Token = "0x40030CC")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121B74", Offset = "0x1121B74")]
		public uint match_mode;

		// Token: 0x040030CD RID: 12493
		[Token(Token = "0x40030CD")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121B88", Offset = "0x1121B88")]
		public uint game_mode;

		// Token: 0x040030CE RID: 12494
		[Token(Token = "0x40030CE")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121B9C", Offset = "0x1121B9C")]
		public uint map_id;

		// Token: 0x040030CF RID: 12495
		[Token(Token = "0x40030CF")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121BB0", Offset = "0x1121BB0")]
		public int group_mode;

		// Token: 0x040030D0 RID: 12496
		[Token(Token = "0x40030D0")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121BC4", Offset = "0x1121BC4")]
		public uint rank;

		// Token: 0x040030D1 RID: 12497
		[Token(Token = "0x40030D1")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121BD8", Offset = "0x1121BD8")]
		public uint time;

		// Token: 0x040030D2 RID: 12498
		[Token(Token = "0x40030D2")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121BEC", Offset = "0x1121BEC")]
		public uint max_drop_count;

		// Token: 0x040030D3 RID: 12499
		[Token(Token = "0x40030D3")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121C00", Offset = "0x1121C00")]
		public uint region_max_drop_count;

		// Token: 0x040030D4 RID: 12500
		[Token(Token = "0x40030D4")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121C14", Offset = "0x1121C14")]
		public uint time_span;

		// Token: 0x040030D5 RID: 12501
		[Token(Token = "0x40030D5")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121C28", Offset = "0x1121C28")]
		public bool is_mail_notice;

		// Token: 0x040030D6 RID: 12502
		[Token(Token = "0x40030D6")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121C3C", Offset = "0x1121C3C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1121C3C", Offset = "0x1121C3C")]
		public string event_detail_url;

		// Token: 0x040030D7 RID: 12503
		[Token(Token = "0x40030D7")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121C8C", Offset = "0x1121C8C")]
		public uint award_time;
	}
}
