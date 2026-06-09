using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005EF RID: 1519
	[Token(Token = "0x20005EF")]
	[ProtoContract]
	public class MessageNotify
	{
		// Token: 0x0600236F RID: 9071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600236F")]
		[Address(RVA = "0x21BCAF4", Offset = "0x21BCAF4", VA = "0x7BBC9BCAF4")]
		public MessageNotify()
		{
		}

		// Token: 0x04001E69 RID: 7785
		[Token(Token = "0x4001E69")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106A90", Offset = "0x1106A90")]
		public ulong account_id;

		// Token: 0x04001E6A RID: 7786
		[Token(Token = "0x4001E6A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106AA4", Offset = "0x1106AA4")]
		public uint protocol;

		// Token: 0x04001E6B RID: 7787
		[Token(Token = "0x4001E6B")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106AB8", Offset = "0x1106AB8")]
		public uint ret;

		// Token: 0x04001E6C RID: 7788
		[Token(Token = "0x4001E6C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106ACC", Offset = "0x1106ACC")]
		public uint cmd;

		// Token: 0x04001E6D RID: 7789
		[Token(Token = "0x4001E6D")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106AE0", Offset = "0x1106AE0")]
		public byte[] content;
	}
}
