using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009DD RID: 2525
	[Token(Token = "0x20009DD")]
	[ProtoContract]
	public class CollectionFlightDesc
	{
		// Token: 0x060026E7 RID: 9959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E7")]
		[Address(RVA = "0x21B8F50", Offset = "0x21B8F50", VA = "0x7BBC9B8F50")]
		public CollectionFlightDesc()
		{
		}

		// Token: 0x04002D99 RID: 11673
		[Token(Token = "0x4002D99")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B8C8", Offset = "0x111B8C8")]
		public uint item_id;
	}
}
