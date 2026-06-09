using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001957 RID: 6487
	[Token(Token = "0x2001957")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F60DC", Offset = "0x10F60DC")]
	internal class UIHudSightController : UIHudButtonBaseController
	{
		// Token: 0x060083B4 RID: 33716 RVA: 0x00023C70 File Offset: 0x00021E70
		[Token(Token = "0x60083B4")]
		[Address(RVA = "0x1664C64", Offset = "0x1664C64", VA = "0x7BBBE64C64")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060083B5 RID: 33717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083B5")]
		[Address(RVA = "0x1664CB4", Offset = "0x1664CB4", VA = "0x7BBBE64CB4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060083B6 RID: 33718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60083B6")]
		[Address(RVA = "0x1664D98", Offset = "0x1664D98", VA = "0x7BBBE64D98", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x060083B7 RID: 33719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083B7")]
		[Address(RVA = "0x1664DE0", Offset = "0x1664DE0", VA = "0x7BBBE64DE0")]
		private void Update()
		{
		}

		// Token: 0x060083B8 RID: 33720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083B8")]
		[Address(RVA = "0x1665368", Offset = "0x1665368", VA = "0x7BBBE65368")]
		public UIHudSightController()
		{
		}

		// Token: 0x04009463 RID: 37987
		[Token(Token = "0x4009463")]
		[FieldOffset(Offset = "0x60")]
		private UIHudSightView m_View;

		// Token: 0x04009464 RID: 37988
		[Token(Token = "0x4009464")]
		[FieldOffset(Offset = "0x68")]
		private bool m_bSighting;

		// Token: 0x04009465 RID: 37989
		[Token(Token = "0x4009465")]
		private const string AimShoot = "UI_icon_aim";

		// Token: 0x04009466 RID: 37990
		[Token(Token = "0x4009466")]
		private const string AimShootClose = "UI_icon_aim_close";

		// Token: 0x04009467 RID: 37991
		[Token(Token = "0x4009467")]
		private const string AimShoot_Shield = "UI_icon_Shield";

		// Token: 0x04009468 RID: 37992
		[Token(Token = "0x4009468")]
		private const string AimShootClose_Shield = "UI_icon_Shield_close";

		// Token: 0x04009469 RID: 37993
		[Token(Token = "0x4009469")]
		[FieldOffset(Offset = "0x6C")]
		private uint weaponID;
	}
}
