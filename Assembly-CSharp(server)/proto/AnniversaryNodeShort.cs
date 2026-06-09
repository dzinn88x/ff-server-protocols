using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000950 RID: 2384
	[Token(Token = "0x2000950")]
	[ProtoContract]
	public class AnniversaryNodeShort
	{
		// Token: 0x0600265E RID: 9822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600265E")]
		[Address(RVA = "0x21AF034", Offset = "0x21AF034", VA = "0x7BBC9AF034")]
		public AnniversaryNodeShort()
		{
		}

		// Token: 0x04002BC3 RID: 11203
		[Token(Token = "0x4002BC3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119244", Offset = "0x1119244")]
		public uint node_id;

		// Token: 0x04002BC4 RID: 11204
		[Token(Token = "0x4002BC4")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119258", Offset = "0x1119258")]
		public ELimitedEvent.NodeStatus status;

		// Token: 0x04002BC5 RID: 11205
		[Token(Token = "0x4002BC5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111926C", Offset = "0x111926C")]
		public uint unlocked_timestamp;

		// Token: 0x04002BC6 RID: 11206
		[Token(Token = "0x4002BC6")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119280", Offset = "0x1119280")]
		public ulong materials_progress;

		// Token: 0x04002BC7 RID: 11207
		[Token(Token = "0x4002BC7")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119294", Offset = "0x1119294")]
		public ulong materials_target;
	}
}
