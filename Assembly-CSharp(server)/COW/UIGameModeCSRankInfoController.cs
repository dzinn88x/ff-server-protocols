using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001848 RID: 6216
	[Token(Token = "0x2001848")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3B54", Offset = "0x10F3B54")]
	internal class UIGameModeCSRankInfoController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x060079D9 RID: 31193 RVA: 0x00021828 File Offset: 0x0001FA28
		[Token(Token = "0x60079D9")]
		[Address(RVA = "0x1FFD81C", Offset = "0x1FFD81C", VA = "0x7BBC7FD81C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060079DA RID: 31194 RVA: 0x00021840 File Offset: 0x0001FA40
		[Token(Token = "0x60079DA")]
		[Address(RVA = "0x1FFD86C", Offset = "0x1FFD86C", VA = "0x7BBC7FD86C", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060079DB RID: 31195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079DB")]
		[Address(RVA = "0x1FFD8B0", Offset = "0x1FFD8B0", VA = "0x7BBC7FD8B0", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060079DC RID: 31196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079DC")]
		[Address(RVA = "0x1FFDAC4", Offset = "0x1FFDAC4", VA = "0x7BBC7FDAC4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060079DD RID: 31197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079DD")]
		[Address(RVA = "0x1FFDF54", Offset = "0x1FFDF54", VA = "0x7BBC7FDF54", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060079DE RID: 31198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079DE")]
		[Address(RVA = "0x1FFAEB0", Offset = "0x1FFAEB0", VA = "0x7BBC7FAEB0")]
		public void SetUIData(List<MapModeData> data)
		{
		}

		// Token: 0x060079DF RID: 31199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079DF")]
		[Address(RVA = "0x1FFD928", Offset = "0x1FFD928", VA = "0x7BBC7FD928")]
		private void UpdateCSDataInfo()
		{
		}

		// Token: 0x060079E0 RID: 31200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079E0")]
		[Address(RVA = "0x1FFE008", Offset = "0x1FFE008", VA = "0x7BBC7FE008")]
		private void SetSelectedMapUIData(MapModeData data)
		{
		}

		// Token: 0x060079E1 RID: 31201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079E1")]
		[Address(RVA = "0x1FFEBE4", Offset = "0x1FFEBE4", VA = "0x7BBC7FEBE4")]
		private void ShowHelpBtn(MapModeData data)
		{
		}

		// Token: 0x060079E2 RID: 31202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079E2")]
		[Address(RVA = "0x1FFE1D0", Offset = "0x1FFE1D0", VA = "0x7BBC7FE1D0")]
		private void RefreshCSLadderInfo(ResourceID id, int star)
		{
		}

		// Token: 0x060079E3 RID: 31203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079E3")]
		[Address(RVA = "0x1FFED30", Offset = "0x1FFED30", VA = "0x7BBC7FED30")]
		private void OnBtnCSRankClick()
		{
		}

		// Token: 0x060079E4 RID: 31204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079E4")]
		[Address(RVA = "0x1FFED6C", Offset = "0x1FFED6C", VA = "0x7BBC7FED6C")]
		private void OnHelpBtnCLick()
		{
		}

		// Token: 0x060079E5 RID: 31205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079E5")]
		[Address(RVA = "0x1FFEFAC", Offset = "0x1FFEFAC", VA = "0x7BBC7FEFAC")]
		public UIGameModeCSRankInfoController()
		{
		}

		// Token: 0x04008EEE RID: 36590
		[Token(Token = "0x4008EEE")]
		[FieldOffset(Offset = "0x58")]
		private UIGameModeCSRankInfoView m_View;

		// Token: 0x04008EEF RID: 36591
		[Token(Token = "0x4008EEF")]
		[FieldOffset(Offset = "0x60")]
		private UIModelMapOpeningInfo m_ModelMap;

		// Token: 0x04008EF0 RID: 36592
		[Token(Token = "0x4008EF0")]
		[FieldOffset(Offset = "0x68")]
		private List<GameObject> m_StarList;

		// Token: 0x04008EF1 RID: 36593
		[Token(Token = "0x4008EF1")]
		[FieldOffset(Offset = "0x70")]
		private List<GameObject> m_BlackStarList;

		// Token: 0x04008EF2 RID: 36594
		[Token(Token = "0x4008EF2")]
		[FieldOffset(Offset = "0x78")]
		private MapModeData m_SelectedMapModeData;
	}
}
