using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009D0 RID: 2512
	[Token(Token = "0x20009D0")]
	[ProtoContract]
	public class BannerDesc
	{
		// Token: 0x060026DA RID: 9946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DA")]
		[Address(RVA = "0x21AF724", Offset = "0x21AF724", VA = "0x7BBC9AF724")]
		public BannerDesc()
		{
		}

		// Token: 0x04002D7E RID: 11646
		[Token(Token = "0x4002D7E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B634", Offset = "0x111B634")]
		public uint Item_id;
	}
}
