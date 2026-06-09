using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000971 RID: 2417
	[Token(Token = "0x2000971")]
	[ProtoContract]
	public class CSGetBooyahDayInfoRes
	{
		// Token: 0x0600267F RID: 9855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600267F")]
		[Address(RVA = "0x21B2764", Offset = "0x21B2764", VA = "0x7BBC9B2764")]
		public CSGetBooyahDayInfoRes()
		{
		}

		// Token: 0x04002C0C RID: 11276
		[Token(Token = "0x4002C0C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11198AC", Offset = "0x11198AC")]
		public uint[] process;

		// Token: 0x04002C0D RID: 11277
		[Token(Token = "0x4002C0D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11198E8", Offset = "0x11198E8")]
		public uint is_sign_in;
	}
}
