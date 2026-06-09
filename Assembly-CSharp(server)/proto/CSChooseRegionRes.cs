using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006DE RID: 1758
	[Token(Token = "0x20006DE")]
	[ProtoContract]
	public class CSChooseRegionRes
	{
		// Token: 0x060023EC RID: 9196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023EC")]
		[Address(RVA = "0x21B06F4", Offset = "0x21B06F4", VA = "0x7BBC9B06F4")]
		public CSChooseRegionRes()
		{
		}

		// Token: 0x04002291 RID: 8849
		[Token(Token = "0x4002291")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110981C", Offset = "0x110981C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110981C", Offset = "0x110981C")]
		public string region;
	}
}
