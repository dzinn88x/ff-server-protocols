using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008D1 RID: 2257
	[Token(Token = "0x20008D1")]
	[ProtoContract]
	public class CSGetMysteryPoolInfoReq
	{
		// Token: 0x060025DF RID: 9695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DF")]
		[Address(RVA = "0x21B4DDC", Offset = "0x21B4DDC", VA = "0x7BBC9B4DDC")]
		public CSGetMysteryPoolInfoReq()
		{
		}

		// Token: 0x04002A52 RID: 10834
		[Token(Token = "0x4002A52")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116CC4", Offset = "0x1116CC4")]
		public uint pool_id;

		// Token: 0x04002A53 RID: 10835
		[Token(Token = "0x4002A53")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116CD8", Offset = "0x1116CD8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1116CD8", Offset = "0x1116CD8")]
		public string language;
	}
}
