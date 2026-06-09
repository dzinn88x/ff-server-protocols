using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006B5 RID: 1717
	[Token(Token = "0x20006B5")]
	[ProtoContract]
	public class DetailedTCStats
	{
		// Token: 0x060023DB RID: 9179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DB")]
		[Address(RVA = "0x21B9538", Offset = "0x21B9538", VA = "0x7BBC9B9538")]
		public DetailedTCStats()
		{
		}

		// Token: 0x040021B2 RID: 8626
		[Token(Token = "0x40021B2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109178", Offset = "0x1109178")]
		public uint mvp_count;

		// Token: 0x040021B3 RID: 8627
		[Token(Token = "0x40021B3")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110918C", Offset = "0x110918C")]
		public uint double_kills;

		// Token: 0x040021B4 RID: 8628
		[Token(Token = "0x40021B4")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11091A0", Offset = "0x11091A0")]
		public uint triple_kills;

		// Token: 0x040021B5 RID: 8629
		[Token(Token = "0x40021B5")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11091B4", Offset = "0x11091B4")]
		public uint four_kills;

		// Token: 0x040021B6 RID: 8630
		[Token(Token = "0x40021B6")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11091C8", Offset = "0x11091C8")]
		public uint damage;

		// Token: 0x040021B7 RID: 8631
		[Token(Token = "0x40021B7")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11091DC", Offset = "0x11091DC")]
		public uint head_shot_kills;

		// Token: 0x040021B8 RID: 8632
		[Token(Token = "0x40021B8")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11091F0", Offset = "0x11091F0")]
		public uint knock_downs;

		// Token: 0x040021B9 RID: 8633
		[Token(Token = "0x40021B9")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109204", Offset = "0x1109204")]
		public uint revivals;

		// Token: 0x040021BA RID: 8634
		[Token(Token = "0x40021BA")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109218", Offset = "0x1109218")]
		public uint assists;

		// Token: 0x040021BB RID: 8635
		[Token(Token = "0x40021BB")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110922C", Offset = "0x110922C")]
		public uint deaths;
	}
}
