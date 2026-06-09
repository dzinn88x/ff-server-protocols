using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020016ED RID: 5869
	[Token(Token = "0x20016ED")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F10A4", Offset = "0x10F10A4")]
	internal class UIBriefProfileInfoController : UIBaseController
	{
		// Token: 0x06006CD6 RID: 27862 RVA: 0x0001EB40 File Offset: 0x0001CD40
		[Token(Token = "0x6006CD6")]
		[Address(RVA = "0x1C1B8EC", Offset = "0x1C1B8EC", VA = "0x7BBC41B8EC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006CD7 RID: 27863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CD7")]
		[Address(RVA = "0x1C1B93C", Offset = "0x1C1B93C", VA = "0x7BBC41B93C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006CD8 RID: 27864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CD8")]
		[Address(RVA = "0x1C1BAD4", Offset = "0x1C1BAD4", VA = "0x7BBC41BAD4")]
		private void OnBtnPinClick()
		{
		}

		// Token: 0x06006CD9 RID: 27865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CD9")]
		[Address(RVA = "0x1C1BBF4", Offset = "0x1C1BBF4", VA = "0x7BBC41BBF4")]
		public void UpdateNickName(string nickname)
		{
		}

		// Token: 0x06006CDA RID: 27866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CDA")]
		[Address(RVA = "0x1C1BCC0", Offset = "0x1C1BCC0", VA = "0x7BBC41BCC0")]
		public void SetUIData(BaseProfileInfo info, uint showState = 0U)
		{
		}

		// Token: 0x06006CDB RID: 27867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CDB")]
		[Address(RVA = "0x1C1C0E4", Offset = "0x1C1C0E4", VA = "0x7BBC41C0E4")]
		public void UpdatePin(uint pinId)
		{
		}

		// Token: 0x06006CDC RID: 27868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CDC")]
		[Address(RVA = "0x1C1C250", Offset = "0x1C1C250", VA = "0x7BBC41C250")]
		public UISprite GetPinIcon()
		{
			return null;
		}

		// Token: 0x06006CDD RID: 27869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CDD")]
		[Address(RVA = "0x1C1C28C", Offset = "0x1C1C28C", VA = "0x7BBC41C28C")]
		public void UpdateBanner(ResourceID resId)
		{
		}

		// Token: 0x06006CDE RID: 27870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CDE")]
		[Address(RVA = "0x1C1C054", Offset = "0x1C1C054", VA = "0x7BBC41C054")]
		public void ResetBanner()
		{
		}

		// Token: 0x06006CDF RID: 27871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CDF")]
		[Address(RVA = "0x1C1C390", Offset = "0x1C1C390", VA = "0x7BBC41C390")]
		public UIBriefProfileInfoController()
		{
		}

		// Token: 0x04008852 RID: 34898
		[Token(Token = "0x4008852")]
		[FieldOffset(Offset = "0x58")]
		private UIBriefProfileInfoView m_View;

		// Token: 0x04008853 RID: 34899
		[Token(Token = "0x4008853")]
		[FieldOffset(Offset = "0x60")]
		private BaseItemInfo m_PinItemInfo;

		// Token: 0x04008854 RID: 34900
		[Token(Token = "0x4008854")]
		[FieldOffset(Offset = "0x68")]
		private AutoChangeComp m_AutoChangeComp;
	}
}
