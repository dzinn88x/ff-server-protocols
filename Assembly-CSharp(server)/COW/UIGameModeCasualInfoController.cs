using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001844 RID: 6212
	[Token(Token = "0x2001844")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3A9C", Offset = "0x10F3A9C")]
	internal class UIGameModeCasualInfoController : UIBaseController
	{
		// Token: 0x060079B1 RID: 31153 RVA: 0x00021798 File Offset: 0x0001F998
		[Token(Token = "0x60079B1")]
		[Address(RVA = "0x1FFF678", Offset = "0x1FFF678", VA = "0x7BBC7FF678")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060079B2 RID: 31154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079B2")]
		[Address(RVA = "0x1FFF6C8", Offset = "0x1FFF6C8", VA = "0x7BBC7FF6C8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060079B3 RID: 31155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079B3")]
		[Address(RVA = "0x1FFF8F0", Offset = "0x1FFF8F0", VA = "0x7BBC7FF8F0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060079B4 RID: 31156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079B4")]
		[Address(RVA = "0x1FFAF30", Offset = "0x1FFAF30", VA = "0x7BBC7FAF30")]
		public void SetUIData(List<MapModeData> dataList)
		{
		}

		// Token: 0x060079B5 RID: 31157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079B5")]
		[Address(RVA = "0x2000564", Offset = "0x2000564", VA = "0x7BBC800564")]
		private void OnHelpBtnCLick()
		{
		}

		// Token: 0x060079B6 RID: 31158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079B6")]
		[Address(RVA = "0x20007A4", Offset = "0x20007A4", VA = "0x7BBC8007A4")]
		private void ShowHelpBtn(MapModeData data)
		{
		}

		// Token: 0x060079B7 RID: 31159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079B7")]
		[Address(RVA = "0x1FFF8F8", Offset = "0x1FFF8F8", VA = "0x7BBC7FF8F8")]
		private void SetSelectedMapUIData(MapModeData data)
		{
		}

		// Token: 0x060079B8 RID: 31160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079B8")]
		[Address(RVA = "0x20008F0", Offset = "0x20008F0", VA = "0x7BBC8008F0")]
		private void RefreshOpeningUI()
		{
		}

		// Token: 0x060079B9 RID: 31161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079B9")]
		[Address(RVA = "0x2000A48", Offset = "0x2000A48", VA = "0x7BBC800A48")]
		public UIGameModeCasualInfoController()
		{
		}

		// Token: 0x04008EDC RID: 36572
		[Token(Token = "0x4008EDC")]
		[FieldOffset(Offset = "0x58")]
		private UIGameModeCasualInfoView m_View;

		// Token: 0x04008EDD RID: 36573
		[Token(Token = "0x4008EDD")]
		[FieldOffset(Offset = "0x60")]
		private UIModelMapOpeningInfo m_ModelMap;

		// Token: 0x04008EDE RID: 36574
		[Token(Token = "0x4008EDE")]
		[FieldOffset(Offset = "0x68")]
		private UIModelLadderMatch m_ladderModel;

		// Token: 0x04008EDF RID: 36575
		[Token(Token = "0x4008EDF")]
		[FieldOffset(Offset = "0x70")]
		private MapModeData m_SelectedMapModeData;
	}
}
