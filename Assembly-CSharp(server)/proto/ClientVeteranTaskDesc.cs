using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000943 RID: 2371
	[Token(Token = "0x2000943")]
	[ProtoContract]
	public class ClientVeteranTaskDesc
	{
		// Token: 0x06002651 RID: 9809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002651")]
		[Address(RVA = "0x21B8DDC", Offset = "0x21B8DDC", VA = "0x7BBC9B8DDC")]
		public ClientVeteranTaskDesc()
		{
		}

		// Token: 0x04002BA8 RID: 11176
		[Token(Token = "0x4002BA8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118F24", Offset = "0x1118F24")]
		public uint task_id;

		// Token: 0x04002BA9 RID: 11177
		[Token(Token = "0x4002BA9")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1118F38", Offset = "0x1118F38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118F38", Offset = "0x1118F38")]
		public string act_text;

		// Token: 0x04002BAA RID: 11178
		[Token(Token = "0x4002BAA")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118F88", Offset = "0x1118F88")]
		public uint task_class;

		// Token: 0x04002BAB RID: 11179
		[Token(Token = "0x4002BAB")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118F9C", Offset = "0x1118F9C")]
		public uint cdt_value;

		// Token: 0x04002BAC RID: 11180
		[Token(Token = "0x4002BAC")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118FB0", Offset = "0x1118FB0")]
		public List<AwardDesc> awards;

		// Token: 0x04002BAD RID: 11181
		[Token(Token = "0x4002BAD")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118FC4", Offset = "0x1118FC4")]
		public uint pre_cdt_value3;
	}
}
