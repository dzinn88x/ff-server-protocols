using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001845 RID: 6213
	[Token(Token = "0x2001845")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3AD4", Offset = "0x10F3AD4")]
	internal class UIGameModeClassicInfoController : UIBaseController
	{
		// Token: 0x060079BA RID: 31162 RVA: 0x000217B0 File Offset: 0x0001F9B0
		[Token(Token = "0x60079BA")]
		[Address(RVA = "0x20010C8", Offset = "0x20010C8", VA = "0x7BBC8010C8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060079BB RID: 31163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079BB")]
		[Address(RVA = "0x2001118", Offset = "0x2001118", VA = "0x7BBC801118", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060079BC RID: 31164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079BC")]
		[Address(RVA = "0x20014A0", Offset = "0x20014A0", VA = "0x7BBC8014A0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060079BD RID: 31165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079BD")]
		[Address(RVA = "0x1FFADBC", Offset = "0x1FFADBC", VA = "0x7BBC7FADBC")]
		public void SetUIData(List<MapModeData> dataList)
		{
		}

		// Token: 0x060079BE RID: 31166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079BE")]
		[Address(RVA = "0x2002878", Offset = "0x2002878", VA = "0x7BBC802878")]
		private void OnHelpBtnCLick()
		{
		}

		// Token: 0x060079BF RID: 31167 RVA: 0x000217C8 File Offset: 0x0001F9C8
		[Token(Token = "0x60079BF")]
		[Address(RVA = "0x2002984", Offset = "0x2002984", VA = "0x7BBC802984")]
		private bool ShowHelpBtn(MapModeData data)
		{
			return default(bool);
		}

		// Token: 0x060079C0 RID: 31168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079C0")]
		[Address(RVA = "0x20029E0", Offset = "0x20029E0", VA = "0x7BBC8029E0")]
		private void UpdateSelectedMapName(object[] data)
		{
		}

		// Token: 0x060079C1 RID: 31169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079C1")]
		[Address(RVA = "0x20015C0", Offset = "0x20015C0", VA = "0x7BBC8015C0")]
		private void SetSelectedMapUIData(MapModeData data)
		{
		}

		// Token: 0x060079C2 RID: 31170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079C2")]
		[Address(RVA = "0x2002D00", Offset = "0x2002D00", VA = "0x7BBC802D00")]
		private void RefreshOpeningUI()
		{
		}

		// Token: 0x060079C3 RID: 31171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079C3")]
		[Address(RVA = "0x2002DD8", Offset = "0x2002DD8", VA = "0x7BBC802DD8")]
		private void OnHLDefaultMap(params object[] data)
		{
		}

		// Token: 0x060079C4 RID: 31172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079C4")]
		[Address(RVA = "0x2003110", Offset = "0x2003110", VA = "0x7BBC803110")]
		public UIGameModeClassicInfoController()
		{
		}

		// Token: 0x04008EE0 RID: 36576
		[Token(Token = "0x4008EE0")]
		[FieldOffset(Offset = "0x58")]
		private UIGameModeClassicInfoView m_View;

		// Token: 0x04008EE1 RID: 36577
		[Token(Token = "0x4008EE1")]
		[FieldOffset(Offset = "0x60")]
		private List<MapModeData> m_Data;

		// Token: 0x04008EE2 RID: 36578
		[Token(Token = "0x4008EE2")]
		[FieldOffset(Offset = "0x68")]
		private UIModelMapOpeningInfo m_ModelMap;

		// Token: 0x04008EE3 RID: 36579
		[Token(Token = "0x4008EE3")]
		[FieldOffset(Offset = "0x70")]
		private UIModelLadderMatch m_ladderModel;

		// Token: 0x04008EE4 RID: 36580
		[Token(Token = "0x4008EE4")]
		[FieldOffset(Offset = "0x78")]
		private MapModeData m_SelectedMapModeData;

		// Token: 0x04008EE5 RID: 36581
		[Token(Token = "0x4008EE5")]
		[FieldOffset(Offset = "0x80")]
		public UIGameModeMainController GameModeMainController;

		// Token: 0x02001846 RID: 6214
		[Token(Token = "0x2001846")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F3B0C", Offset = "0x10F3B0C")]
		private sealed class <>c__DisplayClass15_0
		{
			// Token: 0x060079C5 RID: 31173 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079C5")]
			[Address(RVA = "0x2003108", Offset = "0x2003108", VA = "0x7BBC803108")]
			public <>c__DisplayClass15_0()
			{
			}

			// Token: 0x060079C6 RID: 31174 RVA: 0x000217E0 File Offset: 0x0001F9E0
			[Token(Token = "0x60079C6")]
			[Address(RVA = "0x2003118", Offset = "0x2003118", VA = "0x7BBC803118")]
			internal bool <OnHLDefaultMap>b__0(MapModeData a)
			{
				return default(bool);
			}

			// Token: 0x04008EE6 RID: 36582
			[Token(Token = "0x4008EE6")]
			[FieldOffset(Offset = "0x10")]
			public MapModeData mapdata;
		}
	}
}
