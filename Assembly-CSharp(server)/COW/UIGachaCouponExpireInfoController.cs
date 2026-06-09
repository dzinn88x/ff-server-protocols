using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001835 RID: 6197
	[Token(Token = "0x2001835")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3864", Offset = "0x10F3864")]
	public class UIGachaCouponExpireInfoController : UIPopupWindowController, IEasyList
	{
		// Token: 0x0600792C RID: 31020 RVA: 0x00021588 File Offset: 0x0001F788
		[Token(Token = "0x600792C")]
		[Address(RVA = "0x215F1D4", Offset = "0x215F1D4", VA = "0x7BBC95F1D4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600792D RID: 31021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600792D")]
		[Address(RVA = "0x215F224", Offset = "0x215F224", VA = "0x7BBC95F224", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600792E RID: 31022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600792E")]
		[Address(RVA = "0x215F5F8", Offset = "0x215F5F8", VA = "0x7BBC95F5F8")]
		private void OnBtnClick()
		{
		}

		// Token: 0x0600792F RID: 31023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600792F")]
		[Address(RVA = "0x215F620", Offset = "0x215F620", VA = "0x7BBC95F620")]
		private void OnToggleClick()
		{
		}

		// Token: 0x06007930 RID: 31024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007930")]
		[Address(RVA = "0x215F7B8", Offset = "0x215F7B8", VA = "0x7BBC95F7B8", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06007931 RID: 31025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007931")]
		[Address(RVA = "0x215F828", Offset = "0x215F828", VA = "0x7BBC95F828", Slot = "40")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06007932 RID: 31026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007932")]
		[Address(RVA = "0x215F8BC", Offset = "0x215F8BC", VA = "0x7BBC95F8BC", Slot = "41")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06007933 RID: 31027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007933")]
		[Address(RVA = "0x215F8EC", Offset = "0x215F8EC", VA = "0x7BBC95F8EC")]
		public UIGachaCouponExpireInfoController()
		{
		}

		// Token: 0x04008EAB RID: 36523
		[Token(Token = "0x4008EAB")]
		[FieldOffset(Offset = "0x98")]
		private UIGachaCouponExpireInfoView m_View;

		// Token: 0x04008EAC RID: 36524
		[Token(Token = "0x4008EAC")]
		[FieldOffset(Offset = "0xA0")]
		private ulong m_AccountId;
	}
}
