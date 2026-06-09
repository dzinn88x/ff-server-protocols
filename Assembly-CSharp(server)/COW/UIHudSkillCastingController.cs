using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001958 RID: 6488
	[Token(Token = "0x2001958")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6114", Offset = "0x10F6114")]
	internal class UIHudSkillCastingController : UIBaseController
	{
		// Token: 0x060083B9 RID: 33721 RVA: 0x00023C88 File Offset: 0x00021E88
		[Token(Token = "0x60083B9")]
		[Address(RVA = "0x1668680", Offset = "0x1668680", VA = "0x7BBBE68680")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060083BA RID: 33722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083BA")]
		[Address(RVA = "0x16686D0", Offset = "0x16686D0", VA = "0x7BBBE686D0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060083BB RID: 33723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083BB")]
		[Address(RVA = "0x166881C", Offset = "0x166881C", VA = "0x7BBBE6881C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060083BC RID: 33724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083BC")]
		[Address(RVA = "0x166893C", Offset = "0x166893C", VA = "0x7BBBE6893C")]
		public void OnCastActiveSkill(params object[] param)
		{
		}

		// Token: 0x060083BD RID: 33725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083BD")]
		[Address(RVA = "0x1668A8C", Offset = "0x1668A8C", VA = "0x7BBBE68A8C")]
		protected void Update()
		{
		}

		// Token: 0x060083BE RID: 33726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083BE")]
		[Address(RVA = "0x1668B60", Offset = "0x1668B60", VA = "0x7BBBE68B60")]
		public void OnStopActiveSkill(params object[] param)
		{
		}

		// Token: 0x060083BF RID: 33727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083BF")]
		[Address(RVA = "0x1668B70", Offset = "0x1668B70", VA = "0x7BBBE68B70")]
		public UIHudSkillCastingController()
		{
		}

		// Token: 0x0400946A RID: 37994
		[Token(Token = "0x400946A")]
		[FieldOffset(Offset = "0x58")]
		private UIHudSkillCastingView m_View;

		// Token: 0x0400946B RID: 37995
		[Token(Token = "0x400946B")]
		[FieldOffset(Offset = "0x60")]
		private b]LTXBp m_ActiveSkill;
	}
}
