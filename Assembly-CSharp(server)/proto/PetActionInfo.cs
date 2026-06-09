using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200060F RID: 1551
	[Token(Token = "0x200060F")]
	[ProtoContract]
	public class PetActionInfo
	{
		// Token: 0x0600238A RID: 9098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600238A")]
		[Address(RVA = "0x249F13C", Offset = "0x249F13C", VA = "0x7BBCC9F13C")]
		public PetActionInfo()
		{
		}

		// Token: 0x04001EE8 RID: 7912
		[Token(Token = "0x4001EE8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11073F0", Offset = "0x11073F0")]
		public uint pet_id;

		// Token: 0x04001EE9 RID: 7913
		[Token(Token = "0x4001EE9")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107404", Offset = "0x1107404")]
		public uint action_id;
	}
}
