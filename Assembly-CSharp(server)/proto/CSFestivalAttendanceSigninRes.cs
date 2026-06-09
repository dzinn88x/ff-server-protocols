using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007B9 RID: 1977
	[Token(Token = "0x20007B9")]
	[ProtoContract]
	public class CSFestivalAttendanceSigninRes
	{
		// Token: 0x060024C8 RID: 9416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C8")]
		[Address(RVA = "0x21B137C", Offset = "0x21B137C", VA = "0x7BBC9B137C")]
		public CSFestivalAttendanceSigninRes()
		{
		}

		// Token: 0x040025F6 RID: 9718
		[Token(Token = "0x40025F6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110ECF4", Offset = "0x110ECF4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110ECF4", Offset = "0x110ECF4")]
		public string act_text1;
	}
}
