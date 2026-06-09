using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200152B RID: 5419
	[Token(Token = "0x200152B")]
	public class UILadderMatchHeroicLevelView : MonoBehaviour
	{
		// Token: 0x06005D4D RID: 23885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D4D")]
		[Address(RVA = "0x1E860CC", Offset = "0x1E860CC", VA = "0x7BBC6860CC")]
		private void Awake()
		{
		}

		// Token: 0x06005D4E RID: 23886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D4E")]
		[Address(RVA = "0x1E862F4", Offset = "0x1E862F4", VA = "0x7BBC6862F4")]
		public void SetView(int rankScore)
		{
		}

		// Token: 0x06005D4F RID: 23887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D4F")]
		[Address(RVA = "0x1E86530", Offset = "0x1E86530", VA = "0x7BBC686530")]
		public UILadderMatchHeroicLevelView()
		{
		}

		// Token: 0x04007EFA RID: 32506
		[Token(Token = "0x4007EFA")]
		[FieldOffset(Offset = "0x18")]
		public GameObject m_StarView1;

		// Token: 0x04007EFB RID: 32507
		[Token(Token = "0x4007EFB")]
		[FieldOffset(Offset = "0x20")]
		public GameObject m_StarView2;

		// Token: 0x04007EFC RID: 32508
		[Token(Token = "0x4007EFC")]
		[FieldOffset(Offset = "0x28")]
		public GameObject m_StarView3;

		// Token: 0x04007EFD RID: 32509
		[Token(Token = "0x4007EFD")]
		[FieldOffset(Offset = "0x30")]
		public GameObject m_StarView4;

		// Token: 0x04007EFE RID: 32510
		[Token(Token = "0x4007EFE")]
		[FieldOffset(Offset = "0x38")]
		public GameObject m_StarView5;

		// Token: 0x04007EFF RID: 32511
		[Token(Token = "0x4007EFF")]
		[FieldOffset(Offset = "0x40")]
		private List<GameObject> m_HeroicLevelObjs;
	}
}
