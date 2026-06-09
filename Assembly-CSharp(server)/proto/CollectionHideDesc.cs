using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009DC RID: 2524
	[Token(Token = "0x20009DC")]
	[ProtoContract]
	public class CollectionHideDesc
	{
		// Token: 0x060026E6 RID: 9958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E6")]
		[Address(RVA = "0x21B8F58", Offset = "0x21B8F58", VA = "0x7BBC9B8F58")]
		public CollectionHideDesc()
		{
		}

		// Token: 0x04002D98 RID: 11672
		[Token(Token = "0x4002D98")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B8B4", Offset = "0x111B8B4")]
		public uint item_id;
	}
}
