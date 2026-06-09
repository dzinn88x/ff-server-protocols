using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000723 RID: 1827
	[Token(Token = "0x2000723")]
	[ProtoContract]
	public class CSGetPetListRes
	{
		// Token: 0x06002430 RID: 9264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002430")]
		[Address(RVA = "0x21B5240", Offset = "0x21B5240", VA = "0x7BBC9B5240")]
		public CSGetPetListRes()
		{
		}

		// Token: 0x04002452 RID: 9298
		[Token(Token = "0x4002452")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C1C0", Offset = "0x110C1C0")]
		public List<PetInfo> pets;

		// Token: 0x04002453 RID: 9299
		[Token(Token = "0x4002453")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C1D4", Offset = "0x110C1D4")]
		public List<PetSkinInfo> skins;

		// Token: 0x04002454 RID: 9300
		[Token(Token = "0x4002454")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C1E8", Offset = "0x110C1E8")]
		public List<PetActionInfo> actions;

		// Token: 0x04002455 RID: 9301
		[Token(Token = "0x4002455")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C1FC", Offset = "0x110C1FC")]
		public List<PetSkillInfo> skills;
	}
}
