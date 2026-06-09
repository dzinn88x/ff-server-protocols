using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A31 RID: 2609
	[Token(Token = "0x2000A31")]
	[ProtoContract]
	public class RenameCostDesc
	{
		// Token: 0x0600273B RID: 10043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600273B")]
		[Address(RVA = "0x24A00CC", Offset = "0x24A00CC", VA = "0x7BBCCA00CC")]
		public RenameCostDesc()
		{
		}

		// Token: 0x04002F99 RID: 12185
		[Token(Token = "0x4002F99")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FB30", Offset = "0x111FB30")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111FB30", Offset = "0x111FB30")]
		public string region;

		// Token: 0x04002F9A RID: 12186
		[Token(Token = "0x4002F9A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FB80", Offset = "0x111FB80")]
		public uint diamond_cost;

		// Token: 0x04002F9B RID: 12187
		[Token(Token = "0x4002F9B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FB94", Offset = "0x111FB94")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111FB94", Offset = "0x111FB94")]
		public string start_time;

		// Token: 0x04002F9C RID: 12188
		[Token(Token = "0x4002F9C")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111FBE4", Offset = "0x111FBE4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FBE4", Offset = "0x111FBE4")]
		public string end_time;

		// Token: 0x04002F9D RID: 12189
		[Token(Token = "0x4002F9D")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FC34", Offset = "0x111FC34")]
		public uint on_sale_cost;
	}
}
