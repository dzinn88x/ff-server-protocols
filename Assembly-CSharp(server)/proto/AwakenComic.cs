using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005FC RID: 1532
	[Token(Token = "0x20005FC")]
	[ProtoContract]
	public class AwakenComic
	{
		// Token: 0x0600237C RID: 9084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600237C")]
		[Address(RVA = "0x21AF5B8", Offset = "0x21AF5B8", VA = "0x7BBC9AF5B8")]
		public AwakenComic()
		{
		}

		// Token: 0x04001E93 RID: 7827
		[Token(Token = "0x4001E93")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106F2C", Offset = "0x1106F2C")]
		public ulong account_id;

		// Token: 0x04001E94 RID: 7828
		[Token(Token = "0x4001E94")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106F40", Offset = "0x1106F40")]
		public uint original_avatar_id;

		// Token: 0x04001E95 RID: 7829
		[Token(Token = "0x4001E95")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106F54", Offset = "0x1106F54")]
		public uint comic_id;

		// Token: 0x04001E96 RID: 7830
		[Token(Token = "0x4001E96")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106F68", Offset = "0x1106F68")]
		public uint unlock_num;
	}
}
