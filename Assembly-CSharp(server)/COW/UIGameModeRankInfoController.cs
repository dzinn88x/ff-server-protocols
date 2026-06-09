using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200184D RID: 6221
	[Token(Token = "0x200184D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3C1C", Offset = "0x10F3C1C")]
	internal class UIGameModeRankInfoController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06007A11 RID: 31249 RVA: 0x00021948 File Offset: 0x0001FB48
		[Token(Token = "0x6007A11")]
		[Address(RVA = "0x2009C1C", Offset = "0x2009C1C", VA = "0x7BBC809C1C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007A12 RID: 31250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A12")]
		[Address(RVA = "0x2009C6C", Offset = "0x2009C6C", VA = "0x7BBC809C6C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007A13 RID: 31251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A13")]
		[Address(RVA = "0x2009F20", Offset = "0x2009F20", VA = "0x7BBC809F20", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007A14 RID: 31252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A14")]
		[Address(RVA = "0x1FFACE4", Offset = "0x1FFACE4", VA = "0x7BBC7FACE4")]
		public void SetUIData(List<MapModeData> data)
		{
		}

		// Token: 0x06007A15 RID: 31253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A15")]
		[Address(RVA = "0x2009F60", Offset = "0x2009F60", VA = "0x7BBC809F60")]
		private void SetSelectedMapUIData(MapModeData data)
		{
		}

		// Token: 0x06007A16 RID: 31254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A16")]
		[Address(RVA = "0x200B1AC", Offset = "0x200B1AC", VA = "0x7BBC80B1AC")]
		private void OnRankBtnClick()
		{
		}

		// Token: 0x06007A17 RID: 31255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A17")]
		[Address(RVA = "0x200B1B0", Offset = "0x200B1B0", VA = "0x7BBC80B1B0")]
		private void OnMapChangeButtonClicked()
		{
		}

		// Token: 0x06007A18 RID: 31256 RVA: 0x00021960 File Offset: 0x0001FB60
		[Token(Token = "0x6007A18")]
		[Address(RVA = "0x200B2D4", Offset = "0x200B2D4", VA = "0x7BBC80B2D4", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06007A19 RID: 31257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A19")]
		[Address(RVA = "0x200B318", Offset = "0x200B318", VA = "0x7BBC80B318", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06007A1A RID: 31258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A1A")]
		[Address(RVA = "0x200A9C4", Offset = "0x200A9C4", VA = "0x7BBC80A9C4")]
		private void SetRPData()
		{
		}

		// Token: 0x06007A1B RID: 31259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A1B")]
		[Address(RVA = "0x200B390", Offset = "0x200B390", VA = "0x7BBC80B390")]
		public UIGameModeRankInfoController()
		{
		}

		// Token: 0x04008F0C RID: 36620
		[Token(Token = "0x4008F0C")]
		[FieldOffset(Offset = "0x58")]
		private UIGameModeRankInfoView m_View;

		// Token: 0x04008F0D RID: 36621
		[Token(Token = "0x4008F0D")]
		[FieldOffset(Offset = "0x60")]
		private UIModelLadderMatch m_ladderModel;

		// Token: 0x04008F0E RID: 36622
		[Token(Token = "0x4008F0E")]
		[FieldOffset(Offset = "0x68")]
		private UIModelMapOpeningInfo m_ModelMap;
	}
}
