using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200115D RID: 4445
	[Token(Token = "0x200115D")]
	[Serializable]
	public class PetAnimClipConfig
	{
		// Token: 0x06004547 RID: 17735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004547")]
		[Address(RVA = "0x204E510", Offset = "0x204E510", VA = "0x7BBC84E510")]
		public static implicit operator PetAnimClipInfo(PetAnimClipConfig conf)
		{
			return null;
		}

		// Token: 0x06004548 RID: 17736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004548")]
		[Address(RVA = "0x204E5DC", Offset = "0x204E5DC", VA = "0x7BBC84E5DC")]
		public PetAnimClipConfig()
		{
		}

		// Token: 0x0400561C RID: 22044
		[Token(Token = "0x400561C")]
		[FieldOffset(Offset = "0x10")]
		public PetActionTag AnimType;

		// Token: 0x0400561D RID: 22045
		[Token(Token = "0x400561D")]
		[FieldOffset(Offset = "0x18")]
		public AnimationClip AnimClip;
	}
}
