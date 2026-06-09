using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A79 RID: 2681
	[Token(Token = "0x2000A79")]
	[ProtoContract]
	public class LoginQueueDesc
	{
		// Token: 0x06002783 RID: 10115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002783")]
		[Address(RVA = "0x21BBE28", Offset = "0x21BBE28", VA = "0x7BBC9BBE28")]
		public LoginQueueDesc()
		{
		}

		// Token: 0x0400311E RID: 12574
		[Token(Token = "0x400311E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1122470", Offset = "0x1122470")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122470", Offset = "0x1122470")]
		public string region;

		// Token: 0x0400311F RID: 12575
		[Token(Token = "0x400311F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11224C0", Offset = "0x11224C0")]
		public uint capacity;

		// Token: 0x04003120 RID: 12576
		[Token(Token = "0x4003120")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11224D4", Offset = "0x11224D4")]
		public uint rate;

		// Token: 0x04003121 RID: 12577
		[Token(Token = "0x4003121")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11224E8", Offset = "0x11224E8")]
		public uint burst;

		// Token: 0x04003122 RID: 12578
		[Token(Token = "0x4003122")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11224FC", Offset = "0x11224FC")]
		public uint ttl;

		// Token: 0x04003123 RID: 12579
		[Token(Token = "0x4003123")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122510", Offset = "0x1122510")]
		public bool enable;

		// Token: 0x04003124 RID: 12580
		[Token(Token = "0x4003124")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122524", Offset = "0x1122524")]
		public uint scan_queue_interval;

		// Token: 0x04003125 RID: 12581
		[Token(Token = "0x4003125")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122538", Offset = "0x1122538")]
		public uint scan_cache_interval;

		// Token: 0x04003126 RID: 12582
		[Token(Token = "0x4003126")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112254C", Offset = "0x112254C")]
		public uint process_cache_speed;

		// Token: 0x04003127 RID: 12583
		[Token(Token = "0x4003127")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122560", Offset = "0x1122560")]
		public uint multiplier;

		// Token: 0x04003128 RID: 12584
		[Token(Token = "0x4003128")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122574", Offset = "0x1122574")]
		public bool force_update;
	}
}
