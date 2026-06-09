using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001860 RID: 6240
	[Token(Token = "0x2001860")]
	public class UIHeroicMarkItemCtrl : MonoBehaviour
	{
		// Token: 0x06007AF4 RID: 31476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AF4")]
		[Address(RVA = "0x1D5D484", Offset = "0x1D5D484", VA = "0x7BBC55D484")]
		public void SetData(uint season, ResourceID iconRes, ResourceID vfxRes, bool isDefault)
		{
		}

		// Token: 0x06007AF5 RID: 31477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AF5")]
		[Address(RVA = "0x1D5D758", Offset = "0x1D5D758", VA = "0x7BBC55D758")]
		public void ClearEffect()
		{
		}

		// Token: 0x06007AF6 RID: 31478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AF6")]
		[Address(RVA = "0x1D5DDBC", Offset = "0x1D5DDBC", VA = "0x7BBC55DDBC")]
		public UIHeroicMarkItemCtrl()
		{
		}

		// Token: 0x04008F7B RID: 36731
		[Token(Token = "0x4008F7B")]
		[FieldOffset(Offset = "0x18")]
		public UISprite Icon;

		// Token: 0x04008F7C RID: 36732
		[Token(Token = "0x4008F7C")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Desc;

		// Token: 0x04008F7D RID: 36733
		[Token(Token = "0x4008F7D")]
		[FieldOffset(Offset = "0x28")]
		public GameObject DefaultLabel;

		// Token: 0x04008F7E RID: 36734
		[Token(Token = "0x4008F7E")]
		[FieldOffset(Offset = "0x30")]
		public GameObject VfxContainer;

		// Token: 0x04008F7F RID: 36735
		[Token(Token = "0x4008F7F")]
		[FieldOffset(Offset = "0x38")]
		private GameObject m_CacheEffGo;
	}
}
