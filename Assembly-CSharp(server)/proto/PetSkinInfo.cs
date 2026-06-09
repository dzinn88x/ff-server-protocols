using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200060E RID: 1550
	[Token(Token = "0x200060E")]
	[ProtoContract]
	public class PetSkinInfo
	{
		// Token: 0x06002389 RID: 9097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002389")]
		[Address(RVA = "0x249F2C0", Offset = "0x249F2C0", VA = "0x7BBCC9F2C0")]
		public PetSkinInfo()
		{
		}

		// Token: 0x04001EE5 RID: 7909
		[Token(Token = "0x4001EE5")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11073B4", Offset = "0x11073B4")]
		public uint pet_id;

		// Token: 0x04001EE6 RID: 7910
		[Token(Token = "0x4001EE6")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11073C8", Offset = "0x11073C8")]
		public uint skin_id;

		// Token: 0x04001EE7 RID: 7911
		[Token(Token = "0x4001EE7")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11073DC", Offset = "0x11073DC")]
		public bool is_selected;
	}
}
