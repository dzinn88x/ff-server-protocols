using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BB8 RID: 7096
	[Token(Token = "0x2001BB8")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FAB2C", Offset = "0x10FAB2C")]
	public class UITrialCdkeyPopupWindowController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06009955 RID: 39253 RVA: 0x000285C0 File Offset: 0x000267C0
		[Token(Token = "0x6009955")]
		[Address(RVA = "0x19F2E88", Offset = "0x19F2E88", VA = "0x7BBC1F2E88")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009956 RID: 39254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009956")]
		[Address(RVA = "0x19F2ED8", Offset = "0x19F2ED8", VA = "0x7BBC1F2ED8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009957 RID: 39255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009957")]
		[Address(RVA = "0x19F3028", Offset = "0x19F3028", VA = "0x7BBC1F3028", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06009958 RID: 39256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009958")]
		[Address(RVA = "0x19F30DC", Offset = "0x19F30DC", VA = "0x7BBC1F30DC")]
		private void OnConfirmClick()
		{
		}

		// Token: 0x06009959 RID: 39257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009959")]
		[Address(RVA = "0x19F3360", Offset = "0x19F3360", VA = "0x7BBC1F3360", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600995A RID: 39258 RVA: 0x000285D8 File Offset: 0x000267D8
		[Token(Token = "0x600995A")]
		[Address(RVA = "0x19F36C0", Offset = "0x19F36C0", VA = "0x7BBC1F36C0", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600995B RID: 39259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600995B")]
		[Address(RVA = "0x19F3704", Offset = "0x19F3704", VA = "0x7BBC1F3704")]
		public UITrialCdkeyPopupWindowController()
		{
		}

		// Token: 0x0400A0B0 RID: 41136
		[Token(Token = "0x400A0B0")]
		[FieldOffset(Offset = "0x98")]
		private UITrialCdkeyPopupWindowView m_View;

		// Token: 0x0400A0B1 RID: 41137
		[Token(Token = "0x400A0B1")]
		[FieldOffset(Offset = "0xA0")]
		private string websiteUrl;
	}
}
