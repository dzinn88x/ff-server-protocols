using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200115B RID: 4443
	[Token(Token = "0x200115B")]
	[Serializable]
	public class PetExtraActionConfig : ScriptableObject
	{
		// Token: 0x06004545 RID: 17733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004545")]
		[Address(RVA = "0x205108C", Offset = "0x205108C", VA = "0x7BBC85108C")]
		public PetExtraActionConfig()
		{
		}

		// Token: 0x04005619 RID: 22041
		[Token(Token = "0x4005619")]
		[FieldOffset(Offset = "0x18")]
		public PetAnimClipConfig[] ExtraAnims;
	}
}
