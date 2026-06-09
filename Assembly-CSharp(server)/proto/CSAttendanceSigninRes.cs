using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007AB RID: 1963
	[Token(Token = "0x20007AB")]
	[ProtoContract]
	public class CSAttendanceSigninRes
	{
		// Token: 0x060024BA RID: 9402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024BA")]
		[Address(RVA = "0x21B0440", Offset = "0x21B0440", VA = "0x7BBC9B0440")]
		public CSAttendanceSigninRes()
		{
		}

		// Token: 0x040025D9 RID: 9689
		[Token(Token = "0x40025D9")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E920", Offset = "0x110E920")]
		public uint sign_id;
	}
}
