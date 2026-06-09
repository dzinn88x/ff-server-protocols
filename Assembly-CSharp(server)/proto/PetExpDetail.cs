using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000706 RID: 1798
	[Token(Token = "0x2000706")]
	[ProtoContract]
	public class PetExpDetail
	{
		// Token: 0x06002414 RID: 9236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002414")]
		[Address(RVA = "0x249F154", Offset = "0x249F154", VA = "0x7BBCC9F154")]
		public PetExpDetail()
		{
		}

		// Token: 0x040023CE RID: 9166
		[Token(Token = "0x40023CE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B5F4", Offset = "0x110B5F4")]
		public uint id;

		// Token: 0x040023CF RID: 9167
		[Token(Token = "0x40023CF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110B608", Offset = "0x110B608")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B608", Offset = "0x110B608")]
		public string name;

		// Token: 0x040023D0 RID: 9168
		[Token(Token = "0x40023D0")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B658", Offset = "0x110B658")]
		public uint level_before;

		// Token: 0x040023D1 RID: 9169
		[Token(Token = "0x40023D1")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B66C", Offset = "0x110B66C")]
		public uint level_after;

		// Token: 0x040023D2 RID: 9170
		[Token(Token = "0x40023D2")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B680", Offset = "0x110B680")]
		public uint exp_before;

		// Token: 0x040023D3 RID: 9171
		[Token(Token = "0x40023D3")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B694", Offset = "0x110B694")]
		public uint exp_after;

		// Token: 0x040023D4 RID: 9172
		[Token(Token = "0x40023D4")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B6A8", Offset = "0x110B6A8")]
		public uint skin_id;
	}
}
