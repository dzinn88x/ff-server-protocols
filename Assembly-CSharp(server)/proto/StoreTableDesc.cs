using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008C0 RID: 2240
	[Token(Token = "0x20008C0")]
	[ProtoContract]
	public class StoreTableDesc
	{
		// Token: 0x060025CE RID: 9678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CE")]
		[Address(RVA = "0x24A08CC", Offset = "0x24A08CC", VA = "0x7BBCCA08CC")]
		public StoreTableDesc()
		{
		}

		// Token: 0x04002A16 RID: 10774
		[Token(Token = "0x4002A16")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11165F8", Offset = "0x11165F8")]
		public uint table_type;

		// Token: 0x04002A17 RID: 10775
		[Token(Token = "0x4002A17")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111660C", Offset = "0x111660C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111660C", Offset = "0x111660C")]
		public string language;

		// Token: 0x04002A18 RID: 10776
		[Token(Token = "0x4002A18")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111665C", Offset = "0x111665C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111665C", Offset = "0x111665C")]
		public string table_name;

		// Token: 0x04002A19 RID: 10777
		[Token(Token = "0x4002A19")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11166AC", Offset = "0x11166AC")]
		public uint mall_type;

		// Token: 0x04002A1A RID: 10778
		[Token(Token = "0x4002A1A")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11166C0", Offset = "0x11166C0")]
		public uint sort_id;
	}
}
