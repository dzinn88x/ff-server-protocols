using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000879 RID: 2169
	[Token(Token = "0x2000879")]
	[ProtoContract]
	public class CSFlipCardReq
	{
		// Token: 0x06002587 RID: 9607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002587")]
		[Address(RVA = "0x21B1590", Offset = "0x21B1590", VA = "0x7BBC9B1590")]
		public CSFlipCardReq()
		{
		}

		// Token: 0x0400289A RID: 10394
		[Token(Token = "0x400289A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11134C0", Offset = "0x11134C0")]
		public bool is_pve;

		// Token: 0x0400289B RID: 10395
		[Token(Token = "0x400289B")]
		[FieldOffset(Offset = "0x11")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11134D4", Offset = "0x11134D4")]
		public bool is_all;

		// Token: 0x0400289C RID: 10396
		[Token(Token = "0x400289C")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11134E8", Offset = "0x11134E8")]
		public uint flip_order;
	}
}
