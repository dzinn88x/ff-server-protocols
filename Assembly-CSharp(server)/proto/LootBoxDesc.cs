using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009D2 RID: 2514
	[Token(Token = "0x20009D2")]
	[ProtoContract]
	public class LootBoxDesc
	{
		// Token: 0x060026DC RID: 9948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DC")]
		[Address(RVA = "0x21BC064", Offset = "0x21BC064", VA = "0x7BBC9BC064")]
		public LootBoxDesc()
		{
		}

		// Token: 0x04002D81 RID: 11649
		[Token(Token = "0x4002D81")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B670", Offset = "0x111B670")]
		public uint item_id;
	}
}
