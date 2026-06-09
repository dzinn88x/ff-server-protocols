using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000771 RID: 1905
	[Token(Token = "0x2000771")]
	[ProtoContract]
	public class CSChooseShowReq
	{
		// Token: 0x0600247E RID: 9342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247E")]
		[Address(RVA = "0x21B0750", Offset = "0x21B0750", VA = "0x7BBC9B0750")]
		public CSChooseShowReq()
		{
		}

		// Token: 0x0400252E RID: 9518
		[Token(Token = "0x400252E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D8CC", Offset = "0x110D8CC")]
		public uint[] shows;
	}
}
