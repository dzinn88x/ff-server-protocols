using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009E7 RID: 2535
	[Token(Token = "0x20009E7")]
	[ProtoContract]
	public class ItemClearProtectDesc
	{
		// Token: 0x060026F1 RID: 9969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F1")]
		[Address(RVA = "0x21BB6A8", Offset = "0x21BB6A8", VA = "0x7BBC9BB6A8")]
		public ItemClearProtectDesc()
		{
		}

		// Token: 0x04002DD0 RID: 11728
		[Token(Token = "0x4002DD0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BEB8", Offset = "0x111BEB8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111BEB8", Offset = "0x111BEB8")]
		public string region;

		// Token: 0x04002DD1 RID: 11729
		[Token(Token = "0x4002DD1")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BF08", Offset = "0x111BF08")]
		public bool is_delete_invalid;

		// Token: 0x04002DD2 RID: 11730
		[Token(Token = "0x4002DD2")]
		[FieldOffset(Offset = "0x19")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BF1C", Offset = "0x111BF1C")]
		public bool is_item_id_delete_invalid;
	}
}
