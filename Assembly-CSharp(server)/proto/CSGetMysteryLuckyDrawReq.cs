using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008CE RID: 2254
	[Token(Token = "0x20008CE")]
	[ProtoContract]
	public class CSGetMysteryLuckyDrawReq
	{
		// Token: 0x060025DC RID: 9692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DC")]
		[Address(RVA = "0x21B4DCC", Offset = "0x21B4DCC", VA = "0x7BBC9B4DCC")]
		public CSGetMysteryLuckyDrawReq()
		{
		}

		// Token: 0x04002A49 RID: 10825
		[Token(Token = "0x4002A49")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116C10", Offset = "0x1116C10")]
		public uint entry_from;
	}
}
