using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006E6 RID: 1766
	[Token(Token = "0x20006E6")]
	[ProtoContract]
	public class CSNewbieChoiceReq
	{
		// Token: 0x060023F4 RID: 9204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F4")]
		[Address(RVA = "0x21B6C10", Offset = "0x21B6C10", VA = "0x7BBC9B6C10")]
		public CSNewbieChoiceReq()
		{
		}

		// Token: 0x0400229D RID: 8861
		[Token(Token = "0x400229D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109B28", Offset = "0x1109B28")]
		public uint choice;
	}
}
