using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001719 RID: 5913
	[Token(Token = "0x2001719")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F17A4", Offset = "0x10F17A4")]
	public class UIClanBannerController : UIPopupWindowController, IEasyList
	{
		// Token: 0x06006E46 RID: 28230 RVA: 0x0001F0E0 File Offset: 0x0001D2E0
		[Token(Token = "0x6006E46")]
		[Address(RVA = "0x1CEB4A0", Offset = "0x1CEB4A0", VA = "0x7BBC4EB4A0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006E47 RID: 28231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E47")]
		[Address(RVA = "0x1CEB4F0", Offset = "0x1CEB4F0", VA = "0x7BBC4EB4F0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006E48 RID: 28232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E48")]
		[Address(RVA = "0x1CEB73C", Offset = "0x1CEB73C", VA = "0x7BBC4EB73C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006E49 RID: 28233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E49")]
		[Address(RVA = "0x1CEB808", Offset = "0x1CEB808", VA = "0x7BBC4EB808")]
		public void SetColliderMaskAlpha()
		{
		}

		// Token: 0x06006E4A RID: 28234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E4A")]
		[Address(RVA = "0x1CEB844", Offset = "0x1CEB844", VA = "0x7BBC4EB844", Slot = "40")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06006E4B RID: 28235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E4B")]
		[Address(RVA = "0x1CEB8D8", Offset = "0x1CEB8D8", VA = "0x7BBC4EB8D8", Slot = "41")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06006E4C RID: 28236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E4C")]
		[Address(RVA = "0x1CEB908", Offset = "0x1CEB908", VA = "0x7BBC4EB908")]
		public void BannerSelectHandler(object[] args)
		{
		}

		// Token: 0x06006E4D RID: 28237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E4D")]
		[Address(RVA = "0x1CEB910", Offset = "0x1CEB910", VA = "0x7BBC4EB910")]
		public UIClanBannerController()
		{
		}

		// Token: 0x040088F1 RID: 35057
		[Token(Token = "0x40088F1")]
		[FieldOffset(Offset = "0x98")]
		private UIClanBannerView m_View;
	}
}
