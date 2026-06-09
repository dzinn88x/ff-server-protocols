using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020013D5 RID: 5077
	[Token(Token = "0x20013D5")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC038", Offset = "0x10EC038")]
	public class UISuperFighterRuleWndController : UIPopupWindowController
	{
		// Token: 0x06005337 RID: 21303 RVA: 0x00018E10 File Offset: 0x00017010
		[Token(Token = "0x6005337")]
		[Address(RVA = "0x1F4EE14", Offset = "0x1F4EE14", VA = "0x7BBC74EE14")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005338 RID: 21304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005338")]
		[Address(RVA = "0x1F4EE64", Offset = "0x1F4EE64", VA = "0x7BBC74EE64", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005339 RID: 21305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005339")]
		[Address(RVA = "0x1F4EF50", Offset = "0x1F4EF50", VA = "0x7BBC74EF50", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x0600533A RID: 21306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600533A")]
		[Address(RVA = "0x1F4F0E0", Offset = "0x1F4F0E0", VA = "0x7BBC74F0E0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600533B RID: 21307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600533B")]
		[Address(RVA = "0x1F4EF78", Offset = "0x1F4EF78", VA = "0x7BBC74EF78")]
		private void SetView()
		{
		}

		// Token: 0x0600533C RID: 21308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600533C")]
		[Address(RVA = "0x1F4F0E8", Offset = "0x1F4F0E8", VA = "0x7BBC74F0E8")]
		public UISuperFighterRuleWndController()
		{
		}

		// Token: 0x040078EE RID: 30958
		[Token(Token = "0x40078EE")]
		[FieldOffset(Offset = "0x98")]
		private UISuperFighterRuleWndView m_View;

		// Token: 0x040078EF RID: 30959
		[Token(Token = "0x40078EF")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelSuperFighter m_ModelSuperFighter;

		// Token: 0x040078F0 RID: 30960
		[Token(Token = "0x40078F0")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelBigEvent m_ModelBigEvent;
	}
}
