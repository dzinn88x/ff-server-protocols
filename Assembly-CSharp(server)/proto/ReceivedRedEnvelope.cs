using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000645 RID: 1605
	[Token(Token = "0x2000645")]
	[ProtoContract]
	public class ReceivedRedEnvelope
	{
		// Token: 0x060023AF RID: 9135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023AF")]
		[Address(RVA = "0x249FC14", Offset = "0x249FC14", VA = "0x7BBCC9FC14")]
		public ReceivedRedEnvelope()
		{
		}

		// Token: 0x04001FB8 RID: 8120
		[Token(Token = "0x4001FB8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11083CC", Offset = "0x11083CC")]
		public uint boss_id;

		// Token: 0x04001FB9 RID: 8121
		[Token(Token = "0x4001FB9")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11083E0", Offset = "0x11083E0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11083E0", Offset = "0x11083E0")]
		public string boss_name;

		// Token: 0x04001FBA RID: 8122
		[Token(Token = "0x4001FBA")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108430", Offset = "0x1108430")]
		public uint coins;

		// Token: 0x04001FBB RID: 8123
		[Token(Token = "0x4001FBB")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108444", Offset = "0x1108444")]
		public uint gems;

		// Token: 0x04001FBC RID: 8124
		[Token(Token = "0x4001FBC")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108458", Offset = "0x1108458")]
		public List<Item> items;

		// Token: 0x04001FBD RID: 8125
		[Token(Token = "0x4001FBD")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110846C", Offset = "0x110846C")]
		public bool is_lucky;
	}
}
