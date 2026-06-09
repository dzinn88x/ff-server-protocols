using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007B7 RID: 1975
	[Token(Token = "0x20007B7")]
	[ProtoContract]
	public class CSGetFestivalAttendanceInfoRes
	{
		// Token: 0x060024C6 RID: 9414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C6")]
		[Address(RVA = "0x21B36A0", Offset = "0x21B36A0", VA = "0x7BBC9B36A0")]
		public CSGetFestivalAttendanceInfoRes()
		{
		}

		// Token: 0x040025E8 RID: 9704
		[Token(Token = "0x40025E8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EA74", Offset = "0x110EA74")]
		public List<FestivalAttendanceItem> attendance;

		// Token: 0x040025E9 RID: 9705
		[Token(Token = "0x40025E9")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EA88", Offset = "0x110EA88")]
		public bool is_signed_today;

		// Token: 0x040025EA RID: 9706
		[Token(Token = "0x40025EA")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EA9C", Offset = "0x110EA9C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110EA9C", Offset = "0x110EA9C")]
		public string act_text1;

		// Token: 0x040025EB RID: 9707
		[Token(Token = "0x40025EB")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110EAEC", Offset = "0x110EAEC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EAEC", Offset = "0x110EAEC")]
		public string act_text2;

		// Token: 0x040025EC RID: 9708
		[Token(Token = "0x40025EC")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EB3C", Offset = "0x110EB3C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110EB3C", Offset = "0x110EB3C")]
		public string act_text3;

		// Token: 0x040025ED RID: 9709
		[Token(Token = "0x40025ED")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EB8C", Offset = "0x110EB8C")]
		public long start_time;

		// Token: 0x040025EE RID: 9710
		[Token(Token = "0x40025EE")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EBA0", Offset = "0x110EBA0")]
		public long end_time;

		// Token: 0x040025EF RID: 9711
		[Token(Token = "0x40025EF")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EBB4", Offset = "0x110EBB4")]
		public bool is_in_attendance_time;

		// Token: 0x040025F0 RID: 9712
		[Token(Token = "0x40025F0")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EBC8", Offset = "0x110EBC8")]
		public uint festival_item_id1;

		// Token: 0x040025F1 RID: 9713
		[Token(Token = "0x40025F1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EBDC", Offset = "0x110EBDC")]
		public uint festival_item_id2;
	}
}
