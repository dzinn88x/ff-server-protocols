using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007B6 RID: 1974
	[Token(Token = "0x20007B6")]
	[ProtoContract]
	public class CSGetAttendanceReq
	{
		// Token: 0x060024C5 RID: 9413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C5")]
		[Address(RVA = "0x21B20F0", Offset = "0x21B20F0", VA = "0x7BBC9B20F0")]
		public CSGetAttendanceReq()
		{
		}

		// Token: 0x040025E7 RID: 9703
		[Token(Token = "0x40025E7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EA60", Offset = "0x110EA60")]
		public bool need_clan_info;
	}
}
