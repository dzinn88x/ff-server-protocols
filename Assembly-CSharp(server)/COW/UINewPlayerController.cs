using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A99 RID: 6809
	[Token(Token = "0x2001A99")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8644", Offset = "0x10F8644")]
	public class UINewPlayerController : UIPopupWindowController, ITipsDelegate, IUIModelDataChangeObserver
	{
		// Token: 0x06008F79 RID: 36729 RVA: 0x00026370 File Offset: 0x00024570
		[Token(Token = "0x6008F79")]
		[Address(RVA = "0x1AF310C", Offset = "0x1AF310C", VA = "0x7BBC2F310C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008F7A RID: 36730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F7A")]
		[Address(RVA = "0x1AF315C", Offset = "0x1AF315C", VA = "0x7BBC2F315C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008F7B RID: 36731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F7B")]
		[Address(RVA = "0x1AF4164", Offset = "0x1AF4164", VA = "0x7BBC2F4164", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06008F7C RID: 36732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F7C")]
		[Address(RVA = "0x1AF438C", Offset = "0x1AF438C", VA = "0x7BBC2F438C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008F7D RID: 36733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F7D")]
		[Address(RVA = "0x1AF449C", Offset = "0x1AF449C", VA = "0x7BBC2F449C")]
		public void OnClickClose()
		{
		}

		// Token: 0x06008F7E RID: 36734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F7E")]
		[Address(RVA = "0x1AF44D4", Offset = "0x1AF44D4", VA = "0x7BBC2F44D4")]
		public void OnSelectTab(UINewPlayerController.NewbieTab tab)
		{
		}

		// Token: 0x06008F7F RID: 36735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F7F")]
		[Address(RVA = "0x1AF45C8", Offset = "0x1AF45C8", VA = "0x7BBC2F45C8")]
		private void OnSelectSignin()
		{
		}

		// Token: 0x06008F80 RID: 36736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F80")]
		[Address(RVA = "0x1AF45CC", Offset = "0x1AF45CC", VA = "0x7BBC2F45CC")]
		private void OnSelectPath()
		{
		}

		// Token: 0x06008F81 RID: 36737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F81")]
		[Address(RVA = "0x1AF45D0", Offset = "0x1AF45D0", VA = "0x7BBC2F45D0")]
		private void OnSelectUpGrade()
		{
		}

		// Token: 0x06008F82 RID: 36738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F82")]
		[Address(RVA = "0x1AF3934", Offset = "0x1AF3934", VA = "0x7BBC2F3934")]
		private void UpdateToggleView()
		{
		}

		// Token: 0x06008F83 RID: 36739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F83")]
		[Address(RVA = "0x1AF45D4", Offset = "0x1AF45D4", VA = "0x7BBC2F45D4", Slot = "40")]
		public void OnTipsDataChange(ETipsType type, int num)
		{
		}

		// Token: 0x06008F84 RID: 36740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F84")]
		[Address(RVA = "0x1AF3F68", Offset = "0x1AF3F68", VA = "0x7BBC2F3F68")]
		private void SetNotification()
		{
		}

		// Token: 0x06008F85 RID: 36741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F85")]
		[Address(RVA = "0x1AF4778", Offset = "0x1AF4778", VA = "0x7BBC2F4778", Slot = "41")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008F86 RID: 36742 RVA: 0x00026388 File Offset: 0x00024588
		[Token(Token = "0x6008F86")]
		[Address(RVA = "0x1AF47E4", Offset = "0x1AF47E4", VA = "0x7BBC2F47E4", Slot = "42")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008F87 RID: 36743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F87")]
		[Address(RVA = "0x1AF4828", Offset = "0x1AF4828", VA = "0x7BBC2F4828")]
		public UINewPlayerController()
		{
		}

		// Token: 0x04009BA8 RID: 39848
		[Token(Token = "0x4009BA8")]
		[FieldOffset(Offset = "0x98")]
		private UINewPlayerView m_View;

		// Token: 0x04009BA9 RID: 39849
		[Token(Token = "0x4009BA9")]
		[FieldOffset(Offset = "0xA0")]
		private UINewPlayerSigninController m_SignController;

		// Token: 0x04009BAA RID: 39850
		[Token(Token = "0x4009BAA")]
		[FieldOffset(Offset = "0xA8")]
		private UINewPlayerPathController m_PathController;

		// Token: 0x04009BAB RID: 39851
		[Token(Token = "0x4009BAB")]
		[FieldOffset(Offset = "0xB0")]
		private UINewPlayerUpGradeController m_UpGradeController;

		// Token: 0x04009BAC RID: 39852
		[Token(Token = "0x4009BAC")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelNewPlayerSignin m_SigninModel;

		// Token: 0x04009BAD RID: 39853
		[Token(Token = "0x4009BAD")]
		[FieldOffset(Offset = "0xC0")]
		private UIModelNewPlayerPath m_PathModel;

		// Token: 0x04009BAE RID: 39854
		[Token(Token = "0x4009BAE")]
		[FieldOffset(Offset = "0xC8")]
		private UIModelNewPlayerUpGrade m_UpGradeModel;

		// Token: 0x02001A9A RID: 6810
		[Token(Token = "0x2001A9A")]
		public enum NewbieTab
		{
			// Token: 0x04009BB0 RID: 39856
			[Token(Token = "0x4009BB0")]
			Signin,
			// Token: 0x04009BB1 RID: 39857
			[Token(Token = "0x4009BB1")]
			Path,
			// Token: 0x04009BB2 RID: 39858
			[Token(Token = "0x4009BB2")]
			UpGrade
		}
	}
}
