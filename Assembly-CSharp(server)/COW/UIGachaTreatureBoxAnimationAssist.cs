using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001824 RID: 6180
	[Token(Token = "0x2001824")]
	public class UIGachaTreatureBoxAnimationAssist : MonoBehaviour
	{
		// Token: 0x060078C4 RID: 30916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078C4")]
		[Address(RVA = "0x1FA8200", Offset = "0x1FA8200", VA = "0x7BBC7A8200")]
		public void SetLotterieView(List<uint> Qualitis)
		{
		}

		// Token: 0x060078C5 RID: 30917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078C5")]
		[Address(RVA = "0x1FA9BC8", Offset = "0x1FA9BC8", VA = "0x7BBC7A9BC8")]
		public UIGachaTreatureBoxAnimationAssist()
		{
		}

		// Token: 0x04008E62 RID: 36450
		[Token(Token = "0x4008E62")]
		[FieldOffset(Offset = "0x18")]
		public List<GameObject> LotteryObjects;

		// Token: 0x04008E63 RID: 36451
		[Token(Token = "0x4008E63")]
		[FieldOffset(Offset = "0x20")]
		public List<Material> QualityMaterials;

		// Token: 0x04008E64 RID: 36452
		[Token(Token = "0x4008E64")]
		[FieldOffset(Offset = "0x28")]
		public List<SkinnedMeshRenderer> SkinnedMeshRenderers;
	}
}
