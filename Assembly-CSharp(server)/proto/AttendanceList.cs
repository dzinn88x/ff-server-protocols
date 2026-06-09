using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007A8 RID: 1960
	[Token(Token = "0x20007A8")]
	[ProtoContract]
	public class AttendanceList
	{
		// Token: 0x060024B7 RID: 9399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024B7")]
		[Address(RVA = "0x21AF370", Offset = "0x21AF370", VA = "0x7BBC9AF370")]
		public AttendanceList()
		{
		}

		// Token: 0x040025CF RID: 9679
		[Token(Token = "0x40025CF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E7E0", Offset = "0x110E7E0")]
		public List<AttendanceItem> attendance;

		// Token: 0x040025D0 RID: 9680
		[Token(Token = "0x40025D0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E7F4", Offset = "0x110E7F4")]
		public long end_time;

		// Token: 0x040025D1 RID: 9681
		[Token(Token = "0x40025D1")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110E808", Offset = "0x110E808")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E808", Offset = "0x110E808")]
		public string url;

		// Token: 0x040025D2 RID: 9682
		[Token(Token = "0x40025D2")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E858", Offset = "0x110E858")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110E858", Offset = "0x110E858")]
		public string loc_key;

		// Token: 0x040025D3 RID: 9683
		[Token(Token = "0x40025D3")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E8A8", Offset = "0x110E8A8")]
		public bool is_signed_today;

		// Token: 0x040025D4 RID: 9684
		[Token(Token = "0x40025D4")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E8BC", Offset = "0x110E8BC")]
		public EAttendance.AttendanceType attendance_type;

		// Token: 0x040025D5 RID: 9685
		[Token(Token = "0x40025D5")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E8D0", Offset = "0x110E8D0")]
		public long start_time;

		// Token: 0x040025D6 RID: 9686
		[Token(Token = "0x40025D6")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E8E4", Offset = "0x110E8E4")]
		public uint attendance_config_id;
	}
}
