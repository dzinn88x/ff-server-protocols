using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x02002824 RID: 10276
	[Token(Token = "0x2002824")]
	[Attribute(Name = "RequireComponent", RVA = "0x10FEA00", Offset = "0x10FEA00")]
	public class InGameShopSpawnConfig : MonoBehaviour
	{
		// Token: 0x0600D858 RID: 55384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D858")]
		[Address(RVA = "0x1940C14", Offset = "0x1940C14", VA = "0x7BBC140C14")]
		public List<Transform> GetSpawnPoints()
		{
			return null;
		}

		// Token: 0x0600D859 RID: 55385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D859")]
		[Address(RVA = "0x1940D6C", Offset = "0x1940D6C", VA = "0x7BBC140D6C")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x0600D85A RID: 55386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D85A")]
		[Address(RVA = "0x1940EB0", Offset = "0x1940EB0", VA = "0x7BBC140EB0")]
		public InGameShopSpawnConfig()
		{
		}

		// Token: 0x040108BA RID: 67770
		[Token(Token = "0x40108BA")]
		[FieldOffset(Offset = "0x18")]
		public GameObject SpawnPointsObj;

		// Token: 0x040108BB RID: 67771
		[Token(Token = "0x40108BB")]
		[FieldOffset(Offset = "0x20")]
		public GameObject ColliderTemplate;
	}
}
