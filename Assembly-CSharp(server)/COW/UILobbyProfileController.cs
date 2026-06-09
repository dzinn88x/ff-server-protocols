using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A1E RID: 6686
	[Token(Token = "0x2001A1E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F78DC", Offset = "0x10F78DC")]
	public class UILobbyProfileController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06008BF9 RID: 35833 RVA: 0x00025620 File Offset: 0x00023820
		[Token(Token = "0x6008BF9")]
		[Address(RVA = "0x19DA4B4", Offset = "0x19DA4B4", VA = "0x7BBC1DA4B4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008BFA RID: 35834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008BFA")]
		[Address(RVA = "0x19DA504", Offset = "0x19DA504", VA = "0x7BBC1DA504", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008BFB RID: 35835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008BFB")]
		[Address(RVA = "0x19DA894", Offset = "0x19DA894", VA = "0x7BBC1DA894", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06008BFC RID: 35836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008BFC")]
		[Address(RVA = "0x19DAAA4", Offset = "0x19DAAA4", VA = "0x7BBC1DAAA4", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06008BFD RID: 35837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008BFD")]
		[Address(RVA = "0x19DAAFC", Offset = "0x19DAAFC", VA = "0x7BBC1DAAFC")]
		public void UpdateProfileData()
		{
		}

		// Token: 0x06008BFE RID: 35838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008BFE")]
		[Address(RVA = "0x19DAE84", Offset = "0x19DAE84", VA = "0x7BBC1DAE84")]
		private void SetAvatarIcon()
		{
		}

		// Token: 0x06008BFF RID: 35839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008BFF")]
		[Address(RVA = "0x19DAF50", Offset = "0x19DAF50", VA = "0x7BBC1DAF50")]
		private void OnBtnRenameClick()
		{
		}

		// Token: 0x06008C00 RID: 35840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C00")]
		[Address(RVA = "0x19DB020", Offset = "0x19DB020", VA = "0x7BBC1DB020")]
		private void OnHeadClick()
		{
		}

		// Token: 0x06008C01 RID: 35841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C01")]
		[Address(RVA = "0x19DB280", Offset = "0x19DB280", VA = "0x7BBC1DB280")]
		private void OnRenameBtnStateChange(params object[] data)
		{
		}

		// Token: 0x06008C02 RID: 35842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C02")]
		[Address(RVA = "0x19DB364", Offset = "0x19DB364", VA = "0x7BBC1DB364")]
		private void OnShowRankChanged(params object[] data)
		{
		}

		// Token: 0x06008C03 RID: 35843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C03")]
		[Address(RVA = "0x19DB410", Offset = "0x19DB410", VA = "0x7BBC1DB410", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008C04 RID: 35844 RVA: 0x00025638 File Offset: 0x00023838
		[Token(Token = "0x6008C04")]
		[Address(RVA = "0x19DB4BC", Offset = "0x19DB4BC", VA = "0x7BBC1DB4BC", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008C05 RID: 35845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C05")]
		[Address(RVA = "0x19DB540", Offset = "0x19DB540", VA = "0x7BBC1DB540")]
		public UILobbyProfileController()
		{
		}

		// Token: 0x040098B6 RID: 39094
		[Token(Token = "0x40098B6")]
		[FieldOffset(Offset = "0x58")]
		private UILobbyProfileView m_View;

		// Token: 0x040098B7 RID: 39095
		[Token(Token = "0x40098B7")]
		[FieldOffset(Offset = "0x60")]
		private UIBaseProfileInfoController m_Profile;
	}
}
