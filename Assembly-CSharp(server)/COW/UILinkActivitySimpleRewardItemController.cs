using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001556 RID: 5462
	[Token(Token = "0x2001556")]
	public abstract class UILinkActivitySimpleRewardItemController : UIBaseController, ISetBaseItemInfo
	{
		// Token: 0x06005E7A RID: 24186 RVA: 0x0001B5B8 File Offset: 0x000197B8
		[Token(Token = "0x6005E7A")]
		[Address(RVA = "0x1CC2360", Offset = "0x1CC2360", VA = "0x7BBC4C2360")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005E7B RID: 24187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E7B")]
		[Address(RVA = "0x1CC23C8", Offset = "0x1CC23C8", VA = "0x7BBC4C23C8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005E7C RID: 24188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E7C")]
		[Address(RVA = "0x1CC242C", Offset = "0x1CC242C", VA = "0x7BBC4C242C", Slot = "28")]
		public void SetBaseItemInfo(BaseItemInfo data)
		{
		}

		// Token: 0x06005E7D RID: 24189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E7D")]
		[Address(RVA = "0x1CC2434", Offset = "0x1CC2434", VA = "0x7BBC4C2434")]
		private void RefreshUI()
		{
		}

		// Token: 0x06005E7E RID: 24190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E7E")]
		[Address(RVA = "0x1CB8E04", Offset = "0x1CB8E04", VA = "0x7BBC4B8E04")]
		public void TintIconColor(uint val)
		{
		}

		// Token: 0x06005E7F RID: 24191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E7F")]
		[Address(RVA = "0x1CC24A4", Offset = "0x1CC24A4", VA = "0x7BBC4C24A4")]
		private void OnRewardBtnClick()
		{
		}

		// Token: 0x06005E80 RID: 24192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E80")]
		[Address(RVA = "0x1CB926C", Offset = "0x1CB926C", VA = "0x7BBC4B926C")]
		protected UILinkActivitySimpleRewardItemController()
		{
		}

		// Token: 0x04007FC3 RID: 32707
		[Token(Token = "0x4007FC3")]
		[FieldOffset(Offset = "0x58")]
		private UILinkActivitySimpleRewardItemView m_View;

		// Token: 0x04007FC4 RID: 32708
		[Token(Token = "0x4007FC4")]
		[FieldOffset(Offset = "0x60")]
		private BaseItemInfo m_Data;
	}
}
