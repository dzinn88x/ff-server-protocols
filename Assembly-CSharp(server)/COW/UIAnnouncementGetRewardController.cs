using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020016A3 RID: 5795
	[Token(Token = "0x20016A3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F07D4", Offset = "0x10F07D4")]
	public class UIAnnouncementGetRewardController : UIPopupWindowController
	{
		// Token: 0x06006992 RID: 27026 RVA: 0x0001DEB0 File Offset: 0x0001C0B0
		[Token(Token = "0x6006992")]
		[Address(RVA = "0x1B118AC", Offset = "0x1B118AC", VA = "0x7BBC3118AC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006993 RID: 27027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006993")]
		[Address(RVA = "0x1B118FC", Offset = "0x1B118FC", VA = "0x7BBC3118FC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006994 RID: 27028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006994")]
		[Address(RVA = "0x1B11CFC", Offset = "0x1B11CFC", VA = "0x7BBC311CFC", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06006995 RID: 27029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006995")]
		[Address(RVA = "0x1B11D78", Offset = "0x1B11D78", VA = "0x7BBC311D78")]
		public void ShowAwardList(List<BaseItemInfo> infoList, [Optional] string reward_title, [Optional] RewardBtn btn_data, [Optional] string transfer_hint)
		{
		}

		// Token: 0x06006996 RID: 27030 RVA: 0x0001DEC8 File Offset: 0x0001C0C8
		[Token(Token = "0x6006996")]
		[Address(RVA = "0x1B12BC0", Offset = "0x1B12BC0", VA = "0x7BBC312BC0")]
		private bool IsCanEquip(uint itemId)
		{
			return default(bool);
		}

		// Token: 0x06006997 RID: 27031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006997")]
		[Address(RVA = "0x1B12840", Offset = "0x1B12840", VA = "0x7BBC312840")]
		private void SetEquipBtnStats(List<UIAwardItemController> awardList)
		{
		}

		// Token: 0x06006998 RID: 27032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006998")]
		[Address(RVA = "0x1B12420", Offset = "0x1B12420", VA = "0x7BBC312420")]
		private void SetEquipToggleStats(List<UIAwardItemController> awardList)
		{
		}

		// Token: 0x06006999 RID: 27033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006999")]
		[Address(RVA = "0x1B12CDC", Offset = "0x1B12CDC", VA = "0x7BBC312CDC")]
		private void OnFastEquipClick()
		{
		}

		// Token: 0x0600699A RID: 27034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600699A")]
		[Address(RVA = "0x1B137BC", Offset = "0x1B137BC", VA = "0x7BBC3137BC")]
		private void OnOKBtnClick()
		{
		}

		// Token: 0x0600699B RID: 27035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600699B")]
		[Address(RVA = "0x1B1380C", Offset = "0x1B1380C", VA = "0x7BBC31380C")]
		private void OnBannerEquipResult(params object[] data)
		{
		}

		// Token: 0x0600699C RID: 27036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600699C")]
		[Address(RVA = "0x1B13CA8", Offset = "0x1B13CA8", VA = "0x7BBC313CA8")]
		private void OnHeadPicEquipResult(params object[] data)
		{
		}

		// Token: 0x0600699D RID: 27037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600699D")]
		[Address(RVA = "0x1B13CAC", Offset = "0x1B13CAC", VA = "0x7BBC313CAC")]
		private void OnCommonEquipResult(params object[] data)
		{
		}

		// Token: 0x0600699E RID: 27038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600699E")]
		[Address(RVA = "0x1B13F80", Offset = "0x1B13F80", VA = "0x7BBC313F80")]
		private void OnClothEquipResult(params object[] data)
		{
		}

		// Token: 0x0600699F RID: 27039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600699F")]
		[Address(RVA = "0x1B139EC", Offset = "0x1B139EC", VA = "0x7BBC3139EC")]
		private void OnEquipSuccess()
		{
		}

		// Token: 0x060069A0 RID: 27040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069A0")]
		[Address(RVA = "0x1B13B70", Offset = "0x1B13B70", VA = "0x7BBC313B70")]
		private void OnEquipFail()
		{
		}

		// Token: 0x060069A1 RID: 27041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069A1")]
		[Address(RVA = "0x1B13F84", Offset = "0x1B13F84", VA = "0x7BBC313F84")]
		private void AutoClose()
		{
		}

		// Token: 0x060069A2 RID: 27042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069A2")]
		[Address(RVA = "0x1B1404C", Offset = "0x1B1404C", VA = "0x7BBC31404C")]
		private void OnGoToSharePreviewClick()
		{
		}

		// Token: 0x060069A3 RID: 27043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069A3")]
		[Address(RVA = "0x1B141F8", Offset = "0x1B141F8", VA = "0x7BBC3141F8", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060069A4 RID: 27044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069A4")]
		[Address(RVA = "0x1B142A4", Offset = "0x1B142A4", VA = "0x7BBC3142A4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060069A5 RID: 27045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069A5")]
		[Address(RVA = "0x1B144D4", Offset = "0x1B144D4", VA = "0x7BBC3144D4")]
		public UIAnnouncementGetRewardController()
		{
		}

		// Token: 0x04008666 RID: 34406
		[Token(Token = "0x4008666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private UIAnnouncementGetRewardViewExt m_View;

		// Token: 0x04008667 RID: 34407
		[Token(Token = "0x4008667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RewardBtn m_BtnData;

		// Token: 0x04008668 RID: 34408
		[Token(Token = "0x4008668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Dictionary<int, UIAwardItemController> m_SelectedDict;

		// Token: 0x04008669 RID: 34409
		[Token(Token = "0x4008669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int m_EquippedSuccessNum;

		// Token: 0x0400866A RID: 34410
		[Token(Token = "0x400866A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private bool m_HaveShowFailTip;

		// Token: 0x0400866B RID: 34411
		[Token(Token = "0x400866B")]
		private const float m_AutoCloseSecond = 1f;

		// Token: 0x0400866C RID: 34412
		[Token(Token = "0x400866C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private uint m_AutoCloseDC;

		// Token: 0x0400866D RID: 34413
		[Token(Token = "0x400866D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private bool m_EnableOKBtn;

		// Token: 0x0400866E RID: 34414
		[Token(Token = "0x400866E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private uint previewItemID;

		// Token: 0x0400866F RID: 34415
		[Token(Token = "0x400866F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int quality;
	}
}
