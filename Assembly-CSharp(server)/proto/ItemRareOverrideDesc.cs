using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AD2 RID: 2770
	[Token(Token = "0x2000AD2")]
	[ProtoContract]
	public class ItemRareOverrideDesc
	{
		// Token: 0x060027DA RID: 10202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027DA")]
		[Address(RVA = "0x21BB7C8", Offset = "0x21BB7C8", VA = "0x7BBC9BB7C8")]
		public ItemRareOverrideDesc()
		{
		}

		// Token: 0x0400340A RID: 13322
		[Token(Token = "0x400340A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127A10", Offset = "0x1127A10")]
		public uint item_id;

		// Token: 0x0400340B RID: 13323
		[Token(Token = "0x400340B")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127A24", Offset = "0x1127A24")]
		public uint rare;
	}
}
