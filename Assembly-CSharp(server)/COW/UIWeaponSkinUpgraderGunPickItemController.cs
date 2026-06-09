using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BE7 RID: 7143
	[Token(Token = "0x2001BE7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FB1DC", Offset = "0x10FB1DC")]
	public class UIWeaponSkinUpgraderGunPickItemController : UIBaseController
	{
		// Token: 0x06009B19 RID: 39705 RVA: 0x00028C38 File Offset: 0x00026E38
		[Token(Token = "0x6009B19")]
		[Address(RVA = "0x222FC70", Offset = "0x222FC70", VA = "0x7BBCA2FC70")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009B1A RID: 39706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B1A")]
		[Address(RVA = "0x222FCC0", Offset = "0x222FCC0", VA = "0x7BBCA2FCC0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009B1B RID: 39707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B1B")]
		[Address(RVA = "0x222EE58", Offset = "0x222EE58", VA = "0x7BBCA2EE58")]
		public void SetData(SkinOwnAndOpenInfo skinOwnAndOpenInfo, bool showRedPoint = false)
		{
		}

		// Token: 0x06009B1C RID: 39708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B1C")]
		[Address(RVA = "0x223010C", Offset = "0x223010C", VA = "0x7BBCA3010C")]
		private void GoToWeaponDetailPage()
		{
		}

		// Token: 0x06009B1D RID: 39709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B1D")]
		[Address(RVA = "0x222FDA4", Offset = "0x222FDA4", VA = "0x7BBCA2FDA4")]
		private void SetQualityBG(int Quality)
		{
		}

		// Token: 0x06009B1E RID: 39710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B1E")]
		[Address(RVA = "0x2230528", Offset = "0x2230528", VA = "0x7BBCA30528")]
		public UIWeaponSkinUpgraderGunPickItemController()
		{
		}

		// Token: 0x0400A193 RID: 41363
		[Token(Token = "0x400A193")]
		[FieldOffset(Offset = "0x58")]
		private UIWeaponSkinUpgraderGunPickItemView m_View;

		// Token: 0x0400A194 RID: 41364
		[Token(Token = "0x400A194")]
		[FieldOffset(Offset = "0x60")]
		private SkinOwnAndOpenInfo m_SkinOwnAndOpenInfo;
	}
}
