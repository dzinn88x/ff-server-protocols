using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009E6 RID: 2534
	[Token(Token = "0x20009E6")]
	[ProtoContract]
	public class NewRegisterItemDesc
	{
		// Token: 0x060026F0 RID: 9968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F0")]
		[Address(RVA = "0x249EC00", Offset = "0x249EC00", VA = "0x7BBCC9EC00")]
		public NewRegisterItemDesc()
		{
		}

		// Token: 0x04002DCE RID: 11726
		[Token(Token = "0x4002DCE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BE90", Offset = "0x111BE90")]
		public uint item_id;

		// Token: 0x04002DCF RID: 11727
		[Token(Token = "0x4002DCF")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BEA4", Offset = "0x111BEA4")]
		public uint item_num;
	}
}
