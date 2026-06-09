using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001265 RID: 4709
	[Token(Token = "0x2001265")]
	public class ADSpace1V1SpawnPoints : MonoBehaviour
	{
		// Token: 0x060048F8 RID: 18680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048F8")]
		[Address(RVA = "0x1F97C48", Offset = "0x1F97C48", VA = "0x7BBC797C48")]
		public ADSpace1V1SpawnPoints()
		{
		}

		// Token: 0x040071DF RID: 29151
		[Token(Token = "0x40071DF")]
		[FieldOffset(Offset = "0x18")]
		public PlayerSpawnPoint Team1Point;

		// Token: 0x040071E0 RID: 29152
		[Token(Token = "0x40071E0")]
		[FieldOffset(Offset = "0x20")]
		public PlayerSpawnPoint Team2Point;
	}
}
