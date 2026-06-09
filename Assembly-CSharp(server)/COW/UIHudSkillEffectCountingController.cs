using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001959 RID: 6489
	[Token(Token = "0x2001959")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F614C", Offset = "0x10F614C")]
	internal class UIHudSkillEffectCountingController : UIBaseController
	{
		// Token: 0x060083C0 RID: 33728 RVA: 0x00023CA0 File Offset: 0x00021EA0
		[Token(Token = "0x60083C0")]
		[Address(RVA = "0x1668C1C", Offset = "0x1668C1C", VA = "0x7BBBE68C1C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060083C1 RID: 33729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083C1")]
		[Address(RVA = "0x1668C6C", Offset = "0x1668C6C", VA = "0x7BBBE68C6C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060083C2 RID: 33730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083C2")]
		[Address(RVA = "0x1668E0C", Offset = "0x1668E0C", VA = "0x7BBBE68E0C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060083C3 RID: 33731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083C3")]
		[Address(RVA = "0x1668F80", Offset = "0x1668F80", VA = "0x7BBBE68F80")]
		public void TriggerActiveSkill(b]LTXBp newActiveSkill)
		{
		}

		// Token: 0x060083C4 RID: 33732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083C4")]
		[Address(RVA = "0x16691B0", Offset = "0x16691B0", VA = "0x7BBBE691B0")]
		public void StopActiveSkill()
		{
		}

		// Token: 0x060083C5 RID: 33733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083C5")]
		[Address(RVA = "0x16691CC", Offset = "0x16691CC", VA = "0x7BBBE691CC")]
		private void Update()
		{
		}

		// Token: 0x060083C6 RID: 33734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083C6")]
		[Address(RVA = "0x16692D8", Offset = "0x16692D8", VA = "0x7BBBE692D8")]
		private void OnUpdateSkillIcon(params object[] param)
		{
		}

		// Token: 0x060083C7 RID: 33735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083C7")]
		[Address(RVA = "0x16693B4", Offset = "0x16693B4", VA = "0x7BBBE693B4")]
		private void OnLocalPlayerDead(params object[] param)
		{
		}

		// Token: 0x060083C8 RID: 33736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083C8")]
		[Address(RVA = "0x16693C4", Offset = "0x16693C4", VA = "0x7BBBE693C4")]
		private void OnAddLocalPlayer(params object[] param)
		{
		}

		// Token: 0x060083C9 RID: 33737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083C9")]
		[Address(RVA = "0x1669470", Offset = "0x1669470", VA = "0x7BBBE69470")]
		public UIHudSkillEffectCountingController()
		{
		}

		// Token: 0x0400946C RID: 37996
		[Token(Token = "0x400946C")]
		[FieldOffset(Offset = "0x58")]
		private UIHudSkillEffectCountingView m_View;

		// Token: 0x0400946D RID: 37997
		[Token(Token = "0x400946D")]
		[FieldOffset(Offset = "0x60")]
		private b]LTXBp m_ActiveSkill;

		// Token: 0x0400946E RID: 37998
		[Token(Token = "0x400946E")]
		[FieldOffset(Offset = "0x68")]
		private float countdownSecond;

		// Token: 0x0400946F RID: 37999
		[Token(Token = "0x400946F")]
		[FieldOffset(Offset = "0x6C")]
		private bool alwaysKeep;
	}
}
