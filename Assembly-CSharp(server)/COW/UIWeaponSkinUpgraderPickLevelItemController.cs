using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BE8 RID: 7144
	[Token(Token = "0x2001BE8")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FB214", Offset = "0x10FB214")]
	public class UIWeaponSkinUpgraderPickLevelItemController : UIBaseController
	{
		// Token: 0x06009B1F RID: 39711 RVA: 0x00028C50 File Offset: 0x00026E50
		[Token(Token = "0x6009B1F")]
		[Address(RVA = "0x2230A40", Offset = "0x2230A40", VA = "0x7BBCA30A40")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009B20 RID: 39712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B20")]
		[Address(RVA = "0x2230A90", Offset = "0x2230A90", VA = "0x7BBCA30A90", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009B21 RID: 39713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B21")]
		[Address(RVA = "0x2230BF0", Offset = "0x2230BF0", VA = "0x7BBCA30BF0", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06009B22 RID: 39714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B22")]
		[Address(RVA = "0x222637C", Offset = "0x222637C", VA = "0x7BBCA2637C")]
		public void SetData(uint skinId)
		{
		}

		// Token: 0x06009B23 RID: 39715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B23")]
		[Address(RVA = "0x2230CBC", Offset = "0x2230CBC", VA = "0x7BBCA30CBC")]
		private void GoToWeaponDetailPage()
		{
		}

		// Token: 0x06009B24 RID: 39716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B24")]
		[Address(RVA = "0x2230E6C", Offset = "0x2230E6C", VA = "0x7BBCA30E6C")]
		private void OnPickLv(object[] param)
		{
		}

		// Token: 0x06009B25 RID: 39717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B25")]
		[Address(RVA = "0x2226A44", Offset = "0x2226A44", VA = "0x7BBCA26A44")]
		public void OnChosen()
		{
		}

		// Token: 0x06009B26 RID: 39718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B26")]
		[Address(RVA = "0x2226AA0", Offset = "0x2226AA0", VA = "0x7BBCA26AA0")]
		public void OnUnchosen()
		{
		}

		// Token: 0x06009B27 RID: 39719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B27")]
		[Address(RVA = "0x2230F94", Offset = "0x2230F94", VA = "0x7BBCA30F94")]
		public UIWeaponSkinUpgraderPickLevelItemController()
		{
		}

		// Token: 0x0400A195 RID: 41365
		[Token(Token = "0x400A195")]
		[FieldOffset(Offset = "0x58")]
		private UIWeaponSkinUpgraderPickLevelItemView m_View;

		// Token: 0x0400A196 RID: 41366
		[Token(Token = "0x400A196")]
		[FieldOffset(Offset = "0x60")]
		private SkinOwnAndOpenInfo m_OwnAndOpenInfo;
	}
}
