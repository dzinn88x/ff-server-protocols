using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006DC RID: 1756
	[Token(Token = "0x20006DC")]
	[ProtoContract]
	public class CSFbRegisterReq
	{
		// Token: 0x060023EA RID: 9194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023EA")]
		[Address(RVA = "0x21B130C", Offset = "0x21B130C", VA = "0x7BBC9B130C")]
		public CSFbRegisterReq()
		{
		}

		// Token: 0x0400228C RID: 8844
		[Token(Token = "0x400228C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11096C8", Offset = "0x11096C8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11096C8", Offset = "0x11096C8")]
		public string nickname;

		// Token: 0x0400228D RID: 8845
		[Token(Token = "0x400228D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109718", Offset = "0x1109718")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1109718", Offset = "0x1109718")]
		public string input_token;

		// Token: 0x0400228E RID: 8846
		[Token(Token = "0x400228E")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109768", Offset = "0x1109768")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1109768", Offset = "0x1109768")]
		public string region;

		// Token: 0x0400228F RID: 8847
		[Token(Token = "0x400228F")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11097B8", Offset = "0x11097B8")]
		public uint avatar_id;
	}
}
