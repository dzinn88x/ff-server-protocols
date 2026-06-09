using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x020028F0 RID: 10480
	[Token(Token = "0x20028F0")]
	[Attribute(Name = "RequireComponent", RVA = "0x10FED5C", Offset = "0x10FED5C")]
	public class WeaponBoxSpawnConfig : MonoBehaviour
	{
		// Token: 0x0600DDE8 RID: 56808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDE8")]
		[Address(RVA = "0x149F8F4", Offset = "0x149F8F4", VA = "0x7BBBC9F8F4")]
		public WeaponBoxSpawnConfig()
		{
		}

		// Token: 0x04010DEB RID: 69099
		[Token(Token = "0x4010DEB")]
		[FieldOffset(Offset = "0x18")]
		public GameObject SpawnPointsObj;

		// Token: 0x04010DEC RID: 69100
		[Token(Token = "0x4010DEC")]
		[FieldOffset(Offset = "0x20")]
		public GameObject ColliderTemplate;
	}
}
