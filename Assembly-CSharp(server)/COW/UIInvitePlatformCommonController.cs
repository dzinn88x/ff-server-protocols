using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020019C2 RID: 6594
	[Token(Token = "0x20019C2")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6F94", Offset = "0x10F6F94")]
	internal class UIInvitePlatformCommonController : UIPopupWindowController
	{
		// Token: 0x06008775 RID: 34677 RVA: 0x00024990 File Offset: 0x00022B90
		[Token(Token = "0x6008775")]
		[Address(RVA = "0x1929504", Offset = "0x1929504", VA = "0x7BBC129504")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008776 RID: 34678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008776")]
		[Address(RVA = "0x1929554", Offset = "0x1929554", VA = "0x7BBC129554", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008777 RID: 34679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008777")]
		[Address(RVA = "0x1929990", Offset = "0x1929990", VA = "0x7BBC129990")]
		public void SetViewData(UIUtils.ShareUrlType shareUrlType, params object[] data)
		{
		}

		// Token: 0x06008778 RID: 34680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008778")]
		[Address(RVA = "0x1929B24", Offset = "0x1929B24", VA = "0x7BBC129B24", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008779 RID: 34681 RVA: 0x000249A8 File Offset: 0x00022BA8
		[Token(Token = "0x6008779")]
		[Address(RVA = "0x1929B4C", Offset = "0x1929B4C", VA = "0x7BBC129B4C")]
		private bool CheckIsValidToShare()
		{
			return default(bool);
		}

		// Token: 0x0600877A RID: 34682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600877A")]
		[Address(RVA = "0x1929CBC", Offset = "0x1929CBC", VA = "0x7BBC129CBC")]
		private void OnLineClick()
		{
		}

		// Token: 0x0600877B RID: 34683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600877B")]
		[Address(RVA = "0x192AA64", Offset = "0x192AA64", VA = "0x7BBC12AA64")]
		private void OnBindInviteClick()
		{
		}

		// Token: 0x0600877C RID: 34684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600877C")]
		[Address(RVA = "0x192AFA8", Offset = "0x192AFA8", VA = "0x7BBC12AFA8")]
		private void OnOtherClick()
		{
		}

		// Token: 0x0600877D RID: 34685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600877D")]
		[Address(RVA = "0x192B23C", Offset = "0x192B23C", VA = "0x7BBC12B23C")]
		private void OnCopyLink()
		{
		}

		// Token: 0x0600877E RID: 34686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600877E")]
		[Address(RVA = "0x192A554", Offset = "0x192A554", VA = "0x7BBC12A554")]
		private string MakeInviteUrl(string url)
		{
			return null;
		}

		// Token: 0x0600877F RID: 34687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600877F")]
		[Address(RVA = "0x192A010", Offset = "0x192A010", VA = "0x7BBC12A010")]
		private string ModifyContentKey()
		{
			return null;
		}

		// Token: 0x06008780 RID: 34688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008780")]
		[Address(RVA = "0x192B4D0", Offset = "0x192B4D0", VA = "0x7BBC12B4D0")]
		public UIInvitePlatformCommonController()
		{
		}

		// Token: 0x0400960D RID: 38413
		[Token(Token = "0x400960D")]
		[FieldOffset(Offset = "0x94")]
		private UIUtils.ShareUrlType m_ShareUrlType;

		// Token: 0x0400960E RID: 38414
		[Token(Token = "0x400960E")]
		[FieldOffset(Offset = "0x98")]
		protected UIInvitePlatformCommonView m_View;

		// Token: 0x0400960F RID: 38415
		[Token(Token = "0x400960F")]
		private const string FACEBOOK_ICON_SPRITENAME = "FF_FaceBookIcon";

		// Token: 0x04009610 RID: 38416
		[Token(Token = "0x4009610")]
		private const string VK_ICON_SPRITENAME = "FF_VKIcon";

		// Token: 0x04009611 RID: 38417
		[Token(Token = "0x4009611")]
		private const string GPLUS_ICON_SPRITENAME = "";

		// Token: 0x04009612 RID: 38418
		[Token(Token = "0x4009612")]
		[FieldOffset(Offset = "0xA0")]
		private object[] m_Data;
	}
}
