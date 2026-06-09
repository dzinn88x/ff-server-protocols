using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001B34 RID: 6964
	[Token(Token = "0x2001B34")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F975C", Offset = "0x10F975C")]
	public class UIProfileTrendItemController : UIBaseController
	{
		// Token: 0x06009581 RID: 38273 RVA: 0x000278A0 File Offset: 0x00025AA0
		[Token(Token = "0x6009581")]
		[Address(RVA = "0x1FF2594", Offset = "0x1FF2594", VA = "0x7BBC7F2594")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009582 RID: 38274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009582")]
		[Address(RVA = "0x1FF25E4", Offset = "0x1FF25E4", VA = "0x7BBC7F25E4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009583 RID: 38275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009583")]
		[Address(RVA = "0x1FF26C8", Offset = "0x1FF26C8", VA = "0x7BBC7F26C8")]
		public void RefreshTrendItemUI(AccountNews news, uint id = 0U)
		{
		}

		// Token: 0x06009584 RID: 38276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009584")]
		[Address(RVA = "0x1FF2D48", Offset = "0x1FF2D48", VA = "0x7BBC7F2D48")]
		private void DisableAllIcon()
		{
		}

		// Token: 0x06009585 RID: 38277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009585")]
		[Address(RVA = "0x1FF2C88", Offset = "0x1FF2C88", VA = "0x7BBC7F2C88")]
		private void RefreshTrendTypeText(EAccount.NewsType type)
		{
		}

		// Token: 0x06009586 RID: 38278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009586")]
		[Address(RVA = "0x1FF2EC8", Offset = "0x1FF2EC8", VA = "0x7BBC7F2EC8")]
		private void OnItemClickBtn()
		{
		}

		// Token: 0x06009587 RID: 38279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009587")]
		[Address(RVA = "0x1FF30A4", Offset = "0x1FF30A4", VA = "0x7BBC7F30A4")]
		public void RefreshVisible(bool flag)
		{
		}

		// Token: 0x06009588 RID: 38280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009588")]
		[Address(RVA = "0x1FF30EC", Offset = "0x1FF30EC", VA = "0x7BBC7F30EC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009589 RID: 38281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009589")]
		[Address(RVA = "0x1FF30F4", Offset = "0x1FF30F4", VA = "0x7BBC7F30F4", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x0600958A RID: 38282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600958A")]
		[Address(RVA = "0x1FF30FC", Offset = "0x1FF30FC", VA = "0x7BBC7F30FC")]
		public UIProfileTrendItemController()
		{
		}

		// Token: 0x04009EAB RID: 40619
		[Token(Token = "0x4009EAB")]
		[FieldOffset(Offset = "0x58")]
		private UIProfileTrendItemView m_View;

		// Token: 0x04009EAC RID: 40620
		[Token(Token = "0x4009EAC")]
		[FieldOffset(Offset = "0x60")]
		private EAccount.NewsType m_Newtype;

		// Token: 0x04009EAD RID: 40621
		[Token(Token = "0x4009EAD")]
		[FieldOffset(Offset = "0x64")]
		private uint itemid;

		// Token: 0x04009EAE RID: 40622
		[Token(Token = "0x4009EAE")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<EAccount.NewsType, string> ProfileTrendType2Descrption;
	}
}
