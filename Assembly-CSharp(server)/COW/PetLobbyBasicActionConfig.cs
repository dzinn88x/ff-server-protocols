using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001161 RID: 4449
	[Token(Token = "0x2001161")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x10EAD14", Offset = "0x10EAD14")]
	[Serializable]
	public class PetLobbyBasicActionConfig : ScriptableObject
	{
		// Token: 0x06004550 RID: 17744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004550")]
		[Address(RVA = "0x20516AC", Offset = "0x20516AC", VA = "0x7BBC8516AC")]
		public PetLobbyBasicActionConfig()
		{
		}

		// Token: 0x04005629 RID: 22057
		[Token(Token = "0x4005629")]
		[FieldOffset(Offset = "0x18")]
		public AnimationClip[] LobbyAnims;
	}
}
