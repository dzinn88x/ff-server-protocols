using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BEF RID: 7151
	[Token(Token = "0x2001BEF")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FB2DC", Offset = "0x10FB2DC")]
	internal class UIWeaponSysEntranceController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06009B4B RID: 39755 RVA: 0x00028CC8 File Offset: 0x00026EC8
		[Token(Token = "0x6009B4B")]
		[Address(RVA = "0x17836C8", Offset = "0x17836C8", VA = "0x7BBBF836C8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009B4C RID: 39756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B4C")]
		[Address(RVA = "0x1783718", Offset = "0x1783718", VA = "0x7BBBF83718", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009B4D RID: 39757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B4D")]
		[Address(RVA = "0x1783CB8", Offset = "0x1783CB8", VA = "0x7BBBF83CB8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009B4E RID: 39758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B4E")]
		[Address(RVA = "0x1783DD8", Offset = "0x1783DD8", VA = "0x7BBBF83DD8")]
		private void OnWeaponSkinUpgraderClick()
		{
		}

		// Token: 0x06009B4F RID: 39759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B4F")]
		[Address(RVA = "0x178409C", Offset = "0x178409C", VA = "0x7BBBF8409C")]
		private void GotoUpgrader()
		{
		}

		// Token: 0x06009B50 RID: 39760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B50")]
		[Address(RVA = "0x17841E4", Offset = "0x17841E4", VA = "0x7BBBF841E4")]
		private void GotoSkinLobby()
		{
		}

		// Token: 0x06009B51 RID: 39761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B51")]
		[Address(RVA = "0x1784024", Offset = "0x1784024", VA = "0x7BBBF84024")]
		private void StopVfx()
		{
		}

		// Token: 0x06009B52 RID: 39762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B52")]
		[Address(RVA = "0x17842E8", Offset = "0x17842E8", VA = "0x7BBBF842E8")]
		private void OnWeaponSkiEnternClick()
		{
		}

		// Token: 0x06009B53 RID: 39763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B53")]
		[Address(RVA = "0x17843F0", Offset = "0x17843F0", VA = "0x7BBBF843F0", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06009B54 RID: 39764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B54")]
		[Address(RVA = "0x1783A4C", Offset = "0x1783A4C", VA = "0x7BBBF83A4C")]
		private void RefreshWsuRedPoint()
		{
		}

		// Token: 0x06009B55 RID: 39765 RVA: 0x00028CE0 File Offset: 0x00026EE0
		[Token(Token = "0x6009B55")]
		[Address(RVA = "0x1784468", Offset = "0x1784468", VA = "0x7BBBF84468", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06009B56 RID: 39766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B56")]
		[Address(RVA = "0x17844AC", Offset = "0x17844AC", VA = "0x7BBBF844AC")]
		public UIWeaponSysEntranceController()
		{
		}

		// Token: 0x0400A1B2 RID: 41394
		[Token(Token = "0x400A1B2")]
		[FieldOffset(Offset = "0x98")]
		private UIWeaponSysEntranceView m_View;

		// Token: 0x0400A1B3 RID: 41395
		[Token(Token = "0x400A1B3")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelWeaponSkinUpgrader m_ModelWsu;

		// Token: 0x0400A1B4 RID: 41396
		[Token(Token = "0x400A1B4")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelCollection m_ModelCollection;

		// Token: 0x0400A1B5 RID: 41397
		[Token(Token = "0x400A1B5")]
		[FieldOffset(Offset = "0xB0")]
		private uint m_VfxDelayCallId;
	}
}
