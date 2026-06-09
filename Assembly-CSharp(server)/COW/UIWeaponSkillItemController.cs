using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BD7 RID: 7127
	[Token(Token = "0x2001BD7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FAFCC", Offset = "0x10FAFCC")]
	internal class UIWeaponSkillItemController : UIBaseController
	{
		// Token: 0x06009A21 RID: 39457 RVA: 0x00028950 File Offset: 0x00026B50
		[Token(Token = "0x6009A21")]
		[Address(RVA = "0x16912E0", Offset = "0x16912E0", VA = "0x7BBBE912E0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009A22 RID: 39458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A22")]
		[Address(RVA = "0x1691330", Offset = "0x1691330", VA = "0x7BBBE91330", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009A23 RID: 39459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A23")]
		[Address(RVA = "0x1691494", Offset = "0x1691494", VA = "0x7BBBE91494")]
		private void OnClear()
		{
		}

		// Token: 0x06009A24 RID: 39460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A24")]
		[Address(RVA = "0x16914A0", Offset = "0x16914A0", VA = "0x7BBBE914A0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009A25 RID: 39461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A25")]
		[Address(RVA = "0x169156C", Offset = "0x169156C", VA = "0x7BBBE9156C")]
		public void SetData(uint wpid, uint skinid)
		{
		}

		// Token: 0x06009A26 RID: 39462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A26")]
		[Address(RVA = "0x1691574", Offset = "0x1691574", VA = "0x7BBBE91574")]
		public void ShowSkill()
		{
		}

		// Token: 0x06009A27 RID: 39463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A27")]
		[Address(RVA = "0x1691744", Offset = "0x1691744", VA = "0x7BBBE91744")]
		public void SetUIData(WeaponScoreName name, uint wpid, uint skinId = 0U)
		{
		}

		// Token: 0x06009A28 RID: 39464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A28")]
		[Address(RVA = "0x16915C8", Offset = "0x16915C8", VA = "0x7BBBE915C8")]
		private void SetUIData(uint wpid, uint skinId = 0U)
		{
		}

		// Token: 0x06009A29 RID: 39465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A29")]
		[Address(RVA = "0x169174C", Offset = "0x169174C", VA = "0x7BBBE9174C")]
		private void OnWeaponSkinChanged(params object[] data)
		{
		}

		// Token: 0x06009A2A RID: 39466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A2A")]
		[Address(RVA = "0x1691800", Offset = "0x1691800", VA = "0x7BBBE91800")]
		public UIWeaponSkillItemController()
		{
		}

		// Token: 0x0400A119 RID: 41241
		[Token(Token = "0x400A119")]
		[FieldOffset(Offset = "0x58")]
		private UIWeaponSkillItemView m_View;

		// Token: 0x0400A11A RID: 41242
		[Token(Token = "0x400A11A")]
		[FieldOffset(Offset = "0x60")]
		private uint m_Currentwpid;

		// Token: 0x0400A11B RID: 41243
		[Token(Token = "0x400A11B")]
		[FieldOffset(Offset = "0x64")]
		private uint m_CurrentSkinId;
	}
}
