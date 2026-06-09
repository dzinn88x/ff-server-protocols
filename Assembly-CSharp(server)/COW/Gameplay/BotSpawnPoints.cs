using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x02002817 RID: 10263
	[Token(Token = "0x2002817")]
	public class BotSpawnPoints : MonoBehaviour
	{
		// Token: 0x0600D81E RID: 55326 RVA: 0x0003BB20 File Offset: 0x00039D20
		[Token(Token = "0x600D81E")]
		[Address(RVA = "0x17C8218", Offset = "0x17C8218", VA = "0x7BBBFC8218")]
		public int GetSpawnObjectType()
		{
			return 0;
		}

		// Token: 0x0600D81F RID: 55327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D81F")]
		[Address(RVA = "0x17C8220", Offset = "0x17C8220", VA = "0x7BBBFC8220")]
		public BotSpawnPoints()
		{
		}

		// Token: 0x0401087B RID: 67707
		[Token(Token = "0x401087B")]
		[FieldOffset(Offset = "0x18")]
		public int SpawnPointStartId;

		// Token: 0x0401087C RID: 67708
		[Token(Token = "0x401087C")]
		[FieldOffset(Offset = "0x1C")]
		[HideInInspector]
		public int IdCounter;
	}
}
