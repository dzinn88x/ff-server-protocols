using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200079C RID: 1948
	[Token(Token = "0x200079C")]
	[ProtoContract]
	public class CSGetPlayerPayLevelInfoReq
	{
		// Token: 0x060024AB RID: 9387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024AB")]
		[Address(RVA = "0x21B5590", Offset = "0x21B5590", VA = "0x7BBC9B5590")]
		public CSGetPlayerPayLevelInfoReq()
		{
		}

		// Token: 0x040025AD RID: 9645
		[Token(Token = "0x40025AD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E4FC", Offset = "0x110E4FC")]
		public uint id;
	}
}
