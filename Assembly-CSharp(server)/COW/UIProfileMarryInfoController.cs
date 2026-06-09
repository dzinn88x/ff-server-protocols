using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B29 RID: 6953
	[Token(Token = "0x2001B29")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F95FC", Offset = "0x10F95FC")]
	public class UIProfileMarryInfoController : UIBaseController
	{
		// Token: 0x060094FF RID: 38143 RVA: 0x00027600 File Offset: 0x00025800
		[Token(Token = "0x60094FF")]
		[Address(RVA = "0x1FE28DC", Offset = "0x1FE28DC", VA = "0x7BBC7E28DC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009500 RID: 38144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009500")]
		[Address(RVA = "0x1FE292C", Offset = "0x1FE292C", VA = "0x7BBC7E292C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009501 RID: 38145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009501")]
		[Address(RVA = "0x1FE2A10", Offset = "0x1FE2A10", VA = "0x7BBC7E2A10")]
		public void SetDepth(int depth)
		{
		}

		// Token: 0x06009502 RID: 38146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009502")]
		[Address(RVA = "0x1FE2AEC", Offset = "0x1FE2AEC", VA = "0x7BBC7E2AEC")]
		private void OnCloseBtn()
		{
		}

		// Token: 0x06009503 RID: 38147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009503")]
		[Address(RVA = "0x1FE2AF4", Offset = "0x1FE2AF4", VA = "0x7BBC7E2AF4")]
		public void RefreshData()
		{
		}

		// Token: 0x06009504 RID: 38148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009504")]
		[Address(RVA = "0x1FE2AF8", Offset = "0x1FE2AF8", VA = "0x7BBC7E2AF8")]
		public UIProfileMarryInfoController()
		{
		}

		// Token: 0x04009E5E RID: 40542
		[Token(Token = "0x4009E5E")]
		[FieldOffset(Offset = "0x58")]
		private UIProfileMarryInfoPanelView m_View;
	}
}
