using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000729 RID: 1833
	[Token(Token = "0x2000729")]
	[ProtoContract]
	public class CSSelectPetSkinReq
	{
		// Token: 0x06002436 RID: 9270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002436")]
		[Address(RVA = "0x21B75E8", Offset = "0x21B75E8", VA = "0x7BBC9B75E8")]
		public CSSelectPetSkinReq()
		{
		}

		// Token: 0x04002464 RID: 9316
		[Token(Token = "0x4002464")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C3A0", Offset = "0x110C3A0")]
		public uint pet_id;

		// Token: 0x04002465 RID: 9317
		[Token(Token = "0x4002465")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C3B4", Offset = "0x110C3B4")]
		public uint skin_id;

		// Token: 0x04002466 RID: 9318
		[Token(Token = "0x4002466")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C3C8", Offset = "0x110C3C8")]
		public bool is_selected;
	}
}
