using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A1D RID: 6685
	[Token(Token = "0x2001A1D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F78A4", Offset = "0x10F78A4")]
	public class UILobbyOptionalDownloaderController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06008BE8 RID: 35816 RVA: 0x000255F0 File Offset: 0x000237F0
		[Token(Token = "0x6008BE8")]
		[Address(RVA = "0x19D8704", Offset = "0x19D8704", VA = "0x7BBC1D8704")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008BE9 RID: 35817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008BE9")]
		[Address(RVA = "0x19D8754", Offset = "0x19D8754", VA = "0x7BBC1D8754", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008BEA RID: 35818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008BEA")]
		[Address(RVA = "0x19D8C58", Offset = "0x19D8C58", VA = "0x7BBC1D8C58", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008BEB RID: 35819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008BEB")]
		[Address(RVA = "0x19D8BF8", Offset = "0x19D8BF8", VA = "0x7BBC1D8BF8")]
		public void UpdateContentVisible(bool is_visible)
		{
		}

		// Token: 0x06008BEC RID: 35820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008BEC")]
		[Address(RVA = "0x19D8D98", Offset = "0x19D8D98", VA = "0x7BBC1D8D98")]
		private void Update()
		{
		}

		// Token: 0x06008BED RID: 35821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008BED")]
		[Address(RVA = "0x19D8E8C", Offset = "0x19D8E8C", VA = "0x7BBC1D8E8C")]
		private void LateUpdate()
		{
		}

		// Token: 0x06008BEE RID: 35822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008BEE")]
		[Address(RVA = "0x19D91C0", Offset = "0x19D91C0", VA = "0x7BBC1D91C0")]
		private void EnqueueTips(string info, bool need_btn_group, [Optional] Action comfirm_call_back)
		{
		}

		// Token: 0x06008BEF RID: 35823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008BEF")]
		[Address(RVA = "0x19D9268", Offset = "0x19D9268", VA = "0x7BBC1D9268")]
		private void ShowTips(string info, bool need_btn_group, [Optional] Action comfirm_call_back)
		{
		}

		// Token: 0x06008BF0 RID: 35824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008BF0")]
		[Address(RVA = "0x19D94F0", Offset = "0x19D94F0", VA = "0x7BBC1D94F0")]
		private void OnControlBtnClick()
		{
		}

		// Token: 0x06008BF1 RID: 35825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008BF1")]
		[Address(RVA = "0x19D8BA8", Offset = "0x19D8BA8", VA = "0x7BBC1D8BA8")]
		private void CloseTips()
		{
		}

		// Token: 0x06008BF2 RID: 35826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008BF2")]
		[Address(RVA = "0x19D9648", Offset = "0x19D9648", VA = "0x7BBC1D9648")]
		private void TipsConfirmed()
		{
		}

		// Token: 0x06008BF3 RID: 35827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008BF3")]
		[Address(RVA = "0x19D9684", Offset = "0x19D9684", VA = "0x7BBC1D9684")]
		private void OnFlyInNotify(params object[] data)
		{
		}

		// Token: 0x06008BF4 RID: 35828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008BF4")]
		[Address(RVA = "0x19D9C98", Offset = "0x19D9C98", VA = "0x7BBC1D9C98")]
		private void OnCentreVisibleChange(params object[] data)
		{
		}

		// Token: 0x06008BF5 RID: 35829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008BF5")]
		[Address(RVA = "0x19D9CD8", Offset = "0x19D9CD8", VA = "0x7BBC1D9CD8", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008BF6 RID: 35830 RVA: 0x00025608 File Offset: 0x00023808
		[Token(Token = "0x6008BF6")]
		[Address(RVA = "0x19D9EB4", Offset = "0x19D9EB4", VA = "0x7BBC1D9EB4", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008BF7 RID: 35831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008BF7")]
		[Address(RVA = "0x19D9EF8", Offset = "0x19D9EF8", VA = "0x7BBC1D9EF8")]
		public UILobbyOptionalDownloaderController()
		{
		}

		// Token: 0x06008BF8 RID: 35832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008BF8")]
		[Address(RVA = "0x19D9F70", Offset = "0x19D9F70", VA = "0x7BBC1D9F70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144264", Offset = "0x1144264")]
		private void <LateUpdate>b__13_0()
		{
		}

		// Token: 0x040098AE RID: 39086
		[Token(Token = "0x40098AE")]
		private const float CIRCLE_SPEED = 0.2f;

		// Token: 0x040098AF RID: 39087
		[Token(Token = "0x40098AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private UIModelOptionalDownload m_Model;

		// Token: 0x040098B0 RID: 39088
		[Token(Token = "0x40098B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private UILobbyOptionalDownloaderView m_View;

		// Token: 0x040098B1 RID: 39089
		[Token(Token = "0x40098B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Queue<DownLoadTipsInfo> m_TipsQueue;

		// Token: 0x040098B2 RID: 39090
		[Token(Token = "0x40098B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_isShowTips;

		// Token: 0x040098B3 RID: 39091
		[Token(Token = "0x40098B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool m_ContentShow;

		// Token: 0x040098B4 RID: 39092
		[Token(Token = "0x40098B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
		private bool m_NeedCheckTips;

		// Token: 0x040098B5 RID: 39093
		[Token(Token = "0x40098B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Action m_ComfirmCallBack;
	}
}
