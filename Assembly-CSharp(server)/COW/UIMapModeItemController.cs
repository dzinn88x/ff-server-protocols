using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A61 RID: 6753
	[Token(Token = "0x2001A61")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F80F4", Offset = "0x10F80F4")]
	internal class UIMapModeItemController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06008E20 RID: 36384 RVA: 0x00025EF0 File Offset: 0x000240F0
		[Token(Token = "0x6008E20")]
		[Address(RVA = "0x146ADB8", Offset = "0x146ADB8", VA = "0x7BBBC6ADB8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008E21 RID: 36385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E21")]
		[Address(RVA = "0x146AE08", Offset = "0x146AE08", VA = "0x7BBBC6AE08", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008E22 RID: 36386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E22")]
		[Address(RVA = "0x146B118", Offset = "0x146B118", VA = "0x7BBBC6B118", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06008E23 RID: 36387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E23")]
		[Address(RVA = "0x146B2F8", Offset = "0x146B2F8", VA = "0x7BBBC6B2F8")]
		public void SetUIData(MapModeData data)
		{
		}

		// Token: 0x06008E24 RID: 36388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E24")]
		[Address(RVA = "0x146C6A8", Offset = "0x146C6A8", VA = "0x7BBBC6C6A8")]
		private void RefreshOpeningUI()
		{
		}

		// Token: 0x06008E25 RID: 36389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E25")]
		[Address(RVA = "0x146CD98", Offset = "0x146CD98", VA = "0x7BBBC6CD98")]
		private void OnMapModeClick()
		{
		}

		// Token: 0x06008E26 RID: 36390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E26")]
		[Address(RVA = "0x146CF68", Offset = "0x146CF68", VA = "0x7BBBC6CF68")]
		private void HighLightDefault(bool trigger = true)
		{
		}

		// Token: 0x06008E27 RID: 36391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E27")]
		[Address(RVA = "0x146D16C", Offset = "0x146D16C", VA = "0x7BBBC6D16C")]
		private void OnGroupQuit(object[] data)
		{
		}

		// Token: 0x06008E28 RID: 36392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E28")]
		[Address(RVA = "0x146CEA4", Offset = "0x146CEA4", VA = "0x7BBBC6CEA4")]
		private void ClearGuide()
		{
		}

		// Token: 0x06008E29 RID: 36393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E29")]
		[Address(RVA = "0x146D194", Offset = "0x146D194", VA = "0x7BBBC6D194")]
		private void OnVisible(object[] data)
		{
		}

		// Token: 0x06008E2A RID: 36394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E2A")]
		[Address(RVA = "0x146D300", Offset = "0x146D300", VA = "0x7BBBC6D300")]
		private void OnMapRevert(params object[] data)
		{
		}

		// Token: 0x06008E2B RID: 36395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E2B")]
		[Address(RVA = "0x146D4E4", Offset = "0x146D4E4", VA = "0x7BBBC6D4E4", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008E2C RID: 36396 RVA: 0x00025F08 File Offset: 0x00024108
		[Token(Token = "0x6008E2C")]
		[Address(RVA = "0x146D570", Offset = "0x146D570", VA = "0x7BBBC6D570", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008E2D RID: 36397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E2D")]
		[Address(RVA = "0x146D5B4", Offset = "0x146D5B4", VA = "0x7BBBC6D5B4")]
		public UIMapModeItemController()
		{
		}

		// Token: 0x040099D5 RID: 39381
		[Token(Token = "0x40099D5")]
		[FieldOffset(Offset = "0x58")]
		private UIMapModeItemView m_View;

		// Token: 0x040099D6 RID: 39382
		[Token(Token = "0x40099D6")]
		[FieldOffset(Offset = "0x60")]
		private UIModelMapOpeningInfo m_ModelMap;

		// Token: 0x040099D7 RID: 39383
		[Token(Token = "0x40099D7")]
		[FieldOffset(Offset = "0x68")]
		private MapModeData m_MapModeData;

		// Token: 0x040099D8 RID: 39384
		[Token(Token = "0x40099D8")]
		[FieldOffset(Offset = "0x70")]
		private UIRankGuideController m_GuideCtrl;

		// Token: 0x040099D9 RID: 39385
		[Token(Token = "0x40099D9")]
		[FieldOffset(Offset = "0x78")]
		private UIModelLadderMatch m_ladderModel;

		// Token: 0x040099DA RID: 39386
		[Token(Token = "0x40099DA")]
		[FieldOffset(Offset = "0x80")]
		private UIModelChampionship m_ModelChampionship;
	}
}
