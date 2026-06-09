using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001A3A RID: 6714
	[Token(Token = "0x2001A3A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7CC4", Offset = "0x10F7CC4")]
	public class UIManualController : UINavigationController, IUIModelDataChangeObserver
	{
		// Token: 0x06008D04 RID: 36100 RVA: 0x000259B0 File Offset: 0x00023BB0
		[Token(Token = "0x6008D04")]
		[Address(RVA = "0x1DF5DFC", Offset = "0x1DF5DFC", VA = "0x7BBC5F5DFC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008D05 RID: 36101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D05")]
		[Address(RVA = "0x1DF5E4C", Offset = "0x1DF5E4C", VA = "0x7BBC5F5E4C", Slot = "39")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008D06 RID: 36102 RVA: 0x000259C8 File Offset: 0x00023BC8
		[Token(Token = "0x6008D06")]
		[Address(RVA = "0x1DF6084", Offset = "0x1DF6084", VA = "0x7BBC5F6084", Slot = "40")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008D07 RID: 36103 RVA: 0x000259E0 File Offset: 0x00023BE0
		[Token(Token = "0x6008D07")]
		[Address(RVA = "0x1DF60C8", Offset = "0x1DF60C8", VA = "0x7BBC5F60C8", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x06008D08 RID: 36104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D08")]
		[Address(RVA = "0x1DF60D0", Offset = "0x1DF60D0", VA = "0x7BBC5F60D0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008D09 RID: 36105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D09")]
		[Address(RVA = "0x1DF6F50", Offset = "0x1DF6F50", VA = "0x7BBC5F6F50", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008D0A RID: 36106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D0A")]
		[Address(RVA = "0x1DF7094", Offset = "0x1DF7094", VA = "0x7BBC5F7094")]
		private void UpdateAnim()
		{
		}

		// Token: 0x06008D0B RID: 36107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D0B")]
		[Address(RVA = "0x1DF6004", Offset = "0x1DF6004", VA = "0x7BBC5F6004")]
		private void TryRefreshScene()
		{
		}

		// Token: 0x06008D0C RID: 36108 RVA: 0x000259F8 File Offset: 0x00023BF8
		[Token(Token = "0x6008D0C")]
		[Address(RVA = "0x1DF72DC", Offset = "0x1DF72DC", VA = "0x7BBC5F72DC")]
		public int GetActiveTabIndex()
		{
			return 0;
		}

		// Token: 0x06008D0D RID: 36109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D0D")]
		[Address(RVA = "0x1DF730C", Offset = "0x1DF730C", VA = "0x7BBC5F730C")]
		public void CreateContent(UIManualDataBase data)
		{
		}

		// Token: 0x06008D0E RID: 36110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008D0E")]
		[Address(RVA = "0x1DF78E4", Offset = "0x1DF78E4", VA = "0x7BBC5F78E4")]
		public UIManualContentBaseController OpenManualContent(EManual.EventType manualType)
		{
			return null;
		}

		// Token: 0x06008D0F RID: 36111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D0F")]
		[Address(RVA = "0x1DF64E0", Offset = "0x1DF64E0", VA = "0x7BBC5F64E0")]
		private void InitAnim()
		{
		}

		// Token: 0x06008D10 RID: 36112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D10")]
		[Address(RVA = "0x1DF7AB0", Offset = "0x1DF7AB0", VA = "0x7BBC5F7AB0")]
		public void PlayAnim(params object[] parameters)
		{
		}

		// Token: 0x06008D11 RID: 36113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D11")]
		[Address(RVA = "0x1DF7098", Offset = "0x1DF7098", VA = "0x7BBC5F7098")]
		private void DoFlipAnim()
		{
		}

		// Token: 0x06008D12 RID: 36114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D12")]
		[Address(RVA = "0x1DF7BA0", Offset = "0x1DF7BA0", VA = "0x7BBC5F7BA0", Slot = "23")]
		public override void BeforeScreenshot()
		{
		}

		// Token: 0x06008D13 RID: 36115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D13")]
		[Address(RVA = "0x1DF7BCC", Offset = "0x1DF7BCC", VA = "0x7BBC5F7BCC", Slot = "24")]
		public override void AfterScreenshot()
		{
		}

		// Token: 0x06008D14 RID: 36116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D14")]
		[Address(RVA = "0x1DF7BF8", Offset = "0x1DF7BF8", VA = "0x7BBC5F7BF8", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x06008D15 RID: 36117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D15")]
		[Address(RVA = "0x1DF7C04", Offset = "0x1DF7C04", VA = "0x7BBC5F7C04", Slot = "29")]
		public override void OnNavigationClosed()
		{
		}

		// Token: 0x06008D16 RID: 36118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D16")]
		[Address(RVA = "0x1DF672C", Offset = "0x1DF672C", VA = "0x7BBC5F672C")]
		private void SetShareUIVisiable(bool v)
		{
		}

		// Token: 0x06008D17 RID: 36119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D17")]
		[Address(RVA = "0x1DF7C0C", Offset = "0x1DF7C0C", VA = "0x7BBC5F7C0C")]
		private void OnClickShare()
		{
		}

		// Token: 0x06008D18 RID: 36120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D18")]
		[Address(RVA = "0x1DF7D1C", Offset = "0x1DF7D1C", VA = "0x7BBC5F7D1C")]
		private void OnClickMoreInfo()
		{
		}

		// Token: 0x06008D19 RID: 36121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D19")]
		[Address(RVA = "0x1DF7E68", Offset = "0x1DF7E68", VA = "0x7BBC5F7E68")]
		public void OnClickHelp()
		{
		}

		// Token: 0x06008D1A RID: 36122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D1A")]
		[Address(RVA = "0x1DF7ED0", Offset = "0x1DF7ED0", VA = "0x7BBC5F7ED0")]
		public UIManualController()
		{
		}

		// Token: 0x04009936 RID: 39222
		[Token(Token = "0x4009936")]
		[FieldOffset(Offset = "0xB0")]
		private UIManualView m_View;

		// Token: 0x04009937 RID: 39223
		[Token(Token = "0x4009937")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelManual m_ModelManual;

		// Token: 0x04009938 RID: 39224
		[Token(Token = "0x4009938")]
		[FieldOffset(Offset = "0xC0")]
		private UIManualContentBaseController m_CurContent;

		// Token: 0x04009939 RID: 39225
		[Token(Token = "0x4009939")]
		[FieldOffset(Offset = "0xC8")]
		private Dictionary<int, UIManualContentBaseController> m_ContentDict;

		// Token: 0x0400993A RID: 39226
		[Token(Token = "0x400993A")]
		[FieldOffset(Offset = "0xD0")]
		private List<UISprite> m_AnimList;

		// Token: 0x0400993B RID: 39227
		[Token(Token = "0x400993B")]
		[FieldOffset(Offset = "0xD8")]
		private int m_AnimIdx;

		// Token: 0x0400993C RID: 39228
		[Token(Token = "0x400993C")]
		[FieldOffset(Offset = "0xDC")]
		private bool m_EnableAnim;

		// Token: 0x0400993D RID: 39229
		[Token(Token = "0x400993D")]
		[FieldOffset(Offset = "0xDD")]
		private bool m_ReverseAnim;

		// Token: 0x0400993E RID: 39230
		[Token(Token = "0x400993E")]
		[FieldOffset(Offset = "0xE0")]
		private uint m_AnimDelayCall;

		// Token: 0x0400993F RID: 39231
		[Token(Token = "0x400993F")]
		[FieldOffset(Offset = "0xE8")]
		public UIManualMainTabController m_ManualTabCtrl;

		// Token: 0x04009940 RID: 39232
		[Token(Token = "0x4009940")]
		[FieldOffset(Offset = "0xF0")]
		private UIStandardDrawerTabController m_DrawerTabCtrl;
	}
}
