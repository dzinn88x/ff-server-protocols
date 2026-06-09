using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001847 RID: 6215
	[Token(Token = "0x2001847")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3B1C", Offset = "0x10F3B1C")]
	internal class UIGameModeClassicMapListController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x060079C7 RID: 31175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079C7")]
		[Address(RVA = "0x200386C", Offset = "0x200386C", VA = "0x7BBC80386C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060079C8 RID: 31176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079C8")]
		[Address(RVA = "0x2003B7C", Offset = "0x2003B7C", VA = "0x7BBC803B7C", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x060079C9 RID: 31177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079C9")]
		[Address(RVA = "0x2003D3C", Offset = "0x2003D3C", VA = "0x7BBC803D3C")]
		private void RefreshDownloader(params object[] data)
		{
		}

		// Token: 0x060079CA RID: 31178 RVA: 0x000217F8 File Offset: 0x0001F9F8
		[Token(Token = "0x60079CA")]
		[Address(RVA = "0x2003F88", Offset = "0x2003F88", VA = "0x7BBC803F88")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060079CB RID: 31179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079CB")]
		[Address(RVA = "0x2003FD8", Offset = "0x2003FD8", VA = "0x7BBC803FD8")]
		private void OnChooseMapSuccess(params object[] data)
		{
		}

		// Token: 0x060079CC RID: 31180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079CC")]
		[Address(RVA = "0x2004128", Offset = "0x2004128", VA = "0x7BBC804128")]
		public void TweenAnimParaise()
		{
		}

		// Token: 0x060079CD RID: 31181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079CD")]
		[Address(RVA = "0x200412C", Offset = "0x200412C", VA = "0x7BBC80412C")]
		public void TweenAnimAzore()
		{
		}

		// Token: 0x060079CE RID: 31182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079CE")]
		[Address(RVA = "0x2002260", Offset = "0x2002260", VA = "0x7BBC802260")]
		public void SetUIData(List<MapModeData> dataList)
		{
		}

		// Token: 0x060079CF RID: 31183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079CF")]
		[Address(RVA = "0x2003E5C", Offset = "0x2003E5C", VA = "0x7BBC803E5C")]
		private void updateDownloadList()
		{
		}

		// Token: 0x060079D0 RID: 31184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079D0")]
		[Address(RVA = "0x2004130", Offset = "0x2004130", VA = "0x7BBC804130")]
		public void OnDisable()
		{
		}

		// Token: 0x060079D1 RID: 31185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079D1")]
		[Address(RVA = "0x2004134", Offset = "0x2004134", VA = "0x7BBC804134")]
		public void ResetTween()
		{
		}

		// Token: 0x060079D2 RID: 31186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079D2")]
		[Address(RVA = "0x2004138", Offset = "0x2004138", VA = "0x7BBC804138")]
		private void OnParadiseBtnClick()
		{
		}

		// Token: 0x060079D3 RID: 31187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079D3")]
		[Address(RVA = "0x200468C", Offset = "0x200468C", VA = "0x7BBC80468C")]
		private void OnAzoreBtnClick()
		{
		}

		// Token: 0x060079D4 RID: 31188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079D4")]
		[Address(RVA = "0x2004874", Offset = "0x2004874", VA = "0x7BBC804874", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060079D5 RID: 31189 RVA: 0x00021810 File Offset: 0x0001FA10
		[Token(Token = "0x60079D5")]
		[Address(RVA = "0x2004998", Offset = "0x2004998", VA = "0x7BBC804998", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060079D6 RID: 31190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079D6")]
		[Address(RVA = "0x20049DC", Offset = "0x20049DC", VA = "0x7BBC8049DC")]
		public UIGameModeClassicMapListController()
		{
		}

		// Token: 0x060079D7 RID: 31191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079D7")]
		[Address(RVA = "0x2004A74", Offset = "0x2004A74", VA = "0x7BBC804A74")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114224C", Offset = "0x114224C")]
		private void <OnParadiseBtnClick>b__18_0()
		{
		}

		// Token: 0x060079D8 RID: 31192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079D8")]
		[Address(RVA = "0x2004B4C", Offset = "0x2004B4C", VA = "0x7BBC804B4C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114225C", Offset = "0x114225C")]
		private void <OnAzoreBtnClick>b__19_0()
		{
		}

		// Token: 0x04008EE7 RID: 36583
		[Token(Token = "0x4008EE7")]
		[FieldOffset(Offset = "0x58")]
		private UIGameModeClassicMapListView m_View;

		// Token: 0x04008EE8 RID: 36584
		[Token(Token = "0x4008EE8")]
		[FieldOffset(Offset = "0x60")]
		private MapModeData m_SelectedMapData;

		// Token: 0x04008EE9 RID: 36585
		[Token(Token = "0x4008EE9")]
		[FieldOffset(Offset = "0x68")]
		private UIModelMapOpeningInfo m_ModelMap;

		// Token: 0x04008EEA RID: 36586
		[Token(Token = "0x4008EEA")]
		[FieldOffset(Offset = "0x70")]
		private List<MapModeData> m_MapModeList;

		// Token: 0x04008EEB RID: 36587
		[Token(Token = "0x4008EEB")]
		[FieldOffset(Offset = "0x78")]
		private uint m_DelayCallAzore;

		// Token: 0x04008EEC RID: 36588
		[Token(Token = "0x4008EEC")]
		[FieldOffset(Offset = "0x80")]
		protected List<ResourceID> m_NeedDownloadRes;

		// Token: 0x04008EED RID: 36589
		[Token(Token = "0x4008EED")]
		[FieldOffset(Offset = "0x88")]
		private UICommonOptionalDownloaderController m_DownloaderCtrl;
	}
}
