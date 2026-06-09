using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007AA RID: 1962
	[Token(Token = "0x20007AA")]
	[ProtoContract]
	public class CSAttendanceSigninReq
	{
		// Token: 0x060024B9 RID: 9401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024B9")]
		[Address(RVA = "0x21B0438", Offset = "0x21B0438", VA = "0x7BBC9B0438")]
		public CSAttendanceSigninReq()
		{
		}

		// Token: 0x040025D8 RID: 9688
		[Token(Token = "0x40025D8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E90C", Offset = "0x110E90C")]
		public uint attendance_config_id;
	}
}
