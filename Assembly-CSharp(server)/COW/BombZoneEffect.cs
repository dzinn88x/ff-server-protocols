using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001267 RID: 4711
	[Token(Token = "0x2001267")]
	internal class BombZoneEffect : MonoBehaviour
	{
		// Token: 0x060048FA RID: 18682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048FA")]
		[Address(RVA = "0x14E452C", Offset = "0x14E452C", VA = "0x7BBBCE452C")]
		public BombZoneEffect()
		{
		}

		// Token: 0x040071E7 RID: 29159
		[Token(Token = "0x40071E7")]
		[FieldOffset(Offset = "0x18")]
		public GameObject EffectContainer;

		// Token: 0x040071E8 RID: 29160
		[Token(Token = "0x40071E8")]
		[FieldOffset(Offset = "0x20")]
		public GameObject NormalEffect;

		// Token: 0x040071E9 RID: 29161
		[Token(Token = "0x40071E9")]
		[FieldOffset(Offset = "0x28")]
		public GameObject BombEffect;
	}
}
