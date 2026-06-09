using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200173E RID: 5950
	[Token(Token = "0x200173E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1CAC", Offset = "0x10F1CAC")]
	internal class UICollectionScoreItemController : UIBaseController
	{
		// Token: 0x06006FE4 RID: 28644 RVA: 0x0001F5D8 File Offset: 0x0001D7D8
		[Token(Token = "0x6006FE4")]
		[Address(RVA = "0x20ABCC0", Offset = "0x20ABCC0", VA = "0x7BBC8ABCC0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006FE5 RID: 28645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FE5")]
		[Address(RVA = "0x20ABD10", Offset = "0x20ABD10", VA = "0x7BBC8ABD10", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006FE6 RID: 28646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FE6")]
		[Address(RVA = "0x20AC188", Offset = "0x20AC188", VA = "0x7BBC8AC188", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006FE7 RID: 28647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FE7")]
		[Address(RVA = "0x20AC2FC", Offset = "0x20AC2FC", VA = "0x7BBC8AC2FC")]
		public void SetUIData(WeaponScoreName name, uint wpid, uint skinId = 0U)
		{
		}

		// Token: 0x06006FE8 RID: 28648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FE8")]
		[Address(RVA = "0x20AC30C", Offset = "0x20AC30C", VA = "0x7BBC8AC30C")]
		private void SetUIData(uint wpid, uint skinId = 0U)
		{
		}

		// Token: 0x06006FE9 RID: 28649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FE9")]
		[Address(RVA = "0x20AD008", Offset = "0x20AD008", VA = "0x7BBC8AD008")]
		private void EnapblePropertyScoreTweenAlpha(params object[] data)
		{
		}

		// Token: 0x06006FEA RID: 28650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FEA")]
		[Address(RVA = "0x20ACBB0", Offset = "0x20ACBB0", VA = "0x7BBC8ACBB0")]
		private void SetAllScoreTweenAlpha(params object[] data)
		{
		}

		// Token: 0x06006FEB RID: 28651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FEB")]
		[Address(RVA = "0x20AD1C8", Offset = "0x20AD1C8", VA = "0x7BBC8AD1C8")]
		private void OnWeaponSkinChanged(params object[] data)
		{
		}

		// Token: 0x06006FEC RID: 28652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FEC")]
		[Address(RVA = "0x20AD284", Offset = "0x20AD284", VA = "0x7BBC8AD284")]
		public UICollectionScoreItemController()
		{
		}

		// Token: 0x040089DC RID: 35292
		[Token(Token = "0x40089DC")]
		[FieldOffset(Offset = "0x58")]
		private UICollectionScoreItemView m_View;

		// Token: 0x040089DD RID: 35293
		[Token(Token = "0x40089DD")]
		[FieldOffset(Offset = "0x60")]
		private WeaponScoreName m_ScoreName;

		// Token: 0x040089DE RID: 35294
		[Token(Token = "0x40089DE")]
		[FieldOffset(Offset = "0x68")]
		private Color COLOR_SCORE_RED;

		// Token: 0x040089DF RID: 35295
		[Token(Token = "0x40089DF")]
		[FieldOffset(Offset = "0x78")]
		private Color COLOR_SCORE_GREEN;

		// Token: 0x040089E0 RID: 35296
		[Token(Token = "0x40089E0")]
		[FieldOffset(Offset = "0x88")]
		private List<GameObject> m_UpIconList;

		// Token: 0x040089E1 RID: 35297
		[Token(Token = "0x40089E1")]
		[FieldOffset(Offset = "0x90")]
		private List<GameObject> m_DownIconList;
	}
}
