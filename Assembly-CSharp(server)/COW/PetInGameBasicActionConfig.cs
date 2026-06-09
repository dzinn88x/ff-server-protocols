using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200115F RID: 4447
	[Token(Token = "0x200115F")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x10EACB4", Offset = "0x10EACB4")]
	[Serializable]
	public class PetInGameBasicActionConfig : ScriptableObject
	{
		// Token: 0x0600454C RID: 17740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600454C")]
		[Address(RVA = "0x2051214", Offset = "0x2051214", VA = "0x7BBC851214")]
		public PetInGameBasicActionConfig()
		{
		}

		// Token: 0x04005622 RID: 22050
		[Token(Token = "0x4005622")]
		[FieldOffset(Offset = "0x18")]
		public PetAnimClipInfo[] IngameAnims;
	}
}
