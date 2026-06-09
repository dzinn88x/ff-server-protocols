using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AD6 RID: 2774
	[Token(Token = "0x2000AD6")]
	[ProtoContract]
	public class GlobalBoxDropInfoDesc
	{
		// Token: 0x060027DE RID: 10206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027DE")]
		[Address(RVA = "0x21BAE34", Offset = "0x21BAE34", VA = "0x7BBC9BAE34")]
		public GlobalBoxDropInfoDesc()
		{
		}

		// Token: 0x04003417 RID: 13335
		[Token(Token = "0x4003417")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1127B50", Offset = "0x1127B50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127B50", Offset = "0x1127B50")]
		public string region;

		// Token: 0x04003418 RID: 13336
		[Token(Token = "0x4003418")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127BA0", Offset = "0x1127BA0")]
		public uint region_max_drop_count;

		// Token: 0x04003419 RID: 13337
		[Token(Token = "0x4003419")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127BB4", Offset = "0x1127BB4")]
		public uint time_span_secs;

		// Token: 0x0400341A RID: 13338
		[Token(Token = "0x400341A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127BC8", Offset = "0x1127BC8")]
		public uint item_id;

		// Token: 0x0400341B RID: 13339
		[Token(Token = "0x400341B")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127BDC", Offset = "0x1127BDC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1127BDC", Offset = "0x1127BDC")]
		public string start_time;

		// Token: 0x0400341C RID: 13340
		[Token(Token = "0x400341C")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127C2C", Offset = "0x1127C2C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1127C2C", Offset = "0x1127C2C")]
		public string end_time;

		// Token: 0x0400341D RID: 13341
		[Token(Token = "0x400341D")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127C7C", Offset = "0x1127C7C")]
		public bool is_mail_notice;

		// Token: 0x0400341E RID: 13342
		[Token(Token = "0x400341E")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127C90", Offset = "0x1127C90")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1127C90", Offset = "0x1127C90")]
		public string event_detail_url;

		// Token: 0x0400341F RID: 13343
		[Token(Token = "0x400341F")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127CE0", Offset = "0x1127CE0")]
		public EInventory.AwardType item_type;
	}
}
