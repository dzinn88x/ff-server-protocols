using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008CF RID: 2255
	[Token(Token = "0x20008CF")]
	[ProtoContract]
	public class CSGetMysteryLuckyDrawRes
	{
		// Token: 0x060025DD RID: 9693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DD")]
		[Address(RVA = "0x21B4DD4", Offset = "0x21B4DD4", VA = "0x7BBC9B4DD4")]
		public CSGetMysteryLuckyDrawRes()
		{
		}

		// Token: 0x04002A4A RID: 10826
		[Token(Token = "0x4002A4A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116C24", Offset = "0x1116C24")]
		public uint discount;

		// Token: 0x04002A4B RID: 10827
		[Token(Token = "0x4002A4B")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116C38", Offset = "0x1116C38")]
		public uint discount_show;
	}
}
