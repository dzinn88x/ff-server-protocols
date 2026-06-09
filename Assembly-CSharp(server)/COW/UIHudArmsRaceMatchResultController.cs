using System;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001424 RID: 5156
	[Token(Token = "0x2001424")]
	internal class UIHudArmsRaceMatchResultController : UIHudMatchResultBaseShareController, IEasyList
	{
		// Token: 0x06005528 RID: 21800 RVA: 0x00019668 File Offset: 0x00017868
		[Token(Token = "0x6005528")]
		[Address(RVA = "0x1885968", Offset = "0x1885968", VA = "0x7BBC085968")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005529 RID: 21801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005529")]
		[Address(RVA = "0x18859B8", Offset = "0x18859B8", VA = "0x7BBC0859B8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600552A RID: 21802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600552A")]
		[Address(RVA = "0x1885BC0", Offset = "0x1885BC0", VA = "0x7BBC085BC0", Slot = "30")]
		protected override void OnMatchStatsChange(MatchStats stats, MatchIncome income)
		{
		}

		// Token: 0x0600552B RID: 21803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600552B")]
		[Address(RVA = "0x1885AA8", Offset = "0x1885AA8", VA = "0x7BBC085AA8")]
		private void ShowUI(MatchStats statsData, MatchIncome income)
		{
		}

		// Token: 0x0600552C RID: 21804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600552C")]
		[Address(RVA = "0x1885BC4", Offset = "0x1885BC4", VA = "0x7BBC085BC4", Slot = "36")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x0600552D RID: 21805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600552D")]
		[Address(RVA = "0x1885CB0", Offset = "0x1885CB0", VA = "0x7BBC085CB0", Slot = "37")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x0600552E RID: 21806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600552E")]
		[Address(RVA = "0x1885CE0", Offset = "0x1885CE0", VA = "0x7BBC085CE0")]
		public UIHudArmsRaceMatchResultController()
		{
		}

		// Token: 0x04007A3C RID: 31292
		[Token(Token = "0x4007A3C")]
		[FieldOffset(Offset = "0xA0")]
		private UIHudArmsRaceMatchResultView m_View;

		// Token: 0x04007A3D RID: 31293
		[Token(Token = "0x4007A3D")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_UIInited;
	}
}
