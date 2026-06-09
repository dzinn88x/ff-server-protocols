using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007A9 RID: 1961
	[Token(Token = "0x20007A9")]
	[ProtoContract]
	public class CSGetAttendanceListRes
	{
		// Token: 0x060024B8 RID: 9400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024B8")]
		[Address(RVA = "0x21B207C", Offset = "0x21B207C", VA = "0x7BBC9B207C")]
		public CSGetAttendanceListRes()
		{
		}

		// Token: 0x040025D7 RID: 9687
		[Token(Token = "0x40025D7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E8F8", Offset = "0x110E8F8")]
		public List<AttendanceList> attendance_list;
	}
}
