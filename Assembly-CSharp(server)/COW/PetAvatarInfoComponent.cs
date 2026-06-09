using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001442 RID: 5186
	[Token(Token = "0x2001442")]
	public class PetAvatarInfoComponent : MonoBehaviour
	{
		// Token: 0x06005623 RID: 22051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005623")]
		[Address(RVA = "0x204E5E4", Offset = "0x204E5E4", VA = "0x7BBC84E5E4")]
		public PetAvatarInfoComponent()
		{
		}

		// Token: 0x04007AED RID: 31469
		[Token(Token = "0x4007AED")]
		[FieldOffset(Offset = "0x18")]
		public Animation animator;

		// Token: 0x04007AEE RID: 31470
		[Token(Token = "0x4007AEE")]
		[FieldOffset(Offset = "0x20")]
		public UIItemInputHandler AvatarInput;

		// Token: 0x04007AEF RID: 31471
		[Token(Token = "0x4007AEF")]
		[FieldOffset(Offset = "0x28")]
		public BoxCollider boxCollider;
	}
}
